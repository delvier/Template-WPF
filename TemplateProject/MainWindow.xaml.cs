using System.Windows;

namespace TemplateProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(IMainViewModel viewModel)
        {
            IMainViewModel mainViewModel = viewModel;
            this.DataContext = mainViewModel;
            InitializeComponent();
        }
    }
}
