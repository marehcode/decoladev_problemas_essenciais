using System;
class lerInteiro {
  static void Main() {
    int num = 0;
    num = Convert.ToInt32(Console.ReadLine());
      for (int i = 1; i <= num; i++) {
        Console.WriteLine(i+" "+(i*i)+" "+(i*i*i));
      }
  }
}