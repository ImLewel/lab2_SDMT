namespace ImLewel_LinkedList {
  public class Program {
    static void Main(string[] args) {
      LinkedList list = new();
      list.Append("1");
      list.Append("2");
      list.Append("3");
      list.Append("s");
      list.Append("4");
      list.Append("s");
      list.Append("5");

      Console.WriteLine(list.findFirst("s"));
      Console.WriteLine(list.findLast("s"));
    }
  }
}