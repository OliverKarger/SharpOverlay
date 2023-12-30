namespace SharpOverlay.Runtime.Types;

/// <summary>
///		Result of a Compiler Operation
/// </summary>
public struct CompilerResult
{
	public string SourceFile;
	public string DLLFile;
	public bool Error;
	public string[]? Errors;
}