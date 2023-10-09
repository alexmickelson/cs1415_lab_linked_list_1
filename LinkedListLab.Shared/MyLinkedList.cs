public class MyLinkedList
{
  private MyNode? head { get; set; }

  public int Count
  {
    get
    {
      var current = head;
      var count = 0;
      while (current != null)
      {
        count++;
        current = current.Next;
      }
      return count;
    }
  }
  public string DataAtIndex(int index)
  {
    var current = head;
    while (index != 0)
    {
      index--;
      current = current.Next;
    }
    return current.Data;
  }

  public void Append(string newData)
  {

    if (head == null)
    {
      head = new MyNode() { Data = newData };
      return;
    }

    var current = head;
    while (current.Next != null)
    {
      current = current.Next;
    }

    current.Next = new MyNode() { Data = newData };
  }

  public string Pop()
  {
    if (head == null)
      return "";
    if(head.Next == null)
    {
      var firstOutput = head.Data;
      head = null;
      return firstOutput;
    }

    var current = head;
    while (current.Next?.Next != null)
      current = current.Next;

    string output = current.Next!.Data;
    current.Next = null;
    return output;
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


  // // Extra Credit
  // public void AddAt(int index, string newData )
  // {
  //   // add node to the middle of the list
  //   return;
  // }

  // // Extra Credit
  // public string RemoveAt(int index)
  // {
  //   // remove node from list, return data from removed node
  //   return "";
  // }
}