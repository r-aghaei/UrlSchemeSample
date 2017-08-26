# Url Scheme Sample

Some times you want to have a custom URL Scheme like `mailto:` or `skype:` to handle some custom links. To do so, you can [register an application to a URI Scheme][1] in registry and create an application that runns to handle the requests to that url scheme.

This sample is created to handle `myapp:` url scheme and show a message box containing the values that is passed though url to the application.

The sample contains 2 projects:

* A Windows Forms Application that will be installed and will run when a link of "myapp:" protocole is clicked.
* A Visual Studio Setup Project which installs the application and also setup registery settings to let the windows application handle "myapp:" protocole.

## How it works?
I suppose you want to create `myapp` url scheme and having an application in `c:\myapp.exe` which you want to handle the url scheme with your application. Then you should create these keys and values in registry/l


    HKEY_CLASSES_ROOT
       myapp
          (Default) = "URL:myapp"
          URL Protocol = ""
      DefaultIcon
         (Default) = "c:\myapp.exe",0
      shell
         open
            command
               (Default) = "c:\myapp.exe" "%1"

Then you can get the values that pass to the application through the url using `Environment.GetCommandLineArgs()` and parse the arguments.

For example having a url `myapp:Hello world!`, the command line arguments to your application would be `myapp:Hello world!` and yuou can parse it and extract the information that you need from the arguments.

Just as an example you can have some url like this: `myapp:show?form=form1&param1=something`. Then you can parse the comnmand and do what you need.

## FAQ

**1. What is the role of the Windows Forms Application in this project?**  
When the user clicks on a url of the registed scheme, the application will open and the url will be passed the the application as command line argument. Then you can parse the arguments and do what you need.

**2. What's the role if Setup project?**  

It installs the application that handles the url scheme. Also it registers the url scheme in windows registry with suitable values.  
Instead of using an installer projectm, you can create those registery keys and values using C# code as well, but using an installer project is more convinient. If you don't have the Visual Studio 2017 Setup project template, you can download it [here][2].


  [1]: https://msdn.microsoft.com/en-us/library/aa767914(v=vs.85).aspx
  [2]: https://marketplace.visualstudio.com/items?itemName=VisualStudioProductTeam.MicrosoftVisualStudio2017InstallerProjects