import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { ProductListDataService } from 'src/app/Services/product-list-data.service';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent {
  products: any;
  isLogin :Boolean = false;
  constructor(private productData : ProductListDataService, private router:Router){
    
    this.productData.getProducts().subscribe((data) => {
      console.log("data", data);
      this.products = data;
    })

  }
  CheckLogin(){
    if(this.isLogin== true){
      this.router.navigate(['/products/:productId'])
    }
    else{
        this.router.navigate(['/login'])
    }
  }
}