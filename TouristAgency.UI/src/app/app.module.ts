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
import { NewHotelComponent } from './components/admin/new-hotel/new-hotel.component';
import { NewTourComponent } from './components/admin/new-tour/new-tour.component';
import { SecurityManagementComponent } from './components/admin/security-management/security-management.component';
import { TourDetailsComponent } from './components/tour-details/tour-details.component';
import { NgbModule, NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { NewRoleComponent } from './components/admin/security-management/new-role/new-role.component';
import { NewPrivilegeComponent } from './components/admin/security-management/new-privilege/new-privilege.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    DashboardComponent,
    HeaderComponent,
    ToursComponent,
    ReservationsComponent,
    NewPassengerComponent,
    ManageEmployeesComponent,
    NewHotelComponent,
    NewTourComponent,
    SecurityManagementComponent,
    TourDetailsComponent,
    NewRoleComponent,
    NewPrivilegeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    NgbModule.forRoot()
  ],
  providers: [
    NgbActiveModal
  ],
  bootstrap: [AppComponent],
  entryComponents: [
    TourDetailsComponent,
    NewRoleComponent,
    NewPrivilegeComponent
  ]
})
export class AppModule { }
