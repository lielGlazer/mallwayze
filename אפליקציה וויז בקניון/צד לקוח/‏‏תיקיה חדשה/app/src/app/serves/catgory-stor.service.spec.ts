import { TestBed } from '@angular/core/testing';

import { CatgoryStorService } from './catgory-stor.service';

describe('CatgoryStorService', () => {
  let service: CatgoryStorService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CatgoryStorService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
