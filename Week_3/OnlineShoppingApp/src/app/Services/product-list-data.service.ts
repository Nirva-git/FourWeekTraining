import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class ProductListDataService {
  url = "https://fakestoreapi.com/products";

  constructor(private http: HttpClient) { }

  getProducts(): Observable<any[]> {
    return this.http.get<any[]>(this.url);
  }

  getProduct(productId: number): Observable<any | undefined> {
    return this.getProducts().pipe(
      map(products => products.find(product => product.id === productId))
    );
  }
}
