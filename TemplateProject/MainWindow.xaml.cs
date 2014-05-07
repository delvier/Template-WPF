using System.Windows;

namespace TemplateProject
{
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
