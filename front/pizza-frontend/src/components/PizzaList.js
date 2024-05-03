import React, { useEffect, useState } from 'react'
import { getAllPizzas } from '../services/pizzas'
import { PizzaCard } from './PizzaCard';


export default function PizzaList() {

  const [pizzas, setPizzas] =  useState([]);

  useEffect(() => {
    const getPizzas = async() => {
      const response = await getAllPizzas();
      setPizzas(response);
    }
    getPizzas();
  }, [])

  return (
    <div className='menu'>
      <h1>Menu</h1>
      {pizzas.map((pizza) => (
          <PizzaCard name={pizza.name} description={pizza.description} price={pizza.price}/>
        )
      )}
    </div>
  )
}
