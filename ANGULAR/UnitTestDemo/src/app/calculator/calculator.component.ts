import { Component, OnInit } from '@angular/core';
import { CalculatorService } from "../services/calculator.service";

@Component({
  selector: 'app-calculator',
  templateUrl: './calculator.component.html',
  styleUrls: ['./calculator.component.less']
})
export class CalculatorComponent implements OnInit {

  public result: number;

  public num1: number;
  public num2: number;

  constructor(private calculatorService: CalculatorService) { }

  ngOnInit(): void {
  }

  add() {
    this.result = this.calculatorService.Add(this.num1,this.num2);
  }




}
