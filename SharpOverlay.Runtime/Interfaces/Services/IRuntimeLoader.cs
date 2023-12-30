using SharpOverlay.Runtime.Types;

namespace SharpOverlay.Runtime.Interfaces.Services;

/// <summary>
///		Interface for load external DLLs at Runtime
/// </summary>
public interface IRuntimeLoader : IDisposable
{
	/// <summary>
	///    Loads a DLL into the current AppDomain
	/// </summary>
	/// <param name="file">
	///		Path to DLL
	/// </param>
	/// <returns>
	///		<see cref="LoaderResult"/> containing the Information about the loaded DLL
	/// </returns>
	/// <exception cref="FileNotFoundException">File does not exist</exception>
	/// <exception cref="FileLoadException">Cannot load File</exception>
	/// <exception cref="DriveNotFoundException">Error when accessing DLL(s) from Network Share</exception>
	/// <exception cref="DirectoryNotFoundException">Directory does not exist</exception>
	/// <exception cref="UnauthorizedAccessException">Cannot gain Access to DLL</exception>
	public LoaderResult LoadFile(string file);

	/// <summary>
	///		Loads DLLs into the current AppDomain
	/// </summary>
	/// <param name="files">
	///		List of DLLs to Load
	/// </param>
	/// <returns>
	///		List of <see cref="LoaderResult"/> containing the Information about the loaded DLLs
	/// </returns>
	/// <exception cref="FileNotFoundException">File does not exist</exception>
	/// <exception cref="FileLoadException">Cannot load File</exception>
	/// <exception cref="DriveNotFoundException">Error when accessing DLL(s) from Network Share</exception>
	/// <exception cref="DirectoryNotFoundException">Directory does not exist</exception>
	/// <exception cref="UnauthorizedAccessException">Cannot gain Access to DLL</exception>
	public IList<LoaderResult> LoadFiles(IList<string> files);

	/// <summary>
	///   Loads DLLs into the current AppDomain
	/// </summary>
	/// <param name="directory">
	///		Path to Directory containing DLLs
	/// </param>
	/// <param name="searchPattern">
	///		File Search Pattern<para/>
	///		Default = *.dll
	/// </param>
	/// <param name="recursive">
	///		Search for Files recursive (including Subdirectories)
	/// </param>
	/// <returns>
	///		List of <see cref="LoaderResult"/> containing the Information about the loaded DLLs
	/// </returns>
	/// <exception cref="FileNotFoundException">File does not exist</exception>
	/// <exception cref="FileLoadException">Cannot load File</exception>
	/// <exception cref="DriveNotFoundException">Error when accessing DLL(s) from Network Share</exception>
	/// <exception cref="DirectoryNotFoundException">Directory does not exist</exception>
	/// <exception cref="UnauthorizedAccessException">Cannot gain Access to DLL</exception>
	public IList<LoaderResult> LoadFiles(string directory, string searchPattern = "*.dll", bool recursive = false);
}
