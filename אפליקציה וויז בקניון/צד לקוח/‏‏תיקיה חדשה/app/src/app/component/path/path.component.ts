import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import * as echarts from 'echarts';


@Component({
  selector: 'app-path',
  templateUrl: './path.component.html',
  styleUrls: ['./path.component.css']
})
export class PathComponent implements OnInit {

  @ViewChild('canvas', { static: true })
  canvas: any;
  @ViewChild('img', { static: true })
  img: any;
  private ctx: any;

  // option:any;
  shortestPath: any;

  constructor() {
    // this.option = {
    //   xAxis: {
    //     type: 'category',
    //     data: ['Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat', 'Sun']
    //   },
    //   yAxis: {
    //     type: 'value'
    //   },
    //   series: [
    //     {
    //       data: [150, 230, 224, 218, 135, 147, 260],
    //       type: 'line'
    //     }
    //   ]
    // };
    this.shortestPath = [
      {
        name: "כניסה",
        xAxis: 300,
        yAxis: 50
      },
      {
        name: "אופטיקנה",
        xAxis: 230,
        yAxis: 110
      },
       {
        name: "מרקו",
        xAxis: 230,
        yAxis:150
      },
      {
        name: "סגל",
        xAxis: 200,
        yAxis: 200
      }
     
    ]

  }

  ngOnInit(): void {

    this.ctx = this.canvas.nativeElement.getContext('2d');
    // this.chartDom = document.getElementById('main');
    // this.myChart = echarts.init(this.chartDom);
    // this.option && this.myChart.setOption(this.option);
    // this.drawStores();
    this.drawPath();
  }

  drawStores(): void {

    this.ctx.drawImage(this.img, 0, 0);

  }

  drawPath(): void {

    this.ctx.beginPath();
    this.ctx.moveTo(this.shortestPath[0].xAxis, this.shortestPath[0].yAxis);
    for (let point of this.shortestPath) {

      this.ctx.lineTo(point.xAxis, point.yAxis)
    }
   
    this.ctx.stroke();

    // this method we'll implement soon to do the actual drawing
    // this.ctx.drawOnCanvas(prevPos, currentPos);


    // this.ctx.lineTo(125, 45);
    // this.ctx.lineTo(45, 125);
    // this.ctx.closePath();
    // this.ctx.stroke();
  }



}
