import { Button, SimpleGrid } from "@chakra-ui/react";
import { useEffect, useState } from "react";

export const Board: React.FC<{dimensions: {x: number, y: number}}> = ({dimensions}) => {
    const isValidBoard = dimensions.x > 0 && dimensions.y > 0;
    const [board, updateBoard] = useState([[false]]);

    useEffect(() => {
        updateBoard(Array.from({length: dimensions.x}, (_, i) => i).map(x => 
            Array.from({length: dimensions.y}, (_, i) => i).map(y => false)));
    }, [])

    if (!isValidBoard){
        return <>
            :(
        </>;
    }
        

    const getTileValue = (x:number, y:number): string => {
        return board.at(x)?.at(y) ? "x" : "-";
    }

    return <>
        <SimpleGrid columns={dimensions.y}>{
            Array.from({length: dimensions.x}, (_, i) => i).map(x => 
                Array.from({length: dimensions.y}, (_, i) => i).map(y => <>
                    <Button 
                        colorScheme='teal' 
                        variant='outline' 
                        key={`${x}-${y}`}
                        onClick={_ => {}}
                    >
                        <p>{ getTileValue(x,y) }</p>
                    </Button>
                </>)
            )
        }</SimpleGrid>
    </>;
}