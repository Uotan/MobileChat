using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MobileChat.Classes
{
    public static class ThemeClass
    {
        public static Color colorLabelDark = Color.White;
        public static Color colorlabelLight = Color.Black;

        public static Color colorDarkButton = Color.FromArgb(255, 74, 80, 89);
        public static Color colorLightButton = Color.FromArgb(255, 124, 148, 166);

        public static Color colorMainBackgroundDark = Color.FromArgb(255, 44, 52, 64);
        public static Color colorMainBackgroundLight = Color.FromArgb(255, 246, 246, 246);




        public static Color colorEntryBackgroundDark = Color.FromArgb(255, 36, 38, 43);
        public static Color colorEntryBackgroundLight = Color.FromArgb(255, 237, 237, 237);

        public static Color colorEntryTextColorDark = Color.White;
        public static Color colorEntryTextColorLight = Color.Black;

        public static Color colorEntryPlaceHolderColorDark = Color.FromArgb(255, 184, 184, 184);
        public static Color colorEntryPlaceHolderColorLight = Color.FromArgb(255, 158, 142, 142);



        public static void SetDark()
        {
            App.Current.Resources["colorLabel"] = colorLabelDark;
            App.Current.Resources["colorButtonBackground"] = colorDarkButton;
            App.Current.Resources["colorEntryTextColor"] = colorEntryTextColorDark;
            App.Current.Resources["colorEntryBackground"] = colorEntryBackgroundDark;
            App.Current.Resources["colorBackgroundMain"] = colorMainBackgroundDark;
            App.Current.Resources["colorEntryPlaceholder"] = colorEntryPlaceHolderColorDark;
        }
        public static void SetLight()
        {
            App.Current.Resources["colorLabel"] = colorlabelLight;
            App.Current.Resources["colorButtonBackground"] = colorLightButton;
            App.Current.Resources["colorEntryTextColor"] = colorEntryTextColorLight;
            App.Current.Resources["colorEntryBackground"] = colorEntryBackgroundLight;
            App.Current.Resources["colorBackgroundMain"] = colorMainBackgroundLight;
            App.Current.Resources["colorEntryPlaceholder"] = colorEntryPlaceHolderColorLight;
        }
    }
    
}
