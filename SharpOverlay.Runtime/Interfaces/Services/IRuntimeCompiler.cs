using SharpOverlay.Runtime.Types;

namespace SharpOverlay.Runtime.Interfaces.Services;

/// <summary>
///		Used to Compile Source Files to DLLs at Runtime<para/>
///		WARNING: The DLLs will be locked to the current Process until the AppDomain is unloaded<para/>
/// </summary>
public interface IRuntimeCompiler 
{
	/// <summary>
	///		Compile File to DLL
	/// </summary>
	/// <param name="path">
	///		Path to Source File
	/// </param>
	/// <param name="outAssembly">
	///		Path to Output Assembly<para/>
	///		Default: SourceFileName+Compiled.dll
	/// </param>
	/// <returns>
	///		<see cref="CompilerResult"/> for File
	///	</returns>
	public CompilerResult CompileFile(string path, string? outAssembly = null);

	/// <summary>
	///		Compile Files to DLLs
	/// </summary>
	/// <param name="files">
	///		Dictionary: Key = Path to Source File, Value = Path to Output Assembly<para/>
	/// </param>
	/// <returns>
	///		<see cref="CompilerResult"/>  for each File
	///	</returns>
	public IList<CompilerResult> CompileFiles(IDictionary<string, string> files);

	/// <summary>
	///		Compile Files to DLLs
	/// </summary>
	/// <param name="directory">
	///		Path to Directory containing Source Files
	///	</param>
	/// <param name="searchPattern">
	///		Search Pattern. Default = *.cs
	///	</param>
	/// <param name="recursive">
	///		Search for Files recursive (including Subdirectories)
	///	</param>
	/// <returns>
	///		<see cref="CompilerResult"/> for each File
	///	</returns>
	public IList<CompilerResult> CompileFiles(string directory, string searchPattern = "*.cs", bool recursive = false);
}