import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { AuthGuard } from './auth.guard';
import { LoginComponent } from './components/login/login.component';
import { ToursComponent } from './components/tours/tours.component';
import { ReservationsComponent } from './components/reservations/reservations.component';
import { NewPassengerComponent } from './components/admin/new-passenger/new-passenger.component';
import { ManageEmployeesComponent } from './components/admin/manage-employees/manage-employees.component';

const routes: Routes = [
  { path: '', component: DashboardComponent, canActivate: [AuthGuard] },
  { path: 'dashboard/tours', component: ToursComponent, canActivate: [AuthGuard] },
  { path: 'dashboard/reservations', component: ReservationsComponent, canActivate: [AuthGuard] },
  { path: 'administration/passenger/new', component: NewPassengerComponent, canActivate: [AuthGuard] },
  { path: 'administration/employees', component: ManageEmployeesComponent, canActivate: [AuthGuard] },
  { path: 'login', component: LoginComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
