using System;

class Program {
  public static void Main (string[] args)
  {
    int x,y=0;
    Console.WriteLine("Inserisci 10 numeri:");
    for(int i=0;i<10;i++)
    {
        x =int.Parse(Console.ReadLine());
        y = y + x;
    }
    Console.WriteLine("10 numeri sommati: "+y);
    Console.ReadKey();
  }
}
