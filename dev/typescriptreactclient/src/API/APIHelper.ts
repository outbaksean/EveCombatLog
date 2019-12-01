import { Fitting } from "../Model/Fitting";
import { Config } from "../Config";

export async function GetFitting(): Promise<Fitting[]>  {
    let config: Config = new Config();
    let url: string = config.GetFittingsURL;
    
    //TODO: Lots of error handling
    const response = await fetch(url);
    return await response.json();
}

export function AddFitting(fitting: Fitting): void {
    //TODO:
}

export function UpdateFitting(fitting: Fitting): void {
    //TODO:
}