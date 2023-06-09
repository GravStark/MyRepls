using System;

class Program {
  public static void Main (string[] args)
  {
    double x, y;
    Console.WriteLine("Inserisci raggio: ");
    x = double.Parse(Console.ReadLine());
    y = (x * x) * Math.PI;
    Console.WriteLine("L'area del cerchio equivale a: "+y);
    Console.ReadKey();
  }
}
