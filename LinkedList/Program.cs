﻿namespace ImLewel_LinkedList {
  public class Program {
    static void Main(string[] args) {
      LinkedList list = new();
      list.Append("1");
      list.Append("1");
      list.Append("2");
      list.Append("2");
      list.Append("3");
      list.Append("4");
      list.Append("5");

      Console.WriteLine(list.FindFirst("1"));
      Console.WriteLine(list.FindLast("1"));
    }
  }
}