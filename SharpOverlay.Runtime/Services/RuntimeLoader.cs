using SharpOverlay.Runtime.Interfaces.Services;
using SharpOverlay.Runtime.Types;
using System.Reflection;

namespace SharpOverlay.Runtime.Services;

/// <inheritdoc cref="IRuntimeLoader" />
public class RuntimeLoader : IRuntimeLoader
{
	/// <inheritdoc />
	public void Dispose()
	{}

	/// <inheritdoc />
	public LoaderResult LoadFile(string file)
	{
		Assembly assembly = Assembly.LoadFile(file);
		Type type = assembly.GetType();

		return new LoaderResult(file, type, assembly, false, null);
	}

	/// <inheritdoc />
	public IList<LoaderResult> LoadFiles(IList<string> files)
	{
		List<LoaderResult> results = new List<LoaderResult>();
		foreach (string file in files)
		{
			results.Add(LoadFile(file));
		}
		return results;
	}

	/// <inheritdoc />
	public IList<LoaderResult> LoadFiles(string directory, string searchPattern = "*.dll", bool recursive = false)
	{
		string[] files = Directory.GetFiles(directory, searchPattern, recursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
		return LoadFiles(files);
	}
}