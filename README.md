# Shadow2hel's Workshop Publisher
Hello everyone! This is officially my first project that I've released to the public.
This program is only used for managing addons from Garry's Mod. There's already another program called [gmpu](https://sourceforge.net/projects/garrysmodpublishtool/), but I found this application lacking in certain areas. I decided to improve upon this program, which is why if you run the program you'll notice the layout is exactly the same, and that's intentional.

## Getting started
You can go ahead and download the entire directory and open the .sln link using Visual Studio.
After that it's all up to you!

### Prerequisites
* Visual Studio Community

## Built with
* [Newtonsoft](https://www.newtonsoft.com/json) used for json stuff
* .NET Framework 4.5
* Dcsoup for gathering data from the steam workshop
```
Run this in package manager:
PM> Install-Package dcsoup
```
* WindowsAPICodePack for the CommonOpenFileDialog class
```
Run this in package manager:
PM> Install-Package WindowsAPICodePack-Core -Version 1.1.2
    Install-Package WindowsAPICodePack-Shell
    Install-Package WindowsAPICodePack-ShellExtensions
``` 
## License
This project is licensed under the MIT License - see the LICENSE.md file for details.
The line located in WorkshopPublisherForm/Form1.cs at line 277 is licensed under the MIT License of the original creator - see the LICENSE.DCSOUP.md file for details.
