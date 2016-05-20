using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;

namespace TelopTool
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // マウス移動
            this.MouseLeftButtonDown += (sender, e) => { this.DragMove(); };
            this.MouseEnter += (sender, e) => { this.Background = new SolidColorBrush(Color.FromArgb(10, 200, 200, 200)); };
            this.MouseLeave += (sender, e) => { this.Background = new SolidColorBrush(Colors.Transparent); };
        }
    }
}
