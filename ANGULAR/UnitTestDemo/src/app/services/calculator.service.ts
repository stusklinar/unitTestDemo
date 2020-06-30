import { Injectable } from '@angular/core';
import {CalculatorOperation } from '../enums/CalculatorOperationEnum'

@Injectable({
  providedIn: 'root'
})
export class CalculatorService {

  constructor() { }

  Add(num1: number, num2: number): Number {
    return num1 + num2;
  }

  Operation(num1: number, num2: number, calculatorOperation: CalculatorOperation) {

    //Add if for num1/2

    switch (calculatorOperation) {
      case CalculatorOperation.Add:
        return this.Add(num1, num2);
      case CalculatorOperation.Subtract:
        return num1 - num2;
      case CalculatorOperation.Divide:
        return this.Add(num1, num2); // I know these are wrong.
      case CalculatorOperation.Multiply:
        return this.Add(num1, num2);
      case CalculatorOperation.Modulus:
        return this.Add(num1, num2);
      default:
        return 0;
    }
  }

}
