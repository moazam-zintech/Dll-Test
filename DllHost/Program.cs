
using System.Reflection;
string dllFile = @"C:\\Users\\Muhammad.Moazam\\OneDrive\\Desktop\\DllTestLibrary.dll";
var assembly = Assembly.LoadFile(dllFile);
var type = assembly.GetType("DllTestLibrary.HelloWorld");
var obj = Activator.CreateInstance(type);
var method = type.GetMethod("SayHello");
var result = method.Invoke(obj, new object[] { "Ali" });
Console.WriteLine(result);