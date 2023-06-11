using System;

class Program {
  public static void Main (string[] args)
  {
    string s;
    Console.WriteLine("inserisci stringa: ");
    s = Console.ReadLine();
    string s1;
    Console.WriteLine("inserisci stringa 2: ");
    s1 = Console.ReadLine();
    int x = s.Length + s1.Length;
    Console.WriteLine("le due stringhe sono lunghe in totale: " + x);
    Console.ReadKey();
  }
}
