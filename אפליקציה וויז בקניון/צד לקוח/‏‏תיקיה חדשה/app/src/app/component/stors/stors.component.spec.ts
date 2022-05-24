import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StorsComponent } from './stors.component';

describe('StorsComponent', () => {
  let component: StorsComponent;
  let fixture: ComponentFixture<StorsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ StorsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(StorsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
