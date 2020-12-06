import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-alerta-erro',
  templateUrl: './alerta-erro.component.html',
  styleUrls: ['./alerta-erro.component.css']
})
export class AlertaErroComponent implements OnInit {

  @Input() podeExibir = false;
  @Input() mensagem = 'Erro ao executar operação.';

  constructor() {
  }

  ngOnInit(): void {
  }

}
