# SmallKatas

A set of small Katas to improve my knowledge of the c# language.

### 1 - Vowels Remover

#### Description
Given a sentence, remove all the vowels it contains.

### 2 - Find Capitals

#### Description
Write a function that takes a single string (word) as argument. The function must return an ordered list containing the indexes of all capital letters in the string.

### 3 - Plus One Array
#### Description
Given an array of integers of any length, return an array that has 1 added to the value represented by the array.

For example an array [2, 3, 9] equals 239, add one would return an array [2, 4, 0].

[4, 3, 2, 5] would return [4, 3, 2, 6]

Only positive, single digit integers are allowed in the array so the function should return null if any of the array values are negative or more than 10

[1, -9] would return null.

### 4 - Directions Reduction

#### Description
A man was given directions to go from one point to another. The directions were "NORTH", "SOUTH", "WEST", "EAST".

Clearly "NORTH" and "SOUTH" are opposite, "WEST" and "EAST" too. Going to one direction and coming back the opposite direction is a needless effort.

The directions given to the man are, for example, the following:

string[] plan = { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };

You can immediatly see that going "NORTH" and then "SOUTH" is not reasonable, better stay to the same place! So the task is to give to the man a simplified version of the plan. A better plan in this case is simply:

string[] plan = { "WEST" };

Other examples:

In ["NORTH", "SOUTH", "EAST", "WEST"], the direction "NORTH" + "SOUTH" is going north and coming back right away. What a waste of time! Better to do nothing. The path becomes ["EAST", "WEST"], now "EAST" and "WEST" annihilate each other, therefore, the final result is [].

In ["NORTH", "EAST", "WEST", "SOUTH", "WEST", "WEST"], "NORTH" and "SOUTH" are not directly opposite but they become directly opposite after the reduction of "EAST" and "WEST" so the whole path is reducible to ["WEST", "WEST"].

You have to write a function which will take an array of strings and returns an array of strings with the needless directions removed (W<->E or S<->N side by side).
