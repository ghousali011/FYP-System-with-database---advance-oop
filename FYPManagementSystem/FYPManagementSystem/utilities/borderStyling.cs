using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYPManagementSystem.utilities
{
    internal class borderStyling
    {
        //
        // rounding panels
        //
        public static void RoundPanel(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(panel.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(panel.Width - radius, panel.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, panel.Height - radius, radius, radius), 90, 90);

            path.CloseFigure();
            panel.Region = new Region(path);
        }
        public static void RoundPanelList(List<Panel> panels, int radius) {
            foreach (var panel in panels) { 
                RoundPanel(panel, radius);
            }
        }
        //
        // rounding buttons
        //
        public static void RoundButton(Button button, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(button.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(button.Width - radius, button.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, button.Height - radius, radius, radius), 90, 90);

            path.CloseFigure();
            button.Region = new Region(path);
        }
        public static void RoundButtonList(List<Button> buttons, int radius)
        {
            foreach (var button in buttons)
            {
                RoundButton(button, radius);
            }
        }
        //
        // rounding labels
        //
        public static void RoundLabel(Label label, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(label.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(label.Width - radius, label.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, label.Height - radius, radius, radius), 90, 90);

            path.CloseFigure();
            label.Region = new Region(path);
        }
        public static void RoundLabelList(List<Label> labels, int radius)
        {
            foreach (var label in labels)
            {
                RoundLabel(label, radius);
            }
        }
    }
}
