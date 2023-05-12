string[,] grid1 = new[,]{
  {"Alpha", "Beta", "Gamma", "Delta"},
  {"Anne", "Ben", "Charlie", "Doug"},
  {"Aardvark", "Bear", "Cat", "Dog"}
};

WriteLine($"Lower bound of the first dimension is {grid1.GetLowerBound(0)}");
WriteLine($"Upper bound of the first dimension is {grid1.GetUpperBound(0)}");
WriteLine($"Lower bound of the second dimension is {grid1.GetLowerBound(1)}");
WriteLine($"Upper bound of the second dimension is {grid1.GetUpperBound(1)}");