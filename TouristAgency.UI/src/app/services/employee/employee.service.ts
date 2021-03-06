import { Injectable } from '@angular/core';
import { Employee } from '../../models/employee';
import { environment } from '../../../environments/environment';
import { Observable } from 'rxjs/internal/Observable';
import { map } from 'rxjs/operators';
import { HttpClient } from '@angular/common/http';



@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  constructor(private http: HttpClient) { }

  employeeUrl = environment.serviceUrl + 'employee';

  getAll = (): Observable<Employee[]> => {
    return this.http.get<Employee[]>(this.employeeUrl);
  }
}
