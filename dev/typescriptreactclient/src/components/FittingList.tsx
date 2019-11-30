import * as React from "react";
import * as FittingClass from "../Model/Fitting";
import { checkPropTypes } from "prop-types";

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

export class FittingsList extends React.Component<FittingsProps> {
    constructor(props: FittingsProps) {
        super(props);
        // this.setState({ fittings: props.fittings })
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
                    {this.props.fittings.map((value) =>
                        { return this.renderFitting(value) })
                    }
                </ul>
            </div>
        );
    }
}