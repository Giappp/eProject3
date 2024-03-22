import { Injectable, inject } from '@angular/core';
import { CanActivateFn, Router } from '@angular/router';
import { AuthService } from '../auth/services/auth.service';

@Injectable()
class AuthGuard {
  constructor(private authService: AuthService, private router: Router) {}
  canActivate() : boolean{
    if(this.authService.getAuthentication){
      return true;
    }else{
      this.router.navigate(['auth/login']);
      return false;
    }
  }
}
export const authGuardGuard: CanActivateFn = (route, state) => {
  return inject(AuthGuard).canActivate();
};