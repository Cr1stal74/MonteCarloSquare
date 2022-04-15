using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace Program1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            textBoxAX.Text = "";
            textBoxAY.Text = "";
            textBoxСX.Text = "";
            textBoxСY.Text = "";
        }

        private void example_Click(object sender, RoutedEventArgs e)
        {
            textBoxAX.Text = "10";
            textBoxAY.Text = "5";
            textBoxСX.Text = "30";
            textBoxСY.Text = "10";
        }

        private bool IsCorrectedData()
        {
            double tmp;
            if ((textBoxAX.Text == "") || (textBoxAY.Text == "") || (textBoxСX.Text == "") || (textBoxСY.Text == ""))
            {
                return false;
            }
            else if ((Double.TryParse(textBoxAX.Text, out tmp) == false) || (Double.TryParse(textBoxAY.Text, out tmp) == false) || (Double.TryParse(textBoxСX.Text, out tmp) == false) || (Double.TryParse(textBoxСY.Text, out tmp) == false))
            {
                return false;
            }
            else if ((double.Parse(textBoxAX.Text) >= double.Parse(textBoxСX.Text)) || (double.Parse(textBoxAY.Text) >= double.Parse(textBoxСY.Text)))
            {
                return false;
            }
            else if (2 * Math.Abs(0.5 * (double.Parse(textBoxAY.Text) - double.Parse(textBoxСY.Text))) > double.Parse(textBoxСX.Text) - double.Parse(textBoxAX.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void calculate_Click(object sender, RoutedEventArgs e)
        {
            if (IsCorrectedData() == false)
            {
                MessageBox.Show("Error");
            }
            else
            {
                Point a = new Point(double.Parse(textBoxAX.Text), double.Parse(textBoxAY.Text));
                Point c = new Point(double.Parse(textBoxСX.Text), double.Parse(textBoxСY.Text));
                int countRndPoints = 1000;
                int index = 1;
                MonteKarlo MK = new MonteKarlo(a, c);
                Collection<Result> ResultData = new Collection<Result>();
                while (countRndPoints <= Math.Pow(10, 7))
                {
                    var start = DateTime.Now;
                    double square;
                    double uncertanity;
                    int points = MK.CountPointsInFigure(countRndPoints, out square, out uncertanity);
                    var endTime = DateTime.Now.Subtract(start).TotalMilliseconds;
                    ResultData.Add(new Result { Id = index, Points = countRndPoints, MonteCarloSquare = square, CountPoints = points, Uncertainity = uncertanity, Time = endTime });
                    countRndPoints *= 10;
                    index++;
                }
                dataGridResults.ItemsSource = ResultData;
                TextBoxRealSquare.Text = MK.SquareFigure.ToString("F3");
            }
        }
    }
}
