namespace LinkedList.Logic;

public class MyLinkedList
{
  private MyNode? head { get; set; }

  public int Count
  {
    get
    {
      return -1;
    }
  }

  public void Append(string newData)
  {
    return;
  }

  public string DataAtIndex(int index)
  {
    return "";
  }

  public string Pop()
  {
    return "";
  }

  public override string ToString()
  {
    var output = "Here is the linked list data:" + Environment.NewLine;
    for (int i = 0; i < Count; i++)
    {
      output += $"{i}: {DataAtIndex(i)}" + Environment.NewLine;
    }
    return output;
  }


  // public void AddAt(int index, string newData )
  // {
  //   // add node to the middle of the list
  //   return;
  // }

  // public string RemoveAt(int index)
  // {
  //   // remove node from list, return data from removed node
  //   return "";
  // }
}