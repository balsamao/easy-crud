import { Component, OnInit } from '@angular/core';
import { Validators } from '@angular/forms';
import { Knowledge } from '../../models/knowledge.model';
import { NavegacaoService } from '../../services/navegacao.service';

@Component({
  selector: 'app-curriculo-conhecimento',
  templateUrl: './curriculo-conhecimento.component.html',
  styleUrls: ['./curriculo-conhecimento.component.css']
})
export class CurriculoConhecimentoComponent implements OnInit {

  tecnologias: string[];

  constructor(public navegacaoService: NavegacaoService) {
    this.tecnologias = Object.getOwnPropertyNames(new Knowledge());
    this.tecnologias.forEach(tecnologia => {
      this.navegacaoService.form.get('skills').get(tecnologia).setValidators([Validators.required]);
    });
    this.navegacaoService.titulo = 'E aí, o que você manja?! =P';
    window.scrollTo(0, 0);
  }

  ngOnInit(): void {
  }

}
