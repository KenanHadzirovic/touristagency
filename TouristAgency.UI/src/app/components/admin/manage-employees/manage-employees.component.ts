import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../../../services/employee/employee.service';

@Component({
  selector: 'app-manage-employees',
  templateUrl: './manage-employees.component.html',
  styleUrls: ['./manage-employees.component.css']
})
export class ManageEmployeesComponent implements OnInit {

  private employees: any;
  private roles: any[] = [
    { id: 1, name: "Administrator" },
    { id: 2, name: "Agent" },
    { id: 3, name: "Support" },
  ];

  constructor(private employeeService: EmployeeService) { }

  ngOnInit() {
    this.employees = this.employeeService.getAll();
  }

  removeEmployee = (index: number) => {
    this.employees.splice(index, 1);
    // TODO: go to service and remove this employee
  }

}
