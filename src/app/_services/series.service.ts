import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Series } from '../_models/series';
import { Volume } from '../_models/volume';

@Injectable({
  providedIn: 'root'
})
export class SeriesService {

  baseUrl = environment.apiUrl;

  constructor(private httpClient: HttpClient) { }

  getSeriesForLibrary(libraryId: number) {
    return this.httpClient.get<Series[]>(this.baseUrl + 'library/series?libraryId=' + libraryId);
  }

  getSeries(seriesId: number) {
    return this.httpClient.get<Series>(this.baseUrl + 'series/' + seriesId);
  }

  getVolumes(seriesId: number) {
    return this.httpClient.get<Volume[]>(this.baseUrl + 'series/volumes?seriesId=' + seriesId);
  }
}
