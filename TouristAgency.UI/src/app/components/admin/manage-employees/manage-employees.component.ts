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
        { name: "Upravljanje korisnicima" },
        { name: "Upravljanje putovanjima" },
        { name: "Upravljanje rezervacijama" },
        { name: "Sigurnosne postavke" }
      ]
    },
    {
      roleId: 2,
      roleName: "Agent",
      privileges: [
        { name: "Upravljanje rezervacijama" }
      ]
    },
    {
      roleId: 3,
      roleName: 'Support',
      privileges: [
        { name: "Upravljanje korisnicima" }
      ]
    }
  ]

  private listofemployees: Employee[] = [
    { fullName: "Mirza Vucijak", address: "Adresa 1", dateOfBirth: new Date("02/02/1995"), id:2, roleId: 1, phoneNumber:"033/225-883"},
    { fullName: "Kenan Hadzirovic", address: "Adresa 2", dateOfBirth: new Date("09/26/1996"), id:2,roleId:2, phoneNumber:"033/225/883" },
    { fullName: "Dzenita Ljevo", address: "Adresa 3", dateOfBirth: new Date("07/21/1995"), id:2,roleId:3, phoneNumber:"033/225/883" },
    { fullName: "Adna Tucak", address: "Adresa 4", dateOfBirth: new Date("02/05/1995"), id:2,roleId:1, phoneNumber:"033/225/883" },
    { fullName: "Amar Saradak", address: "Adresa 5", dateOfBirth:new Date("02/12/1995"), id:2, roleId:1, phoneNumber:"033/225/883" },
    { fullName: "Nadja Zilic", address: "Adresa 6", dateOfBirth: new Date("04/09/1995"), id:2, roleId:1, phoneNumber:"033/225/883" },

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
