import { BoardDifficulty } from "./board-difficulty";
import { Coordinate, getAllPossibleCordinates } from "./coordinate";
import { match } from 'ts-pattern';

export type Mine = {
    type: "mine"
    position: Coordinate;
};

const getNumberOfMines = (numberOfTiles: number, difficulty: BoardDifficulty) => match(difficulty)
    .with(BoardDifficulty.EASY,   () => Math.round(numberOfTiles / 4))
    .with(BoardDifficulty.MEDIUM, () => Math.round(numberOfTiles / 2))
    .with(BoardDifficulty.HARD,   () => Math.round(numberOfTiles * (3/4)))
    .otherwise(() => 0);

export const buildMines = (dimensions: [number, number], difficulty: BoardDifficulty): Mine[] => {
    const allCordinates = getAllPossibleCordinates(dimensions);
    const numberOfMines = getNumberOfMines(dimensions[0] * dimensions[1], difficulty);
    const mines: Mine[] = [];
    for (let index = 0; index < numberOfMines; index++) {
        // pop a randon cordinate and add it to the mines array
        const randomCoordinate = allCordinates.splice(allCordinates.length * Math.random() | 0, 1)[0];
        mines.push({position: randomCoordinate, type: "mine"});
    }
    return mines;
}