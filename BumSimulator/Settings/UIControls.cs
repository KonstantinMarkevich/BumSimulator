﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BumSimulator.Settings
{
	public static class UIControls
	{
		public class DriverCard : INotifyPropertyChanged
		{
			double left;
			double top;
			public double Left
			{
				get { return left; }
				set
				{
					left = value;
					OnPropertyChanged("Left");
				}
			}
			public double Top
			{
				get { return top; }
				set
				{
					top = value;
					OnPropertyChanged("Top");
				}
			}

			public DriverCard()
			{
				Left = 0;
				Top = 0;
			}
			public DriverCard(UIElement uIElement)
			{
				Left = uIElement.RenderSize.Width - 50;
				Top = uIElement.RenderSize.Height - 50;
			}

			public event PropertyChangedEventHandler PropertyChanged;
			public void OnPropertyChanged([CallerMemberName]string prop = "")
			{
				if (PropertyChanged != null)
					PropertyChanged(this, new PropertyChangedEventArgs(prop));
			}
		}

		public static Grid PropertyBackground { get; set; }

		public static Label MoodBar { get; set; }
		public static Label ChangesMoodBar { get; set; }

		public static Label HpBar { get; set; }
		public static Label ChangesHpBar { get; set; }

		public static Label FoodBar { get; set; }
		public static Label ChangesFoodBar { get; set; }
        public static MainPage Page { get; set; }

        public static NavigationWindow Win { get; set; }

		//public UIControls()
		//{
		//	MainGrid = null;
		//	MoodBar = ChangesMoodBar = HpBar = ChangesHpBar = FoodBar = ChangesFoodBar = null;
		//}
		//public UIControls(Grid mainGrid)
		//{
		//	MainGrid = mainGrid;
		//	MoodBar = ChangesMoodBar = HpBar = ChangesHpBar = FoodBar = ChangesFoodBar = null;
		//}

	}
}
