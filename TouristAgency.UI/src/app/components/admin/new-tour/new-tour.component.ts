import { Component, OnInit } from '@angular/core';
import { Tour } from '../../../models/tour';
import { Hotel } from '../../../models/hotel';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { NewFeatureComponent } from './new-feature/new-feature.component';
import { Feature } from '../../../models/feature';
import { TourService } from 'src/app/services/tour/tour.service';

declare var $: any

@Component({
  selector: 'app-new-tour',
  templateUrl: './new-tour.component.html',
  styleUrls: ['./new-tour.component.css']
})

export class NewTourComponent implements OnInit {


  private tour: Tour = new Tour();
  private datafromService;
  private saved;
  private errormessage="";
  private success="";

  private hotels: Hotel[] = [
    { phoneNumber: "033-225-883", address: "Adresa 1", city: "Grad", stars: 5, id: 1, name: "Hotel1"},
    { phoneNumber: "033-225-883", address: "Adresa 2", city: "Grad", stars: 3, id: 2, name: "Hotel2"},
    { phoneNumber: "033-225-883", address: "Adresa 3", city: "Grad", stars: 2, id: 3, name: "Hotel3"},
    { phoneNumber: "033-225-883", address: "Adresa 4", city: "Grad", stars: 4, id: 4, name: "Hotel4"},
  ];

  private tours: Tour[] = [
    { name: "033-225-883", location: "Spain", price: 2000,dateFrom: new Date("02/01/2019", ),id: 1, description: "Put oko svijeta"},
    { name: "033-225-883", location: "France", price: 2000,dateFrom: new Date("02/01/2019"),id: 1, description: "Put oko svijeta"},
    { name: "033-225-883", location: "Russia", price: 2000,dateFrom: new Date("02/01/2019"),id: 1, description: "Put oko svijeta"},
    { name: "033-225-883", location: "India", price: 2000,dateFrom: new Date("02/01/2019"), id: 1, description: "Put oko svijeta"},
  
  ];

  constructor(private modalService: NgbModal, private tourservice: TourService) { }

  ngOnInit() {
    $(".custom-file-input").on("change", function() {
      var fileName = ($(this).val() as any).split("\\").pop();
      $(this).siblings(".custom-file-label").addClass("selected").html(fileName);
    });
  }

  clearForm = () => {
    this.tour = new Tour();
    this.errormessage="";
    this.success="";
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
    this.saved=false;
    this.errormessage="";
    if(this.tour.name==null || this.tour.location==null ||this.tour.description==null)
      {
        this.errormessage= "Some of the required fields are empty!";
      }
      else{
        this.tourservice.PostData(this.tour);
        this.datafromService=this.tourservice.getAll();
       for (let entry of this.datafromService) {
        if (entry==this.tour)
         {
            this.saved= true;
            this.success="Tour saved.";
            this.clearForm();
         } 
        }  
        
      }
    
  }
}
