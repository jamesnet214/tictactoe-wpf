# tictactoe-wpf
## Contents
- [개요](#개요)
- [개발 환경](#개발-환경)
- [학습 가이드](#학습-가이드)
- [WPF](#wpf)
- [Custom Control](#custom-control)

<br>
  
## 개요
![image](https://user-images.githubusercontent.com/74305823/127083957-5eb3dd2d-d032-4128-9681-d754849b2698.png)

> 틱택토는 두 명이 번갈아가며 O와 X를 3×3 판에 써서 같은 글자를 가로, 세로, 혹은 대각선 상에 놓이도록 하는 놀이다. &nbsp;  - [Wikipedia](https://ko.wikipedia.org/wiki/%ED%8B%B1%ED%83%9D%ED%86%A0)

틱택토는 게임 방식과 로직이 간단하여 연습 목적으로 만들어보기 좋은 게임입니다. <br> 또한 C, Python 등 다양한 언어로 구현된 예제들이 풍부합니다.

<br>

## 개발 환경
> 해당 오픈소스의 주요 개발 환경은 아래와 같습니다. 
 
✔️ **WPF .NET Core** &nbsp; [.NET 6.0 Preview](https://dotnet.microsoft.com/download/dotnet/6.0)

✔️ **Visual Studio 2022 Preview**  
<br/>
[![image](https://user-images.githubusercontent.com/52397976/127085632-9af789b0-58bd-4e63-be6c-30f567cf088b.png)](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-preview-1-now-available/)

<br>

## 학습 가이드
**틱택토**를 통해 학습할 수 있는 기술들은 아래와 같습니다.
- [x] CustomControl
- [x] Trigger
- [x] Mvvm 패턴
- [x] DataContext
- [x] RelayCommand
- [x] Binding
- [x] RelativeSource TemplatedParent
- [x] ListBox / ListBoxItem
- [x] ItemsPresenter
- [x] ContentPresenter
- [x] GetContainerForItemOverride
- [x] OnApplyTemplate
- [x] Geometry
- [x] Hex Color
- [x] Transparent
- [x] Application

WPF의 중요한 핵심 기술들을 이 앱을 통해 깊이있게 학습할 수 있습니다.

### 숙련자
C#과 WPF를 접해본 개발자라면 약 2시간 이내에 소스코드 전체를 작성하고 실행시킬 수 있습니다.

### 초보자
WPF와 MVVM의 이해가 부족하더라도 약 6시간 이내에 소스코드 전체를 작성하고 실행시킬 수 있습니다.

<br>

## WPF 구조

📁 Local  
📁 Themes  
📁 UI

![image](https://user-images.githubusercontent.com/52397976/127076382-26b655e3-d198-43a4-a0b4-30042047b675.png)

<br>

## MVVM
ViewModel 또는 Model에서 구현할 `OnPropertyChanged`는 `INotifyPropertyChanged` 인터페이스를 직접 구현한 `ObservableObject`를 상속받아 사용하고 있습니다.
```csharp
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TicTacToe.Local.Mvvm
{
    public class ObservableObject : INotifyPropertyChanged
    {
	public event PropertyChangedEventHandler PropertyChanged;
	protected void OnPropertyChanged([CallerMemberName] string name = null)
	{
	    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
	}
    }
}
```

<br>

## ScreenShot
![image](https://user-images.githubusercontent.com/52397976/127074738-ed10f727-207b-467c-ab39-6113578caae6.png)
