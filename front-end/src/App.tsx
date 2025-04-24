import { useEffect, useState } from "react";
import "./App.css";


function App() {
  const url = "http://localhost:5249"

 const [products, setProducts] = useState<{name:string, price:number}[]>([])

 useEffect(() =>{
  fetch(`${url}/api/products`)
  .then(response => response.json())
  .then(data => setProducts(data))
 }, [])

const addProducts = () => {

  setProducts(prevState => [...prevState, {name:"product"  + (prevState.length + 1), price:(prevState.length * 100) + 100}])
}


  return (
    <>
      <div>
        <h1>ModelnCo</h1>
        <ul>{products.map((item, index) => (
          <li key={index}>{item.name} - ${item.price.toFixed(2)}</li>
        ))}</ul>
        <div>

        </div>
        <button onClick={addProducts}>add product </button>
      </div>
    </>
  );
}

export default App;
