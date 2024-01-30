// See https://aka.ms/new-console-template for more information

// SECTION 3

/*
Arrays
-contain anything
-fixed size
-random access
-Killer feature? GET SET
-AKA "Random Access"
-Think "Hard Drive vs. RAM"
*/

/*
Lists<> are actually arrays
in C#
*/

//Arrays
//Array Insertions & Deletions

//Insert at the end of an array
//using cs_datastructures_algorithms.ADT;

//int[] intArray = new int[10];

// Make a variable to keep the length because
// .Length is based on capacity and does not
// track the actual index
//int length = 0;

// This adds data for us
//for (int i = 0; i < 8; i++)
//{
// '1' is optional
//    intArray[length] = i + 1;
//    length++;
//}

//intArray[length] = 8;
//length++;

// Insert at the start of an array
//for (int i = 3; i >= 0; i--)
//{
//    this is moving over all the values;
//    intArray[i + 1] = intArray[i];
//}

//intArray[0]  = 20;

//int value = 0;

// Insert anywhere in the Array
//for (int i = 4; i >= 2; i--)
//{
// Shift each element one position to the right
//    intArray[i + 1] = intArray[i];
//}

//intArray[2] = 8;

// SECTION 2

/*
O(1) - "Constant"
The Cadillac of Big-O
-Assignment        var test = 0;
-Declarations       var test;
-Arithmetic         2 + 2;
-Comparison         2 > 1;
-Accessing Function array[1];
-Calling Function   someFunctions();

A linked list is an example of a constant
data structure because it is mostly just
assignments.

O(N) - "Linear"

-Think for-loops
-Number of inputs increase time
-int total = 0 O(1)
-while(i <= 10) O(N)
-Take the bigger number

You can always spot linear data structures
because they have while or for loops.

O(N^2) - "Quadratic"
var n = int.Parse(Console.ReadLine());
for (var r = 1; r <= n; r++)
{
    for (var c = 1; c <= n; c++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

It's basically just a nested for-loop.
AKA "brute-force"

log(n)
used for binary search & trees

n log(n)
quick sort, merge sort, shell sort, cube sort
*/

// SECTION 1

//using cs_datastructures_algorithms.ADT;
//using System.Collections;

//Stack ts = new Stack();

//Pokemon squirtle = new Pokemon();