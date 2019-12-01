import * as React from "react";
import * as FittingClass from "../Model/Fitting";
import * as APIHelper from "../API/APIHelper"

interface FittingProps { 
    fitting: FittingClass.Fitting,
     onClick: () => void
}

interface FittingsProps { fittings: FittingClass.Fitting[]; }

function Fitting(props: FittingProps) {
    return (
        <li>
            {props.fitting.name}
            <button onClick={props.onClick}>Expand</button>
        </li>
    );
}

export class FittingsList extends React.Component<FittingsProps, FittingsProps> {
    constructor(props: FittingsProps) {
        super(props);
       
        this.state = { fittings: [] }
        APIHelper.GetFitting().then((f) => {
            console.log("Component Constructor: " + f)
            this.setState({ fittings: f});
        })
    }

    fittingOnclick() {
        alert('you clicked a fitting');
    }

    renderFitting(fitting: FittingClass.Fitting) {
        return <Fitting
            fitting = {fitting}
            onClick = {this.fittingOnclick}
        />
    }

    render() {
        return (
            <div>
                <ul>
                    {this.state.fittings.map((value) =>
                        { return this.renderFitting(value) })
                    }
                </ul>
            </div>
        );
    }
}