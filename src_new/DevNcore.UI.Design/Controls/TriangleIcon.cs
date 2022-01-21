using DevNcore.UI.Design.Controls.Primitives;
using System.Windows;

namespace DevNcore.UI.Design.Controls
{
    public class TriangleIcon : Icon
    {
        static TriangleIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TriangleIcon), new FrameworkPropertyMetadata(typeof(TriangleIcon)));
        }
    }
}
