import { Component, OnInit, Input } from '@angular/core';
import { Privilege } from '../../../../models/privilege';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-new-privilege',
  templateUrl: './new-privilege.component.html',
  styleUrls: ['./new-privilege.component.css']
})
export class NewPrivilegeComponent implements OnInit {

  @Input() roleName: string;

  @Input() privileges: Privilege[];

  private selectedPrivilege: Privilege;

  constructor(
    public activeModal: NgbActiveModal) { }

  ngOnInit() {
  }

}
