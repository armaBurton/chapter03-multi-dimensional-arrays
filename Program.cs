// string[,] grid1 = new[,]{
//   {"Alpha", "Beta", "Gamma", "Delta"},
//   {"Anne", "Ben", "Charlie", "Doug"},
//   {"Aardvark", "Bear", "Cat", "Dog"}
// };

// WriteLine($"Lower bound of the first dimension is {grid1.GetLowerBound(0)}");
// WriteLine($"Upper bound of the first dimension is {grid1.GetUpperBound(0)}");
// WriteLine($"Lower bound of the second dimension is {grid1.GetLowerBound(1)}");
// WriteLine($"Upper bound of the second dimension is {grid1.GetUpperBound(1)}");

// for (int row = 0; row <= grid1.GetUpperBound(0); row++){
//   for (int col = 0; col <= grid1.GetUpperBound(1); col++){
//     WriteLine($"Row {row}, Column {col}: {grid1[row, col]}");
//   }
// }

//Working with jagged arrays
// string[][] jagged = new[]{
//   new[] {"Alpha", "Beta", "Gamma"},
//   new[] {"Anne", "Ben", "Charlie", "Doug"},
//   new[] {"Aardvark", "Bear"}
// };

// WriteLine($"Upper bound of array of arrays is: {0}", jagged.GetUpperBound(0));

// for(int array = 0; array <= jagged.GetUpperBound(0); array++){
//   WriteLine("Upper bound of array {0}",
//     arg0: array,
//     arg1: jagged[array].GetUpperBound(0));
// }

// for(int row = 0; row <= jagged.GetUpperBound(0); row++){
//   for(int col = 0; col <= jagged[row].GetUpperBound(0); col++){
//     WriteLine($"Row {row}, Column {col}: {jagged[row][col]}");
//   }
// }

int[] sequentialNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] oneTwoNumbers = new int[] { 1, 2, };
int[] oneTwoTenNumbers = new int[] { 1, 2, 10 };
int[] oneTwoThreeTenNumbers = new int[] { 1, 2, 3, 10 };
int[] primeNumbers = new int[] { 2, 3, 4, 7, 11, 13, 17, 19, 23, 29 };
int[] fibonacciNumbers = new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };
int[] emptyNumbers = new int[] { };
int[] threeNumbers = new int[] { 9, 7, 5 };
int[] sixNumbers = new int[] { 9, 7, 5, 4, 2, 10 };

