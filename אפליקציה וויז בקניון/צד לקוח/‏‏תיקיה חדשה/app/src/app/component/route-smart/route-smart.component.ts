import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';

@Component({
  selector: 'app-route-smart',
  templateUrl: './route-smart.component.html',
  styleUrls: ['./route-smart.component.css']
})
export class RouteSmartComponent implements OnInit {
 imageCanvas="assets/one.png"
  constructor() { }

  ngOnInit(): void {
  }

}

@Component({
  selector: 'app-root',
  template: `
    <canvas #canvas width="600" height="300"></canvas>
    <button (click)="animate()">Play</button>   
  `,
  styles: ['canvas { border-style: solid }']
})
export class AppComponent implements OnInit {
  // @ViewChild('canvas', { static: true })
  // canvas: ElementRef<HTMLCanvasElement>;  
  
  // private ctx: CanvasRenderingContext2D;

  ngOnInit(): void {
    // this.ctx = this.canvas.nativeElement.getContext('2d');
  }
  
  animate(): void {}
}
