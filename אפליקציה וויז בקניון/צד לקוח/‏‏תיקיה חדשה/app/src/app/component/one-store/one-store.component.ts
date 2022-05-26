import { Component, Input, OnInit } from '@angular/core';
import { Store } from 'src/app/models/Store';
import { CatgoryStorService } from 'src/app/serves/catgory-stor.service';
import { StoreService } from 'src/app/serves/store.service';


@Component({
  selector: 'app-one-store',
  templateUrl: './one-store.component.html',
  styleUrls: ['./one-store.component.css']
  
})
export class OneStoreComponent implements OnInit {
  adidas="assets/store/adidas.png"
  foxhome="assets/store/FOXhome.png"
  irobot="assets/store/IRobot.png"
  zara="assets/store/ZARA.png"
  hm="assets/store/H&M.png"
  mango="assets/store/MANGO.png"

  constructor(private dbService: CatgoryStorService) { }
  @Input() thisStore: Store=new Store(-1,-1,'',false)
  ngOnInit(): void {
    getSelection()
    this.dbService.GetAllStor().subscribe(users => {
      console.log(users);
    })


  }
}