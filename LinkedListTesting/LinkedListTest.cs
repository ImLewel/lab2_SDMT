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

      string expectedResult = "1 2\n" +
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
  }
}