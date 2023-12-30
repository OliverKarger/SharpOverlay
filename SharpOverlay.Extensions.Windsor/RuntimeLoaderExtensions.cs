using Castle.MicroKernel;
using Castle.Windsor;
using SharpOverlay.Extensions.Windsor.Types;
using SharpOverlay.Runtime.Interfaces.Services;

namespace SharpOverlay.Extensions.Windsor;

/// <summary>
///		Extensions for the <see cref="IRuntimeLoader"/> to be used with Castle.Windsor
/// </summary>
public static class RuntimeLoaderExtensions
{
	#region IWindsorContainer

	/// <summary>
	///   Loads a DLL into the current AppDomain and injects it into the Castle.Windsor Container<para/>
	///   Used for injecting Services into the Container from outside the Container
	/// </summary>
	/// <param name="loader">
	///		<see cref="IRuntimeLoader"/> Instance
	/// </param>
	/// <param name="file">
	///		Path to DLL File
	/// </param>
	/// <param name="container">
	///		Instance of <see cref="IWindsorContainer"/> Container
	/// </param>
	/// <param name="name">
	///		Name of Component for named Service in Castle.Windsor<para/>
	///		Defaults to Class Name
	/// </param>
	/// <returns>
	///		<see cref="WindsorContainerLoaderResult"/> containing the Information about the loaded DLL
	/// </returns>
	/// <exception cref="FileNotFoundException">File does not exist</exception>
	/// <exception cref="FileLoadException">Cannot load File</exception>
	/// <exception cref="DriveNotFoundException">Error when accessing DLL(s) from Network Share</exception>
	/// <exception cref="DirectoryNotFoundException">Directory does not exist</exception>
	/// <exception cref="UnauthorizedAccessException">Cannot gain Access to DLL</exception>
	public static WindsorContainerLoaderResult LoadFile(this IRuntimeLoader loader, string file, IWindsorContainer container, string? name = null)
	{
		throw new NotImplementedException();
	}

	/// <summary>
	///		Loads DLLs into the current AppDomain and injects them into the Castle.Windsor Container<para/>
	///		Used for injecting Services into the Container from outside the Container
	/// </summary>
	/// <param name="loader">
	///		<see cref="IRuntimeLoader"/> Instance
	/// </param>
	/// <param name="files">
	///		List of DLLs to Load
	/// </param>
	/// <param name="container">
	///		Instance of <see cref="IWindsorContainer"/> Container
	/// </param>
	/// <param name="name">
	///		Name of Component for named Service in Castle.Windsor<para/>
	///		Defaults to Class Name
	/// </param>
	/// <returns>
	///		List of <see cref="WindsorContainerLoaderResult"/> containing the Information about the loaded DLLs"/>
	/// </returns>
	/// <exception cref="FileNotFoundException">File does not exist</exception>
	/// <exception cref="FileLoadException">Cannot load File</exception>
	/// <exception cref="DriveNotFoundException">Error when accessing DLL(s) from Network Share</exception>
	/// <exception cref="DirectoryNotFoundException">Directory does not exist</exception>
	/// <exception cref="UnauthorizedAccessException">Cannot gain Access to DLL</exception>
	public static IList<WindsorContainerLoaderResult> LoadFiles(this IRuntimeLoader loader, IList<string> files, IWindsorContainer container, string? name = null)
	{
		throw new NotImplementedException();
	}

	/// <summary>
	///		Loads DLLs into the current AppDomain and injects them into the Castle.Windsor Container<para/>
	///		Used for injecting Services into the Container from outside the Container
	/// </summary>
	/// <param name="loader">
	///		Instance of <see cref="IRuntimeLoader"/>
	/// </param>
	/// <param name="directory">
	///		Directory containing DLLs
	/// </param>
	/// <param name="container">
	///		Instance of <see cref="IWindsorContainer"/>
	/// </param>
	/// <param name="searchPattern">
	///		Search Pattern for DLLs<para/>
	///		Default = *.dll
	/// </param>
	/// <param name="recursive">
	///		Search for Files recursive (including Subdirectories)
	/// </param>
	/// <returns>
	///		List of <see cref="WindsorContainerLoaderResult"/> containing the Information about the loaded DLLs
	/// </returns>
	/// <exception cref="FileNotFoundException">File does not exist</exception>
	/// <exception cref="FileLoadException">Cannot load File</exception>
	/// <exception cref="DriveNotFoundException">Error when accessing DLL(s) from Network Share</exception>
	/// <exception cref="DirectoryNotFoundException">Directory does not exist</exception>
	/// <exception cref="UnauthorizedAccessException">Cannot gain Access to DLL</exception>
	public static IList<WindsorContainerLoaderResult> LoadFiles(this IRuntimeLoader loader, string directory, IWindsorContainer container, string searchPattern = "*.dll", bool recursive = false)
	{
		throw new NotImplementedException();
	}
	#endregion

	#region IKernel

	/// <summary>
	///		Loads a DLL into the current AppDomain and injects it into the Castle.Windsor Container<para/>
	///		Used to Inject a Service from inside another Service at Runtime<para/>
	///		Use Service <see cref="IKernel"/> to do that
	/// </summary>
	/// <param name="loader">
	///		Instance of <see cref="IRuntimeLoader"/>
	/// </param>
	/// <param name="file">
	///		Path to DLL File
	/// </param>
	/// <param name="kernel">
	///		Instance of <see cref="IKernel"/>
	/// </param>
	/// <param name="name">
	///		Name of Component for named Service in Castle.Windsor<para/>
	/// </param>
	/// <returns>
	///		<see cref="WindsorContainerLoaderResult"/> containing the Information about the loaded DLL
	/// </returns>
	/// <exception cref="FileNotFoundException">File does not exist</exception>
	/// <exception cref="FileLoadException">Cannot load File</exception>
	/// <exception cref="DriveNotFoundException">Error when accessing DLL(s) from Network Share</exception>
	/// <exception cref="DirectoryNotFoundException">Directory does not exist</exception>
	/// <exception cref="UnauthorizedAccessException">Cannot gain Access to DLL</exception>
	public static WindsorContainerLoaderResult LoadFile(this IRuntimeLoader loader, string file, IKernel kernel, string? name = null)
	{
		throw new NotImplementedException();
	}

	/// <summary>
	///		Loads DLLs into the current AppDomain and injects them into the Castle.Windsor Container<para/>
	///		Used to Inject a Service from inside another Service at Runtime<para/>
	///		Use Service <see cref="IKernel"/> to do that
	/// </summary>
	/// <param name="loader">
	///		Instance of <see cref="IRuntimeLoader"/>
	/// </param>
	/// <param name="files">
	///		List of DLLs to Load
	/// </param>
	/// <param name="kernel">
	///		Instance of <see cref="IKernel"/>
	/// </param>
	/// <returns>
	///		List of <see cref="WindsorContainerLoaderResult"/> containing the Information about the loaded DLLs
	/// </returns>
	/// <remarks>
	///		Class Name is used for named Service in Castle.Windsor
	/// </remarks>
	/// <exception cref="FileNotFoundException">File does not exist</exception>
	/// <exception cref="FileLoadException">Cannot load File</exception>
	/// <exception cref="DriveNotFoundException">Error when accessing DLL(s) from Network Share</exception>
	/// <exception cref="DirectoryNotFoundException">Directory does not exist</exception>
	/// <exception cref="UnauthorizedAccessException">Cannot gain Access to DLL</exception>
	public static IList<WindsorContainerLoaderResult> LoadFiles(this IRuntimeLoader loader, IList<string> files, IKernel kernel)
	{
		throw new NotImplementedException();
	}

	/// <summary>
	///		Loads DLLs into the current AppDomain and injects them into the Castle.Windsor Container<para/>
	///		Used to Inject a Service from inside another Service at Runtime<para/>
	///		Use Service <see cref="IKernel"/> to do that
	/// </summary>
	/// <param name="loader">
	///		Instance of <see cref="IRuntimeLoader"/>
	/// </param>
	/// <param name="directory">
	///		Directory containing DLLs
	/// </param>
	/// <param name="kernel">
	///		Instance of <see cref="IKernel"/>
	/// </param>
	/// <param name="searchPattern">
	///		Search Pattern for DLLs<para/>
	///		Default = *.dll
	/// </param>
	/// <param name="recursive">
	///		Rercursive Search for Files (including Subdirectories)
	/// </param>
	/// <returns>
	///		List of <see cref="WindsorContainerLoaderResult"/> containing the Information about the loaded DLLs
	/// </returns>
	/// <exception cref="FileNotFoundException">File does not exist</exception>
	/// <exception cref="FileLoadException">Cannot load File</exception>
	/// <exception cref="DriveNotFoundException">Error when accessing DLL(s) from Network Share</exception>
	/// <exception cref="DirectoryNotFoundException">Directory does not exist</exception>
	/// <exception cref="UnauthorizedAccessException">Cannot gain Access to DLL</exception>
	public static IList<WindsorContainerLoaderResult> LoadFiles(this IRuntimeLoader loader, string directory, IKernel kernel, string searchPattern = "*.dll", bool recursive = false)
	{
		throw new NotImplementedException();
	}
	#endregion
}