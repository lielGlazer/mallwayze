import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OneStoreComponent } from './one-store.component';

describe('OneStoreComponent', () => {
  let component: OneStoreComponent;
  let fixture: ComponentFixture<OneStoreComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ OneStoreComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(OneStoreComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
