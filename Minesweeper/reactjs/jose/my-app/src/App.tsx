import React, { useEffect, useState } from "react";
import logo from "./logo.svg";
import "./App.css";

function App() {
  const [nrOfRows, setNrOfRows] = useState<number>(1);
  const [nrOfCols, setNrOfCols] = useState<number>(1);
  const [nrOfMines, setNrOfMines] = useState<number>(5);
  const [mineGrid, setMineGrid] = useState<Array<Array<boolean>>>([[]]);

  // Use a cell class that holds more information
  // It might be useful to pre initialize the neighbours
  // We should make it so that the initial click doesn't fall on a mine
  // In the calculation of the numbers, we can exclude the ones that do not have a mine

  useEffect(() => {
    defineMineGrid();
  }, [nrOfRows, nrOfCols]);

  const defineMineGrid = () => {
    let newGrid: Array<Array<boolean>> = [[]];
    for (let currentRow = 0; currentRow < nrOfRows; currentRow++) {
      let row: boolean[] = [];
      for (let currentCol = 0; currentCol < nrOfCols; currentCol++) {
        let ismine = DecideIfMine();
        row.push(ismine);
      }
      newGrid.push(row);
    }
    setMineGrid(newGrid);
  };

    const defineNumberGrid = () => {
      let newGrid: Array<Array<boolean>> = [[]];
      for (let currentRow = 0; currentRow < nrOfRows; currentRow++) {
        let row: boolean[] = [];
        for (let currentCol = 0; currentCol < nrOfCols; currentCol++) {
          let randomnumber1 = Math.random();
          let randomnumber2 = Math.random() - 0.2;
          let ismine = randomnumber1 < randomnumber2;
          row.push(ismine);
        }
        newGrid.push(row);
        console.log(newGrid);
      }
      setMineGrid(newGrid);
    };

  return (
    <div className="App">
      <header className="App-header">
        <label>
          Number of rows
          <input
            type="number"
            value={nrOfRows}
            max={50}
            min={1}
            onChange={(e) => {
              setNrOfRows(e.target.valueAsNumber);
            }}
          />
        </label>
        <label>
          Number of columns
          <input
            type="number"
            value={nrOfCols}
            max={50}
            min={1}
            onChange={(e) => {
              setNrOfCols(e.target.valueAsNumber);
            }}
          />
        </label>
        <p>
          Here we will show a {nrOfRows}x{nrOfCols} table, I guess.
        </p>
        <div>
          {mineGrid.map((row) => {
            return (
              <>
                {row.map((cell) => (
                  <button style={{ backgroundColor: "#74dade" }}>
                    {" "}
                    {cell ? 1 : 0}{" "}
                  </button>
                ))}
                <br />
              </>
            );
          })}
        </div>
        <img src={logo} className="App-logo" alt="logo" />
      </header>
    </div>
  );

  function DecideIfMine() {
    let ismine = false;
    if (nrOfMines > 0) {
      let randomnumber1 = Math.random();
      let randomnumber2 = Math.random() - 0.2;
      ismine = randomnumber1 < randomnumber2;
      if (ismine)
        setNrOfMines(nrOfMines - 1);
    }
    return ismine;
  }
}

export default App;
