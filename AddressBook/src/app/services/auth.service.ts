import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private apiUrl = 'https://localhost:7144/UserAuthentication';

  constructor(private http: HttpClient, private router: Router) { }

  register(user: any) {
    const headers = new HttpHeaders({ 'Content-Type': 'application/json' });
    return this.http.post(`${this.apiUrl}/register`, JSON.stringify(user), { headers });
  }

  login(credentials: any) {
    return this.http.post(`${this.apiUrl}/login`, credentials);
  }

  forgotPassword(forgotCredentials: any) {
    const headers = new HttpHeaders({ 'Content-Type': 'application/json' });
    return this.http.post(`${this.apiUrl}/forgot-password`, JSON.stringify(forgotCredentials), { headers });
  }
  
  resetPassword(resetCredentials: any) {
    const headers = new HttpHeaders({ 'Content-Type': 'application/json' });
    const requestBody = {
      ResetToken: resetCredentials.token,
      NewPassword: resetCredentials.password,
      ConfirmPassword: resetCredentials.confirmPassword 
    };
    return this.http.post(`${this.apiUrl}/reset-password`, JSON.stringify(requestBody), { headers });
  }
  

  logout() {
    localStorage.removeItem('token');
    this.router.navigate(['/']);
  }

  isAuthenticated(): boolean {
    return !!localStorage.getItem('token');
  }
}
