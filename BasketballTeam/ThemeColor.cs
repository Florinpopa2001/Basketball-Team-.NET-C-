using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laborator_8
{
    internal class ThemeColor
    {


        // contine codul culorii principale
        public static Color PrimaryColor { get; set; }
        // instanta a clasei Random
        private static Random random = new Random();
        public static Color SecondaryColor { get; set; }
        // lista de culori
        public static List<string> ColorList = new List<string>{"#2F86A6", "#34BE82", "#2FDD92"};
        // indicele selectat
        public static int selectedIndex { get; set; } =
        random.Next(ThemeColor.ColorList.Count);



        // schimba intensitatea culorii pentru a obține culoarea secundară
        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = (double)color.R;
            double green = (double)color.G;
            double blue = (double)color.B;
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (int)red, (int)green, (int)blue);
        }
        // selecteaza o culoare din lista in mod aleatoriu
        public static Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (index == selectedIndex)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            selectedIndex = index;

            string color = ColorList[selectedIndex];
            return ColorTranslator.FromHtml(color);
        }
        // incarca tema in fiecare fornmular
        public static void LoadTheme(Form formActive)
        {
            foreach (Control control in formActive.Controls)
            {
                // schimba culoarea butoanelor
                if (control is Button)
                {
                    Button btn = (Button)control;
                    btn.BackColor = PrimaryColor;
                    btn.ForeColor = Color.Black;

                    btn.FlatAppearance.BorderSize = 0;
                }
                // schimba culoarea etichetelor
                if (control is Label)
                {
                    Label lbl = (Label)control;
                    lbl.ForeColor = SecondaryColor;

                }
            }
        }

    }
}
