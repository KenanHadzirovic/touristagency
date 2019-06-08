import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { AuthGuard } from './auth.guard';
import { LoginComponent } from './components/login/login.component';
import { ToursComponent } from './components/tours/tours.component';
import { ReservationsComponent } from './components/reservations/reservations.component';
import { NewPassengerComponent } from './components/admin/new-passenger/new-passenger.component';
import { NewTourComponent } from './components/admin/new-tour/new-tour.component';
import { NewHotelComponent } from './components/admin/new-hotel/new-hotel.component';
import { SecurityManagementComponent } from './components/admin/security-management/security-management.component';
import { ManageEmployeesComponent } from './components/admin/manage-employees/manage-employees.component';
import { RoleHistoryComponent } from './components/admin/role-history/role-history.component';
import { ActionLogComponent } from './components/admin/action-log/action-log.component';

const routes: Routes = [
  { path: '', component: DashboardComponent, canActivate: [AuthGuard] },
  { path: 'dashboard/tours', component: DashboardComponent, canActivate: [AuthGuard] },
  { path: 'dashboard/reservations', component: ReservationsComponent, canActivate: [AuthGuard] },
  { path: 'administration/passenger/new', component: NewPassengerComponent, canActivate: [AuthGuard] },
  { path: 'administration/tour/new', component: NewTourComponent, canActivate: [AuthGuard] },
  { path: 'administration/hotel/new', component: NewHotelComponent, canActivate: [AuthGuard] },
  { path: 'administration/securitymanagement', component: SecurityManagementComponent, canActivate: [AuthGuard] },
  { path: 'administration/employees', component: ManageEmployeesComponent, canActivate: [AuthGuard] },
  { path: 'administration/rolehistory', component: RoleHistoryComponent, canActivate: [AuthGuard] },
  { path: 'administration/actionlog', component: ActionLogComponent, canActivate: [AuthGuard] },
  { path: 'login', component: LoginComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
