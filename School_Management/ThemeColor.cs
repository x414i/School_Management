using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management
{
    public static class ThemeColor
    {

        public static Color PrimaryColor { get; set; }
        public static Color SecondaryColor { get; set; }
        public static List<string> ColorList = new List<string>() {
            "#70afee",
  "#58a2eb",
  "#4095e7",
  "#2a5c75",
  "#3a7387",
  "#4a8a99",
  "#5a9fa5",
  "#5E94AB",
  "#4f7a95",
  "#407f8e",
  "#30858e"

            //"#e8f0fe",
            //"#2a5c75",
            //"#2A5C75",
            //"#5E94AB" ,
            //"#50849c",
            //"#e8f0fe",
            //"#d0e3fa",
            //"#b8d6f6",
            //"#a0c9f2",
            //"#88bcf0",
            //"#70afee",
            //"#58a2eb",
            //"#4095e7",
            //"#2a5c75",
            //"#3a7387",
            //"#4a8a99",
            //"#5a9fa5",
            //"#6ab5b1",
            //"#7ac0bb",
            //"#8bd2c4",
            //"#9ce3d2",
            //"#5E94AB",
            //"#4f7a95",
            //"#407f8e",
            //"#30858e"
                                                                    //"#3F51B5",
                                                                    //"#009688",
                                                                    //"#FF5722",
                                                                    //"#607D8B",
                                                                    //"#FF9800",
                                                                    //"#9C27B0",
                                                                    //"#2196F3",
                                                                    //"#EA676C",
                                                                    //"#E41A4A",
                                                                    //"#5978BB",
                                                                    //"#018790",
                                                                    //"#0E3441",
                                                                    //"#00B0AD",
                                                                    //"#721D47",
                                                                    //"#EA4833",
                                                                    //"#EF937E",
                                                                    //"#F37521",
                                                                    //"#A12059",
                                                                    //"#126881",
                                                                    //"#8BC240",
                                                                    //"#364D5B",
                                                                    //"#C7DC5B",
                                                                    //"#0094BC",
                                                                    //"#E4126B",
                                                                    //"#43B76E",
                                                                    //"#7BCFE9",
                                                                    //"#B71C46"


//"#2A5C75" ,
//"#5E94AB",
//"#7BCFE9" ,
//"#0094BC" ,
//"#AA8C7E" ,
//"#C4B4A7" ,
//"#DDDFDE" ,
//"#0E3441",
//"#E41A4A" ,
//"#43B76E"
        };
        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            //If correction factor is less than 0, darken color.
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //If correction factor is greater than zero, lighten color.
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }

            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }

    }
}
