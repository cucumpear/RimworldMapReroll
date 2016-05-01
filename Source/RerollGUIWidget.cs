﻿using UnityEngine;
using Verse;

namespace MapReroll {
	public class RerollGUIWidget {
		public const float WidgetMargin = 10f;
		public static float WidgetSize = 48f;

		private static RerollGUIWidget instance;
		public static RerollGUIWidget Instance {
			get {
				return instance ?? (instance = new RerollGUIWidget());
			}
		}

		private Texture2D UITex_OpenRerollDialog;
		private Dialog_RerollControls dialogWindow;

		public void Initialize() {
			UITex_OpenRerollDialog = ContentFinder<Texture2D>.Get("icon_inactive", false);
			dialogWindow = new Dialog_RerollControls();
			WidgetSize = MapRerollController.Instance.SettingsDef.diceWidgetSize;
		}

		public void OnGUI() {
			if(!MapRerollController.Instance.ShowInterface) return;
			var buttonRect = new Rect(Screen.width - WidgetMargin - WidgetSize, WidgetMargin, WidgetSize, WidgetSize);
			if (Widgets.ImageButton(buttonRect, UITex_OpenRerollDialog)) {
				Find.WindowStack.Add(dialogWindow);
			}
		}
	}
}