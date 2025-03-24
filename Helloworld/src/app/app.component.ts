import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, FormsModule, CommonModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title: string = 'BridgeLabz HelloApp';
  imgUrl: string = 'BL_logo_square_jpg.jpg';
  siteUrl: string = 'https://www.bridgelabz.com';
  userName: string = "";
  nameError: string = '';

  openBridgeLabz(): void {
    window.open(this.siteUrl, '_blank');
  }

  validateUserName(): void {
    const namePattern = /^[A-Z]{1}[a-zA-Z\s]{2,}$/;

    if (!this.userName.match(namePattern)) {
      this.nameError = 'Name is Incorrect!';
    } else {
      this.nameError = '';
    }
  }
}

