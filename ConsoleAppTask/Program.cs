// See https://aka.ms/new-console-template for more information
using Random_Examples.Examples;
using System.Linq;
using TaskIntegralType.Entities;

Console.WriteLine("Hello, World!");

#region Task 1: Integer Operations
TaskIntegerOperations myTask = new TaskIntegerOperations();

//myTask.Addition();
//myTask.Decrement();
//Console.Write("Input for Number1: ");
//myTask.Number1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Number 1 = {myTask.Number1}");
//Console.Write("Input for Number2: ");
//myTask.Number2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Number 2 = {myTask.Number2}");
//myTask.Divide();
//myTask.Increment();
//myTask.Modulo();
//myTask.Multiplication();
//myTask.Subtraction();
#endregion
#region ArrayExamples
ArrayExample myExample = new ArrayExample();

//int[] myInt = new int[] { 1, 5, 6, 7, 5, 2 };
//myExample.OddAndEven(myInt);

//Console.Write("Enter the word: ");
//string myWord = Console.ReadLine();
//if (String.IsNullOrEmpty(myWord)) throw new ArgumentNullException(nameof(myWord));
//Console.Write("Enter the number for repeating: ");
//int myNum = Convert.ToInt32(Console.ReadLine());
//myExample.StringArrayExample(myWord, myNum);

//ArrayOp myArr = new ArrayOp();
//myArr.PrintInt();

#endregion
#region String Operations
StringOperation myOperation = new StringOperation();

//myOperation.Concatenate();
#endregion
#region BooleanOps
BooleanOp myBooleanOp = new BooleanOp();

//myBooleanOp.Logical();
#endregion
#region Nullable Task
NullableOperation myNullNumber = new NullableOperation();
//myNullNumber.nullableInt = 16;
//Console.WriteLine(myNullNumber.nullableInt);
//myNullNumber.NullableInt();
#endregion
#region 2D Array (corrupted)
_2DArray myArray = new _2DArray();
//string formattedString = myArray.Format2DArray(myArray.array2D);
//Console.WriteLine($"{formattedString} \n");
#endregion
#region Methods
BeginnerMethods myMethod = new BeginnerMethods();
//Console.Write($"myString input: ");
//string myString = Console.ReadLine();
//Console.Write($"myInt input: ");
//int myInt = Convert.ToInt32(Console.ReadLine());
//object myObject = myMethod.GetMerger(myString, myInt);
//Console.WriteLine(myObject);

//int[] myArr = { 10, 5, 4, 6, 12, 22, 44 };
//object myMax = myMethod.GetMaxValue(myArr);
//object customMax = myMethod.GetMaxValue(15, 33, 90, 22, 212, 234);
//Console.WriteLine($"Max value in customMax is: {customMax}");
//Console.WriteLine($"Max value in myArray is: {myMax}");
#endregion
