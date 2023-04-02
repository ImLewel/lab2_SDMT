namespace ImLewel_LinkedList {
  public class Program {
    static void Main(string[] args) {
      LinkedList list = new();
      list.Append("1");
      list.Append("2");
      list.Append("3");
      list.Append("4");
      list.Append("5");

      LinkedList list2 = list.Clone();
      list2.Append("6");

      Console.WriteLine(list.Show());
      Console.WriteLine(list2.Show());
    }
  }
}