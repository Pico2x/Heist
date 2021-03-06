﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Heist
{
	class Camera
	{
		//The dimensions of the camera
		public int cameraHeight;
		public int cameraWidth;
		public Vector2 position;
		public Vector2 topPos
		{
			get { return position - 0.5f * new Vector2(cameraWidth, cameraHeight); }
			set { position = value + -0.5f * new Vector2(cameraWidth, cameraHeight); }
		}

		public Camera(Vector2 position)
		{
			//the constructor takes the dimensions
			this.cameraHeight = Game1.WINDOW_HEIGTH;
			this.cameraWidth = Game1.WINDOW_WIDTH;
			this.position = position;
		}

		public Vector2 posInCamera(Vector2 posInWorld)
		{
			return posInWorld - topPos;
		}

		public Rectangle posInCamera(Rectangle posInWorld)
		{
			return new Rectangle(posInWorld.X - (int)position.X + Game1.WINDOW_WIDTH / 2, posInWorld.Y - (int)position.Y + Game1.WINDOW_HEIGTH / 2, posInWorld.Width, posInWorld.Height);
		}

	}
}
