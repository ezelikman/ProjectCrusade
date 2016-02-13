﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.Input;

namespace ProjectCrusade {






	/* This is the player class. It will hold all the information for the player. */
	public class Player : IUD {

		/* This is the player's "health." The variable is called "sanity" since this is 
		what we decided we are doing for our game. */
		private int sanity = 100;

		/* The width and height of the player on the screen. */
		private int width = 32, height = 32;

		/* The name of the player. */
		private String playerName;

		/* The 'type' that the player is (see below). */
		private PlayerType playertype;



		//CONSTRUCTOR
		public Player (String name, PlayerType type) {
			this.playerName = name;
			this.playertype = type;
			initialize ();
		}



		public void initialize() {
			//Do all the initializing for the player here.
		}
		public void update(double time) {
			//Do all the updating for the player here.
		}
		public void draw(GraphicsDeviceManager g) {
			//Do all the drawing for the player here.
		}



		//SETTERS
		public void damage(int amount) { sanity -= amount; }
		public void heal(int amount) { sanity += amount; }
		public void setName(String name) { playerName = name; }
		public void setType(PlayerType type) { playertype = type; }

		//GETTERS
		public int getWidth() { return width; }
		public int getHeight() { return height; }
		public int getSanity() { return sanity; }
		public String getName() { return playerName; }
		public PlayerType getPlayerType() { return playertype; }

	} //END OF 'PLAYER' CLASS









	/* This enum will be used to determine what type of player the player is. Since we decided
	on having different player types and different items that you can pick up depending on your type,
	we can use this to do all of that. */
	public enum PlayerType {
		Rogue,
		Knight,
		Wizard,
		Arrowman,
	} //END OF PLAYERTYPE ENUM

















} //END OF NAMESPACE
