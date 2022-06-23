import { Component, Input, OnInit } from '@angular/core';
import { Route, Router } from '@angular/router';
import { Store } from 'src/app/models/Store';
import { CatgoryStorService } from 'src/app/serves/catgory-stor.service';
import { DbService } from 'src/app/serves/db.service';

@Component({
  selector: 'app-route-stor',
  templateUrl: './route-stor.component.html',
  styleUrls: ['./route-stor.component.css']
})
export class RouteStorComponent implements OnInit {
  cart = "assets/cc.jpg";
  allStores = new Array<Store>();
  stroeCard = new Array<Store>();

  constructor(private db: CatgoryStorService, private dbService: DbService, private router: Router) { }
  ngOnInit(): void {
    this.db.getAllSore().subscribe(res => {
      this.allStores = res;
    })
  }
  addToCard(s: Store) {

    this.stroeCard.push(s);
    // this.db.allStors.push(Event.(s));
  }
  createRotue(nav: string) {
    console.log(this.stroeCard);
    console.log("get route");
    this.dbService.getPATH(this.stroeCard).subscribe(res => {
      console.log(res);
      this.dbService.currentPath = res
      let fullpath = 'route-selection/' + nav
      this.router.navigate([fullpath])


    });

  }
  createSALERotue(nav: string) {
    console.log(this.stroeCard);
    console.log("get route");
    this.dbService.getSalePATH(this.stroeCard).subscribe(res => {
      console.log(res);
      this.dbService.currentPath = res
      let fullpath = 'route-selection/' + nav
      this.router.navigate([fullpath])


    });

  }


}
