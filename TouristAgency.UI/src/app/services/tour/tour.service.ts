import { Injectable } from '@angular/core';
import { Tour } from '../../models/tour';
import { DomSanitizer } from '@angular/platform-browser';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../../environments/environment';
import { Observable } from 'rxjs';
import { TourType } from 'src/app/models/tourType';

@Injectable({
  providedIn: 'root'
})
export class TourService {


  constructor(private http: HttpClient) { }

  getAll = (): Observable<TourType[]> => {
    return this.http.get<TourType[]>(environment.serviceUrl + '/tourType');
  }

  PostData(tour: Tour) {
    const retVal = this.http.post(environment.serviceUrl + '/tour', {name: tour.name, description: tour.description, location: tour.location}).subscribe
    (data => console.log(data));
  }
 
}
