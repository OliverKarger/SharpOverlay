namespace SharpOverlay.ExternalModule;

/// <summary>
///		Interface for all external loadable Modules
/// </summary>
public interface IExternalModule : IDisposable
{
	/// <summary>
	///		Initializes the Module. Seperate from Constrcutor to allow for the Module to be loaded without being initialized
	/// </summary>
	public void Init();

	/// <summary>
	///		Called everytime the UI needs to be updated
	/// </summary>
	public void UpdateUI();
}