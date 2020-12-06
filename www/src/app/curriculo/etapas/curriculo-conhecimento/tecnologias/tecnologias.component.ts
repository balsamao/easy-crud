import { Component, Input, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'app-tecnologias',
  templateUrl: './tecnologias.component.html',
  styleUrls: ['./tecnologias.component.css']
})
export class TecnologiasComponent implements OnInit {

  @Input() form: FormGroup;
  @Input() tecnologia: string;

  LEVEL_ZERO = 0;
  LEVEL_UM = 1;
  LEVEL_DOIS = 2;
  LEVEL_TRES = 3;
  LEVEL_QUATRO = 4;
  LEVEL_CINCO = 5;

  constructor() {
  }

  ngOnInit(): void {
  }

}
