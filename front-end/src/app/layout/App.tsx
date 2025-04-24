import { useEffect, useState } from "react";
import "./index.css";
import { ProductProps } from "../models/Product";
import Catalog from "../../features/catalog/Catalog";



function App() {
  const url = "http://localhost:5249";

  const [products, setProducts] = useState<ProductProps[]>([]);

  useEffect(() => {
    fetch(`${url}/api/products`)
      .then((response) => response.json())
      .then((data) => {
        console.log(data);
        setProducts(data);
      });
  }, []);

  const addProduct = () => {
    setProducts(prevState => [...prevState,
      {
        id: 1,
        name: "product",
        price: 0,
        description: "Default description",
        category: "Default category",
        dimension: "Default dimension",
        qtyInStock: 0,
        brand: "Default brand",
        weight: 0,
        pictureUrl: "Default picture URL"
      }
    ])
  }

  return (
    <>
      <div>
        <Catalog products={products} addProduct={addProduct}/>
        <ul>
          {products.map((item, index) => (
            <div key={index}>
              <li> {item.name} {item.price}</li>
            </div>
          ))}
        </ul>
      </div>
    </>
  );
}

export default App;
