import "./App.css";

const products = [
  {name: "blue navie", price: 100.00},
  {name: "yellow chicken", price: 200.00},
  {name: "the red whale", price: 300.00},
  {name: "beru shinji", price: 400.00}
];

function App() {
  return (
    <>
      <div>
        <h1>ModelnCo</h1>
        <ul>{products.map((item, index) => (
          <li key={index}>{item.name} - ${item.price.toFixed(2)}</li>
        ))}</ul>
      </div>
    </>
  );
}

export default App;
