import { Component, OnInit } from '@angular/core';
import { Store } from 'src/app/models/Store';
import { CatgoryStorService } from 'src/app/serves/catgory-stor.service';


@Component({
  selector: 'app-stors',
  templateUrl: './stors.component.html',
  styleUrls: ['./stors.component.css']
})
export class StorsComponent implements OnInit {
 allStores= new Array<Store>();
  constructor(private db:CatgoryStorService ) { }
  ngOnInit(): void {  this.db.getAllSore().subscribe(res =>{
    this.allStores=res;
  })}
  
  
  
  //פונקציה שמקבלת שם קטגוריה ומחזירה רשימה של חנויות 
  // gelAllStorsOfCategory(nameCategory=""){
  //   this.db.gelAllStorOfCategory(nameCategory).subscribe(res =>{
  //     this.allStores=res;
  //   })
  // }
}
