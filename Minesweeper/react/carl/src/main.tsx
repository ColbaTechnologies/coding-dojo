import React from 'react'
import { createRoot } from 'react-dom/client'
import {App} from './App.tsx'
import './index.css'
import { Center, ChakraProvider, Container } from '@chakra-ui/react'

createRoot(document.getElementById('root') as HTMLElement).render(
  	<React.StrictMode>
		<ChakraProvider>
			<Container  w="full">
				<Center>
					<App />
				</Center>
			</Container>
		</ChakraProvider>
  	</React.StrictMode>,
);
