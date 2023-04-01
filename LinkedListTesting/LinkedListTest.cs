using ImLewel_LinkedList;

namespace LinkedListTesting {
  [TestClass]
  public class LinkedListTest {
    [TestMethod]
    public void TestAppend() {
      LinkedList list = new();
      list.Append("1");
      list.Append("2");
      list.Append("3");
      list.Append("4");
      list.Append("5");

      string expected =
        "1 2\n" +
        "2 3\n" +
        "3 4\n" +
        "4 5\n" +
        "5 null";
      Assert.AreEqual(expected, list.Show());
    }
  }
}