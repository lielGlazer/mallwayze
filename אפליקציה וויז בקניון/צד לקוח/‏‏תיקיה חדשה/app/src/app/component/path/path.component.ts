import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { StoreWithLocation } from 'src/app/models/StoreWithLocation';
import { DbService } from 'src/app/serves/db.service';


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
  shortestPath: StoreWithLocation[];

  constructor(private router: Router, private dbService: DbService) {
    const x = this.router.getCurrentNavigation();
    //console.log(x?.extras.state?.list); // should log out 'bar'
    this.shortestPath = dbService.currentPath;
  
    console.log(this.shortestPath);
  }

  calcPointXToCanvas(x: number) {
      console.log(x , "=>" , (x * 433 / 18));
  return (x * 433 / 18);
    
  }

  calcPointYToCanvas(y: number) {
    console.log(y , "=>" , 897 - (y * 897 / 41));

    return 897 - (y * 897 / 41);
  }

  ngOnInit(): void {

    this.ctx = this.canvas.nativeElement.getContext('2d');
    
    this.drawPath();
  }
  routing(nav: string) {
    let fullpath = 'route-selection/' + nav
    this.router.navigate([fullpath])
  }

  drawStores(): void {
    this.ctx.drawImage(this.img, 0, 0);
  }
  drawPath(): void {
    this.ctx.beginPath();
    this.ctx.moveTo(this.calcPointXToCanvas(this.shortestPath[0].xPoint!), this.calcPointYToCanvas(this.shortestPath[0].yPoint!));
    for (let i = 1; i < this.shortestPath.length; i++) {
      const point = this.shortestPath[i];
      this.ctx.lineTo(this.calcPointXToCanvas(point.xPoint!), this.calcPointYToCanvas(point.yPoint!))
    console.log(this.calcPointXToCanvas(point.xPoint!), this.calcPointYToCanvas(point.yPoint!));
    }
    this.ctx.strokeStyle = 'green';
    this.ctx.storkeWidth = 10;
    this.ctx.stroke();
  }
}
