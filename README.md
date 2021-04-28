<img align="center" src="https://daegu.ac.kr/resources/images/site/layout/header_logo.gif">

<center>
    Daegu university project report </br>
    대학 프로젝트 과제입니다.
</center>
![](https://img.shields.io/github/license/yeosj116/AppVolumeHotkeys)
![](https://img.shields.io/github/downloads/yeosj116/AppVolumeHotkeys/total)

> 사용자 지정 단축키를 사용하여 하나의 프로그램 볼륨을 세부적으로 조절을 할 수 있습니다.

## 프로그램 소개
단축키를 통해 Windows 볼륨 믹서에있는 모든 응용 프로그램의 볼륨을 개별적으로 제어 할 수 있습니다.
예를 들어, 게임 하는 동안 게임 창을 닫지 않고도 게임 볼륨은 그대로 유지한 상태에서 음악 플레이어의 소리를 낮출 수 있습니다.
아이디어가 있거나 버그를 찾으면 Github의 issue에 등록해 주세요.

## 프로그램 시작하기

### 요구 사항

본 프로그램을 실행하려면 다음과 같은 시스템 요구사항이 있습니다.
* Windows Vista 이상 버전 (Windows Vista / 8 / 10 지원)
* [Microsoft .NET Framework 4.6.1](https://www.microsoft.com/en-us/download/details.aspx?id=49981)

### 설치 방법
exe 파일을 다운로드 받은 뒤 프로그램을 실행하면 됩니다.
또는 소스코드를 다운 받아 빌드 한 다음 exe 파일을 실행해도 됩니다.
매 사용마다 프로그램을 켜지게 하고 싶다면 Windows 시작 프로그램에 등록해 주세요.

### 사용 방법
Program 드롭다운 메뉴에서 원하는 프로그램을 선택하고 단축키를 설정하면 설정이 완료됩니다. **만약 원하는 프로그램이 표시되지 않으면 현재 오디오 출력 장치(Device)가 올바른지 확인하고 새로 고침 버튼을 눌러주세요.**

## 사용된 라이브러리

* [Microsoft Visual Studio 2019 Community](https://www.visualstudio.com/vs/) - 통합 개발 및 C# 빌드에 사용 되었습니다.
* [CSCore 1.2.1.2](https://github.com/filoe/cscore) - 오디오 볼륨을 제어하기 위한 C# 라이브러리 입니다.
* [Fody 6.1.1](https://github.com/Fody/Fody) - 어셈블리를 프로그램에 포함 시키기 위한 도구입니다.
* [Fody Costura 4.1.0](https://github.com/Fody/Costura) - DLL 파일을 프로그램에 포함 시키기 위한 Fody 확장 프로그램 입니다.

## 개선된 부분
본 프로젝트는 대학 과제로 [razorlikes](https://github.com/razorlikes/AppVolumeHotkeys)의 AppVolumeHotkeys를 기반으로 만들어 졌습니다.
상세한 개선 사항에 대해 궁금한 경우 위키를 참조해 주세요

## MIT 라이센스
본 프로젝트는 MIT 라이센스를 부여 받았습니다. 세부적인 사항은 [LICENSE](LICENSE) 파일을 참조해 주세요.
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details