using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationMenu
{
	public partial class NavigationItem : Grid
	{
		public NavigationItem()
		{
			InitializeComponent();
		}

		public static readonly BindableProperty CommandParameterProperty = BindableProperty.Create(
			nameof(CommandParameter),
			typeof(string),
			typeof(NavigationItem),
			string.Empty,
			propertyChanging: (bindable, oldValue, newValue) =>
			{
				var ctrl = (NavigationItem)bindable;
				ctrl.CommandParameter = (string)newValue;
			},
			defaultBindingMode: BindingMode.OneWay);

		private string _commandParameter;

		public string CommandParameter
		{
			get { return _commandParameter; }
			set
			{
				_commandParameter = value;
				OnPropertyChanged();
			}
		}

		public static readonly BindableProperty IconProperty = BindableProperty.Create(
		nameof(Icon),
		typeof(string),
		typeof(NavigationItem),
		string.Empty,
		propertyChanging: (bindable, oldValue, newValue) =>
		{
			var ctrl = (NavigationItem)bindable;
			ctrl.Icon = (string)newValue;
		},
		defaultBindingMode: BindingMode.OneWay);

		private string _icon;

		public string Icon
		{
			get { return _icon; }
			set
			{
				_icon = value;
				OnPropertyChanged();
			}
		}

		public static readonly BindableProperty TextProperty = BindableProperty.Create(
			nameof(Text),
			typeof(string),
			typeof(NavigationItem),
			string.Empty,
			propertyChanging: (bindable, oldValue, newValue) =>
			{
				var ctrl = (NavigationItem)bindable;
				ctrl.Text = (string)newValue;
			},
			defaultBindingMode: BindingMode.OneWay);

		private string _text;

		public string Text
		{
			get { return _text; }
			set
			{
				_text = value;
				OnPropertyChanged();
			}
		}

		public static readonly BindableProperty CommandProperty = BindableProperty.Create(
			"Command",
			typeof(ICommand),
			typeof(NavigationItem),
			null,
			propertyChanging: (bindable, oldValue, newValue) =>
			{
				var ctrl = (NavigationItem)bindable;
				ctrl.Command = (ICommand)newValue;
			},
			defaultBindingMode: BindingMode.OneWay);

		private ICommand _command;

		public ICommand Command
		{
			get { return _command; }
			set
			{
				_command = value;
				OnPropertyChanged();
			}
		}

	}
}