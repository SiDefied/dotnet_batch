import React from 'react';

class Table extends React.Component
{
    constructor(props)
    {
        super(props);
        this.state = {Vendor : "IKEA",model :"Dining Plus-300",material : "Compact Wood"};
    }

    render()
    {
        return(   
            <div>
                <h1>My table is from {this.state.Vendor} and model {this.state.model}</h1>
            </div>
        );
    }
}

export default Table