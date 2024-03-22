# Getting Started with Xamarin Radial Menu (SfRadialMenu)

This section explains the steps required to launch the radial menu with hierarchical items that can be used as mobile phone system settings. This section covers only the minimal features that needed to get started with the radial menu.

## Adding SfRadialMenu reference
You can add SfRadialMenu reference using one of the following methods:

### Method 1: Adding SfRadialMenu reference from nuget.org

Syncfusion Xamarin components are available in nuget.org. To add SfRadialMenu to your project, open the NuGet package manager in Visual Studio, search for Syncfusion.Xamarin.SfRadialMenu, and then install it.

### Method 2: Adding SfRadialMenu reference from toolbox

Syncfusion also provides Xamarin Toolbox. Using this toolbox, you can drag the SfRadialMenu control to the XAML page. It will automatically install the required NuGet packages and add the namespace to the page. To install Syncfusion Xamarin Toolbox, refer to Toolbox.

### Method 3: Adding SfRadialMenu assemblies manually from the installed location

If you prefer to manually reference the assemblies instead referencing from NuGet, add the following assemblies in respective projects.

## Creating a simple radial menu
The SfRadialMenu control is configured entirely in C# code or in XAML markup. The following steps explain how to create SfRadialMenu and configure its elements:

### Create the project
Create a new BlankApp (Xamarin.Forms.Portable) application in Xamarin Studio or Visual Studio for Xamarin.Forms.

### Adding radial menu in Xamarin.Forms
*   Add the required assembly references to the pcl and renderer projects.

*   Add namespace for the referred assemblies.

**[XAML]**
```
xmlns:radialMenu="clr-namespace:Syncfusion.SfRadialMenu.XForms;assembly=Syncfusion.SfRadialMenu.XForms"
```
Set the radial menu control as content to the ContentPage.

**[XAML]**

```
 <ContentPage.Content>
        <radialMenu:SfRadialMenu x:Name="radialMenu"/>
 </ContentPage.Content>
```
### Adding radial menu with items

**[XAML]**
```
  <radialMenu:SfRadialMenu x:Name="radialMenu" 
                             CenterButtonText="Edit"
                             CenterButtonFontSize="15">
        <radialMenu:SfRadialMenu.Items>
            <radialMenu:SfRadialMenuItem Text="Cut"
                                         FontSize="15"/>
            <radialMenu:SfRadialMenuItem Text="Copy"
                                         FontSize="15"/>
            <radialMenu:SfRadialMenuItem Text="Paste"
                                         FontSize="15"/>
            <radialMenu:SfRadialMenuItem Text="Crop"
                                         FontSize="15"/>
            <radialMenu:SfRadialMenuItem Text="Paint"
                                         FontSize="15"/>
        </radialMenu:SfRadialMenu.Items>
    </radialMenu:SfRadialMenu>
```

### CenterButtonText and CenterButtonBackText
The CenterButtonText changes the text of the center button in SfRadialMenu, and the CenterButtonBackText changes the text of the center back button in SfRadialMenu.

**[XAML]**
```
<radialMenu:SfRadialMenu CenterButtonText="&#xe700;"
                             CenterButtonBackText="&#xe72b;">
        <radialMenu:SfRadialMenu.Items>
            <radialMenu:SfRadialMenuItem Text="Bold" FontSize="12"/>
            <radialMenu:SfRadialMenuItem Text="Copy" FontSize="12"/>
            <radialMenu:SfRadialMenuItem Text="Undo" FontSize="12"/>
            <radialMenu:SfRadialMenuItem Text="Paste" FontSize="12"/>
            <radialMenu:SfRadialMenuItem Text="Color" FontSize="12"/>
        </radialMenu:SfRadialMenu.Items>
    </radialMenu:SfRadialMenu>
</ContentPage>
```
## How to run this application?

To run this application, you need to first clone the how-to-add-busyIndicator-to-sfradialmenu-centerbutton-in-xamarin.android repository and then open it in Visual Studio 2022. Now, simply build and run your project to view the output.

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.