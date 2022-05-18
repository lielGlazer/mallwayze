import { Component, OnInit } from '@angular/core';
import { Store } from 'src/app/models/Store';
import { StoreService } from 'src/app/serves/store.service';

@Component({
  selector: 'app-stors',
  templateUrl: './stors.component.html',
  styleUrls: ['./stors.component.css']
})
export class StorsComponent implements OnInit {
 allStores= new Array<Store>();
  constructor( private shopService:StoreService ) { 

  }
myStore=new Store(1,1,'liel',false)

  ngOnInit(): void {

    this.allStores=new Array<Store>();//this.shopService.GetAllStor();
  }


  
}
