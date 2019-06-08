import { Component, OnInit } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { RoleService } from 'src/app/services/role/role.service';
import { Role } from 'src/app/models/role';

@Component({
  selector: 'app-new-role',
  templateUrl: './new-role.component.html',
  styleUrls: ['./new-role.component.css']
})
export class NewRoleComponent implements OnInit {

  private roleName: string;
  private role: Role = new Role();
  private datafromService;
  private saved;
  private errormessage="";
  private success="";

  constructor(
    public activeModal: NgbActiveModal, private roleservice: RoleService) { }

  ngOnInit() {
  }

  clearForm = () => {
    this.role = new Role();
    this.errormessage="";
    this.success="";
  }
  save = () => {
    this.saved=false;
    this.errormessage="";
    if(this.role.roleName==null)
      {
        this.errormessage= "Some of the required fields are empty!";
      }
      else{
        this.roleservice.PostData(this.role);
        this.datafromService=this.roleservice.getAll();
       for (let entry of this.datafromService) {
        if (entry==this.role)
         {
            this.saved= true;
            this.success="Tour saved.";
            this.clearForm();
         } 
        }  
        
      }
    
  }

}
