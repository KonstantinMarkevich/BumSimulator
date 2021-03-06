﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BumSimulator.Stats;
using BumSimulator.Stats.Valutas;
using System.Windows.Controls;
using System.Threading;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using BumSimulator.Settings;

namespace BumSimulator.MainGame
{
    class User
    {
		public string Name { get; set; }
		public TimeStat Times { get; set; }
		public Valutes Valutes { get; set; }
		public BottlesStat Bottles { get; set; }
		public TransportStat Transports { get; set; }
		public PropertyStat Properties { get; set; }
		public RaitingStat Raiting { get; set; }
		public StatusStat Status { get; set; }
		public EducStat Educ { get; set; }
		public PassportStat Passport { get; set; }

		public MoodStat Mood { get; set; }
		public HpStat Hp { get; set; }
		public FoodStat Food { get; set; }

		public DriverLicenseStat DriverLicense { get; set; }


		public ItemsStat TopHead { get; set; }
		public ItemsStat Head { get; set; }
		public ItemsStat Tors { get; set; }

		public ItemsStat LeftHand { get; set; }
		public ItemsStat RightHand { get; set; }

		public ItemsStat Pants { get; set; }
		public ItemsStat Bottom { get; set; }


		public User()
		{
			Mood = null;
			Hp = null;
			Food = null;
		}
		public User(MoodStat Mood, HpStat Hp, FoodStat Food)
		{
			this.Mood = Mood;
			this.Hp = Hp;
			this.Food = Food;
		}
		public User(string Name, TimeStat Times, Valutes Valutes, BottlesStat Bottles, TransportStat Transports, PropertyStat Properties,
			RaitingStat Raiting, StatusStat Status, EducStat Educ, MoodStat Mood, HpStat Hp, FoodStat Food)
			: this(Mood, Hp, Food)
		{
			this.Name = Name;
			this.Times = Times;
			this.Valutes = Valutes;
			this.Bottles = Bottles;
			this.Transports = Transports;
			this.Properties = Properties;
			this.Raiting = Raiting;
			this.Status = Status;
			this.Educ = Educ;
			Passport = new PassportStat(false);
			DriverLicense = new DriverLicenseStat(false);
		}

		public void CheckLose()
		{
            Hp.Check(Times);
            Mood.Check(Times);
            Food.Check(Times);
            Valutes.Check(Times);
		}

		public void MakeMove()
		{
            UIControls.PropertyBackground.Background = new ImageBrush(new BitmapImage(new Uri(System.IO.Path.GetFullPath(@"..\..\Img\Backgrounds\" + Properties.HighestProperty.ToString() + ".jpg"))));
		}
		async void ChangeSeason(Grid grid)
		{
			if(grid != null)
				await Task.Run(() => Times.ChangeSeason(grid));
		}
	}
}
