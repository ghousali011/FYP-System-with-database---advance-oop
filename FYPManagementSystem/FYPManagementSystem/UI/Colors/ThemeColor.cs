using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace FYPManagementSystem.UI.Colors
{
    internal class ThemeColor
    {
        public static Color PrimaryColor { get; set; }
        public static Color SecondaryColor { get; set; }
        public static Color TertiaryColor { get; set; }
        public static List<string> ColorList = new List<string>()   
        {
                "#FF5733", // Bright Red-Orange
                "#FFC300", // Bright Yellow
                "#FF33FF", // Hot Pink / Fuchsia
                "#33FF57", // Bright Green / Lime
                "#33FFF6", // Bright Cyan / Aqua
                "#FF3380", // Magenta Pink
                "#FF6F33", // Vivid Orange
                "#FFFF33", // Neon Yellow
                "#33FFBD", // Turquoise / Mint
                "#FF3333", // Bright Red
                "#FF9933", // Orange / Tangerine
                "#33FF99", // Lime Green
                "#FF33B5", // Vivid Pink
                "#33B5FF", // Sky Blue
                "#99FF33", // Bright Lime
                "#FFCC33", // Golden Yellow
                "#FF66FF", // Neon Pink
                "#66FF33", // Bright Green
                "#33FFFF", // Electric Cyan
                "#FF9933"  // Vivid Orange-Yellow
        };
        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            correctionFactor = Math.Max(-1.0, Math.Min(1.0, correctionFactor));

            double red = color.R;
            double green = color.G;
            double blue = color.B;

            if (correctionFactor < 0)
            {
                red *= 1 + correctionFactor;
                green *= 1 + correctionFactor;
                blue *= 1 + correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (int)red, (int)green, (int)blue);
        }
    }
}
