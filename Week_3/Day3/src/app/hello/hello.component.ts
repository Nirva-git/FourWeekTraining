import { Component } from '@angular/core';

@Component({
  selector: 'app-hello',
  templateUrl: './hello.component.html',
  styleUrls: ['./hello.component.css']
})
export class HelloComponent {
  name= 'NIRVA';
  color= "Red";
  getColor(){
    this.color = this.color=== 'Blue'? 'Red' : 'Blue';
  } 
}
