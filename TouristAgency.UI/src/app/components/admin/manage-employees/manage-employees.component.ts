import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../../../services/employee/employee.service';
import { RoleService } from '../../../services/role/role.service';
import { Employee } from 'src/app/models/employee';
import { Role } from 'src/app/models/role';
import { DatePipe } from '@angular/common/src/pipes';
import { Privilege } from 'src/app/models/privilege';

@Component({
  selector: 'app-manage-employees',
  templateUrl: './manage-employees.component.html',
  styleUrls: ['./manage-employees.component.css']
})
export class ManageEmployeesComponent implements OnInit {

  private employees: Employee[];
  private roles: Role[];
  private privileges: Privilege[];

  constructor(private employeeService: EmployeeService, private roleService: RoleService) { }

   private listofroles: Role[] = [
    {
      roleId: 1,
      roleName: "Administrator", privileges: [
        { name: "Can manage users" },
        { name: "Can manage tours" },
        { name: "Can manage reservations" },
        { name: "Can manage security" }
      ]
    },
    {
      roleId: 2,
      roleName: "Agent",
      privileges: [
        { name: "Can manage reservations" }
      ]
    },
    {
      roleId: 3,
      roleName: 'Support',
      privileges: [
        { name: "Can manage users" }
      ]
    }
  ]

  private listofemployees: Employee[] = [
    { fullName: "Mirza Vucijak", address: "Adresa 1", dateOfBirth: new Date("02/02/1995"), id:2, roleId: 1, phoneNumber:"032656"},
    { fullName: "Kenan Hadzirovic", address: "Adresa 1", dateOfBirth: new Date("02/02/1995"), id:2,roleId:1, phoneNumber:"032656" },
    { fullName: "Dzenita Ljevo", address: "Adresa 1", dateOfBirth: new Date("02/02/1995"), id:2,roleId:1, phoneNumber:"032656" },
    { fullName: "Adna Tucak", address: "Adresa 1", dateOfBirth: new Date("02/02/1995"), id:2,roleId:1, phoneNumber:"032656" },
    { fullName: "Amar Saradak", address: "Adresa 1", dateOfBirth:new Date("02/02/1995"), id:2, roleId:1, phoneNumber:"032656" },
    { fullName: "Nadja Zilic", address: "Adresa 1", dateOfBirth: new Date("02/02/1995"), id:2, roleId:1, phoneNumber:"032656" },

  ];

  ngOnInit() {
   /* this.employeeService.getAll().subscribe((data: Employee[]) => {
      this.employees = data;
        });*/

      

    this.roleService.getAll().subscribe((data: Role[]) => {
      this.roles = data;
      console.log(this.roles);
    })
  }

  

  removeEmployee = (index: number) => {
    this.listofemployees.splice(index, 1);
  }

}
