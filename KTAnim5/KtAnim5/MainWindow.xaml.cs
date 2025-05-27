using System.Windows;
using System.Windows.Media.Animation;

namespace KtAnim5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartAnimations_Click(object sender, RoutedEventArgs e)
        {
            // Останавливаем предыдущие анимации, если они были
            (FindResource("PathAnimation") as Storyboard)?.Begin(this, true);
            (FindResource("FadeAnimation") as Storyboard)?.Begin(this, true);
        }
    }


}