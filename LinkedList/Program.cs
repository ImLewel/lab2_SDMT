using static LinkedList.LinkedList;

namespace LinkedList {
  public class Program {
    static void Main(string[] args) {
      LinkedList list = new();
      list.Append("1");
      list.Append("s");
      list.Append("3");
      list.Append("4");
      list.Append("s");
      Console.WriteLine(list.Show());
      list.deleteAll("h");
      list.Append("zz");
      Console.WriteLine(list.Show());
    }
  }
}