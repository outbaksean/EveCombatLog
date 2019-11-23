import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';

function Fitting(props) {
    return (
        <li>
            {props.fittingName}
        </li>
    );
}

class Fittings extends React.Component {
    renderFitting(fittingName) {
        return <Fitting
            fittingName = {fittingName}
        />
    }

    render() {
        return (
            <div>
                <ul>
                    {this.renderFitting('first')}
                    {this.renderFitting('second')}
                </ul>
            </div>
        );
    }
}

// ========================================

ReactDOM.render(
    <Fittings />,
    document.getElementById('root')
);
