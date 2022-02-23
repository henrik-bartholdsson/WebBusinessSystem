import React, {useState, useEffect} from "react";
import Item from './Item'

function ItemList(props){
    const [items, setItems] = useState()

    useEffect(() => {
        FetchItemsFromCategory();
      }, [props.match.params.category]);

    const FetchItemsFromCategory = async () =>
    {
        console.log(props.match.params.category)
        const response = await fetch('/api/items?guid=' + props.match.params.category,
        {
            method: 'GET'
        }).then(x => x.json())
        .then(x => setItems(x))

    }

    return(
        <div>
            Item list
            {
                items ? (items.map(x => 
                    {
                    return(<Item object={x} />)
                    }))
                 : (<div>Empty</div>)
            }
        </div>
    )



}

export default ItemList;

// Get items by fetch