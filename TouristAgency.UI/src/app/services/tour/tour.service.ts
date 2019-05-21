import { Injectable } from '@angular/core';
import { Tour } from '../../models/tour';
import { DomSanitizer } from '@angular/platform-browser';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class TourService {

  constructor(private http: HttpClient) { }

  getAll = (): Tour[] => {
    return [];
  }
}
