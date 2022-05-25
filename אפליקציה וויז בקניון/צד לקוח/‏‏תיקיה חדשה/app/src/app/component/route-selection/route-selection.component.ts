import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-route-selection',
  templateUrl: './route-selection.component.html',
  styleUrls: ['./route-selection.component.css']
})
export class RouteSelectionComponent implements OnInit {

  constructor(private router:Router) { }

  ngOnInit(): void {
  }
  route(){
//לחבר לחישוב מסלול 
  }
  categoriesPage(){
//לחבר לדף הקטגוריות
  }
  routing(nav:string){
    let fullpath='route-selection/'+nav
    this.router.navigate([fullpath])
  }

}
