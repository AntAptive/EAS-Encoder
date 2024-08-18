![EAS Encoder](/EASEncoderBanner.png)

# EAS Encoder
Encode EAS audio messages with valid SAME headers!
### [Check out my other projects!](https://antaptive.com/projects/)
## Features
* Encode EAS (Emergency Alert System - United States) audio messages with valid SAME (Specific Area Message Encoding) headers
* EBS (Emergency Broadcast System) attention tones
* NWS (National Weather Service) attention tones
* Spoken announcement synthesized with any installed Microsoft SAPI TTS voice
* Generate messages to .wav or .mp3
* Preview messages via MemoryStream
* Save configuration data for later

## Credits
* Main developer - [Sasquelch](https://github.com/sasquelch)
* Secondary developer - [AntAptive](https://antaptive.com)
* Contributor - [jemerson722](https://github.com/jemerson722)
* Contributor - [k2fc](https://github.com/k2fc)

## How is this fork different?
The original repo is owned by [Sasquelch](https://github.com/sasquelch). I (AntAptive) provided a massive quality-of-life update that I thought would be too big and overtaking for a pull request, so I kept the two projects seperate.

[See below](https://github.com/AntAptive/EAS-Encoder#fork-differences) for a full list of differences between this fork and the original repo.

**If Sasquelch would like me to make a pull request or delete this repository entirely, please contact me through one of my socials on [my website](https://antaptive.com) (https://antaptive.com)!**

## How to install
1. Check our [Releases page](https://github.com/AntAptive/EAS-Encoder/releases) to download the latest release.
2. Pick between the installer (.exe) or portable (.zip) version to install.
### For the installer...
3. Simply open the installer and install to a location of your choice.
4. Open EAS Encoder from the Start menu or from your desktop if you made an icon.
* EAS Encoder can be uninstalled from your Control Panel.
### For the portable version...
3. Extract the .zip file anywhere you want.
4. Run the file `EAS Encoder Test App.exe`.

## How to run in Visual Studio
- Download the Source Code zip.
- Use Visual Studio 2022.
- Ensure all NuGet packages are installed and up-to-date.
- Set "EASEncoder Test App" to the startup project.
1. In Solution Explorer, highlight the "EASEncoder Test App" project and right-click it.
2. In the popup menu. click "Set As Startup Project"

## Fork Differences
### Bug Fixes
* Fixed deleted event locations not updating the list
### Tweaks
* Major UI enhancements
* Raised .MP3 encoding bitrate from ABR_32 to VBR_90
* Capped Sender ID textbox to 8 characters
* Changed Hour and Minute dropdowns to number boxes
* Selecting a state now automatically selects the first option in the county list
* Moved "Open file location after generating" tickbox to the "Save As" dialog
### Additions
* Added support for any SAPI TTS voice the user has installed
* Added speech rate (speed) slider
* Added option to enable or disable speech
* Added "About" page with credits to the original programmers and beta testers
* Added save configuration system with the option to reset everything
* Added "Set Date & Time to Right Now" button
* Added "Save As" dialog when generating an EAS

## How to fix configuration file error
This is because you have a configuration file for an older version of EAS Encoder. If EAS Encoder fails to delete the files itself, they will need to be removed manually.
1. Close EAS Encoder
2. Press Windows + R to open the Run dialog and type `%localappdata%`. Press Enter
3. Locate the folder titled `Joe_Goldade`
4. Within this folder, delete every folder starting with the name `EASEncoder_Test_App.exe`
5. Restart EAS Encoder
* Still running into issues? Contact [AntAptive](https://antaptive.com) for more assistance.
