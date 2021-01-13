using System;
class rv {
  static void Main() {
    
    int r = 0, v = 0, i = 0, qtdSomas = 0, rTemp = 0;
    
    r = Convert.ToInt32(Console.ReadLine());
    do {
      v = Convert.ToInt32(Console.ReadLine());
    } while (r >= v);
    
    for (i = r,rTemp = 0; rTemp < v; i++) {
      rTemp = rTemp + i;
      qtdSomas++;
    }
    
    Console.WriteLine(qtdSomas);
  }
}