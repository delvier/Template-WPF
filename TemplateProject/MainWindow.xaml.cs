using System.Windows;
using TemplateProject.ViewModels;

namespace TemplateProject
{
    public partial class MainWindow : Window
    {
        public MainWindow(MainViewModel viewModel)
        {
            if (viewModel != null) DataContext = viewModel;
            InitializeComponent();
        }
    }
}
