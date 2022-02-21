import React, { useState, useEffect } from "react";
import CategoryItem from './CategoryItem'

function CategoryMenu() {
    const [menu, setMenu] = useState(null);

    useEffect(() => {
        fetchMenu();
      }, []);

    const fetchMenu = async () =>
    {
        const response = await fetch('/api/home',
        {
            method: 'GET',
            headers: {
                'Content-Type': 'application/json'
              }
        }).then(x => x.json())

        setMenu(response)
        
        return response;
    }

    return (
        <div>
            {
               menu ? (<div>
                   {
                       menu.map(m => 
                        <CategoryItem menuItem={m} key={m.id}/>
                        )
                   }
               </div>):(<div>Loading...</div>) 
            }
        </div>
    );


}


export default CategoryMenu