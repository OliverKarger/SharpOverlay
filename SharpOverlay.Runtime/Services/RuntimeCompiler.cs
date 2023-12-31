using SharpOverlay.Runtime.Interfaces.Services;
using SharpOverlay.Runtime.Types;
using Westwind.Scripting;

namespace SharpOverlay.Runtime.Services;

///	<inheritdoc cref="IRuntimeCompiler" />
public class RuntimeCompiler : IRuntimeCompiler
{
	private readonly CSharpScriptExecution _cSharpScriptExecution;

	/// <summary>
	///		Constructor
	/// </summary>
	public RuntimeCompiler()
	{
		_cSharpScriptExecution = new CSharpScriptExecution();

		// Setting up basic Settings
		_cSharpScriptExecution.AddDefaultReferencesAndNamespaces();
		_cSharpScriptExecution.AddLoadedReferences();
		_cSharpScriptExecution.AddNetCoreDefaultReferences();
	}

	///	<inheritdoc/>
	public CompilerResult CompileFile(string path, string? outAssembly = null)
	{
		string sourceFilename = Path.GetFileNameWithoutExtension(path);
		string sourceDirectory = Path.GetDirectoryName(path) ?? throw new InvalidOperationException();

		if (outAssembly == null)
		{
			outAssembly = Path.Combine(sourceDirectory, $"{sourceFilename}.Compiled.dll");
		}

		_cSharpScriptExecution.OutputAssembly = outAssembly;
		_cSharpScriptExecution.CompileAssembly(path, true);

		return new CompilerResult(
			path, 
			outAssembly,
			_cSharpScriptExecution.Error,
			_cSharpScriptExecution.Error ? new string[] { _cSharpScriptExecution.ErrorMessage } : null);
	}

	///	<inheritdoc/>
	public IList<CompilerResult> CompileFiles(IDictionary<string, string> files)
	{
		List<CompilerResult> results = new List<CompilerResult>();
		foreach (KeyValuePair<string, string> file in files)
		{
			results.Add(CompileFile(file.Key, file.Value));
		}
		return results;
	}

	///	<inheritdoc/>
	public IList<CompilerResult> CompileFiles(string directory, string searchPattern = "*.cs", bool recursive = false)
	{
		List<string> files = Directory.GetFiles(directory, searchPattern, recursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly).ToList();
		List<CompilerResult> results = new List<CompilerResult>();

		foreach (string file in files)
		{
			results.Add(CompileFile(file));
		}

		return results;
	}

	///	<inheritdoc/>
	public void Dispose()
	{}
}