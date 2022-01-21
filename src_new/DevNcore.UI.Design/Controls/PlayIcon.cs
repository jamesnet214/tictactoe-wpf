using DevNcore.UI.Design.Controls.Primitives;
using System.Windows;

namespace DevNcore.UI.Design.Controls
{
    public class PlayIcon : Icon
    {
        static PlayIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PlayIcon), new FrameworkPropertyMetadata(typeof(PlayIcon)));
        }
    }
}
