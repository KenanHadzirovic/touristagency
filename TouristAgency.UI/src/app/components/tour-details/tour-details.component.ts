import { Component, OnInit, Input } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { Tour } from '../../models/tour';
import { Router } from '@angular/router';

@Component({
  selector: 'app-tour-details',
  templateUrl: './tour-details.component.html',
  styleUrls: ['./tour-details.component.css']
})
export class TourDetailsComponent implements OnInit {

  @Input() tour: Tour;

  constructor(
    private activeModal: NgbActiveModal,
    private router: Router) { }

  ngOnInit() {
  }

  newReservation = () => {
    this.activeModal.close();
    this.router.navigate(['dashboard/reservations'], { state: { id: this.tour.id } });
  }

}
