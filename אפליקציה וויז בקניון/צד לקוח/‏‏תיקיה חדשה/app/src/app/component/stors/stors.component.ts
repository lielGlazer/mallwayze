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
  myStore: Store | undefined;
  constructor(private db: CatgoryStorService) { }
  ngOnInit(): void {
    this.db.getAllSore().subscribe(res => {
      this.allStores = res;
    })
  }

  saveStore(s: Store) {
    this.myStore = s;
    this.getAllCategoryOfStor(s.NameStor);
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

  openNow() {
    let now = new Date().getHours();
    let open = 10;
    let close = 22;
    if (now > open && now < close)
      return 'פתוח עכשיו.'
    else
      return 'החנות סגורה עכשיו. תפתח בשעה 10:00'
  }
}
