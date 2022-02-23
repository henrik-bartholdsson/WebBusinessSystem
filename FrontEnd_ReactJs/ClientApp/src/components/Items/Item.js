import React from "react";

function Item(props){
console.log(props)
    return(
        <div>
            <h5>{props.object.name}</h5>
            <p>Vendor {props.object.name2}</p>
            <p>id: {props.object.id}</p>
        </div>
    )
}

export default Item