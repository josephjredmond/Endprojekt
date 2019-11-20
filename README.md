## Endprojekt

#### Requirements
Create a room in VR based on the Inctober List from 2019 (you can use one or more words from this list).
+	Move inside the Room
+	Grab and Move Objects
+	Solve a Mystery
+	Have sounds inside the Game
+	animated Globe (it can be any round object as long as it is able to spin and rotate)

#### Data:
+ Development Platforms: Windows 8.1 / Unity Version 2019.1.14f1 / Visual Studio Code
+ Target Platform: Android Version 9
+ Reference Resolution:
+ Third Party Material: Asset Store 3D Models
+ Copyright sresl

#### Progress:
###### 06.11.2019
+ Installing Android SDK and importing it into Unity
+ added developer options on Android Phone and enabled 'USB debugging'
+ Updating README and adding more Details
+ Adding and updating Kanban Board
+ informing myself about the use of a Cardboard in relation to VR

###### 08.11.2019
+ Demo Scene finally worked on Android (adb failed before and sdk was not binded right)
+ My Scene worked on Android (adb failed before)
+ Moved Project into another File -> Scene is now in monoscopic View and adb failes again
+ learned about branches

###### 09.11.2019
+ fixed the Problem with the adb Server by copying the adb files in 'platform-tools' from 'AppData' to the SDK Ordner in Unity
+ fixed Monoscopic view by updating GoogleVR

###### 13.11.2019
+ made a second branch 'Modelling'
+ downloaded and imported assets from the asset store to use in my Project
+ tried to make a Waypoint by using the scripts from the GoogleVR Demo Scenes but it didn't work
+ tried to make an Object dissapear when clicked on by using the scripts from the GoogleVR Demo Scenes but it didn't work

#### Used Websites/Tutorials:
+ https://developers.google.com/vr/develop/unity/get-started-android
+ https://docs.unity3d.com/Manual/android-sdksetup.html
+ https://github.com/googlevr/gvr-unity-sdk
+ https://de.slideshare.net/marknb00/building-vr-applications-for-google-cardboard
