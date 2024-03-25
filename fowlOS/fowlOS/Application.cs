// Copyright (c) MOSA Project. Licensed under the New BSD License.

using fowlOS.Apps;

namespace fowlOS;

public static class AppManager
{
	public static readonly IApp[] Applications =
	{
		new Clear(),
		new Help(),
		new Shell(),
		new Time()
	};

	public static bool Execute(string name)
	{
		foreach (var app in Applications)
		{
			if (app.Name.ToLower() == name.ToLower())
			{
				app.Execute();
				return true;
			}
		}

		return false;
	}
}