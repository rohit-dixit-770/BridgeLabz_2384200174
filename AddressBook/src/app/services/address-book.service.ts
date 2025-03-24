import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class AddressBookService {
  private apiUrl = 'https://localhost:7144/AddressBook';

  constructor(private http: HttpClient) {}

  getContacts() {
    return this.http.get(`${this.apiUrl}`);
  }
  getUserContacts() {
    const headers = new HttpHeaders({
      'Content-Type': 'application/json',
      'Authorization': `Bearer ${localStorage.getItem('token')}`
    });
  
    return this.http.get(`${this.apiUrl}/my-contacts`, { headers: headers });
  }
  
  getContact(id: number) {
    return this.http.get(`${this.apiUrl}/${id}`);
  }

  addContact(contact: any) {
    return this.http.post(`${this.apiUrl}`, contact);
  }

  updateContact(id: number, contact: any) {
    return this.http.put(`${this.apiUrl}/${id}`, contact);
  }

  deleteContact(id: number) {
    return this.http.delete(`${this.apiUrl}/${id}`);
  }
}
