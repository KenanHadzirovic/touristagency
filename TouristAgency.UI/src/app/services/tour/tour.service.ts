import { Injectable } from '@angular/core';
import { Tour } from '../../models/tour';
import { DomSanitizer } from '@angular/platform-browser';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class TourService {

  url = "http://localhost:56219/api/tour";

  constructor(private http: HttpClient) { }

  getAll = (): Tour[] => {
    return [];
  }

  PostData(tour: Tour) {
    const retVal = this.http.post(this.url, {name: tour.name, description: tour.description, location: tour.location}).subscribe
    (data => console.log(data));
  }
 
}
