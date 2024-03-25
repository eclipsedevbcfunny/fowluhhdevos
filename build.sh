cd fowlOS/fowlOS.x86
dotnet build
cd bin
dotnet Tools/Mosa.Tool.Launcher.Console.dll -autostart -oMax -vmware-svga -include ../../fowlOS/include fowlOS.x86.dll