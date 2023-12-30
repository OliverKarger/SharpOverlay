namespace SharpOverlay.Runtime.Interfaces.Services;

/// <summary>
///		Interface for access the external Compiler<para/>
///		Used to Compile Source Files without loading the Compiler/Assemblies into the current AppDomain<para/>
/// </summary>
public interface IRemoteCompiler : IDisposable { }