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

namespace WPFandXAML
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

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double firstNumber;
            double secondNumber;
            double answer;

            try
            {
                if (!double.TryParse(txtFirstNumber.Text, out firstNumber))
                {
                    MessageBox.Show("First number is not numeric.", "Error parsing number.");
                    return;
                }
                if (cboOperation.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select an operation.", "No operation selected.");
                    return;
                }
                if (!double.TryParse(txtSecondNumber.Text, out secondNumber))
                {
                    MessageBox.Show("Second number is not numeric.", "Error parsing number.");
                    return;
                }
                switch (cboOperation.Text)
                {
                    case "Addition":
                        answer = firstNumber + secondNumber;
                        break;
                    case "Subtraction":
                        answer = firstNumber - secondNumber;
                        break;
                    case "Multiplication":
                        answer = firstNumber * secondNumber;
                        break;
                    case "Division":
                        if (secondNumber == 0)
                        {
                            MessageBox.Show("Cannot divide by zero.", "Calculation error.");
                            return;
                        }
                        answer = firstNumber / secondNumber;
                        break;
                    default:
                        MessageBox.Show("Operation not implemented", "Error execution the selected operation.");
                        return;
                }
                MessageBox.Show($"The answer is {answer}.", "Result!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
            
        }
    }
}
