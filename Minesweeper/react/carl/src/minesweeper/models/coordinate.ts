export type Coordinate = [number, number];

export const getAllPossibleCordinates = (dimensions: [number, number]): Coordinate[] => {
    const allCordinates: Coordinate[] = [];
    for (let x = 0; x < dimensions[0]; x++) {
        for (let y = 0; y < dimensions[1]; y++) {
            allCordinates.push([x, y]);       
        }
    }
    return allCordinates;
}