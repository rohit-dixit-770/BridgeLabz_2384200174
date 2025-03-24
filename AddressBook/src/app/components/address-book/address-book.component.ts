import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { AddressBookService } from 'app/services/address-book.service';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-address-book',
  imports: [CommonModule, FormsModule, RouterModule, ReactiveFormsModule],
  templateUrl: './address-book.component.html',
  styleUrl: './address-book.component.scss'
})

export class AddressBookComponent implements OnInit {
  contacts: any[] = [];
  showAddContact: boolean = false;
  newContact = { name: '', phoneNumber: '', address: '' };

  constructor(private addressBookService: AddressBookService) { }

  ngOnInit() {
    this.loadContacts();
  }

  loadContacts() {
    this.addressBookService.getContacts().subscribe((response: any) => {
      this.contacts = response.data;
    });
  }

  openAddContactModal() {
    this.showAddContact = true; 
  }

  closeAddContactModal() {
    this.showAddContact = false; 
  }

  saveContact() {
    this.addressBookService.addContact(this.newContact).subscribe(response => {
      this.loadContacts();
      this.newContact = { name: '', phoneNumber: '', address: '' };
      this.showAddContact = false; 
    }, error => {
      console.error('Error saving contact', error);
    });
  }

  deleteContact(id: number) {
    this.addressBookService.deleteContact(id).subscribe(() => {
      this.loadContacts();
    });
  }
  editContact(id: number, contact: any) {
    this.addressBookService.updateContact(id, contact).subscribe(() => {
      this.loadContacts();
    });
  }

}
