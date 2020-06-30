import { TestBed } from '@angular/core/testing';

import { CalculatorService } from './calculator.service';
import { CalculatorOperation } from '../enums/CalculatorOperationEnum';

describe('CalculatorService', () => {
  let service: CalculatorService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CalculatorService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });


  it('should add 1 and 1 to get 2', () => {
    var result = service.Add(1,1);
    expect(result).toBe(2);
  });

  it('should subtract 1 and 1 to get 0', () => {
    var result = service.Operation(1,1,CalculatorOperation.Subtract);
    expect(result).toBe(0);
  });

  // it('should 1 and 10 to get 10', () => {
  //   var result = service.Operation(1,1,CalculatorOperation.Multiply);
  //   expect(result).toBe(10);
  // });
});
