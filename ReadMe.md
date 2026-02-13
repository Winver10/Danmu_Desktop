# Danmu_Desktop

## What is it

It's an unoffical version of the Project [desk-danmaku-vb](https://github.com/wsrj/desk-danmaku-vb), build on .NET Framework 4.0.

## System Support

.NET Framework 4.0 Support Windows Vista and later version, and I develop it on Windows 7. So it suppot Windows 7 and later.

## How to compile it

### Check enviroment

**If you are using Windows 8.1 or older version of Windows**

You can search ".NET Framework 4.0 Developer Package", and download, install it. 

**If you are using Windows 10 or later version of Windows**

You already have .NET Framework 4.8. Open contral panle, choose "Program and Feature", enble the ".NET Framwork 4.8".

Then, you need add this after you .csproj:

```csproj
<ItemGroup>
    <PackageReference Include="Microsoft.NETFramwork.ReferenceAssembles.net40" Version="1.0.3">
        <PrivateAssets>all</PrivateAssets>
    </PackageReference>
</ItemGroup>
```

### Compile it

Open your MSBuild (32bit often in "C:\Windows\Microsoft.NET\Framework", 64bit often in "C:\Windows\Microsoft.NET\Framework64") in your terminal. 

Then, use this command to load the NuGet package. If you are using Windows 8.1 or older, you needn't this command.

```cmd
.\msbuild <the .csproj file path> /t:restroe
```

Then use this to release the project
```cmd
.\msbuild <the .csproj file path> /p:Configuration=Release /p:Platform=<x86 or x64>
```
If sucesse, you will find the .exe under the project dir.
