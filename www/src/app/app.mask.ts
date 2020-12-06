import { IConfig } from 'ngx-mask';
import { CurrencyMaskInputMode } from 'ngx-currency';

export const MASK_CONFIG: Partial<IConfig> = {
    validation: false,
};

export const MASK_CONFIG_MONEY = {
    align: 'right',
    allowNegative: true,
    allowZero: true,
    decimal: ',',
    precision: 2,
    prefix: 'R$ ',
    suffix: '',
    thousands: '.',
    nullable: true,
    min: null,
    max: null,
    inputMode: CurrencyMaskInputMode.FINANCIAL
};