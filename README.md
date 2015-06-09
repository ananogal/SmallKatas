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

### 5 - Are they the same?

#### Description
Given two arrays a and b write a function that checks whether the two arrays have the "same" elements, with the same multiplicities. "Same" means, here, that the elements in b are the elements in a squared, regardless of the order.

### 6 - Highest and Lowest

#### Description
In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.

### 7 - Opposites Attract

#### Description
Timmy & Sarah think they are in love, but around where they live, they will only know once they pick a flower each. If one of the flowers has an even number of petals and the other has an odd number of petals it means they are in love.

Write a function that will take the number of petals of each flower and return true if they are in love and false if they aren't.

### 8 - Factorial

#### Description
In mathematics, the factorial of a non-negative integer n, denoted by n!, is the product of all positive integers less than or equal to n. For example: 5! = 5 * 4 * 3 * 2 * 1 = 120. By convention the value of 0! is 1.

Write a function to calculate factorial for a given input. If input is below 0 or above 12 throw an exception of type ArgumentOutOfRangeException. Function skeleton is already provided, as are some test cases.

More details about factorial can be found here: http://en.wikipedia.org/wiki/Factorial
