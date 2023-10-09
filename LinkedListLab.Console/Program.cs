

var linkedList = new MyLinkedList();

linkedList.Append("this is the first string");
linkedList.Append("second string");
linkedList.Append("I am the third string");



Console.WriteLine("Here is the linked list data:");
for (int i = 0; i < linkedList.Count; i++)
{
  Console.WriteLine($"{i}: {linkedList.DataAtIndex(i)}");
}