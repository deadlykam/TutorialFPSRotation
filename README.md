# TutorialFPSRotation

### Introduction:
A tutorial on how to get smooth first person rotation in Unity3D. While making a first person view game you will notice mainly in the build game what when you rotate the camera the game stutters/jitters a lot which gets noticable when circuling around an object. In this tutorial I am showing one of a way to fix that. Watch my [Video]() to get a detail understanding of the problem and the solution. If my solution doesn't work then I have linked to other sources that fixes this issue using other means.

## Table of Contents:
- [Prerequisites](#prerequisites)
- [Stable Build](#stable-build)
- [Main Scripts](#main-scripts)
  - [PlayerRotate](#playerrotate)
  - [PlayerRotateSmooth](#playerrotatesmooth)
- [Research Links](#research-links)
- [Authors](#authors)
- [License](#license)
***
## Prerequisites
#### Unity Game Engine
Unity Version used for this tutorial is **2020.3.3f1**.
***
## Stable Build
[Stable Build - main](https://github.com/deadlykam/TutorialFPSRotation) is the stable version of the tutorial and is similar to the one shown in the [Video]()
***
## Main Scripts
The main scripts for solving this issue are [PlayerRotate](https://github.com/deadlykam/TutorialFPSRotation/blob/20c94069f25b51205404a644a49f7b378506668e/TutorialFPSRotation/Assets/TutorialFPSRotation/Scripts/PlayerRotate.cs) and [PlayerRotateSmooth](https://github.com/deadlykam/TutorialFPSRotation/blob/20c94069f25b51205404a644a49f7b378506668e/TutorialFPSRotation/Assets/TutorialFPSRotation/Scripts/PlayerRotateSmooth.cs). Both of these scripts are needed to solve the issue.
#### _[PlayerRotate](https://github.com/deadlykam/TutorialFPSRotation/blob/20c94069f25b51205404a644a49f7b378506668e/TutorialFPSRotation/Assets/TutorialFPSRotation/Scripts/PlayerRotate.cs):_
This script rotates the player and camera normally. Using this script will show the rotation is smooth in the editor but NOT in the build game. From my research the reason is because of VSync which lowers the fps of the game to the monitor refresh rate which in my case was 60fps because my monitor refresh rate is 60Hz.
#### _[PlayerRotateSmooth](https://github.com/deadlykam/TutorialFPSRotation/blob/20c94069f25b51205404a644a49f7b378506668e/TutorialFPSRotation/Assets/TutorialFPSRotation/Scripts/PlayerRotateSmooth.cs):_
This script fixes the stuttering issue caused by VSync in the build game. The camera rotates smoothly. Using this script in the editor will make the rotation very very slow. It is adviced to use the [PlayerRotate](https://github.com/deadlykam/TutorialFPSRotation/blob/20c94069f25b51205404a644a49f7b378506668e/TutorialFPSRotation/Assets/TutorialFPSRotation/Scripts/PlayerRotate.cs) script when testing in the editor.
***
## Research Links
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
***
## License
This project is licensed under the MIT License - see the [LICENSE.md](LICENSE) file for details.
***
