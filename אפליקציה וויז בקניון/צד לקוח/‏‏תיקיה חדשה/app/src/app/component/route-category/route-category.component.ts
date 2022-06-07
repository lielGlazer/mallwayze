import { Component, OnInit } from '@angular/core';
import { Category } from 'src/app/models/Category';
import { CatgoryStorService } from 'src/app/serves/catgory-stor.service';

@Component({
  selector: 'app-route-category',
  templateUrl: './route-category.component.html',
  styleUrls: ['./route-category.component.css']
})
export class RouteCategoryComponent implements OnInit {
  allCategory= new Array<Category>();
   constructor(private db:CatgoryStorService ) { 
 
   }
  ngOnInit(): void {
    
  }
  dostart(){
    this.db.getAllCaregory().subscribe(res =>{
      this.allCategory=res;
    })

}

}
