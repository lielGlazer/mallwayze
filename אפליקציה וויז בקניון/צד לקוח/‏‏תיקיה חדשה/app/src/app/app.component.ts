import { Component } from '@angular/core';

@Component({
  
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  image = 'assets/love.png' 
  imagRenanim='assets/renanim.png'
  title = 'app';

  enter: boolean = false

  openSign() {
    console.log("enter!!!!!!!!!!!");
    this.enter = !this.enter
  }
}


