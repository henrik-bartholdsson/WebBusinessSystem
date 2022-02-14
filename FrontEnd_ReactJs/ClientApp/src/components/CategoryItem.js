import React from "react";
import './CategoryItem.css'

function CategoryItem(props) {
    return (
        <div className="CategoryItem row">
            <div className="VisualPadding block">
            </div>
            <div id="name" className="TextArea block">
                {props.name}
            </div>
            <div className="ExpandArea block">+

            </div>
        </div>
    );
}

export default CategoryItem;