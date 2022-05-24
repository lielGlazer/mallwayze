import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RouteCategoryComponent } from './route-category.component';

describe('RouteCategoryComponent', () => {
  let component: RouteCategoryComponent;
  let fixture: ComponentFixture<RouteCategoryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RouteCategoryComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RouteCategoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
