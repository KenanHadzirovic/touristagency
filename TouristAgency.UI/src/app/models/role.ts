import { Privilege } from './privilege';

export class Role {
    name: string;
    privileges?: Privilege[] = [];
}