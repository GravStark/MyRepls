using System;

class Program {
  public static void Main (string[] args)
  {
    string s;
    Console.WriteLine("inserisci stringa: ");
    s = Console.ReadLine();
    string s1=s.Substring(0,s.Length/3);
    string s2=s.Substring(s.Length/3,s.Length/3);
    string s3=s.Substring((s.Length/3)*2,s.Length/3);
    Console.WriteLine("stringa1: " + s1);
    Console.WriteLine("stringa2: " + s2);
    Console.WriteLine("stringa3: " + s3);
     Console.ReadKey();
  }
}
