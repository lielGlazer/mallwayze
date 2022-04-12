import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RouteStorComponent } from './route-stor.component';

describe('RouteStorComponent', () => {
  let component: RouteStorComponent;
  let fixture: ComponentFixture<RouteStorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RouteStorComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RouteStorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
