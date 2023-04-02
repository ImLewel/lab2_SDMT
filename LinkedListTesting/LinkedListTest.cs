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

    [TestMethod]
    public void TestInsert() {
      LinkedList list = new();
      list.Append("1");
      list.Append("2");
      list.Append("3");
      list.Append("4");
      list.Append("5");
      list.Insert(3, "s");

      string expected =
        "1 2\n" +
        "2 3\n" +
        "3 s\n" +
        "s 4\n" +
        "4 5\n" +
        "5 null";
      Assert.AreEqual(expected, list.Show());
    }

    [TestMethod]
    public void TestDelete() {
      LinkedList list = new();
      list.Append("1");
      list.Append("2");
      list.Append("3");
      list.Append("4");
      list.Append("5");
      
      Assert.AreEqual(list.Delete(0), "1");
      Assert.AreEqual(list.Delete(3), "5");

      string expected =
        "2 3\n" +
        "3 4\n" +
        "4 null";
      Assert.AreEqual(expected, list.Show());
    }

    [TestMethod]
    public void TestDeleteAll() {
      LinkedList list = new();
      list.Append("s");
      list.Append("s");
      list.Append("1");
      list.Append("s");
      list.Append("2");
      list.Append("s");
      list.Append("3");
      list.Append("s");
      list.Append("4");
      list.Append("5");
      list.Append("s");
      list.Append("s");

      list.DeleteAll("s");

      string expected =
        "1 2\n" +
        "2 3\n" +
        "3 4\n" +
        "4 5\n" +
        "5 null";
      Assert.AreEqual(expected, list.Show());
    }

    [TestMethod]
    public void TestGet() {
      LinkedList list = new();
      list.Append("1");
      list.Append("2");
      list.Append("3");
      list.Append("4");
      list.Append("5");

      Assert.AreEqual(list.Get(2), "3");
      Assert.AreEqual(list.Get(4), "5");
      Assert.AreEqual(list.Get(0), "1");
    }
  }
}