# ter.exe
Small exe project that runs the new [Windows Terminal](https://www.microsoft.com/en-us/p/windows-terminal-preview/9n0dx20hk701) in the current directory this exe is started at

## Why?
Lazy workaround for [this issue](https://github.com/microsoft/terminal/issues/4581)

## Downloading

Download the latest [ter.exe](https://github.com/sharunkumar/ter/releases/latest/download/ter.exe)

## Building

1. Clone the project: ```git clone https://github.com/sharunkumar/terminal.git```
2. Open terminal.sln in Visual Studio
3. F5 to build the exe. `ter.exe` will be available at
  `<path-to-repo>\bin\Debug`
  
## Usage

1. Copy `ter.exe` to `C:\Users\<username>\AppData\Local\Microsoft\WindowsApps\`.
  If you have [Windows Terminal](https://www.microsoft.com/en-us/p/windows-terminal-preview/9n0dx20hk701) installed, there would be a wt.exe in this same folder
2. Now you can launch wt.exe by typing `ter` in the address bar in Windows Explorer and windows terminal would open with the same folder that you are currently in.

Note: You would need to add `%USERPROFILE%\AppData\Local\Microsoft\WindowsApps` to your PATH evnironment variable.
