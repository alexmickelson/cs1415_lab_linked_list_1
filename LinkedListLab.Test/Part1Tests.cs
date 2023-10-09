public class Part1Tests
{
  [Test]
  public void TestAppendAndCount1()
  {
    var list = new MyLinkedList();
    list.Append("first");

    Assert.AreEqual(1, list.Count);
  }

  [Test]
  public void TestAppendAndCount2()
  {
    var list = new MyLinkedList();
    list.Append("first");
    list.Append("second");

    Assert.AreEqual(2, list.Count);
  }

  [Test]
  public void TestAppendAndCount3()
  {
    var list = new MyLinkedList();

    Assert.AreEqual(0, list.Count);
  }
}