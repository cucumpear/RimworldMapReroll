﻿using HugsLib.Utils;
using Verse;

namespace MapReroll {
	/// <summary>
	/// Wrapper to allow MapRerollState to be stored inside a map
	/// </summary>
	public class MapComponent_MapRerollState : MapComponent {
		public MapRerollState State;
		
		public MapComponent_MapRerollState(Map map) : base(map) {
			this.EnsureIsActive();
		}

		public override void ExposeData() {
			base.ExposeData();
			Scribe_Deep.Look(ref State, "state");
		}
	}
}