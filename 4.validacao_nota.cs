using System;
using System.Globalization;
class notas {
  static void Main() {
    float media, notaTemp;
    float[] notas = new float[2];
    int qtdNotasValidas = 0;
    string mediaString;
    
    while (qtdNotasValidas != 2) {
      notaTemp = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
      if ((notaTemp >= 0.0) && (notaTemp <= 10.0)) {
        notas[qtdNotasValidas] = notaTemp;
        qtdNotasValidas++;
      }
      else {
        Console.WriteLine("nota invalida");
      }
    }
    
    media = (notas[0] + notas[1])/2;
    mediaString = media.ToString("0.00");
    Console.WriteLine("media = "+mediaString);
  }
}