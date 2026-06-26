[Setup]
AppName=FYP Management System
AppVersion=1.0
DefaultDirName={autopf}\FYPManagementSystem
DefaultGroupName=FYP Management System
UninstallDisplayIcon={app}\logo.ico
SetupIconFile=d:\Career\FYP System with database - advance oop\FYPManagementSystem\logo.ico
OutputDir=d:\Career\FYP System with database - advance oop\FYPManagementSystem\Output
OutputBaseFilename=FYPManagementSystemSetup
Compression=lzma2
SolidCompression=yes
ArchitecturesInstallIn64BitMode=x64

[Files]
Source: "d:\Career\FYP System with database - advance oop\FYPManagementSystem\FYPManagementSystem\bin\Debug\FYPManagementSystem.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "d:\Career\FYP System with database - advance oop\FYPManagementSystem\FYPManagementSystem\bin\Debug\*.dll"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "d:\Career\FYP System with database - advance oop\FYPManagementSystem\FYPManagementSystem\bin\Debug\FYPManagementSystem.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "d:\Career\FYP System with database - advance oop\FYPManagementSystem\FYPManagementSystem\bin\Debug\SqlServerTypes\*"; DestDir: "{app}\SqlServerTypes"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "d:\Career\FYP System with database - advance oop\FYPManagementSystem\FYPManagementSystem\DL\CleanFiles\*"; DestDir: "{app}\DL\Files"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "d:\Career\FYP System with database - advance oop\FYPManagementSystem\logo.ico"; DestDir: "{app}"; Flags: ignoreversion

[Icons]
Name: "{group}\FYP Management System"; Filename: "{app}\FYPManagementSystem.exe"; IconFilename: "{app}\logo.ico"
Name: "{autodesktop}\FYP Management System"; Filename: "{app}\FYPManagementSystem.exe"; IconFilename: "{app}\logo.ico"

[Run]
Filename: "{app}\FYPManagementSystem.exe"; Description: "Launch FYP Management System"; Flags: nowait postinstall skipifsilent
