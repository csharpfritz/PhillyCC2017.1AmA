using System;

class Program
{
  static void Main(string[] args)
  {

    if (args.Length == 0 || args[0] == "--help")
    {
      OutputHelp();
      return;
    }

    SetEnvironmentName(args[0]);

  }

  static void SetEnvironmentName(string envName)
  {

    Environment.SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", envName);
    Console.WriteLine($"Setting environment to: {envName}");
    Console.WriteLine("\n\n");

  }

  static void OutputHelp()
  {

    Console.WriteLine(".NET Environment Tool\n");
    Console.WriteLine("Usage: dotnet environment [environment-name]\n");

    Console.WriteLine("Arguments:");
    Console.WriteLine("  <environment-name>  The name of the environment to set for this console session.");
    Console.WriteLine("\n\n");

  }


}