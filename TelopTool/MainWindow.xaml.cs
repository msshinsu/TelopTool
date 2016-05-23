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
using System.Runtime.InteropServices;

namespace TelopTool
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        [DllImport("user32")]
        static extern short GetAsyncKeyState(Keys vKey);

        public MainWindow()
        {
            InitializeComponent();
            // マウス移動
            this.MouseLeftButtonDown += (sender, e) => { this.DragMove(); };
            this.MouseEnter += (sender, e) => { this.Background = new SolidColorBrush(Color.FromArgb(10, 200, 200, 200)); };
            this.MouseLeave += (sender, e) => { this.Background = new SolidColorBrush(Colors.Transparent); };
            // テキスト初期化
            this.main.Text = "Telop";
            // 入力チェック
            Task.Factory.StartNew(() => chkKey());
        }

        private void chkKey()
        {
            while(true)
            {
                if (GetAsyncKeyState(Keys.LWin) < 0 && GetAsyncKeyState(Keys.W) < 0)
                {
                    Dispatcher.Invoke(() =>
                    {
                        this.Activate();
                        this.main.Focus();
                        this.main.SelectAll();
                    });
                }
            }
        }
    }
}
