import { Component, OnInit } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { Feature } from '../../../../models/feature';
import { FeatureType } from '../../../../models/feature-type';

@Component({
  selector: 'app-new-feature',
  templateUrl: './new-feature.component.html',
  styleUrls: ['./new-feature.component.css']
})
export class NewFeatureComponent implements OnInit {

  private feature: Feature = new Feature();

  private featureTypes: FeatureType[] = [
    { id: 1, name: "Naziv tipa", description: "Opis"},
    { id: 2, name: "Naziv tipa2", description: "Opis"},
    { id: 3, name: "Naziv tipa3", description: "Opis"},
  ];

  constructor(public activeModal: NgbActiveModal) { }

  ngOnInit() {
  }

}
