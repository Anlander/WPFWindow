using System.Windows.Controls;

namespace WPFMoreWindows
{

    public partial class ShowPage : Page
    {
        public ShowPage(string Name)
        {
            InitializeComponent();
            txtBlockShow.Text = $"Välkommen {Name}";
        }


    }
}
