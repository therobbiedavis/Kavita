import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, ReplaySubject } from 'rxjs';
import { map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import { User } from '../_models/user';

@Injectable({
  providedIn: 'root'
})
export class AccountService {

  baseUrl = environment.apiUrl;
  userKey = 'kavita-user';
  currentUser: User | undefined;

  // Stores values, when someone subscribes gives (1) of last values seen.
  private currentUserSource = new ReplaySubject<User>(1); // TODO: Move away from ReplaySubject. It's overly complex for what it provides
  currentUser$ = this.currentUserSource.asObservable(); // $ at end is because this is observable

  constructor(private httpClient: HttpClient) { 
  }

  hasAdminRole(user: User) {
    return user && user.roles.includes('Admin');
  }

  login(model: any): Observable<any> {
    return this.httpClient.post<User>(this.baseUrl + 'account/login', model).pipe(
      map((response: User) => {
        const user = response;
        if (user) {
          this.setCurrentUser(user);
        }
      })
    );
  }

  setCurrentUser(user: User) {
    if (user) {
      user.roles = [];
      const roles = this.getDecodedToken(user.token).role;
      Array.isArray(roles) ? user.roles = roles : user.roles.push(roles);
    }
    
    localStorage.setItem(this.userKey, JSON.stringify(user));
    this.currentUserSource.next(user);
    this.currentUser = user;
  }

  logout() {
    localStorage.removeItem(this.userKey);
    this.currentUserSource.next(undefined);
    this.currentUser = undefined;
  }

  register(model: {username: string, password: string, isAdmin?: boolean}, login = false) {
    if (model?.isAdmin) {
      model.isAdmin = false;
    }

    return this.httpClient.post<User>(this.baseUrl + 'account/register', model).pipe(
      map((user: User) => {
        return user;
      })
    );
  }

  getDecodedToken(token: string) {
    return JSON.parse(atob(token.split('.')[1]));
  }


}
