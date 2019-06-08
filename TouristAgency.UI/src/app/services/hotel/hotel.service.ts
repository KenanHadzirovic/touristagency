import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Hotel } from 'src/app/models/hotel';

@Injectable({
  providedIn: 'root'
})
export class HotelService {

  constructor(private http: HttpClient) { }
  url = "http://localhost:56219/api/hotel";

  PostData(hotel: Hotel) {
    const retVal = this.http.post(this.url, {Name: hotel.name, address: hotel.address, city: hotel.city, country: hotel.country, stars: hotel.stars, phone: hotel.phoneNumber, website: hotel.website}).subscribe
    (data => console.log(data));
  }

  getAll = (): Observable<Hotel[]> => {
    return this.http.get<Hotel[]>(this.url);
  }
}
