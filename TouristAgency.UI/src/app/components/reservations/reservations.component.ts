import { Component, OnInit } from '@angular/core';
import { Reservation } from '../../models/reservation';
import { Tour } from '../../models/tour';
import { Tourist } from '../../models/Tourist';

@Component({
  selector: 'app-reservations',
  templateUrl: './reservations.component.html',
  styleUrls: ['./reservations.component.css']
})
export class ReservationsComponent implements OnInit {

  private reservation: Reservation = new Reservation();

  private tours: Tour[] = [
    { 
      id: 1,
      location: "London", 
      name: "Bračno putovanje u London", 
      dateFrom: new Date(2019, 1, 1), 
      dateTo: new Date(2019, 1, 11), 
      hotel: {
        id: 1,
        name: "London Hotel",
        phoneNumber: "033-225-883"
      },
      description: "...",
      tourType: "Bračno putovanje",
      pricePerDay: 100,
      price: 1000
    },
    { 
      id: 2,
      location: "Berlin", 
      name: "Sa školom u Njemačku", 
      dateFrom: new Date(2019, 1, 1), 
      dateTo: new Date(2019, 1, 11), 
      hotel: {
        id: 1,
        name: "Berlin Hotel",
        phoneNumber: "033-225-883"
      },
      description: "...",
      tourType: "Škola u prirodi",
      price: 1000,
      pricePerDay: 100
    },
    { 
      id: 3,
      location: "Lisabon", 
      name: "Ekskurzija u Portugal", 
      dateFrom: new Date(2019, 1, 1), 
      dateTo: new Date(2019, 1, 11), 
      hotel: {
        id: 1,
        name: "Lisabon Hotel",
        phoneNumber: "033-225-883"
      },
      description: "...",
      tourType: "Ekskurzija za SŠ",
      price: 1000,
      pricePerDay: 100
    }
  ];

  private tourists: Tourist[] = [
    { id: 1, fullName: "Mirza Vucijak" },
    { id: 2, fullName: "Steve Jobs" },
    { id: 2, fullName: "Satya Nadella" },
  ]

  constructor() { }

  ngOnInit() {
  }

  clearForm = () => {
    this.reservation = new Reservation();
  }

  submit = () => {
    
  }
}
