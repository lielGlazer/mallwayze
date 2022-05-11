import { Component, Input, OnInit } from '@angular/core';
import { Store } from 'src/app/models/Store';

@Component({
  selector: 'app-one-store',
  templateUrl: './one-store.component.html',
  styleUrls: ['./one-store.component.css']
})
export class OneStoreComponent implements OnInit {


  @Input() thisStore=new Store();
  constructor() { }

  ngOnInit(): void {
  }

}
