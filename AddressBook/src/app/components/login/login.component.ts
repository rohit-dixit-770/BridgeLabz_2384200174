import { Component } from '@angular/core';
import { AuthService } from 'app/services/auth.service';
import { RouterModule, Router } from '@angular/router';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-login',
  imports: [CommonModule, RouterModule , FormsModule, ReactiveFormsModule], 
  templateUrl: './login.component.html',
  styleUrl: './login.component.scss'
})
export class LoginComponent {
  email = '';
  password = '';

  constructor(private authService: AuthService, private router: Router) {}

  login() {
    this.authService.login({ email: this.email, password: this.password }).subscribe((response: any) => {
      localStorage.setItem('token', response.token);
      alert('Logged in Successfully');
      this.router.navigate(['/address-book']).then(() => {
        window.location.reload();
      });
    }, 
    error => {
      alert('Invalid credentials');
    });
  }
}
