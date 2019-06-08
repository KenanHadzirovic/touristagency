import { Privilege } from './privilege';

export class Role {
    roleId: number;
    roleName: string;
    privileges?: Privilege[] = [];

    
}