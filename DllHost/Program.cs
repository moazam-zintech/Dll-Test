using System.Reflection;
namespace DllHost
{
    class Program
    {
        public static void Main(string[] args)
        {
            string dllFile = @"C:\Users\Muhammad.Moazam\OneDrive\Desktop\Attendence-API\libzkfpcsharp.dll";
            var assembly = Assembly.LoadFile(dllFile);
            var type = assembly.GetType("libzkfpcsharp.zkfp2");
            var obj = Activator.CreateInstance(type);
            var method = type.GetMethod("Init");
            var result = method.Invoke(obj, new object[] {});
            Console.WriteLine(result);
        }
    }
}