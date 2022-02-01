import { Component, OnInit } from '@angular/core';
import { DbService } from 'src/app/serves/db.service';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {

  constructor(private dbService: DbService) { }

  ngOnInit(): void {

    this.dbService.getAllUser().subscribe(users => {
      console.log(users);
    })

  }



}
