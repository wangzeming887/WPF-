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
using System.Windows.Shapes;

namespace WPF学习
{
    /// <summary>
    /// 圆角带图标的按钮.xaml 的交互逻辑
    /// </summary>
    public partial class 圆角带图标的按钮 : Window
    {
        public 圆角带图标的按钮()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("我点击了按钮");
        }
    }
}
