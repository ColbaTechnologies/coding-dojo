# Minesweeper

## About this Kata
Difficulty: Easy

### Problem Description

Have you ever played Minesweeper? It’s a cute little game which used to come within a certain Operating System whose name we can’t really remember. \
Well, the goal of the game is to find all the mines within an MxN field. To help you, the game shows a number in a square which tells you how many mines there are adjacent to that square. For instance, take the following 4x4 field with 2 mines (which are represented by an * character):

`* . . . ` \
`. . . . ` \
`. * . . ` \
`. . . . ` 

The same field including the hint numbers described above would look like this:

`* 1 0 0`\
`2 2 1 0`\
`1 * 1 0`\
`1 1 1 0`

You should write a program that takes input as follows:

"m, n, x"

Where (0 < m,n <= 100), n and m are the (integer) number of rows and columns respectively and x is the number of mines.

Your program should produce output as follows:

A table with x mines placed randomly and the numbers of the safe squares representing the amount of mines in their surroundings.

Suggestion: make the random position generator so that it can be replaced by a specific series of positions that we can use to test.
