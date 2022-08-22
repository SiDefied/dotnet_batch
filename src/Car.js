import React from 'react';

class Car extends React.Component
{
    constructor(props)
    {
        super(props);
        // this.state = {brand:"Ford"};                 In this case only the last defined state will be accepted
        // this.state = {make:"Ford"};
        // this.state = {carbrandname : "Ford"};
        // this.state = {carname : "Endeavor"};
        // this.state = {model : "Ford"};
        // this.state = {brand : "Tata"};
        // this.state = {carname : "Endeavor"};

        this.state = {brand:"Ford" 
         ,make:"Ford"
         ,carbrandname : "Ford"
         ,model : "Ford"
         ,brand : "Tata"
         ,carname : "Endeavor"}

    }

    render()
    {
        return(
            <div>
                <h1>My Car {this.state.brand} and model is {this.state.model}</h1>
            </div>
        );
    }
}

export default Car 