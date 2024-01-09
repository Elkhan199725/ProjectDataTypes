// See https://aka.ms/new-console-template for more information
using ConsoleAppTask.Models;
using Random_Examples.Examples;
using System.Linq;
using System.Reflection;
using TaskIntegralType.Entities;

Console.WriteLine("Hello, World!");
#region DataTypes1

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

#endregion
#region Directory, File, Stream
//Console.WriteLine("System IO: ");
//string directoryPath = @".\Test";
//string filePath = @".\Test\test.txt";
//Console.WriteLine("Enter: name, email and id: ");
//string name = Console.ReadLine();
//string email = Console.ReadLine();
//int num = Convert.ToInt32(Console.ReadLine());
//Client client1 = new(4,"Orxan","or@code.edu.az");

//if (!Directory.Exists(directoryPath))
//{
//    Directory.CreateDirectory(directoryPath);
//}

//if (!File.Exists(filePath))
//{
//    using (File.Create(filePath)) { }
//}

//if (!File.Exists(Path.Combine(directoryPath, "test.txt")))
//{
//    Directory.Delete(directoryPath);
//}

//using (StreamReader sr = new StreamReader(filePath))
//{
//    while (!sr.EndOfStream)
//    {
//        string line = sr.ReadLine();
//        Console.WriteLine(line);
//    }
//    sr.Close();
//}

//using (StreamWriter sw = new StreamWriter(filePath, true)) 
//{ 
//sw.WriteLine($"Id: {client1.Id}; Name: {client1.Name}; Email: {client1.Email}");
//sw.Close();
//}
#endregion
#region Reflection
#region Reflection Part1
//Console.WriteLine("Reflection: ");
string filePath2 = @"C:\Users\Elkhan Mammadli\source\repos\DataTypes\ConsoleAppTask\bin\Debug\net8.0\ConsoleAppTask.dll";
Assembly assembly = Assembly.LoadFile(filePath2);
//Type[] types = assembly.GetTypes();
//foreach (Type t in types)
//{
//    Console.WriteLine(t);
//}
string pathProduct = "ConsoleAppTask.Models.Product";
Type type = assembly.GetType(pathProduct);
FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
//foreach (var field in fields)
//{
//    Console.WriteLine(field);
//}
MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
//foreach(var method in methods)
//{
//    Console.WriteLine(method);
//}
PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);//Binding is not necessary here.
//foreach(var property in properties)
//{
//    Console.WriteLine(property);
//}
ConstructorInfo[] constructors = type.GetConstructors(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
/*var ctors = type.GetConstructors(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)*/;// alternative way 
//foreach (var ctor in constructors)
//{
//    Console.WriteLine(ctor);
//}
object? product = Activator.CreateInstance(type);
//type.GetField("Id", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(product, 15);
//var id = type.GetField("Id", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(product);
//Console.WriteLine($"Id: {id}");

var getData = type.GetMethod("GetData");
//object[] parameters = {"Xiaomi Note 12", 1500M };
//var result = getData.Invoke(product, parameters);
//Console.WriteLine(result);
#endregion

#endregion