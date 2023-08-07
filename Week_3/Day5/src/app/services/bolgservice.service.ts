import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
@Injectable({
  providedIn: 'root'
})
export class BolgserviceService {
  url = "https://jsonplaceholder.typicode.com/posts"
  
  constructor(private http:HttpClient ) { }
  posts() 
  {
    return this.http.get(this.url);   
  }
  getPost(postId: number): Observable<Post> {
    return this.http.get<Post>(`${this.url}/posts/${postId}`);
  }
} 
