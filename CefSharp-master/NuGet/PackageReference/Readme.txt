CefSharp .Net Core/.Net 5.0 Nuget Package

Background:
  CefSharp is a .Net wrapping library for CEF (Chromium Embedded Framework) https://bitbucket.org/chromiumembedded/cef
  CEF is a C/C++ library that allows developers to embed the HTML content rendering strengths of Google's Chrome open source WebKit engine (Chromium).

Post Installation:
  - Read the release notes for your version https://github.com/cefsharp/CefSharp/releases (Any known issues will be listed here)
  - Read the `Need to know/limitations` section of the General usage guide (https://github.com/cefsharp/CefSharp/wiki/General-Usage#need-to-knowlimitations)
  - It is reccommended that you set a RuntimeIdentifier during development, adding the following to your project file will <RuntimeIdentifier Condition="'$(RuntimeIdentifier)' == ''">$(NETCoreSdkRuntimeIdentifier)</RuntimeIdentifier>
  - Check your output `\bin` directory to make sure the appropriate references have been copied.
  - Add an app.manifest to your exe if you don't already have one, it's required for Windows 10 compatability, HighDPI support and tooltips. The   https://github.com/cefsharp/CefSharp.MinimalExample project contains an example app.manifest file in the root of the WPF/WinForms/OffScreen examples. 
  
Deployment:
  - Make sure a minimum of `Visual C++ 2019` is installed (`x86` or x64` depending on your build) or package the runtime dlls with your application, see the FAQ for details.
  
What's New:
  See https://github.com/cefsharp/CefSharp/wiki/ChangeLog

Basic Troubleshooting:
  - Minimum of .Net Core 3.1 (.Net 5.0 is supported)
  - Minimum of `Visual C++ 2019 Redist` is installed (either `x86` or `x64` depending on your application).
  - Please ensure your output directory contains these required dependencies:
    * libcef.dll (CEF code)
    * icudtl.dat (Unicode Support data)
    * CefSharp.Core.dll, CefSharp.dll, CefSharp.Core.Runtime.dll
      CefSharp.BrowserSubprocess.exe, CefSharp.BrowserSubprocess.dll, CefSharp.BrowserSubProcess.Core.dll
        - These are required CefSharp binaries that are the common core logic binaries of CefSharp.
    * One of the following UI presentation approaches:
        * CefSharp.WinForms.dll
        * CefSharp.Wpf.dll
        * CefSharp.OffScreen.dll
  - Additional CEF files are described at: https://github.com/cefsharp/CefSharp/wiki/Output-files-description-table-%28Redistribution%29
    NOTE: CefSharp does not currently support CEF sandboxing.
  - By default `CEF` has it's own log file, `Debug.log` which is located in your executing folder. e.g. `bin`

For further help please read the following content:
  - General Usage Guide https://github.com/cefsharp/CefSharp/wiki/General-Usage
  - Minimal Example Projects showing the browser in action (https://github.com/cefsharp/CefSharp.MinimalExample)
  - CefSharp GitHub https://github.com/cefsharp/CefSharp
  - CefSharp's Wiki on github (https://github.com/cefsharp/CefSharp/wiki)
  - FAQ: https://github.com/cefsharp/CefSharp/wiki/Frequently-asked-questions
  - Troubleshooting guide (https://github.com/cefsharp/CefSharp/wiki/Trouble-Shooting)
  - CefSharp vs Cef (https://github.com/cefsharp/CefSharp/blob/master/CONTRIBUTING.md#cefsharp-vs-cef)
  - Got a CefSharp specific question ask it on https://github.com/cefsharp/CefSharp/discussions
  - Got a general javascript/css/html question ask on https://stackoverflow.com/questions/tagged/cefsharp

Please consider sponsoring the projects development https://github.com/sponsors/amaitland

Regards,
@amaitland and the CefSharp Team
