using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace cooljam.Views
{
    public partial class MainWindow : Window
    {
        public Button button1;
        public MainWindow()
        {
            button1 = new Button();
            button1.Name = "button1";
            button1.Click += button1_Click;
            button1.HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center;
            button1.VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center;
            InitializeComponent();
            this.FindControl<Grid>("gridiron").Children.Add(button1);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private async void button1_Click(object sender, System.EventArgs e) {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Avalonia OpenFileDialog";
            string[] files = await openFileDialog1.ShowAsync(VisualRoot as Window);
        }
    }
}