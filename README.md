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
						- MainWindow.xaml
							- <Window x:Class="xxxx.Views.MainView"
						- App.xaml 
							- StartupUri="Views/MainView.xaml">
						- MainView.xaml.cs
							- Cambiar clase y constructor de "MainWindow" a
								- MainView
					- Crear carpeta ViewModels
						- Agregar clase BaseViewModel
						- Agregar clases Main, Home y AccountsViewModel 
						- Heredar Main, Home y AccountsViewModel de BaseViewModel
					- Crear carpeta Models
						- Agregar clase Class1.cs
					- Agregar dos botones a vista MainView
					
			- Invocar a vista Home
				- Agregar en "MainViewModel.cs" propfull _selectedViewModel
				- Agregar en "MainView.xaml.cs" DataContext.
					- DataContext = new MainViewModel();
				- Agregar en "MainView.xaml" 
					- <ContentControl Content="{Binding SelectedViewModel}" />
				- Agregar en "App.xaml"
					- xmlns:views="clr-namespace:SwitchingViewsWithStyles.Views"
					  xmlns:viewsmodels="clr-namespace:SwitchingViewsWithStyles.ViewModels"
					  
					- DataTemplate
						<Application.Resources>
							<DataTemplate DataType="{x:Type viewsmodels:HomeViewModel}">
								<views:HomeView/>
							</DataTemplate>
							<DataTemplate DataType="{x:Type viewsmodels:AccourntViewModel}">
								<views:AccourntView/>
							</DataTemplate>
						</Application.Resources>
						
			- Agregar Command al botón.
				- En "MainView.xaml" agregar al boton
					- Command="{Binding UpdateViewCommand}"
					  CommandParameter="Home"
					  
				- En "ViewModels/MainViewModel.cs" agregar al set de la propiedad
					- OnPropertyChanged(nameof(SelectedViewModel));
					  
					- public ICommand UpdateViewCommand { get; set; }
					  
					  
					  public MainViewModel()
					  {
					  	UpdateViewCommand = new UpdateViewCommand(this);
					  
					  }
					  
				- En "BaseViewModel.cs" implementar "INotifyPropertyChanged"
				- Crear "Commands/UpdateViewCommand.cs"
					- public class UpdateViewCommand : ICommand