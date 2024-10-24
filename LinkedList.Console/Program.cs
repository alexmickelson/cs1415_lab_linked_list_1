using LinkedList.Logic;

var linkedList = new MyLinkedList();

linkedList.Append("this is the first string");
linkedList.Append("second string");
linkedList.Append("I am the third string");
Console.WriteLine(linkedList);

var removedData = linkedList.Pop();
Console.WriteLine($"Removed Data: {removedData}" + Environment.NewLine);
Console.WriteLine(linkedList);
