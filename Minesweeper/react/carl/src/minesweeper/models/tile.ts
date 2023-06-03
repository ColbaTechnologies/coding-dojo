import { Coordinate } from "./coordinate";
import { Mine } from "./mine";

export type Tile = Mine | Hint; // TODO - add neightbours

export type Hint = {
    type: "hint"
    position: Coordinate;
    numberOfAdjacentMines: number;
}