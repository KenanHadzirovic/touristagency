import { FeatureType } from "./feature-type";

export class Feature {
    id: number;
    name: string;
    description: string;
    datetime: Date;
    price: number;
    type?: FeatureType;
}