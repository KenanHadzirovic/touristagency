import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './components/login/login.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { HeaderComponent } from './components/layout/header/header.component';
import { ToursComponent } from './components/tours/tours.component';
import { ReservationsComponent } from './components/reservations/reservations.component';
import { NewPassengerComponent } from './components/admin/new-passenger/new-passenger.component';
import { ManageEmployeesComponent } from './components/admin/manage-employees/manage-employees.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    DashboardComponent,
    HeaderComponent,
    ToursComponent,
    ReservationsComponent,
    NewPassengerComponent,
    ManageEmployeesComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
