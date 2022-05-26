import { Component, OnInit } from '@angular/core';
import { Store } from 'src/app/models/Store';
import { CatgoryStorService } from 'src/app/serves/catgory-stor.service';

@Component({
  selector: 'app-categorys',
  templateUrl: './categorys.component.html',
  styleUrls: ['./categorys.component.css']
})
export class CategorysComponent implements OnInit {
  allStores= new Array<Store>();

  constructor(private db:CatgoryStorService) { }

  ngOnInit(): void {
  }
  

}
