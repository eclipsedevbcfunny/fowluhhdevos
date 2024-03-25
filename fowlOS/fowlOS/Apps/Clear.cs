using System;

namespace fowlOS.Apps;

public class Clear : IApp
{
	public string Name => "Clear";

	public string Description => "Clears the screen.";

	public void Execute()
	{
		Console.Clear();
	}
}