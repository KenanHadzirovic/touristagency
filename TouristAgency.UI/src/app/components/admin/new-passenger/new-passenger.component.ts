import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { TouristService } from 'src/app/services/tourist/tourist.service';
import { Tourist } from 'src/app/models/Tourist';

@Component({
  selector: 'app-new-passenger',
  templateUrl: './new-passenger.component.html',
  styleUrls: ['./new-passenger.component.css']
})
export class NewPassengerComponent implements OnInit {

  private tourist: Tourist = new Tourist();
  private firstname;
  private address;
  private lastname;
  private ssn;
  private datafromService;
  private saved;
  private errormessage="";
  private success="";

  constructor(private http: HttpClient, private touristservice: TouristService) { 
  }
  ngOnInit() {
  }
  
  clearForm = () => {
    this.tourist = new Tourist();
    this.errormessage="";
    this.success="";
  }

  submit = () => {
    this.saved=false;
    this.errormessage="";
    if(this.tourist.firstname==null || this.tourist.address==null || this.tourist.lastname==null
      || this.tourist.ssn==null)
      {
        this.errormessage= "Some of the required fields are empty!";
      }
      else{
        this.touristservice.PostData(this.tourist);
        this.datafromService=this.touristservice.getAll();
       for (let entry of this.datafromService) {
        if (entry==this.tourist)
         {
            this.saved= true;
            this.success="Tourist saved.";
            this.clearForm();
         } 
        }  
  }
  }

}
