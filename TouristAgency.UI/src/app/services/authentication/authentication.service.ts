import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {

  public userData: any;

  constructor() { }

  isAuthenticated = () => {
    if (this.userData) {
      // TODO: go to API and check token
      return true;
    }

    let token = localStorage.getItem('touristagencyaccesstoken');

    if (token) {
      // TODO: parse user data from token
      this.userData = JSON.parse(token);
      
      // TODO: go to API and check token
      return true;
    }

    return false;
  };

  authenticate = (username: string, password: string, shouldCache: boolean) => {
    this.userData = { fullName: username };

    if (shouldCache) {
      localStorage.setItem('touristagencyaccesstoken', JSON.stringify(this.userData));
    }
  }

  logOut = () => {
    localStorage.removeItem("touristagencyaccesstoken");
    this.userData = null;
  }
}