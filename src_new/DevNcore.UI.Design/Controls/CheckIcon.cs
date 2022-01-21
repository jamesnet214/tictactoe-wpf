using DevNcore.UI.Design.Controls.Primitives;
using System.Windows;

namespace DevNcore.UI.Design.Controls
{
    public class CheckIcon : Icon
    {
        static CheckIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CheckIcon), new FrameworkPropertyMetadata(typeof(CheckIcon)));
        }
    }
}
