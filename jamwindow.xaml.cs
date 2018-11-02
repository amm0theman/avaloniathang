using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace cooljam
{
    public class jamwindow : Window
    {
        public jamwindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}