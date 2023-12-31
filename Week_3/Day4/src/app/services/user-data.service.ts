import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http'
@Injectable({
  providedIn: 'root'
})
export class UserDataService {
  url = "https://jsonplaceholder.typicode.com/posts"
  
  constructor(private http:HttpClient ) { }
  posts() 
  {
    return this.http.get(this.url);   
  }
  saveUsers(data:any){
    return this.http.post(this.url,data)
  }
  DeleteUser(data:any){
    return this.http.delete(this.url,data)
  }
}
