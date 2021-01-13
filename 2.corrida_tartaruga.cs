using System;
class tartaruga {
  static void Main() {
    
    int qtd;
    string[] velocidade;
    string qtdTemp = "";
    int maiorNumero;
    
    while (qtdTemp != null) {
      qtdTemp = Console.ReadLine();
      
      if (qtdTemp != null) {
        velocidade = Console.ReadLine().Split();
        qtd = Convert.ToInt32(qtdTemp);
        maiorNumero = Convert.ToInt32(velocidade[0]);
        for (int i = 0; i < qtd; i++) {
           if (Convert.ToInt32(velocidade[i]) > maiorNumero) {
             maiorNumero = Convert.ToInt32(velocidade[i]);
           }
        }
        
        if (maiorNumero < 10) {
          Console.WriteLine(1);
        }
        else if ((maiorNumero >= 10) && (maiorNumero < 20)) {
          Console.WriteLine(2);
        }
        else {
          Console.WriteLine(3);
        }  
      }
    }
  }
}