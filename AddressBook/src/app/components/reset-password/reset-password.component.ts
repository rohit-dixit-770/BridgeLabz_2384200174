import { Component } from '@angular/core';
import { AuthService } from 'app/services/auth.service';
import { ActivatedRoute, Router, RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
@Component({
  selector: 'app-reset-password',
  imports: [CommonModule, FormsModule, RouterModule, ReactiveFormsModule],
  templateUrl: './reset-password.component.html',
  styleUrl: './reset-password.component.scss',
})
export class ResetPasswordComponent {
  password: string = '';
  confirmPassword: string = '';
  token: string = '';

  constructor(private authService: AuthService, private route: ActivatedRoute, private router: Router) { }
  ngOnInit() {
    this.token = this.route.snapshot.queryParamMap.get('token') || '';
    console.log("Extracted Token:", this.token);
  }

  resetPassword() {
    if (this.password !== this.confirmPassword) {
      alert('Passwords do not match!');
      return;
    }
  
    console.log("Sending Reset Request:", { token: this.token, password: this.password });
  
    this.authService.resetPassword({ token: this.token, password: this.password , confirmPassword: this.confirmPassword}).subscribe(
      (response: any) => {
        console.log("Reset Success:", response);
        alert('Password reset successful! Please login.');
        this.router.navigate(['/login']);
      },
      (error) => {
        console.error('Reset Password Error:', error);
        console.error('Error Details:', error.error);
        alert(error.error?.message || 'Something went wrong!');
      }
    );
  }
  }
      