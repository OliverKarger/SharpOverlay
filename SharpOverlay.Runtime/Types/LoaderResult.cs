namespace SharpOverlay.Runtime.Types;

/// <summary>
///		Result of a Loader Operation
/// </summary>
public class LoaderResult
{
	/// <summary>
	///		Path to DLL File
	/// </summary>
	public string DLLFile;

	/// <summary>
	///		Type of loaded Class
	/// </summary>
	public Type Type;

	/// <summary>
	///		Error Flag
	/// </summary>
	public bool Error;

	/// <summary>
	///		List of Errors<para/>
	///		NULL if <see cref="Error"/> is false
	/// </summary>
	public string[]? Errors;

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
	public LoaderResult(string dllFile, Type type, bool error, string[]? errors)
	{
		DLLFile = dllFile;
		Type = type;
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
	public LoaderResult(string dllFile, Type type)
	{
		DLLFile = dllFile;
		Type = type;
		Error = false;
		Errors = null;
	}
}

