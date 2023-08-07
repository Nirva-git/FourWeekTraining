import { TestBed } from '@angular/core/testing';

import { BolgserviceService } from './bolgservice.service';

describe('BolgserviceService', () => {
  let service: BolgserviceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(BolgserviceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
