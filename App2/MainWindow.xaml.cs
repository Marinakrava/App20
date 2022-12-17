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

namespace App2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 



    public partial class MainWindow : Window
    {
        double firstValue;// Объявляем первое вводимое значение
        double secondValue;// Объявляем второе вводимое значение
        char operation;// Объявляем символ операции
        double result;// Объявляем результат вычислений


        public MainWindow()
        {
            InitializeComponent();
        }


        private void Equal_Click(object sender, RoutedEventArgs e) //Обработчик результатов вычислений
        {
            secondValue = Convert.ToDouble(textBox1.Text);
            if (operation == '+')
            {
                result = firstValue + secondValue;
                textBox1.Text = Convert.ToString(result);
            }
            if (operation == '-')
            {
                result = firstValue - secondValue;
                textBox1.Text = Convert.ToString(result);
            }
            if (operation == '*')
            {
                result = firstValue * secondValue;
                textBox1.Text = Convert.ToString(result);
            }
            if (operation == '/')
            {
                if (secondValue == 0)
                {
                    textBox1.Text = "На ноль делить нельзя!";
                }
                else
                {
                    result = firstValue / secondValue;
                    textBox1.Text = Convert.ToString(result);
                }
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            firstValue = Convert.ToDouble(textBox1.Text);// Присваиваем переменной значение, вводимое пользователем
            textBox1.Text = "0";// Нажатие очищает текстовой поле для ввода второго числа
            operation = '+';// Присваиваем переменной знак сложения
        }

        private void n1_Click(object sender, RoutedEventArgs e)// Обработчик события при нажатии на кнопку "1" 
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";// присваиваем значение 1, если исходное является нулем или пустым полем
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";// иначе, дописываем "1" уже к существующему числу
            }
        }

        private void n0_Click(object sender, RoutedEventArgs e)// Обработчик события при нажатии на кнопку "0" 
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";// присваиваем значение 0, если исходное является нулем или пустым полем
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";// иначе, дописываем "0" уже к существующему числу
            }
        }

        private void n2_Click(object sender, RoutedEventArgs e)// Обработчик события при нажатии на кнопку "2" 
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";// присваиваем значение 2, если исходное является нулем или пустым полем
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";// иначе, дописываем "2" уже к существующему числу
            }
        }

        private void n3_Click(object sender, RoutedEventArgs e)// Обработчик события при нажатии на кнопку "3" 
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";// присваиваем значение 3, если исходное является нулем или пустым полем
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";// иначе, дописываем "3" уже к существующему числу
            }
        }

        private void n4_Click(object sender, RoutedEventArgs e)// Обработчик события при нажатии на кнопку "4" 
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";// присваиваем значение 4, если исходное является нулем или пустым полем
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";// иначе, дописываем "4" уже к существующему числу
            }
        }

        private void n5_Click(object sender, RoutedEventArgs e)// Обработчик события при нажатии на кнопку "5" 
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";// присваиваем значение 5, если исходное является нулем или пустым полем
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";// иначе, дописываем "5" уже к существующему числу
            }
        }

        private void n6_Click(object sender, RoutedEventArgs e)// Обработчик события при нажатии на кнопку "6" 
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";// присваиваем значение 6, если исходное является нулем или пустым полем
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";// иначе, дописываем "6" уже к существующему числу
            }
        }

        private void n7_Click(object sender, RoutedEventArgs e)// Обработчик события при нажатии на кнопку "7" 
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";// присваиваем значение 7, если исходное является нулем или пустым полем
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";// иначе, дописываем "7" уже к существующему числу
            }
        }

        private void n8_Click(object sender, RoutedEventArgs e)// Обработчик события при нажатии на кнопку "8" 
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";// присваиваем значение 8, если исходное является нулем или пустым полем
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";// иначе, дописываем "8" уже к существующему числу
            }
        }

        private void n9_Click(object sender, RoutedEventArgs e)// Обработчик события при нажатии на кнопку "9" 
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";// присваиваем значение 9, если исходное является нулем или пустым полем
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";// иначе, дописываем "9" уже к существующему числу
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)// Обработчик события при нажатии на кнопку "СЕ" 
        {
            {
                textBox1.Text = "0";
            }

        }

        private void Dot_Click(object sender, RoutedEventArgs e)// Обработчик события при нажатии на кнопку "." 
        {
            {
                textBox1.Text = textBox1.Text + ".";
            }

        }

        private void Multiply_Click(object sender, RoutedEventArgs e)// Обработчик события при нажатии на кнопку "х" 
        {
            firstValue = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = '*';
        }

        private void Minus_Click(object sender, RoutedEventArgs e)// Обработчик события при нажатии на кнопку "-" 
        {
            {
                firstValue = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";
                operation = '-';
            }
        }

        private void Divide_Click(object sender, RoutedEventArgs e)// Обработчик события при нажатии на кнопку "/" 
        {
            {
                firstValue = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";
                operation = '/';
            }
        }

        private void Squ_Click(object sender, RoutedEventArgs e)// Обработчик события при нажатии на кнопку "Вычисление квадратного корня" 
        {
            firstValue = Convert.ToDouble(textBox1.Text);
            result = Math.Sqrt(firstValue);
            textBox1.Text = Convert.ToString(result);

        }

        private void Pow2_Click(object sender, RoutedEventArgs e)// Обработчик события при нажатии на кнопку "Возведение в квдрат" 
        {
            firstValue = Convert.ToDouble(textBox1.Text);
            result = Math.Pow(firstValue, 2);
            textBox1.Text = Convert.ToString(result);

        }

        private void PlusMinus(object sender, RoutedEventArgs e)// Обработчик события при нажатии на кнопку "+/-" 
        {
            {
                firstValue = Convert.ToDouble(textBox1.Text);
                if (firstValue > 0)
                {
                    result = -firstValue;
                    textBox1.Text = Convert.ToString(result);
                }
            }
        }
    }
}
