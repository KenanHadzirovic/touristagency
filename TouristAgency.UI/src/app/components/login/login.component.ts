import { Component, OnInit } from '@angular/core';
import { AuthenticationService } from '../../services/authentication/authentication.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  private username: string;
  private password: string;
  private rememberMe: boolean;

  ngOnInit() {
    if (this.authenticationService.isAuthenticated()) {
      this.router.navigate(['/']);
    }
  }

  constructor(
    private authenticationService: AuthenticationService,
    private router: Router) { }

  login = () => {
    this.authenticationService.authenticate(this.username, this.password, this.rememberMe);
    this.router.navigate(['/']);
  }
}
