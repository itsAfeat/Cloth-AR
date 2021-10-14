; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Cloth-AR"
#define MyAppVersion "0.9"
#define MyAppPublisher "Alexander Wiencken"
#define MyAppURL "https://github.com/itsAfeat/Cloth-AR/releases"
#define MyAppExeName "Clother.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{B93C8F81-E377-41EF-BC1C-82519ACFBFE0}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DisableProgramGroupPage=yes
OutputDir=C:\Users\StankyDanky\Desktop
OutputBaseFilename=ClothSetup
SetupIconFile=C:\Users\StankyDanky\Desktop\install.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "brazilianportuguese"; MessagesFile: "compiler:Languages\BrazilianPortuguese.isl"
Name: "catalan"; MessagesFile: "compiler:Languages\Catalan.isl"
Name: "corsican"; MessagesFile: "compiler:Languages\Corsican.isl"
Name: "czech"; MessagesFile: "compiler:Languages\Czech.isl"
Name: "danish"; MessagesFile: "compiler:Languages\Danish.isl"
Name: "dutch"; MessagesFile: "compiler:Languages\Dutch.isl"
Name: "finnish"; MessagesFile: "compiler:Languages\Finnish.isl"
Name: "french"; MessagesFile: "compiler:Languages\French.isl"
Name: "german"; MessagesFile: "compiler:Languages\German.isl"
Name: "greek"; MessagesFile: "compiler:Languages\Greek.isl"
Name: "hebrew"; MessagesFile: "compiler:Languages\Hebrew.isl"
Name: "hungarian"; MessagesFile: "compiler:Languages\Hungarian.isl"
Name: "italian"; MessagesFile: "compiler:Languages\Italian.isl"
Name: "japanese"; MessagesFile: "compiler:Languages\Japanese.isl"
Name: "norwegian"; MessagesFile: "compiler:Languages\Norwegian.isl"
Name: "polish"; MessagesFile: "compiler:Languages\Polish.isl"
Name: "portuguese"; MessagesFile: "compiler:Languages\Portuguese.isl"
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"
Name: "scottishgaelic"; MessagesFile: "compiler:Languages\ScottishGaelic.isl"
Name: "serbiancyrillic"; MessagesFile: "compiler:Languages\SerbianCyrillic.isl"
Name: "serbianlatin"; MessagesFile: "compiler:Languages\SerbianLatin.isl"
Name: "slovenian"; MessagesFile: "compiler:Languages\Slovenian.isl"
Name: "spanish"; MessagesFile: "compiler:Languages\Spanish.isl"
Name: "turkish"; MessagesFile: "compiler:Languages\Turkish.isl"
Name: "ukrainian"; MessagesFile: "compiler:Languages\Ukrainian.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\StankyDanky\Dropbox\10.I stuff\Clother\Clother\bin\Debug\Clother.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\StankyDanky\Dropbox\10.I stuff\Clother\Clother\bin\Debug\bomb.png"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\StankyDanky\Dropbox\10.I stuff\Clother\Clother\bin\Debug\Clother.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\StankyDanky\Dropbox\10.I stuff\Clother\Clother\bin\Debug\Clother.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\StankyDanky\Dropbox\10.I stuff\Clother\Clother\bin\Debug\Emgu.CV.UI.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\StankyDanky\Dropbox\10.I stuff\Clother\Clother\bin\Debug\Emgu.CV.UI.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\StankyDanky\Dropbox\10.I stuff\Clother\Clother\bin\Debug\Emgu.CV.World.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\StankyDanky\Dropbox\10.I stuff\Clother\Clother\bin\Debug\Emgu.CV.World.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\StankyDanky\Dropbox\10.I stuff\Clother\Clother\bin\Debug\Fonte.png"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\StankyDanky\Dropbox\10.I stuff\Clother\Clother\bin\Debug\haarcascade_frontalface_default.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\StankyDanky\Dropbox\10.I stuff\Clother\Clother\bin\Debug\Kuro.png"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\StankyDanky\Dropbox\10.I stuff\Clother\Clother\bin\Debug\xxx.png"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\StankyDanky\Dropbox\10.I stuff\Clother\Clother\bin\Debug\ZedGraph.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\StankyDanky\Dropbox\10.I stuff\Clother\Clother\bin\Debug\ZedGraph.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\StankyDanky\Dropbox\10.I stuff\Clother\Clother\bin\Debug\x86\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "C:\Users\StankyDanky\Dropbox\10.I stuff\Clother\Clother\bin\Debug\x64\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{commonprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

