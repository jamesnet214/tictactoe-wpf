# tictactoe-wpf

## Contents
- [개요](#개요)
- [개발 환경](#개발-환경)
- [학습 가이드](#학습-가이드)
- [WPF 구조](#wpf-구조)
- [MVVM](#mvvm)

<br>
  
## 개요
![image](https://user-images.githubusercontent.com/74305823/127083957-5eb3dd2d-d032-4128-9681-d754849b2698.png)

> 틱택토는 두 명이 번갈아가며 O와 X를 3×3 판에 써서 같은 글자를 가로, 세로, 혹은 대각선 상에 놓이도록 하는 놀이다. &nbsp;  - [Wikipedia](https://ko.wikipedia.org/wiki/%ED%8B%B1%ED%83%9D%ED%86%A0)

틱택토는 게임 방식과 로직이 간단하여 연습 목적으로 만들어보기 좋은 게임입니다. <br> 또한 C, Python 등 다양한 언어로 구현된 예제들이 풍부합니다.

이제 WPF로 구현한 **틱택토**를 함께 즐겨보시기 바랍니다!

<br>

## 개발 환경
> 해당 오픈소스의 주요 개발 환경은 아래와 같습니다. 
 
✔️ **WPF .NET Core** &nbsp; [.NET 6.0 Preview](https://dotnet.microsoft.com/download/dotnet/6.0)

✔️ **Visual Studio 2022 Preview**  
<br/>
[![image](https://user-images.githubusercontent.com/52397976/127085632-9af789b0-58bd-4e63-be6c-30f567cf088b.png)](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-preview-1-now-available/)

<br>

## 학습 가이드

- **숙련자:** C#과 WPF를 접해본 개발자라면 약 2시간 이내에 소스코드 전체를 작성하고 실행시킬 수 있습니다.
- **초보자:** WPF와 MVVM의 이해가 부족하더라도 약 6시간 이내에 소스코드 전체를 작성하고 실행시킬 수 있습니다.


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

<br>

## WPF 구조
소스코드는 **`Local`** **`Themes`** **`UI`** 3개의 폴더 구조로 구성되어 있습니다. 각각의 폴더는 기능, 리소스, UI를 담당합니다.

<details open>
  <summary>
	<a href="https://github.com/devncore/tictactoe-wpf#local"><b>Local</b></a>
  </summary>

  &nbsp;&nbsp;&nbsp;&nbsp; - Data  
  &nbsp;&nbsp;&nbsp;&nbsp; - Mvvm  
  &nbsp;&nbsp;&nbsp;&nbsp; - ViewModel  
</details>

<details open>
  <summary>
	<a href="https://github.com/devncore/tictactoe-wpf#themes"><b>Themes</b></a>
  </summary>

  &nbsp;&nbsp;&nbsp;&nbsp; - Controls  
</details>

<details open>
  <summary>
	<a href="https://github.com/devncore/tictactoe-wpf#ui"><b>UI</b></a>
  </summary>

  &nbsp;&nbsp;&nbsp;&nbsp; - Units  
  &nbsp;&nbsp;&nbsp;&nbsp; - Views  
</details>

### `Local`
로컬 기반에서 필요한 클래스 영역입니다. Model, Converter, 각종 Helper, Mvvm에 필요한 모듈, ViewModel 등 로컬에서 필요한 모든 클래스를 이 위치에서 관리합니다.

### `Themes`
Generic.xaml을 포함한 리소스 분기 영역입니다. DefaultStyleKey에 해당하는 리소스를 약속된 위치(Generic.xaml)에서 다시 한번 ResourceDictionary 파일을 통해 분기하여 관리하도록 합니다.

### `UI`
DeafultStyleKey를 포함하는 CustomControl 영역입니다. **`Units`** 폴더는 ListBox, ListBoxItem, Button 등과 같이 하위 요소 수준의 컨트롤 객체를 포함합니다. 그리고 **`Views`** 폴더는 Window, UserControl, ContentControl과 같이 UI 레이아웃을 담당할 수 있는 ContentPresenter 객체를 포함합니다.

![image](https://user-images.githubusercontent.com/52397976/127076382-26b655e3-d198-43a4-a0b4-30042047b675.png)

<br>

## MVVM
MVVM 패턴을 사용하기 위해서는 **INotifyPropertyChanged**가 구현된 클래스가 필요합니다. 해당 앱에서는 별도의 라이브러리를 사용하지 않고 기본적으로 필요한 메서드만 로컬에 구현해서 사용합니다.

### `ObservableObject`
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
![image](https://user-images.githubusercontent.com/74305823/130179419-58d5ac1e-b037-4882-9219-525c5bd39f2b.png)
