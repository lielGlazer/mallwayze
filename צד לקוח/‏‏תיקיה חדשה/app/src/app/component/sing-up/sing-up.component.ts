import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.css']
})
export class SignUpComponent implements OnInit {

  signUpForm: any;
  constructor() { }

  ngOnInit(): void {

    this.signUpForm = new FormGroup(
      {
        userName: new FormControl('', Validators.compose([Validators.required, Validators.pattern("^[ת-א]*$"),, Validators.maxLength(8)])),
        password: new FormControl(''),
        confirmPassword: new FormControl(''),
        agree: new FormControl(''),

      }
    )

  }

}
