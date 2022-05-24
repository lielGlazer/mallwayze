import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StorDataComponent } from './stor-data.component';

describe('StorDataComponent', () => {
  let component: StorDataComponent;
  let fixture: ComponentFixture<StorDataComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ StorDataComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(StorDataComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
