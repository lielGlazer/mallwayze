import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RouteSmartComponent } from './route-smart.component';

describe('RouteSmartComponent', () => {
  let component: RouteSmartComponent;
  let fixture: ComponentFixture<RouteSmartComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RouteSmartComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RouteSmartComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
