import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  imageSrc = 'assets/nice.png' 
  imagRenanim='assets/renanim.png'
  constructor() { }

  ngOnInit(): void {
  }

}
