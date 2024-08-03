int[] values = { 10, 20, 50 };
/*
Rule 1: Should contain only three elements
Rule 2: The element 0 should be 10
Rule 3: The element 1 should be less than 25
Rule 4: The element 2 should be either 50 or 100
*/

//Older
bool b1 = values.Length == 3 && values[0] == 10 && values[1] < 25 && (values[2] == 50 || values[2] == 100);
Console.WriteLine(b1);

//Newer
bool b2 = values is [10, < 25, 50 or 100];
Console.WriteLine(b2);

Console.ReadKey();