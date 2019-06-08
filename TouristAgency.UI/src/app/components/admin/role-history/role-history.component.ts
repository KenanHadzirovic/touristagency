import { Component, OnInit } from '@angular/core';
import { RoleChange } from 'src/app/models/roleChange';
import { checkAndUpdateElementInline } from '@angular/core/src/view/element';

@Component({
  selector: 'app-role-history',
  templateUrl: './role-history.component.html',
  styleUrls: ['./role-history.component.css']
})
export class RoleHistoryComponent implements OnInit {

  constructor() { }
  changes: RoleChange[];
  filteredChanges: RoleChange[];
  searchString: string;

  ngOnInit() {
    this.changes = this.getChanges();
    this.filteredChanges = this.changes;
  }

  private getChanges(): RoleChange[] {
    return [
      { username: 'admin', changeType: 'Rola dodjeljena.', currentRole: 'Administrator', date: new Date, previousRole: '', newRole: 'Administrator'},
      { username: 'mirza', changeType: 'Rola dodjeljena.', currentRole: 'Support', date: new Date, previousRole: '', newRole: 'Support'},
      { username: 'mirza', changeType: 'Rola dodjeljena.', currentRole: 'Support', date: new Date, previousRole: 'Support', newRole: 'Administrator'},
      { username: 'mirza', changeType: 'Rola dodjeljena.', currentRole: 'Support', date: new Date, previousRole: 'Administrator', newRole: 'Agent'},
      { username: 'mirza', changeType: 'Rola dodjeljena.', currentRole: 'Support', date: new Date, previousRole: 'Agent', newRole: 'Support'},
      { username: 'kenan', changeType: 'Rola dodjeljena.', currentRole: '', date: new Date, previousRole: '', newRole: 'Administrator'},
      { username: 'kenan', changeType: 'Rola uklonjena.', currentRole: '', date: new Date, previousRole: 'Administrator', newRole: ''},
      { username: 'dzenita', changeType: 'Rola dodjeljena.', currentRole: 'Agent', date: new Date, previousRole: '', newRole: 'Administrator'},
      { username: 'dzenita', changeType: 'Rola uklonjena.', currentRole: 'Agent', date: new Date, previousRole: 'Administrator', newRole: ''},
      { username: 'dzenita', changeType: 'Rola dodjeljena.', currentRole: 'Agent', date: new Date, previousRole: '', newRole: 'Agent'}
    ];
  }

  public filter(): void {
    if(this.searchString != '')
    {
      this.filteredChanges = this.filteredChanges.filter(x => x.username.includes(this.searchString));
    }
    else
    {
      this.filteredChanges = this.changes;
    }
  }

}
