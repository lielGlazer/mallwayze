import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RouteOneStorComponent } from './route-one-stor.component';

describe('RouteOneStorComponent', () => {
  let component: RouteOneStorComponent;
  let fixture: ComponentFixture<RouteOneStorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RouteOneStorComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RouteOneStorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
