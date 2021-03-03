#requires -Version 5

# Update projects files
# I haven't found a clean solution that allows for using just nuget.exe and dotnet.exe to do this
# Update the vcxproj files first
# Update the .Net 4.5.2 csproj files using nuget.exe
# Update the .Net Core csproj files modifying the xml file directly

function RemoveEnsureNuGetPackageBuildImports
{
    param([Parameter(Position = 0, ValueFromPipeline = $true)][string] $FileName)

    $xml = [xml](Get-Content $FileName)
	$target = $xml.Project.Target | Where-Object {$_."Name" -eq "EnsureNuGetPackageBuildImports"}
	
	if($target -ne $null)
	{
		$target.ParentNode.RemoveChild($target)

		$xml.Save( $FileName )
	}
}

$vcxprojFiles = @('CefSharp.Core\CefSharp.Core.vcxproj','CefSharp.BrowserSubprocess.Core\CefSharp.BrowserSubprocess.Core.vcxproj')

foreach($file in $vcxprojFiles)
{
	..\nuget update $file -Id cef.sdk	
	
	RemoveEnsureNuGetPackageBuildImports (Resolve-Path $file)
}

$vcxprojFiles = @('CefSharp.Core\CefSharp.Core.netcore.vcxproj', 'CefSharp.BrowserSubprocess.Core\CefSharp.BrowserSubprocess.Core.netcore.vcxproj')

foreach($file in $vcxprojFiles)
{
	..\nuget update $file -Id cef.sdk	
	
	RemoveEnsureNuGetPackageBuildImports (Resolve-Path $file)
}

$csprojFiles = @('CefSharp.WinForms.Example\CefSharp.WinForms.Example.csproj','CefSharp.Wpf.Example\CefSharp.Wpf.Example.csproj','CefSharp.OffScreen.Example\CefSharp.OffScreen.Example.csproj', 'CefSharp.Test\CefSharp.Test.csproj')

foreach($file in $csprojFiles)
{
	..\nuget update $file -Id cef.redist.x64 -Id cef.redist.x86
	
	RemoveEnsureNuGetPackageBuildImports (Resolve-Path $file)
}

#Read the newly updated version number from the packages.CefSharp.Core.config

$CefSharpCorePackagesXml = [xml](Get-Content (Resolve-Path 'CefSharp.Core\packages.CefSharp.Core.config'))
$RedistVersion = $CefSharpCorePackagesXml.SelectSingleNode("//packages/package[@id='cef.sdk']/@version").value

$netcorecsprojFiles = @('CefSharp.WinForms.Example\CefSharp.WinForms.Example.netcore.csproj','CefSharp.Wpf.Example\CefSharp.Wpf.Example.netcore.csproj','CefSharp.OffScreen.Example\CefSharp.OffScreen.Example.netcore.csproj', 'CefSharp.Test\CefSharp.Test.netcore.csproj')

#Loop through the net core projects and update the package version number

foreach($file in $netcorecsprojFiles)
{
    $file = Resolve-Path $file
	$xml = New-Object xml
	$xml.PreserveWhitespace = $true
	$xml.Load($file)
	
	$packRefx86 = $xml.Project.ItemGroup.PackageReference | Where-Object {$_."Include" -eq "cef.redist.x86"}
	$packRefx64 = $xml.Project.ItemGroup.PackageReference | Where-Object {$_."Include" -eq "cef.redist.x64"}
	
	$packRefx86.Version = $RedistVersion
	$packRefx64.Version = $RedistVersion
	
	$xml.Save( $file )
}