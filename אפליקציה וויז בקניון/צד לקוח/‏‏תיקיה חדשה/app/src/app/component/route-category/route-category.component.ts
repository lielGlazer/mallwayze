import { Component, OnInit } from '@angular/core';
import { Category } from 'src/app/models/Category';
import { CategoryService } from 'src/app/serves/category.service';

@Component({
  selector: 'app-route-category',
  templateUrl: './route-category.component.html',
  styleUrls: ['./route-category.component.css']
})
export class RouteCategoryComponent implements OnInit {
  allStores= new Array<Category>();
   constructor(private db:CategoryService ) { 
 
   }
  ngOnInit(): void {
    
  }
  dostart(){
    this.db.getAllCaregory().subscribe(res =>{
      this.allStores=res;
    })

}
}
