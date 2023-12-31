using SharpOverlay.Runtime.Interfaces.Services;
using SharpOverlay.Runtime.Types;
using System.Diagnostics;

namespace SharpOverlay.Runtime.Services;

/// <inheritdoc cref="IRemoteCompiler" />
public class RemoteCompiler : IRemoteCompiler
{
	/// <summary>
	///		Possible Compiler Paths
	/// </summary>
	protected readonly IEnumerable<string> CompilerLookupPaths = new string[]
	{
		Path.Combine(Environment.CurrentDirectory, "SharpOverlay.RemoteCompiler.exe"),
		@"C:\Program Files\SharpOverlay\SharpOverlay.RemoteCompiler.exe",
		@"C:\Program Files(x86)\SharpOverlay\SharpOverlay.RemoteCompiler.exe",
		@"/usr/share/SharpOverlay/SharpOverlay.RemoteCompiler.dll",
		@"/var/opt/SharpOverlay/SharpOverlay.RemoteCompiler.dll"
	};

	/// <inheritdoc />
	public CompilerResult CompileFile(string path, string? outAssembly = null)
	{

		Process process = CreateCompilerProcess();

		throw new NotImplementedException();
	}

	/// <inheritdoc />
	public IList<CompilerResult> CompileFiles(IDictionary<string, string> files)
	{
		throw new NotImplementedException();
	}

	/// <inheritdoc />
	public IList<CompilerResult> CompileFiles(string directory, string searchPattern = "*.cs", bool recursive = false)
	{
		throw new NotImplementedException();
	}

	/// <inheritdoc />
	public void Dispose()
	{}

	/// <summary>
	///		Setups a new Compiler Process
	/// </summary>
	/// <returns>
	///		Compiler Process pre-configured
	/// </returns>
	protected Process CreateCompilerProcess()
	{
		Process compilerProcess = new Process();
		string? foundCompilerPath = null;
		foreach (string compilerPath in CompilerLookupPaths)
		{
			if (File.Exists(compilerPath))
			{
				foundCompilerPath = compilerPath;
				break;
			}
		}

		if (foundCompilerPath == null)
			throw new FileNotFoundException("Could not find Compiler");

		compilerProcess.StartInfo.Environment.Add("SHARPOVERLAY_REMOTE_COMPILER", "true");
		compilerProcess.StartInfo.FileName = foundCompilerPath;
		compilerProcess.StartInfo.UseShellExecute = true;
		compilerProcess.StartInfo.CreateNoWindow = true;
		compilerProcess.StartInfo.RedirectStandardError = true;
		compilerProcess.StartInfo.RedirectStandardInput = true;
		compilerProcess.StartInfo.RedirectStandardOutput = true;

		return compilerProcess;
	}
}