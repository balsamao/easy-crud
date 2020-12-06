import { Component, Input, OnInit } from '@angular/core';
import { Developer } from 'src/app/curriculo/models/developer.model';

@Component({
  selector: 'app-listagem-cadidato',
  templateUrl: './listagem-cadidato.component.html',
  styleUrls: ['./listagem-cadidato.component.css']
})
export class ListagemCadidatoComponent implements OnInit {

  @Input() developers: Developer[];
  constructor() { }

  ngOnInit(): void {
  }

}
