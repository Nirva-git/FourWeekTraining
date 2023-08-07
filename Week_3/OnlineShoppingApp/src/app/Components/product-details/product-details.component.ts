import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ProductListDataService } from '../../Services/product-list-data.service';

@Component({
  selector: 'app-product-details',
  templateUrl: './product-details.component.html',
  styleUrls: ['./product-details.component.css']
})
export class ProductDetailsComponent implements OnInit {
  
  product: any; // Replace 'any' with the actual product type

  constructor(
    private route: ActivatedRoute,
    private productService: ProductListDataService // Replace with the actual ProductService if you named it differently
  ) { }

  ngOnInit(): void {
    let productId=Number(this.route.snapshot.paramMap.get('productId'));
    console.warn(productId);
    productId && this.productService.getProduct(productId).subscribe((result)=>{
      console.warn(result)
      this.product= result;
    });
  }

  
}
    