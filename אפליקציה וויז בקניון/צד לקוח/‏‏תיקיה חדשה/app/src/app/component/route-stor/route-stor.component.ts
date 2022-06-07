import { Component, OnInit } from '@angular/core';
import { Store } from 'src/app/models/Store';
import { CatgoryStorService } from 'src/app/serves/catgory-stor.service';

@Component({
  selector: 'app-route-stor',
  templateUrl: './route-stor.component.html',
  styleUrls: ['./route-stor.component.css']
})
export class RouteStorComponent implements OnInit {

  allStores= new Array<Store>();
  stroeCard=new Array<Store>();
  constructor(private db:CatgoryStorService ) { }
  ngOnInit(): void 
  {  this.db.getAllSore().subscribe(res =>
    {
    this.allStores=res;
    })
  }
  addToCard(s:string){
    return;
  }

}
