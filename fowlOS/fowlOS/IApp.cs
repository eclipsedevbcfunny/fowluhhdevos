namespace fowlOS;

public interface IApp
{
	string Name { get; }

	string Description { get; }

	void Execute();
}