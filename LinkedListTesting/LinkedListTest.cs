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

      string expectedResult = 
        "1 2\n" +
        "2 3\n" +
        "3 4\n" +
        "4 5\n" +
        "5 null";
      Assert.AreEqual(expectedResult, list.Show());
    }
    [TestMethod]
    public void TestLength() {
      LinkedList list = new();

      int expectedLength = 0;
      Assert.AreEqual(expectedLength, list.Length);

      list.Append("1");
      list.Append("2");
      list.Append("3");
      list.Append("4");
      list.Append("5");

      expectedLength = 5;
      Assert.AreEqual(expectedLength, list.Length);
    }
    [TestMethod]
    public void TestInsert() {
      LinkedList list = new();

      list.Append("1");
      list.Append("2");
      list.Append("3");
      list.Append("4");
      list.Append("5");
      list.Insert(1, "6");
      list.Insert(2, "7");
      list.Insert(0, "8");

      string expectedResult =
        "8 1\n" +
        "1 6\n" +
        "6 7\n" +
        "7 2\n" +
        "2 3\n" +
        "3 4\n" +
        "4 5\n" +
        "5 null";
      Assert.AreEqual(expectedResult, list.Show());
    }
    [TestMethod]
    public void TestClear() {
      LinkedList list = new();
      list.Append("1");
      list.Append("2");
      list.Append("3");
      list.Append("4");
      list.Append("5");

      list.Clear();
      Assert.AreEqual(list.Show(), "");

      list.Append("5");
      Assert.AreEqual(list.Show(), "5 null");
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
      Assert.AreEqual(list2.Show(), list.Show());

      list.Append("6");
      list2.Append("6");
      Assert.AreEqual(list2.Show(), list.Show());
    }
    [TestMethod]
    public void TestDeleteAll() {
      LinkedList list = new();
      list.Append("1");
      list.Append("2");
      list.Append("3");
      list.Append("4");
      list.Append("5");

      LinkedList list2 = new();
      list2.Append("1");
      list2.Append("2");
      list2.Append("s");
      list2.Append("3");
      list2.Append("s");
      list2.Append("s");
      list2.Append("4");
      list2.Append("s");
      list2.Append("5");

      Assert.AreNotEqual(list.Show(), list2.Show());
      list2.deleteAll("s");
      Assert.AreEqual(list.Show(), list2.Show());
    }
    [TestMethod]
    public void TestReverse() {
      LinkedList list = new();
      list.Append("1");
      list.Append("2");
      list.Append("3");
      list.Append("4");
      list.Append("5");

      string expectedResult = "5 4\n" +
        "4 3\n" +
        "3 2\n" +
        "2 1\n" +
        "1 null";

      Assert.AreNotEqual(expectedResult, list.Show());
      list.Reverse();
      Assert.AreEqual(expectedResult, list.Show());
    }
    [TestMethod]
    public void TestGet() {
      LinkedList list = new();
      list.Append("1");
      list.Append("2");
      list.Append("3");
      list.Append("4");
      list.Append("5");

      string expected = "3 4";
      LinkedList.Node node = list.Get(2);
      Assert.AreEqual(expected, $"{node.Data} {node.Next.Data}");
    }
    [TestMethod]
    public void TestExtend() {
      LinkedList list = new();
      list.Append("a");
      list.Append("b");
      list.Append("c");
      list.Append("d");
      list.Append("e");

      LinkedList list2 = new();
      list2.Append("1");
      list2.Append("2");
      list2.Append("3");
      list2.Append("4");
      list2.Append("5");

      list2.Extend(list);

      string expectedResult =
        "1 2\n" +
        "2 3\n" +
        "3 4\n" +
        "4 5\n" +
        "5 a\n" +
        "a b\n" +
        "b c\n" +
        "c d\n" +
        "d e\n" +
        "e null";
      Assert.AreEqual(list2.Show(), expectedResult);
    }
    [TestMethod]
    public void TestDelete() {
      LinkedList list = new();
      list.Append("1");
      list.Append("2");
      list.Append("3");
      list.Append("s");
      list.Append("4");
      list.Append("5");

      list.Delete(3);
      string expectedResult = 
        "1 2\n" +
        "2 3\n" +
        "3 4\n" +
        "4 5\n" +
        "5 null";
      Assert.AreEqual(expectedResult, list.Show());
    }
    [TestMethod]
    public void TestFindFirst() {
      LinkedList list = new();
      list.Append("1");
      list.Append("2");
      list.Append("3");
      list.Append("s");
      list.Append("4");
      list.Append("5");

      int expected = 3;
      Assert.AreEqual(expected, list.findFirst("s"));
    }
    [TestMethod]
    public void TestFindLast() {
      LinkedList list = new();
      list.Append("1");
      list.Append("2");
      list.Append("3");
      list.Append("s");
      list.Append("4");
      list.Append("s");
      list.Append("5");

      int expected = 5;
      Assert.AreEqual(expected, list.findLast("s"));
    }
  }
}