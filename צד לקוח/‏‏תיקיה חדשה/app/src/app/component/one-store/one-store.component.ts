import { Component, Input, OnInit } from '@angular/core';
import { Store } from 'src/app/models/Store';
import { DbService } from 'src/app/serves/db.service';


@Component({
  selector: 'app-one-store',
  templateUrl: './one-store.component.html',
  styleUrls: ['./one-store.component.css']
})
export class OneStoreComponent implements OnInit {
  constructor(private dbService: StoreService) { }
  @Input() thisStore: Store=new Store(-1,-1,'',false)
  ngOnInit(): void {
    getSelection()
    this.dbService.getAllUser().subscribe(users => {
      console.log(users);
    })


  }
}