import React, {useState, useCallback, useEffect} from 'react';
import { useHistory } from "react-router-dom";
import './CategoryItem.css'
import SubCategoryItem from './CategoryItem'

function CategoryItem(props) {
    const [expanded, setExpanded] = useState();
    const [componentId, setComponentId] = useState(props.menuItem.id)
    const [mark, setMark] = useState(!props.menuItem.topLevel);
    const expandHandler = useCallback(() => setExpanded(!expanded), [expanded]);
    
    const history = useHistory();
  
    const routeChange = () =>{ 
      let path = `/items/` + componentId; 
      history.push(path);
    }

    useEffect(() =>{

        if(!props.menuItem.topLevel)
        setMark(!expanded)
    },[expanded])
    
    return (
        <div className={!expanded ?? !props.menuItem.topLevel ? 'collapsed' : 'expanded'}>
            <div className='CategoryItem row'
                id={props.menuItem.id}>
                    <div>
                <div className={mark ? 'VisualPadding block' : ''}>
                </div>
                </div>
                <div id='name' className='TextArea block' onClick={routeChange}>
                    {props.menuItem.name}
                </div>
                <div className={props.menuItem.subCategories ?
                    'ExpandArea block' : 'HideExpandArea'}
                    onClick={expandHandler}> {expanded ? ('-') : ('+')}
                </div>
            </div>
            {
                props.menuItem.subCategories ? 
                (<div className='submenu'>
                    {
                        props.menuItem.subCategories.map(m => {
                            return <SubCategoryItem menuItem={m} key={m.id} />
                        })
                    }
                </div>)
                 : 
                 (<div/>)
                    
                
            }
        </div>
    );

    
}

export default CategoryItem;