import { Component } from '@angular/core';
import { AuthService } from 'app/services/auth.service';
import { Router, RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-forgot-password',
  imports: [CommonModule, FormsModule, RouterModule],
  templateUrl: './forgot-password.component.html',
  styleUrl: './forgot-password.component.scss'
})
export class ForgotPasswordComponent {
  email: string = '';

  constructor(private authService: AuthService, private router: Router) {}

  submitForgotPassword() {
    this.authService.forgotPassword({email: this.email}).subscribe((response: any) =>{
        alert('Reset link sent to your email');
        this.router.navigate(['/reset-password']);
      },
      error => {
        alert('Something went wrong!');
      });
  }
}
