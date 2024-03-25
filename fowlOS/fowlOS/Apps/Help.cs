using System;

namespace fowlOS.Apps;

public class Help : IApp
{
	public string Name => "Help";

	public string Description => "Shows information about all commands.";

	public void Execute()
	{
		foreach (var app in AppManager.Applications)
			Console.WriteLine(app.Name + " - " + app.Description);
	}
}