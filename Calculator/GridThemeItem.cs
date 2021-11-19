using Windows.UI.Xaml.Media;

namespace App1
{
    public class GridThemeItem
    {
        private SolidColorBrush solidColorBrush1;
        private SolidColorBrush solidColorBrush2;

        public GridThemeItem(SolidColorBrush solidColorBrush1, SolidColorBrush solidColorBrush2)
        {
            this.solidColorBrush1 = solidColorBrush1;
            this.solidColorBrush2 = solidColorBrush2;
        }
    }
}