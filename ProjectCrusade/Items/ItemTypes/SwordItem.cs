﻿using System;

namespace ProjectCrusade
{
	public abstract class SwordItem : WeaponItem
	{
		public SwordItem ()
		{
			//Cannot stack a sword
			Stackable = false;
		}

		//All swords have same behavior
		public override void PrimaryUse (Player player)
		{
			throw new NotImplementedException ();
		}
		public override void SecondaryUse (Player player)
		{
			throw new NotImplementedException ();
		}
	}
}

