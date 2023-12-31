using System.Reflection;

namespace SharpOverlay.Runtime.Types;

/// <summary>
///		Result of a Loader Operation
/// </summary>
public class LoaderResult
{
	/// <summary>
	///		Path to DLL File
	/// </summary>
	public readonly string DLLFile;

	/// <summary>
	///		Type of loaded Class
	/// </summary>
	public readonly Type Type;

	/// <summary>
	///		Assembly
	/// </summary>
	public readonly Assembly Assembly;

	/// <summary>
	///		Error Flag
	/// </summary>
	public readonly bool Error;

	/// <summary>
	///		List of Errors<para/>
	///		NULL if <see cref="Error"/> is false
	/// </summary>
	public readonly string[]? Errors;

	/// <summary>
	///		Constructor
	/// </summary>
	/// <param name="dllFile">
	///		Path to DLL File
	/// </param>
	/// <param name="type">
	///		Type of loaded Class
	/// </param>
	/// <param name="error">
	///		Error Flag
	/// </param>
	/// <param name="errors">
	///		List of Errors
	/// </param>
	public LoaderResult(string dllFile, Type type, Assembly assembly, bool error, string[]? errors)
	{
		DLLFile = dllFile;
		Type = type;
		Assembly = assembly;
		Error = error;
		Errors = errors;

	}

	/// <summary>
	///		Constructor
	/// </summary>
	/// <param name="dllFile">
	///		Path to DLL File
	/// </param>
	/// <param name="type">
	///		Type of loaded Class
	/// </param>
	public LoaderResult(string dllFile, Type type, Assembly assembly)
	{
		DLLFile = dllFile;
		Type = type;
		Assembly = assembly;
		Error = false;
		Errors = null;
	}
}

