import { Injectable } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { Developer } from '../models/developer.model';
import { Preference } from '../models/preference.model';
import { Skill } from '../models/skill.model';
import { Knowledge } from '../models/knowledge.model';
import { CurriculoService } from './curriculo.service';

@Injectable()
export class NavegacaoService {

    private developer: Developer = new Developer();
    private tituloDaPagina = '';
    sucesso = false;
    mensagemErro = '';
    form: FormGroup;

    constructor(private router: Router, private fb: FormBuilder, private curriculoService: CurriculoService) {
        this.inicializarForm();
    }

    public voltar(): void {
        if (this.router.url === '/curriculo/conhecimento') {
            this.limparValidacoesDoForm(this.form);
            this.router.navigate([`curriculo/preferencias`]);
        } else if (this.router.url === '/curriculo/preferencias') {
            this.limparValidacoesDoForm(this.form);
            this.router.navigate([`curriculo/contato`]);
        } else if (this.router.url === '/curriculo/contato') {
            this.limparValidacoesDoForm(this.form);
            this.router.navigate([`curriculo/apresentacao`]);
        } else if (this.router.url === '/curriculo/apresentacao') {
            this.limparValidacoesDoForm(this.form);
            this.form.reset();
            this.router.navigate([`/`]);
        }
    }

    public proximo(): void {
        if (this.form.invalid) {
            return;
        } else if (this.router.url.trim().includes('/curriculo/apresentacao')) {
            this.router.navigate(['curriculo/contato']);
        } else if (this.router.url === '/curriculo/contato') {
            this.router.navigate(['curriculo/preferencias']);
        } else if (this.router.url === '/curriculo/preferencias') {
            this.router.navigate(['curriculo/conhecimento']);
        } else if (this.router.url === '/curriculo/conhecimento') {
            this.router.navigate(['curriculo/apresentacao']);
        }
    }

    public limparValidacoesDoForm(form: FormGroup): void {
        // tslint:disable-next-line: forin
        for (const key in form.controls) {
            form.get(key).clearValidators();
            form.get(key).updateValueAndValidity();
        }
    }

    private inicializarForm(): void {
        this.mensagemErro = '';
        this.sucesso = false;

        this.form = this.fb.group({
            id: [0, []],
            name: [this.developer?.name, []],
            email: [this.developer?.email, []],
            portfolio: [this.developer?.portfolio, []],
            hourlySalary: [this.developer?.hourlySalary, []],
            phone: [this.developer?.phone, []],
            linkedin: [this.developer?.linkedin, []],
            city: [this.developer?.city, []],
            state: [this.developer?.state, []],
            preference: this.fb.group({
                id: [0, []],
                developerId: [0, []],
                upToFourHoursPerDay: [false, []],
                fourToSixHoursPerDay: [false, []],
                sixtoEightHoursPerDay: [false, []],
                upToEightHoursADay: [false, []],
                onlyWeekends: [false, []],
                morning: [false, []],
                afternoon: [false, []],
                night: [false, []],
                dawn: [false, []],
                business: [false, []]
            }),
            skills: this.fb.group({
                id: [0, []],
                developerId: [0, []],
                aditionalInformation: [this.developer?.skills?.aditionalInformation, []],
                linkCrud: ['', []],
                ionic: [0, []],
                reactJS: [0, []],
                reactNative: [0, []],
                android: [0, []],
                flutter: [0, []],
                swift: [0, []],
                ios: [0, []],
                html: [0, []],
                css: [0, []],
                bootstrap: [0, []],
                jquery: [0, []],
                angularJs: [0, []],
                angular: [0, []],
                java: [0, []],
                python: [0, []],
                flask: [0, []],
                aspNetMVC: [0, []],
                aspNetWebForm: [0, []],
                c: [0, []],
                csharp: [0, []],
                nodeJS: [0, []],
                expressNodeJs: [0, []],
                cake: [0, []],
                django: [0, []],
                majento: [0, []],
                php: [0, []],
                vue: [0, []],
                wordpress: [0, []],
                ruby: [0, []],
                mySQLServer: [0, []],
                mySQL: [0, []],
                salesforce: [0, []],
                photoshop: [0, []],
                illustrator: [0, []],
                seo: [0, []],
                laravel: [0, []],
            })
        });
    }

    public salvar(): void {
        this.curriculoService.salvar(this.prepararEnvioDados())
            .subscribe(_ => this.respostaSucesso(), error => this.respostaComErro(error));
    }

    public editar(): void {
        this.curriculoService.editar(this.prepararEnvioDados())
            .subscribe(_ => this.respostaSucesso(), error => this.respostaComErro(error));
    }

    public listarPorId(id: number): void {
        this.curriculoService.listarPorId(id)
            .subscribe(retorno => {
                this.form.patchValue(this.prepararRecebimentoDados(retorno));
            });
    }

    private prepararEnvioDados(): Developer {
        let obj = this.entidade;

        obj = this.prepararDeveloper(obj);
        obj.skills = this.prepararSkills(obj.skills);
        obj.preference = this.prepararPreference(obj.preference);
        return obj;
    }

    private prepararDeveloper(obj: Developer): Developer {
        if (obj.id === null || obj.id === undefined) {
            obj.id = 0;
            obj.preference.id = 0;
            obj.skills.id = 0;
        }
        obj.preference.developerId = obj.id;
        obj.skills.developerId = obj.id;

        return obj;
    }

    private prepararSkills(obj: Skill): Skill {
        const tecnologias = Object.getOwnPropertyNames(new Knowledge());

        tecnologias.forEach(tecnologia => {
            if (obj[tecnologia] === null) { obj[tecnologia] = 0; }
            else { obj[tecnologia] = parseInt(obj[tecnologia], null); }
        });

        return obj;
    }

    private prepararPreference(obj: Preference): Preference {
        if (!obj.upToFourHoursPerDay) { obj.upToFourHoursPerDay = false; }
        if (!obj.fourToSixHoursPerDay) { obj.fourToSixHoursPerDay = false; }
        if (!obj.sixtoEightHoursPerDay) { obj.sixtoEightHoursPerDay = false; }
        if (!obj.upToEightHoursADay) { obj.upToEightHoursADay = false; }
        if (!obj.onlyWeekends) { obj.onlyWeekends = false; }
        if (!obj.morning) { obj.morning = false; }
        if (!obj.afternoon) { obj.afternoon = false; }
        if (!obj.night) { obj.night = false; }
        if (!obj.dawn) { obj.dawn = false; }
        if (!obj.business) { obj.business = false; }

        return obj;
    }

    private prepararRecebimentoDados(developer: Developer): Developer {
        const tecnologias = Object.getOwnPropertyNames(new Knowledge());

        tecnologias.forEach(tecnologia => {
            developer.skills[tecnologia] = developer.skills[tecnologia].toString();
        });
        return developer;
    }

    private respostaSucesso(): void {
        this.sucesso = true;
        this.mensagemErro = '';
        this.limparValidacoesDoForm(this.form);
        this.form.reset();
        this.inicializarForm();
        this.router.navigate([`candidatos/true`]);
    }

    private respostaComErro(error: any): void {
        this.mensagemErro = error;
        this.sucesso = false;
    }

    get titulo(): string {
        return this.tituloDaPagina;
    }
    set titulo(titulo: string) {
        this.tituloDaPagina = titulo;
    }

    get entidade(): Developer { return this.form.getRawValue() as Developer; }
}
