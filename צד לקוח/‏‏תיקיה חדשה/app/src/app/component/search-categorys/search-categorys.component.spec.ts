import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SearchCategorysComponent } from './search-categorys.component';

describe('SearchCategorysComponent', () => {
  let component: SearchCategorysComponent;
  let fixture: ComponentFixture<SearchCategorysComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SearchCategorysComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SearchCategorysComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
