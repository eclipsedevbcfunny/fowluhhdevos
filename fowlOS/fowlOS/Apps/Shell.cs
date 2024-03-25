using System;

namespace fowlOS.Apps;

public class Shell : IApp
{
	public string Name => "Shell";

	public string Description => "Runs the interactive shell.";

	public void Execute()
	{
		Console.WriteLine();
		Console.WriteLine("fowlOS Shell v1.0");
		Console.WriteLine("Type \"help\" for commands.");

		while (true)
		{
			Console.Write("> ");

			var cmd = Console.ReadLine();

			if (!AppManager.Execute(cmd))
			{
				Console.WriteLine("Unknown command: " + cmd);
			}
		}
	}
}