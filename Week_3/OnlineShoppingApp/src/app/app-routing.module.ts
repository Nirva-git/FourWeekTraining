import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProductDetailsComponent } from './Components/product-details/product-details.component';
import { ProductListComponent } from './Components/product-list/product-list.component';
import { authGuard } from './auth/auth.guard'
import { LoginComponent } from './login/login.component';

const routes: Routes = [
  { path: '', redirectTo: 'products', pathMatch: 'full'},
  {
    component: ProductListComponent,
    path: 'products'
  },
  {
    component: LoginComponent,
    path: 'login'
  },
  {
    component: ProductDetailsComponent,
    path: 'products/:productId',
    canActivate: [authGuard]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
