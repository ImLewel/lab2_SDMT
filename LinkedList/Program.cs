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

      LinkedList list2 = new();
      list2.Append("a");
      list2.Append("b");
      list2.Append("c");
      list2.Append("d");
      list2.Append("e");

      list2.Extend(list);
      Console.WriteLine(list2.Show());
    }
  }
}