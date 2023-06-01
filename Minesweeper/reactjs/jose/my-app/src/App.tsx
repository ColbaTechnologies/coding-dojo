import React, { useState } from "react";
import logo from "./logo.svg";
import "./App.css";

function App() {
  const [nrOfRows, setNrOfRows] = useState<number>(1);
  const [nrOfCols, setNrOfCols] = useState<number>(1);

  return (
    <div className="App">
      <header className="App-header">
        <label>
          Number of rows
          <input
            type="number"
            value={nrOfRows}
            onChange={(e) => setNrOfRows(e.target.valueAsNumber)}
          />
        </label>
        <label>
          Number of columns
          <input
            type="number"
            value={nrOfCols}
            onChange={(e) => setNrOfCols(e.target.valueAsNumber)}
          />
        </label>
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Here we will show a {nrOfRows}x{nrOfCols} table, I guess.
        </p>
        <table></table>
      </header>
    </div>
  );
}

export default App;
