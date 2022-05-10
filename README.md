# 044_WPF_SwitchingViewsWithStyles

- REFERENCIA
	- SingletonSean
		- Switching Between Multiple Views in MVVM - EASY WPF (.NET CORE)
			- https://www.youtube.com/watch?v=1_cUgpWqS0Y&list=PLA8ZIAm2I03h8QW3JaGrDBf7cq7F-cT4O
			
			- Crear estructura inicial
				- Estructura inicial
					- Crear carpeta Views
						- Agregar userControls Home y Accounts a carpeta Views
						- Agregar Label con nombre de la vista a c/u
					- mover vista MainWindows.xaml a carpeta Views
						- App.xaml 
							- "StartupUri="Views/MainWindow.xaml""
						- MainWindow.xaml
							- <Window x:Class="xxxx.Views.MainWindow"
						- MainWindow.xaml.cs
							- namespace xxxx.Views
					- Renombrar MainWindow.xaml a MainView.xaml
						- App.xaml 
							- StartupUri="Views/MainView.xaml">
					- Crear carpeta ViewModels
						- Agregar clase BaseViewModel
						- Agregar clases Main, Home y AccountsViewModel 
						- Heredar Main, Home y AccountsViewModel de BaseViewModel
					- Crear carpeta Models
						- Agregar clase Class1.cs
					- Agregar dos botones a vista MainView