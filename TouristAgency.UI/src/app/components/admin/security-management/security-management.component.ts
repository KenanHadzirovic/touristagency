import { Component, OnInit } from '@angular/core';
import { Role } from '../../../models/role';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { NewPrivilegeComponent } from './new-privilege/new-privilege.component';
import { NewRoleComponent } from './new-role/new-role.component';
import { Privilege } from '../../../models/privilege';

@Component({
  selector: 'app-security-management',
  templateUrl: './security-management.component.html',
  styleUrls: ['./security-management.component.css']
})
export class SecurityManagementComponent implements OnInit {

  private selectedRole: Role;

  private allPrivileges: Privilege[] = [
    { name: "Can manage users" },
    { name: "Can manage tours" },
    { name: "Can manage reservations" },
    { name: "Can manage security" }
  ];

  private roles: Role[] = [
    {
      name: "Administrator", privileges: [
        { name: "Can manage users" },
        { name: "Can manage tours" },
        { name: "Can manage reservations" },
        { name: "Can manage security" }
      ]
    },
    {
      name: "Agent",
      privileges: [
        { name: "Can manage reservations" }
      ]
    },
    {
      name: 'Support',
      privileges: [
        { name: "Can manage users" }
      ]
    }
  ]

  constructor(private modalService: NgbModal) { }

  ngOnInit() {
  }

  removePrivilege = (index: number) => {
    this.selectedRole.privileges.splice(index, 1);
    // TODO: go to service and remove privilege from this role
  }

  addNewPrivilege = () => {
    const modalRef = this.modalService.open(NewPrivilegeComponent);
    modalRef.componentInstance.roleName = this.selectedRole.name;
    
    // TODO: this should be filtered by id not name
    modalRef.componentInstance.privileges = this.allPrivileges.filter(x => !this.selectedRole.privileges.find(p => p.name == x.name));

    modalRef.result.then((newPrivilege: Privilege) => {
      if (newPrivilege) {
        this.selectedRole.privileges.push(newPrivilege);
        // TODO: go to service and add privilege to role
      }
    })
  }

  addNewRole = () => {
    const modalRef = this.modalService.open(NewRoleComponent);
    modalRef.result.then((roleName: string) => {
      if (roleName) {
        let newRole = new Role();
        newRole.name = roleName;
        
        // TODO: go to service and save role with "roleName"

        this.roles.push(newRole);
        this.selectedRole = newRole;
      }
    })
  }
  
  clearForm = () => {
    this.selectedRole = null;
  }
}
