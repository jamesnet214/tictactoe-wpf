using DevNcore.UI.Design.Controls.Primitives;
using System.Windows;

namespace DevNcore.UI.Design.Controls
{
    public class CircleIcon : Icon
    {
        static CircleIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CircleIcon), new FrameworkPropertyMetadata(typeof(CircleIcon)));
        }
    }
}
