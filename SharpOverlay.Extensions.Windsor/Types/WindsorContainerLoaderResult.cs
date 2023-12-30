using SharpOverlay.Runtime.Types;

namespace SharpOverlay.Extensions.Windsor.Types;

/// <summary>
///    Result of a Loader and Injection Operation for Castle.Windsor<para/>
///    Extension of on <see cref="LoaderResult"/>
/// </summary>
public class WindsorContainerLoaderResult : LoaderResult
{
	public string ComponentName;

	/// <summary>
	///		Constructor
	/// </summary>
	/// <param name="dllFile">
	///		Path to DLL File
	/// </param>
	/// <param name="type">
	///		Type of loaded Class
	/// </param>
	/// <param name="name">
	///		Name of loaded Component for Castle.Windsor
	/// </param>
	/// <param name="error">
	///		Error Flag
	/// </param>
	/// <param name="errors">
	///		List of Errors
	/// </param>
	public WindsorContainerLoaderResult(
		string dllFile, 
		Type type, 
		string name,
		bool error, 
		string[]? errors) : base(dllFile, type, error, errors)
	{
		ComponentName = name;
	}

	/// <summary>
	///   Constructor
	/// </summary>
	/// <param name="dllFile">
	///		Path to DLL File
	/// </param>
	/// <param name="type">
	///		Type of loaded Class
	/// </param>
	/// <param name="name">
	///		Name of loaded Component for Castle.Windsor
	/// </param>
	public WindsorContainerLoaderResult(
			string dllFile, 
			Type type, 
			string name) : base(dllFile, type)
	{
		ComponentName = name;
	}
}