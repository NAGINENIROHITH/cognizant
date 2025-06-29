using System;
public class Program
{
 public static void Main(string[] args)
 {
 Logger log1 = Logger.GetInstance();
 log1.Print("This is the First message");
 
 Logger log2 = Logger.GetInstance();
 log2.Print("This is the Second Message");
 }
}