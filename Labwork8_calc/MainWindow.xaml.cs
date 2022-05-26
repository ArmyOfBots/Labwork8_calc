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

namespace Labwork8_calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int FirstnumberInt;
        int SecondnumberInt;
        int resultInt;
        public int CurrentEditField = 0;
        string mathfunc;

        private void Num1_Click(object sender, RoutedEventArgs e)
        {
            Adder(1);
        }

        private void Num2_Click(object sender, RoutedEventArgs e)
        {
            Adder(2);
        }

        private void Num3_Click(object sender, RoutedEventArgs e)
        {
            Adder(3);
        }

        private void Num4_Click(object sender, RoutedEventArgs e)
        {
            Adder(4);
        }

        private void Num5_Click(object sender, RoutedEventArgs e)
        {
            Adder(5);
        }

        private void Num6_Click(object sender, RoutedEventArgs e)
        {
            Adder(6);
        }

        private void Num7_Click(object sender, RoutedEventArgs e)
        {
            Adder(7);
        }

        private void Num8_Click(object sender, RoutedEventArgs e)
        {
            Adder(8);
        }
        private void Num9_Click(object sender, RoutedEventArgs e)
        {
            Adder(9);
        }

        private void Num0_Click(object sender, RoutedEventArgs e)
        {
            Adder(0);
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            CurrentEditField = 0;
            Firstnumber.Content = "";
            Secondnumber.Content = "";
            ResultNumber.Content = "";
            mathfuncmonitor.Content = "";
        }

        private void subtract_Click(object sender, RoutedEventArgs e)
        {
            mathfunc = "subtraction";
            CurrentEditField = 1;
            mathfuncmonitor.Content = "-";
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            mathfunc = "addition";
            CurrentEditField = 1;
            mathfuncmonitor.Content = "+";
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            mathfunc = "divide";
            CurrentEditField = 1;
            mathfuncmonitor.Content = "/";
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            mathfunc = "multiplication";
            CurrentEditField = 1;
            mathfuncmonitor.Content = "*";
        }

        private void confirm_Click(object sender, RoutedEventArgs e)
        {
            FirstnumberInt = Convert.ToInt32(Firstnumber.Content);
            SecondnumberInt = Convert.ToInt32(Secondnumber.Content);
            switch (mathfunc)
            {
                case "addition":
                    resultInt = FirstnumberInt + SecondnumberInt;
                    ResultNumber.Content = ""+ resultInt;
                    break;
                case "subtraction":
                    resultInt = FirstnumberInt - SecondnumberInt;
                    ResultNumber.Content = "" + resultInt;
                    break;
                case "multiplication":
                    resultInt = FirstnumberInt * SecondnumberInt;
                    ResultNumber.Content = "" + resultInt;
                    break;
                case "divide":
                    if (SecondnumberInt == 0)
                    {
                        MessageBox.Show("Can't divide by 0 yet");
                    }
                    else
                    {
                        resultInt = FirstnumberInt / SecondnumberInt;
                        ResultNumber.Content = "" + resultInt;
                    }
                    break;
            }
        }

        private void Adder(int number)
        {
            switch (CurrentEditField)
            {
                case 0:
                    Firstnumber.Content += "" + number;
                    break;
                case 1:
                    Secondnumber.Content += ""+number;
                    break;
            }
        }
    }

}