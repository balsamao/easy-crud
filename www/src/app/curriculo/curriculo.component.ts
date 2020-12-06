import { Component, OnDestroy, OnInit } from '@angular/core';
import { NavegacaoService } from './services/navegacao.service';

@Component({
  selector: 'app-curriculo',
  templateUrl: './curriculo.component.html',
  styleUrls: ['./curriculo.component.css']
})
export class CurriculoComponent implements OnInit, OnDestroy {

  constructor(public navegacaoService: NavegacaoService) { }

  ngOnInit(): void {
  }

  ngOnDestroy(): void {
    this.navegacaoService.form.reset();
  }

  public exibirBotaoAvancar(): boolean {
    return this.navegacaoService.titulo !== 'E aí, o que você manja?! =P';
  }


  public exibirBotaoSalvar(): boolean {
    return this.navegacaoService.titulo === 'E aí, o que você manja?! =P' &&
      (this.navegacaoService.form.get('id').value === 0 || this.navegacaoService.form.get('id').value == null);
  }


  public exibirBotaoEditar(): boolean {
    return this.navegacaoService.titulo === 'E aí, o que você manja?! =P' &&
      this.navegacaoService.form.get('id').value > 0;
  }

}
