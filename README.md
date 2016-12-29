CloudScanner
=========
version 1.0

Introduction
-----------

CloudScanner is developed with Dynamic .NET TWAIN SDK and other cloud APIs. It allowes users to scan documents and upload captured images to cloud service.

Prerequisites
-----------

* Download [Dynamic .NET TWAIN SDK][1].
* Download [virtual scanner][2] if there is no real scanner connected.

Features
--------------

* Support Google Drive


How to Build Project
--------------
* Run Package Manager Console, and type in ```Install-Package Google.Apis.Drive.v2``` to install Drive API NuGet package in Visual Studio.
* Build project.

Blog
----
[How to Upload Scanned Images to Google Drive With Dynamic .NET TWAIN][3]


[1]:https://www.dynamsoft.com/Secure/Register_ClientInfo.aspx?productName=NetTWAIN&from=FromDownload
[2]:http://www.dynamsoft.com/demo/DWT/Sources/twainds.win64.installer.2.1.3.msi
[3]:http://www.codepool.biz/how-to-upload-scanned-images-to-google-drive-with-dynamic-net-twain.html
