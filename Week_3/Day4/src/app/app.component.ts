import { Component } from '@angular/core';
import { UserDataService } from './services/user-data.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Day4';
  posts:any;
  constructor(private postData:UserDataService)
  {
    postData.posts().subscribe((data)=>this.posts= data);
  }
  getUserFormData(data:any)
  {
      this.postData.saveUsers(data).subscribe((result)=>console.warn(result))
  }
  deleteUserData(data:any){ 
    this.postData.DeleteUser(data).subscribe((result)=>console.warn(result))
  }
  updateUserData(data:any){
    this.postData.DeleteUser(data).subscribe((result)=>console.warn(result))
  }
}
