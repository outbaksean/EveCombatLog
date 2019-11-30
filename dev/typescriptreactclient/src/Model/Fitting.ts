import { CombatLogEntry } from "./CombatLogEntry";


export class Fitting {
    name: string;
    CombatLogEntries: CombatLogEntry[];
    constructor(name: string) {
        this.name = name;
    }
}