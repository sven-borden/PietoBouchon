﻿using PietoBouchon.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

namespace PietoBouchon.Simulation
{
	public class Pieton
	{
		/// <summary>
		/// Id of the Pieton
		/// </summary>
		public double Id { get; set; }

		/// <summary>
		/// Coordinate of the pieton
		/// </summary>
		public Coordinate Position { get; set; }

		/// <summary>
		/// The direction taken by the Pieton, in radian
		/// </summary>
		public double Direction { get; set; }

		/// <summary>
		/// The velocity of the Pieton
		/// </summary>
		public double Velocity { get; set; }

		/// <summary>
		/// The point representing the pieton
		/// </summary>
		public Ellipse Draw { get; set; }

		public TranslateTransform Trans { get; set; }

		public Pieton()
		{
			Draw = new Ellipse();
			Draw.Width = CNST.Radius;
			Draw.Height = CNST.Radius;
			Draw.Fill = new SolidColorBrush(Colors.BlueViolet);
			Draw.ManipulationMode = Windows.UI.Xaml.Input.ManipulationModes.All;
			Trans = new TranslateTransform();
			Draw.RenderTransform = Trans;
		}

		public Coordinate GetSpeed()
		{
			Coordinate c = new Coordinate();
			c.X = Velocity * Math.Cos(Direction);
			c.Y = Velocity * Math.Sin(Direction);
			return c;
		}

		public Coordinate ComputeNewPosition(Coordinate c)
		{
			c.X += Velocity * Math.Cos(Direction);
			c.Y += Velocity * Math.Sin(Direction);
			return c;
		}

		internal Ellipse GetEllipse()
		{
			Ellipse e = new Ellipse();

			e.Width = CNST.Radius;
			e.Height = CNST.Radius;
			e.Fill = new SolidColorBrush(Colors.BlueViolet);
			e.RenderTransform = new TranslateTransform();
			e.ManipulationMode = Windows.UI.Xaml.Input.ManipulationModes.All;
			return e;
		}
	}
}