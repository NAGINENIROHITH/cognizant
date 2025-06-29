using System;
public class Logger
{
 private static Logger instance = null;
 private Logger()
 {
 Console.WriteLine("Instance Created");
 }
 public static Logger GetInstance()
 {
 if (instance == null)
 {
 instance = new Logger();
 }
 return instance;
 }
 public void Print(string message)
 {
 Console.WriteLine(message);
 }
}