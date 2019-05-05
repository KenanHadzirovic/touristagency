import { Component, OnInit } from '@angular/core';
import { TourService } from '../../services/tour/tour.service';
import { Tour } from '../../models/tour';

@Component({
  selector: 'app-tours',
  templateUrl: './tours.component.html',
  styleUrls: ['./tours.component.css']
})
export class ToursComponent implements OnInit {

  constructor(private tourService: TourService) { }

  private tours: Tour[];

  ngOnInit() {
    this.tours = this.tourService.getAll();
  }
}