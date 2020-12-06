import { Preference } from './preference.model';
import { Skill} from './skill.model';

export class Developer {
    id: number;
    email: string;
    name: string;
    portfolio: string;
    hourlySalary: number;
    phone: string;
    linkedin: string;
    city: string;
    state: string;
    preference: Preference;
    skills: Skill;

    constructor() {
        this.id = 0;
        this.email = '';
        this.name = '';
        this.portfolio = '';
        this.hourlySalary = 0;
        this.phone = '';
        this.linkedin = '';
        this.city = '';
        this.state = '';
        this.preference = new Preference();
        this.skills = new Skill();
    }
}
