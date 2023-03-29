using static LinkedList.LinkedList;

namespace LinkedList {
  public class Program {
    static void Main(string[] args) {
      LinkedList list = new();
      list.Append("1");
      list.Append("2");
      list.Append("3");
      list.Append("4");
      list.Append("5");
      list.Insert(1, "6");
      list.Insert(2, "7");
      list.Insert(0, "8");
      Console.WriteLine(list.Show());
      Console.WriteLine(list.Length + "\n");
      LinkedList list2 = list.Clone();
      Console.WriteLine(list2.Show());
    }
  }
}