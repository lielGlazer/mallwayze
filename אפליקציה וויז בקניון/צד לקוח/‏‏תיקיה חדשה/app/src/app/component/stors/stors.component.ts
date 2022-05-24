import { Component, OnInit } from '@angular/core';
import { Store } from 'src/app/models/Store';
import { DbService } from 'src/app/serves/db.service';
import { StoreService } from 'src/app/serves/store.service';

@Component({
  selector: 'app-stors',
  templateUrl: './stors.component.html',
  styleUrls: ['./stors.component.css']
})
export class StorsComponent implements OnInit {
 allStores= new Array<Store>();
  constructor(private db:DbService ) { 

  }


  ngOnInit(): void {

   
  }

  shoeAllStore(){
    this.db.getAllSore().subscribe(res =>{
      this.allStores=res;
    })
  }
  
}
