using System;
using System.Collections; 
class Program {
  
  static void Main(string[] args) {
    string joia = "";
    ArrayList listaJoias = new ArrayList();
    int qtdJoias = 0;
    while (joia != null) {
      joia = Console.ReadLine();
      
      if (joia != null) {
        if (!listaJoias.Contains(joia)) {
          listaJoias.Add(joia);
          qtdJoias++;
        }
      }
    }
    
    Console.WriteLine(qtdJoias);
  }
}