using System;

class MainClass {
  public static string EvenNumbersRecursive(int m, int n) {
    if (m > n) {
        return "";
    }
    if (m % 2 == 0) {
        return m + ", " + EvenNumbersRecursive(m+1, n);
    } else {
        return EvenNumbersRecursive(m+1, n);
    }
  }
  
  public static void Main (string[] args) {
    int M = 1;
    int N = 5;
    Console.WriteLine(EvenNumbersRecursive(M, N));

    M = 4;
    N = 8;
    Console.WriteLine(EvenNumbersRecursive(M, N));
  }
}
