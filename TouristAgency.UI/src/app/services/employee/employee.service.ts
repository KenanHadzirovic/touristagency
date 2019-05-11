import { Injectable } from '@angular/core';
import { Employee } from '../../models/employee';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  constructor() { }

  getAll = (): Employee[] => {
    return [
      { address: "Neka adresa", dateOfBirth: new Date(1995, 4, 4), fullName: "Mirza Vucijak", id: 1, phoneNumber: "033-225-883", roleId: 1 },
      { address: "Neka adresa", dateOfBirth: new Date(1995, 4, 4), fullName: "Mirza Vucijak", id: 1, phoneNumber: "033-225-883", roleId: 1 },
      { address: "Neka adresa", dateOfBirth: new Date(1995, 4, 4), fullName: "Mirza Vucijak", id: 1, phoneNumber: "033-225-883", roleId: 1 },
      { address: "Neka adresa", dateOfBirth: new Date(1995, 4, 4), fullName: "Mirza Vucijak", id: 1, phoneNumber: "033-225-883", roleId: 1 },
      { address: "Neka adresa", dateOfBirth: new Date(1995, 4, 4), fullName: "Mirza Vucijak", id: 1, phoneNumber: "033-225-883", roleId: 1 },
      { address: "Neka adresa", dateOfBirth: new Date(1995, 4, 4), fullName: "Mirza Vucijak", id: 1, phoneNumber: "033-225-883", roleId: 1 },
      { address: "Neka adresa", dateOfBirth: new Date(1995, 4, 4), fullName: "Mirza Vucijak", id: 1, phoneNumber: "033-225-883", roleId: 1 },
    ]
  }
}
