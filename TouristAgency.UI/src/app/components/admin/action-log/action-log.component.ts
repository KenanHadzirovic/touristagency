import { Component, OnInit } from '@angular/core';
import { Action } from 'src/app/models/action';

@Component({
  selector: 'app-action-log',
  templateUrl: './action-log.component.html',
  styleUrls: ['./action-log.component.css']
})
export class ActionLogComponent implements OnInit {

  constructor() { }
  actions: Action[];
  filteredActions: Action[];
  searchString: string;

  ngOnInit() {
    this.actions = this.getActions();
    this.filteredActions = this.actions;
  }

  private getActions(): Action[] {
    return [
      { username: 'admin', ipAddress: '192.168.0.0', role: 'Administrator', date: new Date,  action:'Rola dodjeljena korisniku: mirza.'},
      { username: 'admin', ipAddress: '8.8.8.8', role: 'Administrator', date: new Date,  action:'Rola dodjeljena korisniku: kenan'},
      { username: 'admin', ipAddress: '8.8.8.8', role: 'Administrator', date: new Date,  action:'Rola dodjeljena korisniku: dzenita'},
      { username: 'admin', ipAddress: '8.8.8.8', role: 'Administrator', date: new Date,  action:'Dodano novo putovanje: Pariz'},
      { username: 'admin', ipAddress: '8.8.8.8', role: 'Administrator', date: new Date,  action:'Dodano novo putovanje: Lisabon'},
      { username: 'kenan', ipAddress: '10.0.0.0', role: 'Support', date: new Date,  action:'Dodano novo putovanje: London'},
      { username: 'kenan', ipAddress: '10.0.0.0', role: 'Support', date: new Date,  action:'Dodano novo putovanje: Moskva'},
      { username: 'kenan', ipAddress: '10.0.0.0', role: 'Support', date: new Date,  action:'Obrisano putovanje: Lisabon'},
      { username: 'kenan', ipAddress: '10.0.0.0', role: 'Support', date: new Date,  action:'Dodano novo putovanje: Minhen'},
      { username: 'kenan', ipAddress: '10.0.0.0', role: 'Support', date: new Date,  action:'Dodano novo putovanje: Barselona'},
      { username: 'dzenita', ipAddress: '255.255.255.0', role: 'Agent', date: new Date,  action:'Dodan novi hotel: Bristol'},
      { username: 'dzenita', ipAddress: '255.255.255.0', role: 'Agent', date: new Date,  action:'Dodan novi hotel : Holiday Inn'},
      { username: 'dzenita', ipAddress: '255.255.255.0', role: 'Agent', date: new Date,  action:'Dodan novo putovanje: Dubrovnik'},
      { username: 'dzenita', ipAddress: '255.255.255.0', role: 'Agent', date: new Date,  action:'Dodana nova rezervacija: Mirza Vucijak'},
    ];
  }

  public filter(): void {
    if(this.searchString != '')
    {
      this.filteredActions = this.filteredActions.filter(x => x.username.includes(this.searchString));
    }
    else
    {
      this.filteredActions = this.actions;
    }
  }

}
