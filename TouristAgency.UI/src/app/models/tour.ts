import { Hotel } from './hotel';

export class Tour {
    id: number;
    name: string;
    location: string;
    previewImage?: string;
    description: string;
    dateFrom?: Date;
    dateTo?: Date;
    hotel?: Hotel;
    pricePerDay?: number;
    price?: number;
    tourType?: string;
}
