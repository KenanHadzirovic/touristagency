import { Injectable } from '@angular/core';
import { Role } from '../../models/role';
import { environment } from '../../../environments/environment';
import { Observable } from 'rxjs/internal/Observable';
import { map } from 'rxjs/operators';
import { HttpClient } from '@angular/common/http';



@Injectable({
  providedIn: 'root'
})
export class RoleService {

  constructor(private http: HttpClient) { }

  roleUrl = environment.serviceUrl + 'useraccount';

  getAll = (): Observable<Role[]> => {
    return this.http.get<Role[]>(this.roleUrl);
  }

  PostData(role: Role) {
    const retVal = this.http.post(this.roleUrl, {name: role.roleName}).subscribe
    (data => console.log(data));
  }

}
