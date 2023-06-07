using System;

class Program {
  public static void Main (string[] args)
  {
    double l;
    do
    {
      Console.WriteLine("Inserisci lato: ");
      string line = Console.ReadLine();
      l=Double.Parse(line);
    }while(l<0);
    double a=l*l;
    Console.WriteLine("Risultato: "+ a);
    Console.ReadKey();
  }
}
