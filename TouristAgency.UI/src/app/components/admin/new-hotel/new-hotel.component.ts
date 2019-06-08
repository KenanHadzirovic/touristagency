import { Component, OnInit } from '@angular/core';
import { Hotel } from '../../../models/hotel';
import { HttpClient } from '@angular/common/http';
import { HotelService } from 'src/app/services/hotel/hotel.service';

@Component({
  selector: 'app-new-hotel',
  templateUrl: './new-hotel.component.html',
  styleUrls: ['./new-hotel.component.css']
})
export class NewHotelComponent implements OnInit {

  private hotel: Hotel = new Hotel();
  private Name;
  private address;
  private city;
  private country;
  private stars;
  private phone;
  private website;
  private datafromService;
  private saved;
  private errormessage="";
  private success="";

  constructor(private http: HttpClient, private hotelservice: HotelService) { 
  }


  ngOnInit() {
  }

  clearForm = () => {
    this.hotel = new Hotel();
    this.errormessage="";
    this.success="";
  }

  submit = () => {
    this.saved=false;
    this.errormessage="";
    if(this.hotel.name==null || this.hotel.address==null ||this.hotel.city==null
      || this.hotel.country==null || this.hotel.phoneNumber==null || this.hotel.website==null)
      {
        this.errormessage= "Some of the required fields are empty!";
      }
      else{
        this.hotelservice.PostData(this.hotel);
        this.datafromService=this.hotelservice.getAll();
       for (let entry of this.datafromService) {
        if (entry==this.hotel)
         {
            this.saved= true;
            this.success="Hotel saved.";
            this.clearForm();
         } 
        }  
        
      }
    
  }
}   

