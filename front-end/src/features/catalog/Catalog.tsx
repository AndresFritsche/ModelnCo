import { ProductProps } from "../../app/models/Product"

type Props = {
  products: ProductProps[],
  addProduct: () => void
}


export default function Catalog({products, addProduct}: Props) {
  return (
    <>
      <ul>
          {products.map((item) => (
            <li key={item.id}>{item.name} - {item.price}</li>
          ))}
        </ul>
        <button onClick={addProduct}>add product</button>
    </>
  )
}