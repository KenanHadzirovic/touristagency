import { Component, OnInit } from '@angular/core';
import { Tour } from '../../../models/tour';
import { Hotel } from '../../../models/hotel';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { NewFeatureComponent } from './new-feature/new-feature.component';
import { Feature } from '../../../models/feature';

declare var $: any

@Component({
  selector: 'app-new-tour',
  templateUrl: './new-tour.component.html',
  styleUrls: ['./new-tour.component.css']
})
export class NewTourComponent implements OnInit {

  private tour: Tour = new Tour();

  private hotels: Hotel[] = [
    { phoneNumber: "033-225-883", address: "Adresa 1", city: "Grad", stars: 5, id: 1, name: "Hotel1"},
    { phoneNumber: "033-225-883", address: "Adresa 2", city: "Grad", stars: 3, id: 2, name: "Hotel2"},
    { phoneNumber: "033-225-883", address: "Adresa 3", city: "Grad", stars: 2, id: 3, name: "Hotel3"},
    { phoneNumber: "033-225-883", address: "Adresa 4", city: "Grad", stars: 4, id: 4, name: "Hotel4"},
  ];

  constructor(private modalService: NgbModal) { }

  ngOnInit() {
    $(".custom-file-input").on("change", function() {
      var fileName = ($(this).val() as any).split("\\").pop();
      $(this).siblings(".custom-file-label").addClass("selected").html(fileName);
    });
  }

  clearForm = () => {
    this.tour = new Tour();
  }

  removeFeature = (index: number) => {
    this.tour.features.splice(index, 1);
  }

  addNewFeature = () => {
    const modalRef = this.modalService.open(NewFeatureComponent, { size: 'lg' });

    modalRef.result.then((newFeature: Feature) => {
      if (newFeature) {
        this.tour.features.push(newFeature);
      }
    })
  }

  save = () => {
    // TODO: go to service and save tour
  }
}
