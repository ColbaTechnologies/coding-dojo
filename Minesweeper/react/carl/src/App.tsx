import { useState } from 'react';
import { Box, Input, SimpleGrid, VStack } from '@chakra-ui/react';
import { Board } from './minesweeper/Board';

export const App = () => {
	const [{x, y}, setDimensions] = useState<{x: number, y: number}>({x: 5, y: 5});

	return (
		<>
			<VStack>
				<Box>
					<h1>mineswepper 💣</h1>
				</Box>
				<Box>
					<SimpleGrid columns={2} margin={"2rem"}>
						<Box>
							<div>
								<p>rows</p>
								<Input 
									isInvalid={x <= 0}
									htmlSize={4} 
									width='auto' 
									errorBorderColor='crimson'
									value={x}
									onChange={e => setDimensions({x: Number(e.target.value), y})}
								/>
							</div>
						</Box>
						<Box>
							<div>
								<p>columns</p>
								<Input 
									isInvalid={y <= 0}
									htmlSize={4} 
									width='auto' 
									errorBorderColor='crimson'
									value={y}
									onChange={e => setDimensions({x, y: Number(e.target.value)})}
								/>
							</div>				
						</Box>
					</SimpleGrid>
				</Box>
				<Box>
					<Board dimensions={{x,y}} />
				</Box>
			</VStack>
		</>
	);
};