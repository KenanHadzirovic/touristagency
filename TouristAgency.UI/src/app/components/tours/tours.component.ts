import { Component, OnInit } from '@angular/core';
import { TourService } from '../../services/tour/tour.service';
import { Tour } from '../../models/tour';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { TourDetailsComponent } from '../tour-details/tour-details.component';
import { TourType } from 'src/app/models/tourType';

@Component({
  selector: 'app-tours',
  templateUrl: './tours.component.html',
  styleUrls: ['./tours.component.css']
})
export class ToursComponent implements OnInit {

  constructor(
    private tourService: TourService,
    private modalService: NgbModal) { }

  private tours: TourType[];

  ngOnInit() {
    this.tourService.getAll().subscribe(tours => {
      this.tours = tours;
    });
  }

  openTourDetails = (tour: Tour) => {
    const modalRef = this.modalService.open(TourDetailsComponent, { size: 'lg' });
    modalRef.componentInstance.tour = tour;
  }
}