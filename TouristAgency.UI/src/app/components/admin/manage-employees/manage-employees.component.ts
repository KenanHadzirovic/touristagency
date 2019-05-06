import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../../../services/employee/employee.service';

@Component({
  selector: 'app-manage-employees',
  templateUrl: './manage-employees.component.html',
  styleUrls: ['./manage-employees.component.css']
})
export class ManageEmployeesComponent implements OnInit {

  private employees: any;

  constructor(private employeeService: EmployeeService) { }

  ngOnInit() {
    this.employees = this.employeeService.getAll();
  }

}
