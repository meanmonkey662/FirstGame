﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace FirstGame
{
	public class Player
	{
		private int score;
		private bool active;
		private int health;

		// Animation representing the player
		public Texture2D PlayerTexture;

		// Position of the Player relative to the upper left side of the screen
		public Vector2 Position;

		// State of the player
		public bool Active;
		{
			get { return active; }
			set { health = value; }
		}

		// Amount of hit points that player has
		public int Health;
		{
			get { return active; }
			set { health = value; }
		}

		// Get the width of the player ship
		public int Width
		{
			get { return PlayerTexture.Width; }
		}

		// Get the height of the player ship
		public int Height
		{
			get { return PlayerTexture.Height; }
		}


		public int Score
		{
			get { return score; }
			set { score = value; }
		}

		public Player ()
		{
		}
	}
}

