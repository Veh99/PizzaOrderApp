import React from 'react'

export const PizzaCard = ({name, description, price}) => {
    return(
        <div className='card' 
    style={{
        display: "flex",
        flexDirection: "row",
        alignItems: "center",
        justifyContent: "space-between",
    }}>
        <h2>{name}</h2>
        <p>{description}</p>
        <p>{price}</p>
    </div>
    )
}
    

