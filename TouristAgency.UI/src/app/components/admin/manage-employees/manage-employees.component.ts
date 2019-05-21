import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../../../services/employee/employee.service';
import { RoleService } from '../../../services/role/role.service';
import { Employee } from 'src/app/models/employee';
import { Role } from 'src/app/models/role';

@Component({
  selector: 'app-manage-employees',
  templateUrl: './manage-employees.component.html',
  styleUrls: ['./manage-employees.component.css']
})
export class ManageEmployeesComponent implements OnInit {

  private employees: Employee[];
  private roles: Role[];

  constructor(private employeeService: EmployeeService, private roleService: RoleService) { }

  ngOnInit() {
    this.employeeService.getAll().subscribe((data: Employee[]) => {
      this.employees = data;
    });

    this.roleService.getAll().subscribe((data: Role[]) => {
      this.roles = data;
      console.log(this.roles);
    })
  }

  removeEmployee = (index: number) => {
    this.employees.splice(index, 1);
    // TODO: go to service and remove this employee
  }

}
