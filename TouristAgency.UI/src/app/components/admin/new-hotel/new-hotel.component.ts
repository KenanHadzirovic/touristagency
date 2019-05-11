import { Component, OnInit } from '@angular/core';
import { Hotel } from '../../../models/hotel';

@Component({
  selector: 'app-new-hotel',
  templateUrl: './new-hotel.component.html',
  styleUrls: ['./new-hotel.component.css']
})
export class NewHotelComponent implements OnInit {

  private hotel: Hotel = new Hotel();

  constructor() { }

  ngOnInit() {
  }

  clearForm = () => {
    this.hotel = new Hotel();
  }

  submit = () => {

  }

}
