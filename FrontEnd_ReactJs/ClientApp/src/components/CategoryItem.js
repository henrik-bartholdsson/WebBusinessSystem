import React, {useState, useCallback, useEffect} from 'react';
import './CategoryItem.css'
import SubCategoryItem from './CategoryItem'

function CategoryItem(props) {
    const [expanded, setExpanded] = useState();
    const [mark, setMark] = useState(!props.menuItem.topLevel);
    const clickHandler = useCallback(() => setExpanded(!expanded), [expanded]);

    useEffect(() =>{
        console.log('Update. ' + props.menuItem.name)

        if(!props.menuItem.topLevel)
        setMark(!expanded)
    },[expanded])

    //setShow(props.menuItem.topLevel)

    // Top level item = always show.
    // Lowest level has no sub menu items

    //console.log(props.menuItem.name + ' - ' + expanded)
    console.log(props.menuItem.subCategories)
    return (
        <div className={!expanded ?? !props.menuItem.topLevel ? 'collapsed' : 'expanded'}>
            <div className='CategoryItem row'
                id={props.menuItem.id}>
                    <div>
                <div className={mark ? 'VisualPadding block' : ''}>
                </div>
                </div>
                <div id='name' className='TextArea block'>
                    {props.menuItem.name}
                </div>
                <div className={props.menuItem.subCategories ?
                    'ExpandArea block' : 'HideExpandArea'}
                    onClick={clickHandler}> {expanded ? ('-') : ('+')}
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