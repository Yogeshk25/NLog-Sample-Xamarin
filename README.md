# NLog Sample Xamarin
This project demonstrates, how to setup NLog in a Xamarin.Forms project

# Step 1:
Create a blank xamarin.Form project

# Step 2:
Install [NLog.Config](https://www.nuget.org/packages/NLog.Config/)  nuget in all projects in solution

# Step 3:
Add NLog.config file to your platform specific projects (Android/iOS/UWP etc.)

#### For Android:
Add **NLog.config** in Assests folder of android project. Make sure it's Build Action is set to AndroidAsset.

#### For iOS:
Add **NLog.config** in root folder of iOS project. Make sure it's Build Action is set to Content.

Write logging configration rules and target in this file as show below. For more details about rules and targets check official [ducumentation](https://github.com/NLog/NLog/wiki/Tutorial)
```XML
<?xml version="1.0" encoding="utf-8" ?>
<nlog xmlns="http://www.nlog-project.org/schemas/NLog.xsd"
      xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">

    <targets>
        <target name="logfile" xsi:type="File" fileName="file.txt" />
        <target name="logconsole" xsi:type="Console" />
    </targets>

    <rules>
        <logger name="*" minlevel="Info" writeTo="logconsole" />
        <logger name="*" minlevel="Debug" writeTo="logfile" />
    </rules>
</nlog>
```
