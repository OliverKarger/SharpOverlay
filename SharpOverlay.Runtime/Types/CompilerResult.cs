namespace SharpOverlay.Runtime.Types;

/// <summary>
///		Result of a Compiler Operation
/// </summary>
public struct CompilerResult
{
	/// <summary>
	///		Path to Source File
	/// </summary>
	public readonly string SourceFile;

	/// <summary>
	///		Path to compiled DLL
	/// </summary>
	public readonly string DLLFile;

	/// <summary>
	///		Error Flag
	/// </summary>
	public readonly bool Error;

	/// <summary>
	///		List of Errors
	/// </summary>
	public readonly string[]? Errors;

	/// <summary>
	///		Constructor
	/// </summary>
	/// <param name="sourceFile">
	///		Path to Source File
	/// </param>
	/// <param name="dllFile">
	///		Path to compiled DLL
	/// </param>
	/// <param name="error">
	///		Error Flag
	/// </param>
	/// <param name="errors">
	///		List of Errors
	/// </param>
	public CompilerResult(string sourceFile, string dllFile, bool error, string[]? errors)
	{
		SourceFile = sourceFile;
		DLLFile = dllFile;
		Error = error;
		Errors = errors;
	}

	/// <summary>
	///		Constructor
	/// </summary>
	/// <param name="sourceFile">
	///		Path to Source File
	/// </param>
	/// <param name="dllFile">
	///		Path to compiled DLL
	/// </param>
	public CompilerResult(string sourceFile, string dllFile)
	{
		SourceFile = sourceFile;
		DLLFile = dllFile;
		Error = false;
		Errors = null;
	}
}