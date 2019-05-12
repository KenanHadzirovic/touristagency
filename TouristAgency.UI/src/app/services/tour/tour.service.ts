import { Injectable } from '@angular/core';
import { Tour } from '../../models/tour';
import { DomSanitizer } from '@angular/platform-browser';

@Injectable({
  providedIn: 'root'
})
export class TourService {

  constructor() { }

  getAll = (): Tour[] => {
    let image = "https://www.edreams.net/images/landingpages/vacation/640x480/paris_640x480.jpg";

    return [
      {
        id: 1,
        location: "Venecija",
        previewImage: image,
        name: "Venecija",
        description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
        dateFrom: new Date(2019, 1, 1),
        dateTo: new Date(2019, 1, 11),
        tourType: "Ekskurzija za SŠ",
        price: 1000,
        pricePerDay: 100, hotel: {
          id: 1,
          name: 'Ime hotela',
          phoneNumber: '033-225-883'
        }
      },
      {
        id: 1,
        location: "Barselona",
        previewImage: image,
        name: "Barselona",
        description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
        dateFrom: new Date(2019, 1, 1),
        dateTo: new Date(2019, 1, 11),
        tourType: "Ekskurzija za SŠ",
        price: 1000,
        pricePerDay: 100, hotel: {
          id: 1,
          name: 'Ime hotela',
          phoneNumber: '033-225-883'
        }
      },
      {
        id: 1,
        location: "Pariz",
        previewImage: image,
        name: "Pariz",
        description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
        dateFrom: new Date(2019, 1, 1),
        dateTo: new Date(2019, 1, 11),
        tourType: "Ekskurzija za SŠ",
        price: 1000,
        pricePerDay: 100, hotel: {
          id: 1,
          name: 'Ime hotela',
          phoneNumber: '033-225-883'
        }
      },
      {
        id: 1,
        location: "Monako",
        previewImage: image,
        name: "Monako",
        description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
        dateFrom: new Date(2019, 1, 1),
        dateTo: new Date(2019, 1, 11),
        tourType: "Ekskurzija za SŠ",
        price: 1000,
        pricePerDay: 100, hotel: {
          id: 1,
          name: 'Ime hotela',
          phoneNumber: '033-225-883'
        }
      },
      {
        id: 1,
        location: "Minhen",
        previewImage: image,
        name: "Minhen",
        description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
        dateFrom: new Date(2019, 1, 1),
        dateTo: new Date(2019, 1, 11),
        tourType: "Ekskurzija za SŠ",
        price: 1000,
        pricePerDay: 100, hotel: {
          id: 1,
          name: 'Ime hotela',
          phoneNumber: '033-225-883'
        }
      },
      {
        id: 1,
        location: "London",
        previewImage: image,
        name: "London",
        description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
        dateFrom: new Date(2019, 1, 1),
        dateTo: new Date(2019, 1, 11),
        tourType: "Ekskurzija za SŠ",
        price: 1000,
        pricePerDay: 100, hotel: {
          id: 1,
          name: 'Ime hotela',
          phoneNumber: '033-225-883'
        }
      },
      {
        id: 1,
        location: "Dablin",
        previewImage: image,
        name: "Dablin",
        description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
        dateFrom: new Date(2019, 1, 1),
        dateTo: new Date(2019, 1, 11),
        tourType: "Ekskurzija za SŠ",
        price: 1000,
        pricePerDay: 100, hotel: {
          id: 1,
          name: 'Ime hotela',
          phoneNumber: '033-225-883'
        }
      },
      {
        id: 1,
        location: "Kopenhagen",
        previewImage: image,
        name: "Kopenhagen",
        description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
        dateFrom: new Date(2019, 1, 1),
        dateTo: new Date(2019, 1, 11),
        tourType: "Ekskurzija za SŠ",
        price: 1000,
        pricePerDay: 100,
        hotel: {
          id: 1,
          name: 'Ime hotela',
          phoneNumber: '033-225-883'
        }
      }
    ];
  }
}
