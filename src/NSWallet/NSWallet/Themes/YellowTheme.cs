﻿using Xamarin.Forms;

namespace NSWallet
{
    public class YellowTheme : DefaultTheme
    {
		static Color BackgroundColor = Color.FromRgb(0xfa, 0xfa, 0xfa);
        static Color BackgroundColor2 = Color.FromHex("ffc400");
		static Color TextColor = Color.Black;
        static Color TextColor2 = Color.Gray;
        static Color HeaderColor = Color.FromHex("fbc02d");
        static Color StatusBarColor = Color.FromHex("ffc400");
		static Color SeparatorColor = Color.FromRgb(0xd1, 0xd1, 0xd1);
        static Color ButtonsColor = Color.FromHex("fbc02d");

		override public Color AppStatusBarBackground { get { return StatusBarColor; } }
		override public Color AppBackground { get { return BackgroundColor2; } }
		override public Color AppHeaderBackground { get { return HeaderColor; } }
        override public Color AppHeaderTextColor { get { return Color.White; } }
		override public Color DefaultLinkColor { get { return Color.Navy; } }

		override public Color MenuTopBackgroundColor { get { return BackgroundColor2; } }
        override public Color MenuTopTextColor { get { return Color.White; } }
		override public Color MenuTopPremiumColor { get { return Color.Yellow; } }
		//override public Color MenuTextColor { get { return TextColor; } }
		override public Color MenuBackgroundColor { get { return BackgroundColor; } }

		override public Color GroupBackground { get { return AppHeaderBackground; } }
        override public Color GroupTextColor { get { return Color.White; } }

		override public Color ListBackgroundColor { get { return BackgroundColor; } }
		override public Color ListTextColor { get { return TextColor; } }
		override public Color ListSecondaryTextColor { get { return TextColor2; } }
		override public Color ListSeparatorColor { get { return SeparatorColor; } }

		override public Color FeatureTextColor { get { return BackgroundColor; } }
		override public Color LabelTextColor { get { return Color.Black; } }
		override public Color CommonButtonBackground { get { return ButtonsColor; } }
        override public Color CommonButtonTextColor { get { return Color.White; } }
		override public Color CommonGroupHeaderBackground { get { return ButtonsColor; } }

		const string mainPageAddRoundIcon = "MainScreen.Add.ic_add_round_yellow.png";

        override public string MainPageAddRoundIcon { get { return mainPageAddRoundIcon; } }
    }
}