import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Category } from 'src/app/models/Category';
import { CatgoryStorService } from 'src/app/serves/catgory-stor.service';
import { DbService } from 'src/app/serves/db.service';

@Component({
  selector: 'app-route-category',
  templateUrl: './route-category.component.html',
  styleUrls: ['./route-category.component.css']
})
export class RouteCategoryComponent implements OnInit {
  cart = "assets/cc.jpg";
  allCategory: Array<Category> = new Array<Category>();
  cardCategorys: Array<Category> = new Array<Category>();
  
  constructor(private db: CatgoryStorService, private dbService: DbService, private router: Router) {

  }
  addToCard(s: Category) {

    this.cardCategorys.push(s);
    // this.db.allStors.push(Event.(s));
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
  
  createRotue(nav: string) {
    console.log(this.cardCategorys);
    console.log("get route");
    this.dbService.getPATHCatgor(this.cardCategorys
      ).subscribe(res => {
      console.log(res);
      this.dbService.currentPath = res
      let fullpath = 'route-selection/' + nav
      this.router.navigate([fullpath])


    });

  }

}
