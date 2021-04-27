<img align="center" src="https://daegu.ac.kr/resources/images/site/layout/header_logo.gif">

<center>
    Daegu university project report </br>
    대학 프로젝트 과제입니다.
</center>



![](https://img.shields.io/github/license/yeosj116/AppVolumeHotkeys)
![](https://img.shields.io/github/downloads/yeosj116/AppVolumeHotkeys/total)  

> Control the volume of a single application through hotkeys.  

## 프로그램 소개
With AppVolumeHotkeys you can control the volume of any application in the Windows Volume Mixer through hotkeys in the background.  
For example, changing the volume of a music player while playing a game without having to tab out.

If you have any ideas or find any bugs, please open an issue.

## 프로그램 시작하기

### 요구 사항

To use AppVolumeHotkeys you only need:
* A computer with at least Windows Vista
* [Microsoft .NET Framework 4.6.1](https://www.microsoft.com/en-us/download/details.aspx?id=49981)

### 설치 방법
Just run the executable from anywhere you want.

### 사용 방법
Simply select the desired application from the drop down menu, set some hotkeys and you're set up. **If your application doesn't show up, make sure it's currently outputting audio and click on refresh.**

## 사용된 라이브러리

* [Microsoft Visual Studio 2019 Community](https://www.visualstudio.com/vs/) - The IDE and Compiler used
* [CSCore 1.2.1.2](https://github.com/filoe/cscore) - The audio library used to control volumes
* [Fody 6.1.1](https://github.com/Fody/Fody) - The tool used to embed assemblies
* [Fody Costura 4.1.0](https://github.com/Fody/Costura) - Fody addon used to embed DLLs into application

## MIT 라이센스
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details