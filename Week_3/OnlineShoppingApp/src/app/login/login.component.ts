import { Component, OnInit } from '@angular/core';
import { AuthService } from '../auth/auth.service'; // Replace with the correct path to your AuthService
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})

export class LoginComponent implements OnInit {
  Username:string='';
  Password:number=1;
  constructor(private authService: AuthService, private router: Router) {}

  ngOnInit(): void {}

  login() {
    
    if(this.Username== 'Nirva' && this.Password== 123){
    this.authService.login();
    this.router.navigate(['/products']); 
  }else{
    alert("please enter valid credientials!!")
  }                                                
}

  logout() {
    // Perform dummy logout logic here
    this.authService.logout();
  }
}
                       