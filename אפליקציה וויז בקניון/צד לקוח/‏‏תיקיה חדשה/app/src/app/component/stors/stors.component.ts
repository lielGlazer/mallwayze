import { Component, OnInit } from '@angular/core';
import { Category } from 'src/app/models/Category';
import { Store } from 'src/app/models/Store';
import { CatgoryStorService } from 'src/app/serves/catgory-stor.service';


@Component({
  selector: 'app-stors',
  templateUrl: './stors.component.html',
  styleUrls: ['./stors.component.css']
})
export class StorsComponent implements OnInit {
  allStores = new Array<Store>();
  allCategories: Array<Category> = new Array<Category>()
  constructor(private db: CatgoryStorService) { }
  ngOnInit(): void {
    this.db.getAllSore().subscribe(res => {
      this.allStores = res;
    })
  }



  //פונקציה שמקבלת שם קטגוריה ומחזירה רשימה של חנויות 
  getAllCategoryOfStor(nameStor: string) {
    console.log("getAllCategoryOfStor");
    
    this.db.getAllCategoryOfStor(nameStor).subscribe(res => {
      this.allCategories = res;
      console.log("this.allCategories:" + res);

    }
      ,
      err => console.log("error:" + err.message)
    )
  }
}
