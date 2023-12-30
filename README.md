# SharpOverlay

Library/Application for drawing Overlay onto a User' Desktop

## How it works
The Application itself uses ImGui.NET with Veldrid/SDL as Backend.<br>
All DLLs containing classes that implement `IExternalModule` from `SharpOverlay.ExternalModule` will be loaded<br>
at Runtime. These are User-made Classes/Methods that can be used to draw stuff.
<br>
These can either be pre-compiled or compiled at Runtime by the Application using `Westwind.Scripting`.
<br>
Dependency Injection with `Castle.Windsor` is used.
