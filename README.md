# TutorialFPSRotation

<p align="center"><img src="https://imgur.com/wwpRdfA.png"></p>

<p align="center"><a href="https://youtu.be/hsoJLJ22GVA" target="_blank"><img src="https://imgur.com/p2XtmNe.png"></a></p>

### Introduction:
A tutorial on how to get smooth first person rotation in Unity3D. While making a first person view game you will notice mainly in the build game that when you rotate the camera the game stutters/jitters a lot which gets noticable when circuling around an object. In this tutorial I am showing one of a way to fix that. Watch my [Video](https://youtu.be/hsoJLJ22GVA) to get a detailed understanding of the issue, the cause of the issue and the solution to the issue. If my solution doesn't work then I have linked to other sources in [Research Links](#research-links) that fixes this issue using other means.

## Table of Contents:
- [Prerequisites](#prerequisites)
- [Stable Build](#stable-build)
- [Main Scripts](#main-scripts)
  - [PlayerRotate](#playerrotate)
  - [PlayerRotateSmooth](#playerrotatesmooth)
- [Jump Feature](#jump-feature)
- [Research Links](#research-links)
- [Authors](#authors)
- [License](#license)
***
## Prerequisites
#### Unity Game Engine
Unity Version used for this tutorial is **2020.3.3f1**.
***
## Stable Build
[Stable Build - main](https://github.com/deadlykam/TutorialFPSRotation) is the stable version of the tutorial and is similar to the one shown in the [Video](https://youtu.be/hsoJLJ22GVA)
***
## Main Scripts
The main scripts for solving this issue are [PlayerRotate](https://github.com/deadlykam/TutorialFPSRotation/blob/20c94069f25b51205404a644a49f7b378506668e/TutorialFPSRotation/Assets/TutorialFPSRotation/Scripts/PlayerRotate.cs) and [PlayerRotateSmooth](https://github.com/deadlykam/TutorialFPSRotation/blob/20c94069f25b51205404a644a49f7b378506668e/TutorialFPSRotation/Assets/TutorialFPSRotation/Scripts/PlayerRotateSmooth.cs). Both of these scripts are needed to solve the issue.
#### _[PlayerRotate](https://github.com/deadlykam/TutorialFPSRotation/blob/20c94069f25b51205404a644a49f7b378506668e/TutorialFPSRotation/Assets/TutorialFPSRotation/Scripts/PlayerRotate.cs):_
This script rotates the player and camera normally. Using this script will show the rotation is smooth in the editor but NOT in the build game. From my research the reason is because of VSync which lowers the fps of the game to the monitor refresh rate which in my case was 60fps because my monitor refresh rate is 60Hz.
#### _[PlayerRotateSmooth](https://github.com/deadlykam/TutorialFPSRotation/blob/20c94069f25b51205404a644a49f7b378506668e/TutorialFPSRotation/Assets/TutorialFPSRotation/Scripts/PlayerRotateSmooth.cs):_
This script fixes the stuttering issue caused by VSync in the build game. The camera rotates smoothly. Using this script in the editor will make the rotation very very slow. It is adviced to use the [PlayerRotate](https://github.com/deadlykam/TutorialFPSRotation/blob/20c94069f25b51205404a644a49f7b378506668e/TutorialFPSRotation/Assets/TutorialFPSRotation/Scripts/PlayerRotate.cs) script when testing in the editor.
***
#### Jump Feature
Added jump feature. Now the player will be able to jump as well. I have set up the project that allows the player to jump. You can open the project and see it. I am also giving brief explanation as well so that it will help you to understand.

Ok, the first part you need to do is create a new Layer called "Ground".
<div align="center"><img src="https://imgur.com/2zJi5RB.png" style="width:50%;height:50%;"></div>

Then you need to select the ground model called "Plane", which is found inside environment, and then change its Layer to "Ground". Make sure in your project the ground model has a collider attached to it. In this project the collider is "Mesh Collider" but it can be any collider as long as it is attached.
<div align="center"><img src="https://imgur.com/IcadiRK.png" style="width:50%;height:50%;"></div>

Now select the "Player" model. Attach the new script called "[GroundDetector](https://github.com/deadlykam/TutorialFPSRotation/blob/a5e1f0041ccbbaa95b0366f8a8e4bcf9048693bc/TutorialFPSRotation/Assets/TutorialFPSRotation/Scripts/GroundDetector.cs)" to the player model. Drag and drop the added "GroundDetector" script into the Collider field in "PlayerMove" script. Set values as shown in the image below.
<div align="center"><img src="https://imgur.com/c14SX4S.png" style="width:50%;height:50%;"></div>


Let me briefly explain what each field does starting from "PlayerMove.cs"
1. _Speed Jump_: How high the player will jump. The higher the value the more high the player will jump and MUST be positive. In this case I gave the value to 3.
2. _Gravity_: The gravity that will effect the player. The lower the gravity value the higher its effect. So gravity value -1 will be weaker than gravity value -2. The value of the gravity MUST be negative. In this case I gave the value to -19.62.
3. _Collider_: The script that detects for ground collisions which is the [GroundDetector.cs](https://github.com/deadlykam/TutorialFPSRotation/blob/a5e1f0041ccbbaa95b0366f8a8e4bcf9048693bc/TutorialFPSRotation/Assets/TutorialFPSRotation/Scripts/GroundDetector.cs) script. In this case the GroundDetector script is attached to the "Player" model. So just drag and drop the "Player" model into this field.

Now lets explain the "[GroundDetector.cs](https://github.com/deadlykam/TutorialFPSRotation/blob/a5e1f0041ccbbaa95b0366f8a8e4bcf9048693bc/TutorialFPSRotation/Assets/TutorialFPSRotation/Scripts/GroundDetector.cs)"
1. _Offset_: The point from which the physical sphere will be generated. Everything 0 means the sphere will be generated from the pivot point. Make sure to change the value in such a way that the physical sphere is generated at the feet of the player. In this case it is all 0 because the pivot point and the feet point are at the same position.
2. _Radius_: The radius of physical sphere. The higher the value the bigger the sphere. Usually you want to keep this value low because the feet of the player aren't usually big. But if you create huge giant objects that requires more area to detect the ground then increase this value. The value should also be positive. In my case the value is 0.4.
3. _Detect Layers_: This is the layer mask that the physical sphere will detect. The more layers you add the more layers it will detect. For example if you want the player to stand on enemies as well then create a new enemy layer and select that layer as well. In my case the layer mask is only "Ground" layer.

That is all from the Jump feature. Hope it helps :)
***
## Research Links
- [(Video) Unite 2016 - Tools, Tricks and Technologies for Reaching Stutter Free 60 FPS in INSIDE](https://www.youtube.com/watch?v=mQ2KTRn4BMI)
- [(Video) Brackeys - FIRST PERSON MOVEMENT in Unity - FPS Controller](https://www.youtube.com/watch?v=_QajrabyTJc)
- [(Video) SpeedTutor - FREE FPS Character Controller for UNITY 2020!](https://www.youtube.com/watch?v=LeFi2qKIzp4)
- [(Video) Magic Monk - Unity 2018.2 First Person Adventure Game Tutorial 4 - Mouse movement, camera & player rotation](https://www.youtube.com/watch?v=BzBIK4_WSJY)
- [(Video) Ned Makes Games - Setting Up a Smooth Mouse Look Camera Controller Script in Unity ✔️ 2020.3 | Game Dev Tutorial](https://www.youtube.com/watch?v=Coch-PkHY54)
- [(Blog) Nothke's Dev blog - How to Cope with Standard Unity FPS Controller](http://nothkedev.blogspot.com/2017/11/how-to-cope-with-standard-unity-fps.html)
- [(Blog) IronEqual - Unity: CHARACTER CONTROLLER vs RIGIDBODY](https://medium.com/ironequal/unity-character-controller-vs-rigidbody-a1e243591483)
- [(Unity Blog) Tautvydas Žilys - Fixing Time.deltaTime in Unity 2020.2 for smoother gameplay: What did it take?](https://blogs.unity3d.com/2020/10/01/fixing-time-deltatime-in-unity-2020-2-for-smoother-gameplay-what-did-it-take/)
***
## Authors
- Syed Shaiyan Kamran Waliullah 
  - [Kamran Wali Github](https://github.com/deadlykam)
  - [Kamran Wali Twitter](https://twitter.com/KamranWaliDev)
  - [Kamran Wali Youtube](https://www.youtube.com/channel/UCkm-BgvswLViigPWrMo8pjg)
  - [Kamran Wali Website](https://deadlykam.github.io/)
***
## License
This project is licensed under the MIT License - see the [LICENSE.md](LICENSE) file for details.
***
