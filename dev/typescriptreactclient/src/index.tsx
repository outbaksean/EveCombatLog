import * as React from "react";
import * as ReactDOM from "react-dom";

// import { Hello } from "./components/Hello";
import { FittingsList } from "./components/FittingList";
import { Fitting } from "./Model/Fitting";
import { CombatLogEntry } from "./Model/CombatLogEntry";

let c1:CombatLogEntry = new CombatLogEntry("C1");
let c2:CombatLogEntry = new CombatLogEntry("C2");
let f1:Fitting = new Fitting("F1");
f1.CombatLogEntries = [c1, c2];

let c3:CombatLogEntry = new CombatLogEntry("C5");
let c4:CombatLogEntry = new CombatLogEntry("C4");
let f2:Fitting = new Fitting("F2");
f2.CombatLogEntries = [c3, c4];

let fittings:Fitting[] = [f1,f2];

ReactDOM.render(
    // <Hello 
    //     compiler="TypeScript"
    //     framework="React"
    // />,
    <FittingsList 
        fittings = {fittings}
    />,
    document.getElementById("example")
)