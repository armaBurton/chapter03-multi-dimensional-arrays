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
}

//Working with jagged arrays
string[][] jagged = new[]{
  {"Alpha", "Beta", "Gamma"},
  {"Anne", "Ben", "Charlie", "Doug"},
  {"Aardvark", "Bear"}
};

WriteLine($"Upper bound of array of arrays is: {0}", jagged.GetUpperBound(0));

for(int array = 0; array <= jagged.GetUpperBound(0); array++){
  WriteLine("Upper bound of array {0}",
    arg0: array,
    arg1: jagged[array].GetUpperBound(0));
}