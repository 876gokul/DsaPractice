using DsaPratice.Array;

var myArray = new MyStaticArray();

Console.WriteLine($"Capcity of the array: {myArray.Capacity}");
Console.WriteLine($"Length of the array: {myArray.Length}");
myArray.Print();
myArray.InsertAtBeginning(1);
myArray.Print();
myArray.InsertAtEnd(3);
myArray.Print();
myArray.InsertAtGivenIndex(1, 2);
myArray.Print();
myArray.InsertAtBeginning(0);
myArray.Print();
myArray.InsertAtEnd(10);
myArray.Print();
Console.WriteLine();
Console.WriteLine($"Capcity of the array: {myArray.Capacity}");
Console.WriteLine($"Length of the array: {myArray.Length}");
Console.WriteLine();
try
{
    myArray.InsertAtEnd(20);
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"An Exception occured. {ex.Message}");
}
myArray.Print();
myArray.DeleteAtBeginning();
myArray.Print();
myArray.DeleteAtEnd();
myArray.Print();
myArray.DeleteAtGivenIndex(1);
myArray.Print();
Console.WriteLine();
Console.WriteLine($"Capcity of the array: {myArray.Capacity}");
Console.WriteLine($"Length of the array: {myArray.Length}");
Console.WriteLine();
try
{
    myArray.UpdateValueByIndex(3, 1);
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"An Exception occured. {ex.Message}");
}
int serachItem = 4;
if(myArray.FindIndex(serachItem, out int? searchIndex))
{
    Console.WriteLine($"the item : {serachItem} is found at index : {searchIndex}");
}
else
{
    Console.WriteLine($"the item : {serachItem} was not found in the array.");
}
Console.WriteLine();
Console.WriteLine($"Capcity of the array: {myArray.Capacity}");
Console.WriteLine($"Length of the array: {myArray.Length}");
Console.WriteLine();
myArray.Print();
myArray.Clear();
myArray.Print();
Console.WriteLine();
Console.WriteLine($"Capcity of the array: {myArray.Capacity}");
Console.WriteLine($"Length of the array: {myArray.Length}");
Console.WriteLine();
myArray.IncreaseCapacity(10);
Console.WriteLine();
Console.WriteLine($"Capcity of the array: {myArray.Capacity}");
Console.WriteLine($"Length of the array: {myArray.Length}");
Console.WriteLine();
for(int i = 0; i < 9; i++)
{
    myArray.InsertAtEnd((i + 1) % 2);
}
var indexes = myArray.FindAllIndex(1);
Console.WriteLine($"1 is present in following indexes: {string.Join(", ", indexes)}");
myArray.Print();
Console.WriteLine($"value at index 3: {myArray.GetValueByIndex(3)}");
Console.ReadKey();