# Algorithms

Various algorithms demonstrating concepts I learned in school

## Week1

Constant, Linear, and Quadratic algorithms
  Week1.cs contains 3 methods that all have different runtimes.
  They all print things to the console, using different loops.

## Week2

Shuffling an array using Fisher-Yates Shuffle
  Week2_Fisher-Yates Shuffle.cs is my implementation of the Fisher-Yates shuffle.
  For every element in the array, the algorithm picks a pseudo-random index of the array, and swaps it with the current.

## Week3

Data Structures: Array, Map, Stack, Queue
  Week3_DataStructures.cs has a few examples of different data types in action.
  For game development, I mostly use arrays and dictionaries, and stacks and queues have niche uses in other applications.

## Week4

Sorting Algorithms:

  BubbleSort - Runtime: O(n2) average and worst case
  
  InsertionSort - Runtime: best case is O(n), and worst case is O(n2)
  
  SelectionSort - Runtime: O(n2) average and worst case
  
## Week5

Searching

  LinearSearch - Worst: O(n), Best: O(1), Average: O(n/2)
This is the most simple searching algorithm: iterate through all the elements in the array until you find one that matches.

  BinarySearch - Worst: O(log n), Average: O(log n), Best: O(1)
Binary search needs a sorted array in order to work.  It stores a left and right bound and gets the element in the middle.  Until the middle element is equal to what we are
searching for, it moves the left and right bounds to select smaller areas of the array.

  InterpolationSearch - Worst: O(n), Best O(1), Average O(log(log(n)))[2]
Interpolation search is almost the same as BinarySearch, except instead of using the middle of the left and right, it calculates a "probe", which is a guess of how far left/right the value might lie in between the bounds.
 