export class Preference {
    id: number;
    developerId: number;
    upToFourHoursPerDay: boolean;
    fourToSixHoursPerDay: boolean;
    sixtoEightHoursPerDay: boolean;
    upToEightHoursADay: boolean;
    onlyWeekends: boolean;
    morning: boolean;
    afternoon: boolean;
    night: boolean;
    dawn: boolean;
    business: boolean;

    constructor() {
        this.id = 0;
        this.developerId = 0;
        this.upToFourHoursPerDay = false;
        this.fourToSixHoursPerDay = false;
        this.sixtoEightHoursPerDay = false;
        this.upToEightHoursADay = false;
        this.onlyWeekends = false;
        this.morning = false;
        this.afternoon = false;
        this.night = false;
        this.dawn = false;
        this.business = false;
    }
}