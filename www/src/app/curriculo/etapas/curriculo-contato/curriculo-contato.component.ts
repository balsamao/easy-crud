import { Component, OnDestroy, OnInit } from '@angular/core';
import { AbstractControl, Validators } from '@angular/forms';
import { NavegacaoService } from '../../services/navegacao.service';

@Component({
  selector: 'app-curriculo-contato',
  templateUrl: './curriculo-contato.component.html',
  styleUrls: ['./curriculo-contato.component.css']
})
export class CurriculoContatoComponent implements OnInit {

  constructor(public navegacaoService: NavegacaoService) {
    this.navegacaoService.titulo = 'Como podemos entrar em contato?! :)';
    this.phone.setValidators([Validators.required]);
    this.state.setValidators([Validators.required]);
    this.city.setValidators([Validators.required]);
  }

  ngOnInit(): void {
  }

  get linkedin(): AbstractControl { return this.navegacaoService.form.get('linkedin'); }
  get phone(): AbstractControl { return this.navegacaoService.form.get('phone'); }
  get state(): AbstractControl { return this.navegacaoService.form.get('state'); }
  get city(): AbstractControl { return this.navegacaoService.form.get('city'); }
}
