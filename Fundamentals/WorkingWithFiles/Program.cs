using System;
using System.IO;

namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
        //   var someNiceString="Today is a very beautiful day. Why don't we go out and have fun.";
        //   File.WriteAllText(@"C:\Dev\learn-csharp-with-dotnet\Fundamentals\WorkingWithFiles\someNiceMessage.txt",someNiceString);
          var niceTextContent=File.ReadAllText(@"C:\Dev\learn-csharp-with-dotnet\Fundamentals\WorkingWithFiles\someNiceMessage.txt");
          Console.WriteLine(niceTextContent);
          Console.WriteLine("This file was last accessed " + File.GetLastAccessTime(@"C:\Dev\learn-csharp-with-dotnet\Fundamentals\WorkingWithFiles\someNiceMessage.txt"));

        //   var doesFileExist=File.Exists(@"C:\Dev\learn-csharp-with-dotnet\Fundamentals\WorkingWithFiles\someNiceMessage.txt");
        //   Console.WriteLine(doesFileExist);
        // niceTextContent+="\nHey, it was fun today";
        // File.WriteAllText(@"C:\Dev\learn-csharp-with-dotnet\Fundamentals\WorkingWithFiles\someNiceMessage.txt",niceTextContent);
        }
    }
}
