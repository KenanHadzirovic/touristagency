import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Tourist } from 'src/app/models/Tourist';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TouristService {

  url = "http://localhost:56219/api/tourist";

  constructor(private http: HttpClient) { }

  getAll = (): Observable<Tourist[]> => {
    return this.http.get<Tourist[]>(this.url);
  }

  PostData(tourist: Tourist) {
    const retVal = this.http.post(this.url, {name: tourist.firstname, lastname: tourist.lastname, ssn: tourist.ssn, address: tourist.address, dateofbirth: ""}).subscribe
    (data => console.log(data));
  }
}
