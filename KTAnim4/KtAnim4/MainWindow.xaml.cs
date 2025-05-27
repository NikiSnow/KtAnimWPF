using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace WpfAnimations
{
    public partial class MainWindow : Window
    {
        private Storyboard ellipseStoryboard;
        private bool isAnimationRunning = true;

        public MainWindow()
        {
            InitializeComponent();
            SetupEllipseAnimation();
        }

        private void SetupEllipseAnimation()
        {
            ellipseStoryboard = new Storyboard();

            // Анимация по X
            DoubleAnimation xAnimation = new DoubleAnimation
            {
                From = 0,
                To = 300,
                Duration = TimeSpan.FromSeconds(3),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };
            Storyboard.SetTarget(xAnimation, animatedEllipse);
            Storyboard.SetTargetProperty(xAnimation, new PropertyPath("(Canvas.Left)"));

            // Анимация по Y (синусоида)
            DoubleAnimation yAnimation = new DoubleAnimation
            {
                From = 0,
                To = 200,
                Duration = TimeSpan.FromSeconds(2),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };
            Storyboard.SetTarget(yAnimation, animatedEllipse);
            Storyboard.SetTargetProperty(yAnimation, new PropertyPath("(Canvas.Top)"));

            ellipseStoryboard.Children.Add(xAnimation);
            ellipseStoryboard.Children.Add(yAnimation);

            // Запуск анимации при загрузке окна
            Loaded += (s, e) => ellipseStoryboard.Begin(this, true);
        }

        private void ToggleAnimation_Click(object sender, RoutedEventArgs e)
        {
            if (isAnimationRunning)
            {
                ellipseStoryboard.Pause(this);
                toggleButton.Content = "Возобновить";
            }
            else
            {
                ellipseStoryboard.Resume(this);
                toggleButton.Content = "Остановить";
            }
            isAnimationRunning = !isAnimationRunning;
        }
    }
}