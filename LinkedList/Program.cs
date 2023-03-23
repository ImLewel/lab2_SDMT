using static LinkedList.LinkedList;

namespace LinkedList {
  public class Program {
    static void Main(string[] args) {
      LinkedList list = new();
      Console.WriteLine(list.Length);
      list.Append("1");
      list.Append("2");
      list.Append("3");
      list.Append("4");
      list.Append("5");
      Console.WriteLine(list.Show());
      Console.WriteLine(list.Length);
    }
  }
}