import { BoardDifficulty } from "./board-difficulty";
import { Hint, Tile } from "./tile";
import { buildMines } from "./mine";
import { getAllPossibleCordinates } from "./coordinate";

export type Board = Tile[];

export const buildBoard = (dimensions: [number, number], difficulty: BoardDifficulty): Board => {
    const mines = buildMines(dimensions, difficulty);
    
    const hints: Hint[] = [];
    const allCordinates = getAllPossibleCordinates(dimensions);
    allCordinates.forEach(cordinate => {
        if (mines.find(mine => mine.position[0] == cordinate[0] && mine.position[1] == cordinate[1])){
            return;
        }
        hints.push({ position: cordinate, numberOfAdjacentMines: -1, type: "hint" })
    });

    const board = [...mines, ...hints];
    console.log(board);

    return board;
}