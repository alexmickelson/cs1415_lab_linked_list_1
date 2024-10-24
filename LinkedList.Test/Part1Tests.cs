using FluentAssertions;
using LinkedList.Logic;

namespace LinkedList.Test;
public class Part1Tests
{
  [Fact]
  public void TestAppendAndCount1()
  {
    var list = new MyLinkedList();
    list.Append("first");

    list.Count.Should().Be(1);
  }

  [Fact]
  public void TestAppendAndCount2()
  {
    var list = new MyLinkedList();
    list.Append("first");
    list.Append("second");

    list.Count.Should().Be(2);
  }

  [Fact]
  public void TestAppendAndCount3()
  {
    var list = new MyLinkedList();

    list.Count.Should().Be(0);
  }
}