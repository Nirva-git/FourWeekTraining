import { CanActivateFn } from '@angular/router';
import { AuthService } from './auth.service'; // Replace with the correct path to your AuthService

export const authGuard: CanActivateFn = (route, state) => {
  const authService = new AuthService(); // Initialize your AuthService here

  if (authService.isAuthenticated()) {
    return true;
  } else {
    // Redirect to the login page or perform any other action
    // For example, you can use Angular's Router to navigate to the login page
    // import { Router } from '@angular/router';
    // const router = new Router();
    // router.navigate(['/login']);
    
    return false;
  }
};
