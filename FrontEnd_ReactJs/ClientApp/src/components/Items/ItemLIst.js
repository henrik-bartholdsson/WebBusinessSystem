import React, {useState} from "react";
import Item from './Item'

function ItemList(props){
    const [items, setItems] = useState()

    console.log(props.match.params.category)
    return(
        <div>
            Item list
        </div>
    )
}

export default ItemList;

// Get items by fetch