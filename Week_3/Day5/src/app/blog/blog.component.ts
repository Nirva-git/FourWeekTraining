import { Component } from '@angular/core';
import { BolgserviceService } from '../services/bolgservice.service';
@Component({
  selector: 'app-blog',
  templateUrl: './blog.component.html',
  styleUrls: ['./blog.component.css']
})
export class BlogComponent {
  posts:any;
  constructor(private postData:BolgserviceService)
  {
    postData.posts().subscribe((data)=>this.posts= data);
  }
}
