using System;

class Program {
  public static void Main (string[] args)
  {
    double b;
    double h;
    do
    {
      Console.WriteLine("Inserisci Base: ");
      string line = Console.ReadLine(); //lettura
      b=Double.Parse(line); //conversione
    }while(b<=0);
    do
    {
      Console.WriteLine("Inserisci altezza: ");
      string line = Console.ReadLine(); //lettura2
      h=Double.Parse(line); //conversione2
    }while(h<=0);
    double a=(b*h)/2; //operazione
    Console.WriteLine("Risultato: "+ a); //stampa
    Console.ReadKey(); //fine
  }
}
