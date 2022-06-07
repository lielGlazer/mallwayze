import { Component, OnInit } from '@angular/core';
import { Category } from 'src/app/models/Category';
import { CatgoryStorService } from 'src/app/serves/catgory-stor.service';

@Component({
  selector: 'app-route-category',
  templateUrl: './route-category.component.html',
  styleUrls: ['./route-category.component.css']
})
export class RouteCategoryComponent implements OnInit {
  allCategory: Array<Category> = new Array<Category>();
  cardCategorys: Array<Category> = new Array<Category>();
  constructor(private db: CatgoryStorService) {

  }
  ngOnInit(): void {
    this.db.getAllCaregory().subscribe(res => {
      this.allCategory = res;
      console.log("allCategory:" + this.allCategory);

    },
      err => {
        console.log("error:" + err.message);

      })

  }
  dostart() {


  }

}
