import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SearchStorsComponent } from './search-stors.component';

describe('SearchStorsComponent', () => {
  let component: SearchStorsComponent;
  let fixture: ComponentFixture<SearchStorsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SearchStorsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SearchStorsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
