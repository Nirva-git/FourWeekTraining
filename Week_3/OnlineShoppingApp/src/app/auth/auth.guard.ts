import { CanActivateFn, Router } from '@angular/router';
import { AuthService } from './auth.service'; // Replace with the correct path to your AuthService

export const authGuard: CanActivateFn = (route, state) => {
  const authService = new AuthService(); // Initialize your AuthService here

  if (authService.isAuthenticated()) {
    return true;
  } else {
    
    const router = new Router();
     router.navigate(['/login']);
    
    return false;
  }
};
