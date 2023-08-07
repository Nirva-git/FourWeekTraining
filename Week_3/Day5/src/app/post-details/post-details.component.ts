import { Component, OnInit  } from '@angular/core';
import { BolgserviceService } from '../services/bolgservice.service';
import { ActivatedRoute } from '@angular/router';


@Component({
  selector: 'app-post-details',
  templateUrl: './post-details.component.html',
  styleUrls: ['./post-details.component.css']
})
export class PostDetailsComponent implements OnInit {
  postId: any;
  post: any;
  // comments: any[];

  constructor(
    private route: ActivatedRoute,
    private postData: BolgserviceService
  ) {}

  ngOnInit() {
    // Get the post ID from the route parameter
    this.route.paramMap.subscribe(params => {
      this.postId? +params.get('id')!: 1;
      // Fetch the post details
      this.postData.getPost(this.postId).subscribe(data => {
        this.post = data;
      });
      // Fetch the comments for the post
      // this.postData.getComments(this.postId).subscribe(data => {
      //   this.comments = data;
      // });
    });
  }
}
