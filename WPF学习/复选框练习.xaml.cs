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
    /// 复选框练习.xaml 的交互逻辑
    /// </summary>
    public partial class 复选框练习 : Window
    {
        public 复选框练习()
        {
            InitializeComponent();
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new();
            foreach (var item in Mypannel.Children)
            {
                if (item is CheckBox cbx)
                {
                    if (cbx.IsChecked == true)
                    {
                        sb.Append(cbx.Content.ToString() + ',');
                    }
                }
            }
            sb.Remove(sb.Length - 1, 1);
            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString());
            }

        }

        private void OnChecked(object sender, RoutedEventArgs e)
        {
            int total = 0;
            foreach (var item in Mypannel.Children)
            {
                if (item is CheckBox cbx)
                {
                    if (cbx.IsChecked == true)
                    {
                        total++;
                    }

                }
            }
            if (total > 3)
            {
                if (sender is CheckBox cbx1) {
                    if (cbx1.IsChecked == true)
                    {
                        cbx1.IsChecked = false;
                        MessageBox.Show("梦想最多中三个");
                    }
                 
                }
               
            }
        }
    }
}
