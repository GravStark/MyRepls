using System;

class Program {
  public static void Main (string[] args)
  {
    string s;
            Console.WriteLine("inserisci stringa: ");
            s = Console.ReadLine();
            string s1=s.Substring(0,1);
            string s2=s.Substring(s.Length-1,1);
            Console.WriteLine("primo carattere: " + s1);
            Console.WriteLine("ultimo carattere: " + s2);
            Console.ReadKey();
  }
}
