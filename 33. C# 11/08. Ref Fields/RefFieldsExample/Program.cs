public ref struct RefStruct
{
  public ref int myField;

  public RefStruct(ref int refField)
  {
    myField = ref refField;
  }
}

class Program
{
  static void Main()
  {
   //RefStruct[] x = new RefStruct[]; //not allowed

    int value = 42;
    RefStruct refStruct = new RefStruct(ref value);

    //refStruct.myField = value; //reference copy (not allowed directly; but allowed through constructor)

    Console.WriteLine(refStruct.myField); //42
    Console.WriteLine(value); //42

    value = 100;
    Console.WriteLine(refStruct.myField); //100

    Console.ReadKey();
  }
}