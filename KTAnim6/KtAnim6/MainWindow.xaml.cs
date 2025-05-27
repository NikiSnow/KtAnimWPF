using System.Windows;
using System.Windows.Media.Animation;

namespace KtAnim6
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            if (menuPanel.Visibility == Visibility.Collapsed)
            {
                Storyboard openAnimation = (Storyboard)FindResource("OpenMenuAnimation");
                openAnimation.Begin(this);
            }
            else
            {
                Storyboard closeAnimation = (Storyboard)FindResource("CloseMenuAnimation");
                closeAnimation.Begin(this);
            }
        }
    }
}