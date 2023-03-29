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

      list.Reverse();
      Console.WriteLine(list.Show());
      Console.WriteLine(list.Get(1).Data);
    }
  }
}