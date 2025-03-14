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
using CalculatorException = NCalc.Expression;//获取计算器类库中的expression,为了防止其与system.linq下的expression冲突

namespace WPF学习
{
    /// <summary>
    /// 计算器综合案例.xaml 的交互逻辑
    /// </summary>
    public partial class 计算器综合案例 : Window
    {
        public 计算器综合案例()
        {
            InitializeComponent();
        }

        private void Btn_Clear(object sender, RoutedEventArgs e)
        {
            TBox_express.Text = "";
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            if(sender is Button button)
            {
                TBox_express.Text += button.Content;
            }
            
        }

        private void Btn_Computer(object sender, RoutedEventArgs e)
        {
            

            if (TBox_express.Text.Count(x => x == '=') > 0)
            {
                //string ClearLastEqual = TBox_express.Text.Remove(TBox_express.Text.Length - 1);
                //int LastEqualIndex = ClearLastEqual.LastIndexOf('=');
                //TBox_express.Text = "";
                //TBox_express.Text = ClearLastEqual.Substring(LastEqualIndex + 1, ClearLastEqual.Length - 1);

                string ClearLastEqual = TBox_express.Text;
                int LastEqualIndex = ClearLastEqual.LastIndexOf('=');
                TBox_express.Text = "";
                TBox_express.Text = ClearLastEqual.Substring(LastEqualIndex + 1, ClearLastEqual.Length - 1-LastEqualIndex);
            }

            if (sender is Button button1)
            {
                CalculatorException calculator = new CalculatorException(TBox_express.Text);
                TBox_express.Text += button1.Content;
                
                TBox_express.Text += calculator.Evaluate().ToString();
            }
           
        }

        private void Btn_ClearLast(object sender, RoutedEventArgs e)
        {
            string result=TBox_express.Text.Remove(TBox_express.Text.Length-1);
            TBox_express.Text=result;
        }
    }
}
