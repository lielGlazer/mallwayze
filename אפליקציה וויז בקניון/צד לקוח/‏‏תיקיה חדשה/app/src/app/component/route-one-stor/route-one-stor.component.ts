import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-route-one-stor',
  templateUrl: './route-one-stor.component.html',
  styleUrls: ['./route-one-stor.component.css']
})
export class RouteOneStorComponent implements OnInit {

  constructor(private router:Router) { }

  ngOnInit(): void {
  }
  routing(nav:string){
    let fullpath='app-route-one-stor/'+nav
    this.router.navigate([fullpath])
  }

}
