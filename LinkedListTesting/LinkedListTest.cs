using LinkedList;

namespace LinkedListTesting {
  [TestClass]
  public class LinkedListTest {
    [TestMethod]
    public void TestAppend() {
      LinkedList.LinkedList list = new();
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
      LinkedList.LinkedList list = new();

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
      LinkedList.LinkedList list = new();

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
      LinkedList.LinkedList list = new();
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
      LinkedList.LinkedList list = new();
      list.Append("1");
      list.Append("2");
      list.Append("3");
      list.Append("4");
      list.Append("5");

      LinkedList.LinkedList list2 = list.Clone();
      Assert.AreEqual(list2.Show(), list.Show());

      list.Append("6");
      list2.Append("6");
      Assert.AreEqual(list2.Show(), list.Show());
    }
  }
}