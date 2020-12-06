import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { ReactiveFormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { HomeComponent } from './home/home.component';
import { RouterModule } from '@angular/router';
import { ROUTES } from './app.routes';
import { CurriculoComponent } from './curriculo/curriculo.component';
import { CurriculoApresentacaoComponent } from './curriculo/etapas/curriculo-apresentacao/curriculo-apresentacao.component';
import { CurriculoContatoComponent } from './curriculo/etapas/curriculo-contato/curriculo-contato.component';
import { CurriculoPreferenciasComponent } from './curriculo/etapas/curriculo-preferencias/curriculo-preferencias.component';
import { CurriculoConhecimentoComponent } from './curriculo/etapas/curriculo-conhecimento/curriculo-conhecimento.component';

import {CurriculoService} from './curriculo/services/curriculo.service';
import {NavegacaoService} from './curriculo/services/navegacao.service';

import { CURRICULO_ROUTES } from './curriculo/curriculo.routes';
import { NgxMaskModule } from 'ngx-mask';
import { NgxCurrencyModule } from 'ngx-currency';
import { MASK_CONFIG, MASK_CONFIG_MONEY } from './app.mask';
import { TecnologiasComponent } from './curriculo/etapas/curriculo-conhecimento/tecnologias/tecnologias.component';
import { CandidatoComponent } from './candidato/candidato.component';
import { ListagemCadidatoComponent } from './candidato/listagem-cadidato/listagem-cadidato.component';
import { AlertaErroComponent } from './compartilhado/componentes/alertas/alerta-erro/alerta-erro.component';
import { AlertaSucessoComponent } from './compartilhado/componentes/alertas/alerta-sucesso/alerta-sucesso.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    HomeComponent,
    CurriculoComponent,
    CurriculoApresentacaoComponent,
    CurriculoContatoComponent,
    CurriculoPreferenciasComponent,
    CurriculoConhecimentoComponent,
    TecnologiasComponent,
    CandidatoComponent,
    ListagemCadidatoComponent,
    AlertaErroComponent,
    AlertaSucessoComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    RouterModule.forRoot(ROUTES),
    RouterModule.forChild(CURRICULO_ROUTES),
    ReactiveFormsModule,
    NgxMaskModule.forRoot(MASK_CONFIG),
    NgxCurrencyModule.forRoot(MASK_CONFIG_MONEY)
  ],
  providers: [CurriculoService, NavegacaoService],
  bootstrap: [AppComponent]
})
export class AppModule { }
