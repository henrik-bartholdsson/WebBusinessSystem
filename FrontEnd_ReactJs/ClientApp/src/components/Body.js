import React from "react";
//import { Container } from 'reactstrap';
import CategoryMenu from "./CategoryMenu";
import Home from './Home'

function Body()
{
    return(
      <div className='container justify-content-center d-flex h-100'>
        <div className="row align-self-center w-100 h-100 border">
          
            <div className="col-2">
              <CategoryMenu/>
            </div>

            <div className="col-8">
              <Home/>
            </div>  

        </div>
      </div>
    )
}

export default Body;