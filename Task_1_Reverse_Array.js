// Reverse Array
// Write a program that takes an array of size N as input and gives the output as an array in the reverse order. The format of the input is as follow:

// N
// a1 a2 a3 a4 a5 … an

// 'N' is the size of the array and a1, a2, a3, … an, are its elements. Your program should give output (on the same line and separated by a space) as follows:

// an an-1 an-2 … a1

// Example

// Case 1:
// For input provided as follows:

// 3
// 1 2 3

// Output of the program will be:

// 3 2 1

// Description:

// As the input is 1 2 3, if we reverse these numbers we get: 3 2 1.

// Case 2:

// For the input provided as follows:

// 4
// 1 2 1 0

// Output of the program will be:

// 0 1 2 1

// Description:

// The reversed order of the input is 0 1 2 1.

function reverse(array, len){
  for(var i = 0; i < len/2; i++) {
    let temp = array[i];
    array[i] = array[len-i];
    array[len-i] = temp;
  }
}