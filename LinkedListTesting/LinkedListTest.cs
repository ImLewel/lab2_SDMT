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

    [TestMethod]
    public void TestLength() {
      LinkedList list = new();
      list.Append("1");
      list.Append("2");
      list.Append("3");
      list.Append("4");
      list.Append("5");

      Assert.AreEqual(list.Length(), 5);

      list.Append("6");
      list.Insert(2, "6");
      Assert.AreEqual(list.Length(), 7);

      list.DeleteAll("6");
      Assert.AreEqual(list.Length(), 5);
    }

    [TestMethod]
    public void TestClone() {
      LinkedList list = new();
      list.Append("1");
      list.Append("2");
      list.Append("3");
      list.Append("4");
      list.Append("5");

      LinkedList list2 = list.Clone();
      list2.Append("6");

      Assert.AreNotEqual(list.Show(), list2.Show());
      Assert.AreNotEqual(list.Length(), list2.Length());
    }

    [TestMethod]
    public void TestReverse() {
      LinkedList list = new();
      list.Append("1");
      list.Append("2");
      list.Append("3");
      list.Append("4");
      list.Append("5");

      LinkedList list2 = list.Clone();
      list2 = list2.Reverse();

      Assert.AreNotEqual(list.Show(), list2.Show());
      Assert.AreEqual(list.Length(), list2.Length());

     string expected =
        "5 4\n" +
        "4 3\n" +
        "3 2\n" +
        "2 1\n" +
        "1 null";
      Assert.AreEqual(expected, list2.Show());
    }

    [TestMethod]
    public void TestFindFirstAndLast() {
      LinkedList list = new();
      list.Append("1");
      list.Append("1");
      list.Append("2");
      list.Append("2");
      list.Append("3");
      list.Append("4");
      list.Append("5");

      int expectedFirst = 2;
      int expectedLast = 3;
      Assert.AreEqual(list.FindFirst("2"), expectedFirst);
      Assert.AreEqual(list.FindLast("2"), expectedLast);
    }
  }
}