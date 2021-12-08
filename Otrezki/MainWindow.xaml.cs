using System;
using System.Data.Entity;
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

namespace Otrezki
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        dbHistoryEntities db = new dbHistoryEntities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Otrezok1_Click(object sender, RoutedEventArgs e)
        {
            double PointX1 = Convert.ToDouble(tbX1_1.Text) * 10;
            double PointY1 = Convert.ToDouble(tbY1_1.Text) * 10;
            double PointX2 = Convert.ToDouble(tbX1_2.Text) * 10;
            double PointY2 = Convert.ToDouble(tbY1_2.Text) * 10;

            double X1_ = Convert.ToDouble(tbX1_1.Text);
            double Y1_ = Convert.ToDouble(tbY1_1.Text);
            double X2_ = Convert.ToDouble(tbX1_2.Text);
            double Y2_ = Convert.ToDouble(tbY1_2.Text);

            Label label = new Label();
            label.Margin = new Thickness(240 + PointX1, 185, 0, 0);
            label.Content = X1_.ToString();
            CanvasGraf.Children.Add(label);

            Label label2 = new Label();
            label2.Margin = new Thickness(235, 190 - PointY1, 0, 0);
            label2.Content = Y1_.ToString();
            CanvasGraf.Children.Add(label2);

            Label label3 = new Label();
            label3.Margin = new Thickness(240 + PointX2, 190, 0, 0);
            label3.Content = X2_.ToString();
            CanvasGraf.Children.Add(label3);

            Label label4 = new Label();
            label4.Margin = new Thickness(235, 185 - PointY2, 0, 0);
            label4.Content = Y2_.ToString();
            CanvasGraf.Children.Add(label4);

            Line MyLine = new Line();
            MyLine.X1 = PointX1 + 250;
            MyLine.Y1 = -PointY1 + 200;
            MyLine.X2 = PointX2 + 250;
            MyLine.Y2 = -PointY2 + 200;
            MyLine.Stroke = System.Windows.Media.Brushes.Blue;
            MyLine.StrokeThickness = 2;
            MyLine.HorizontalAlignment = HorizontalAlignment.Left;
            MyLine.VerticalAlignment = VerticalAlignment.Center;
            CanvasGraf.Children.Add(MyLine);

            History history = new History();
            history.SegmentStartX1 = Convert.ToDouble(tbX1_1.Text);
            history.SegmentStartY1 = Convert.ToDouble(tbY1_1.Text);
            history.SegmentStartX2 = Convert.ToDouble(tbX1_2.Text);
            history.SegmentStartY2 = Convert.ToDouble(tbY1_2.Text);
            db.History.Add(history);
            db.SaveChanges();
            historytable.ItemsSource = db.History.ToList();
        }

        private void Otrezok2_Click(object sender, RoutedEventArgs e)
        {
            double PointX1 = Convert.ToDouble(tbX2_1.Text) * 10;
            double PointY1 = Convert.ToDouble(tbY2_1.Text) * 10;
            double PointX2 = Convert.ToDouble(tbX2_2.Text) * 10;
            double PointY2 = Convert.ToDouble(tbY2_2.Text) * 10;

            double X1_ = Convert.ToDouble(tbX2_1.Text);
            double Y1_ = Convert.ToDouble(tbY2_1.Text);
            double X2_ = Convert.ToDouble(tbX2_2.Text);
            double Y2_ = Convert.ToDouble(tbY2_2.Text);

            Label label = new Label();
            label.Margin = new Thickness(240 + PointX1, 190, 0, 0);
            label.Content = X1_.ToString();
            CanvasGraf.Children.Add(label);

            Label label2 = new Label();
            label2.Margin = new Thickness(235, 190 - PointY1, 0, 0);
            label2.Content = Y1_.ToString();
            CanvasGraf.Children.Add(label2);

            Label label3 = new Label();
            label3.Margin = new Thickness(240 + PointX2, 190, 0, 0);
            label3.Content = X2_.ToString();
            CanvasGraf.Children.Add(label3);

            Label label4 = new Label();
            label4.Margin = new Thickness(235, 190 - PointY2, 0, 0);
            label4.Content = Y2_.ToString();
            CanvasGraf.Children.Add(label4);

            Line MyLine = new Line();
            MyLine.X1 = PointX1 + 250;
            MyLine.Y1 = -PointY1 + 200;
            MyLine.X2 = PointX2 + 250;
            MyLine.Y2 = -PointY2 + 200;
            MyLine.Stroke = System.Windows.Media.Brushes.Pink;
            MyLine.StrokeThickness = 2;
            MyLine.HorizontalAlignment = HorizontalAlignment.Left;
            MyLine.VerticalAlignment = VerticalAlignment.Center;
            CanvasGraf.Children.Add(MyLine);

            History history = new History();
            history.SegmentStartX3 = Convert.ToDouble(tbX2_1.Text);
            history.SegmentStartY3 = Convert.ToDouble(tbY2_1.Text);
            history.SegmentStartX4 = Convert.ToDouble(tbX2_2.Text);
            history.SegmentStartY4 = Convert.ToDouble(tbY2_2.Text);
            db.History.Add(history);
            db.SaveChanges();
            historytable.ItemsSource = db.History.ToList();
        }

        public void Peresechenie_Click(object sender, RoutedEventArgs e)
        {
            double x1 = Convert.ToDouble(tbX1_1.Text) * 10;
            double y1 = Convert.ToDouble(tbY1_1.Text) * 10;
            double x2 = Convert.ToDouble(tbX1_2.Text) * 10;
            double y2 = Convert.ToDouble(tbY1_2.Text) * 10;

            double x3 = Convert.ToDouble(tbX2_1.Text) * 10;
            double y3 = Convert.ToDouble(tbY2_1.Text) * 10;
            double x4 = Convert.ToDouble(tbX2_2.Text) * 10;
            double y4 = Convert.ToDouble(tbY2_2.Text) * 10;

            double Ua, Ub, numerator_a, numerator_b, denominator;

            denominator = (y4 - y3) * (x1 - x2) - (x4 - x3) * (y1 - y2);
            numerator_a = (x4 - x2) * (y4 - y3) - (x4 - x3) * (y4 - y2);
            numerator_b = (x1 - x2) * (y4 - y2) - (x4 - x2) * (y1 - y2);
            Ua = numerator_a / denominator;
            Ub = numerator_b / denominator;

            x1 /= 10;
            x2 /= 10;
            x3 /= 10;
            x4 /= 10;

            y1 /= 10;
            y2 /= 10;
            y3 /= 10;
            y4 /= 10;

            double x = 0;
            double y = 0;



            if (Ua >= 0 && Ua <= 1 && Ub >= 0 && Ub <= 1)
            {
                if (x1 <= x2 && x3 <= x4)
                {
                    if (x1 >= x2)
                    {
                        x1 = x1 + x2 - (x2 = x1);
                        y1 = y1 + y2 - (y2 = y1);
                    }
                    if (x3 >= x4)
                    {
                        x3 = x3 + x4 - (x4 = x3);
                        y3 = y3 + y4 - (y4 = y3);
                    }

                    if (y2 == y1)
                    {
                        double k1 = 0;

                        if (y3 == y4)
                        {
                            double k2 = (y4 - y3) / (x4 - x3);

                            if (k1 == k2)
                            {
                                return;
                            }
                            else
                            {
                                double b1 = y1 - k1 * x1;
                                double b2 = y3 - k2 * x3;

                                x = (b2 - b1) / (k1 - k2);
                                y = k1 * x + b1;

                                //MessageBox.Show(x.ToString() + " " + y.ToString());
                            }
                        }
                    }
                    else
                    {
                        double k1 = (y2 - y1) / (x2 - x1);
                        if (y3 == y4)
                        {
                            double k2 = 0;


                            if (k1 == k2)
                            {
                                return;
                            }
                            else
                            {
                                double b1 = y1 - k1 * x1;
                                double b2 = y3 - k2 * x3;

                                x = (b2 - b1) / (k1 - k2);
                                y = k1 * x + b1;
                            }
                        }
                        else
                        {
                            double k2 = (y4 - y3) / (x4 - x3);

                            if (k1 == k2)
                            {
                                return;
                            }
                            else
                            {
                                double b1 = y1 - k1 * x1;
                                double b2 = y3 - k2 * x3;


                                x = (b2 - b1) / (k1 - k2);
                                y = k1 * x + b1;

                                //MessageBox.Show(x.ToString() + " " + y.ToString());

                            }
                        }
                    }
                }
                else
                {
                    if (y2 == y1)
                    {
                        double k1 = 0;

                        if (y3 == y4)
                        {
                            double k2 = (y4 - y3) / (x4 - x3);

                            if (k1 == k2)
                            {
                                return;
                            }
                            else
                            {
                                double b1 = y1 - k1 * x1;
                                double b2 = y3 - k2 * x3;

                                x = (b2 - b1) / (k1 - k2);
                                y = k1 * x + b1;

                                //MessageBox.Show(x.ToString() + " " + y.ToString());
                            }
                        }
                    }
                    else
                    {
                        double k1 = (y2 - y1) / (x2 - x1);
                        if (y3 == y4)
                        {
                            double k2 = 0;

                            if (k1 == k2)
                            {
                                return;
                            }
                            else
                            {
                                double b1 = y1 - k1 * x1;
                                double b2 = y3 - k2 * x3;

                                x = (b2 - b1) / (k1 - k2);
                                y = k1 * x + b1;
                            }
                        }
                        else
                        {
                            double k2 = (y4 - y3) / (x4 - x3);

                            if (k1 == k2)
                            {
                                return;
                            }
                            else
                            {
                                double b1 = y1 - k1 * x1;
                                double b2 = y3 - k2 * x3;


                                x = (b2 - b1) / (k1 - k2);
                                y = k1 * x + b1;

                                //MessageBox.Show(x.ToString() + " " + y.ToString());

                            }
                        }
                    }
                }

                x *= 10; y *= 10;
                Ellipse elipse = new Ellipse();
                elipse.Width = 4;
                elipse.Height = 4;
                elipse.StrokeThickness = 5;
                elipse.Stroke = Brushes.Red;
                elipse.Fill = System.Windows.Media.Brushes.Red;
                elipse.Margin = new Thickness(248 + x, 198 - y, 0, 0);
                CanvasGraf.Children.Add(elipse);

                x /= 10; y /= 10;
                double outputX = Math.Round(x, 2);
                TextBoxX.Text = Convert.ToString(outputX);

                double outputY = Math.Round(y, 2);
                TextBoxY.Text = Convert.ToString(outputY);

                //MessageBox.Show(x.ToString() + " " + y.ToString());
                //MessageBox.Show("Отрезки пересекаются");
            }
            else
            {
                MessageBox.Show("Отрезки не пересекаются");
            }

        }

        private void Ugol_Click(object sender, RoutedEventArgs e)
        {
            double x1 = Convert.ToDouble(tbX1_1.Text) * 10;
            double y1 = Convert.ToDouble(tbY1_1.Text) * 10;
            double x2 = Convert.ToDouble(tbX1_2.Text) * 10;
            double y2 = Convert.ToDouble(tbY1_2.Text) * 10;

            double radians1 = Math.Atan2(y2 - y1, x2 - x1);
            radians1 = (radians1 * 180) / Math.PI;
            double outputradians1 = Math.Round(radians1, 2);

            TextBoxAngle1.Text = Convert.ToString(outputradians1 + "°");

            //MessageBox.Show("угол отрезка 1: " + outputradians1.ToString());

            double x3 = Convert.ToDouble(tbX2_1.Text) * 10;
            double y3 = Convert.ToDouble(tbY2_1.Text) * 10;
            double x4 = Convert.ToDouble(tbX2_2.Text) * 10;
            double y4 = Convert.ToDouble(tbY2_2.Text) * 10;

            double radians2 = Math.Atan2(y4 - y3, x4 - x3);
            radians2 = (radians2 * 180) / Math.PI;
            double outputradians2 = Math.Round(radians2, 2);

            TextBoxAngle2.Text = Convert.ToString(outputradians2 + "°");

            //MessageBox.Show("угол отрезка 1: " + outputradians2.ToString());
        }

        private void Erase1_Click(object sender, RoutedEventArgs e)
        {
            CanvasGraf.Children.RemoveRange(1, CanvasGraf.Children.Count - 6);
            tbX1_1.Clear();
            tbY1_1.Clear();
            tbX1_2.Clear();
            tbY1_2.Clear();
        }

        private void Erase2_Click(object sender, RoutedEventArgs e)
        {
            CanvasGraf.Children.RemoveRange(1, CanvasGraf.Children.Count - 6);
            tbX2_1.Clear();
            tbY2_1.Clear();
            tbX2_2.Clear();
            tbY2_2.Clear();
        }

        private void Turn_Click(object sender, RoutedEventArgs e)
        {
            double x1 = Convert.ToDouble(tbX1_1.Text) * 10;
            double y1 = Convert.ToDouble(tbY1_1.Text) * 10;
            double x2 = Convert.ToDouble(tbX1_2.Text) * 10;
            double y2 = Convert.ToDouble(tbY1_2.Text) * 10;

            double TurnX = Convert.ToDouble(TextBoxTurnX.Text);
            double TurnY = Convert.ToDouble(TextBoxTurnY.Text);

            Ellipse elipse = new Ellipse();
            elipse.Width = 4;
            elipse.Height = 4;
            elipse.StrokeThickness = 5;
            elipse.Stroke = Brushes.Orange;
            elipse.Fill = System.Windows.Media.Brushes.Orange;
            elipse.Margin = new Thickness(248 + TurnX, 198 - TurnY, 0, 0);
            CanvasGraf.Children.Add(elipse);

            double TurnAngle = Convert.ToDouble(TextBoxTurnAngle.Text);

            Point pointTurn = new Point(TurnX, TurnY);
            Point pointx1 = new Point(x1, y1);
            Point pointx2 = new Point(x2, y2);

            Point p_newA = new Point();
            Point p_newB = new Point();
            double rad = (Math.PI / 180) * TurnAngle;

            p_newA.X = pointTurn.X + (pointx1.X - pointTurn.X) * Math.Cos(rad) - (pointx1.Y - pointTurn.Y) * Math.Sin(rad) + pointTurn.X;
            p_newA.Y = pointTurn.Y + (pointx1.X - pointTurn.X) * Math.Sin(rad) + (pointx1.Y - pointTurn.Y) * Math.Cos(rad) + pointTurn.Y;

            p_newB.X = pointTurn.X + (pointx2.X - pointTurn.X) * Math.Cos(rad) - (pointx2.Y - pointTurn.Y) * Math.Sin(rad) + pointTurn.X;
            p_newB.Y = pointTurn.Y + (pointx2.X - pointTurn.X) * Math.Sin(rad) + (pointx2.Y - pointTurn.Y) * Math.Cos(rad) + pointTurn.Y;

            CanvasGraf.Children.RemoveRange(1, 5);
            tbX1_1.Clear();
            tbY1_1.Clear();
            tbX1_2.Clear();
            tbY1_2.Clear();

            Line MyLine = new Line();
            MyLine.X1 = p_newA.X + 250;
            MyLine.Y1 = -p_newA.Y + 200;
            MyLine.X2 = p_newB.X + 250;
            MyLine.Y2 = -p_newB.Y + 200;
            MyLine.Stroke = System.Windows.Media.Brushes.Blue;
            MyLine.StrokeThickness = 2;
            MyLine.HorizontalAlignment = HorizontalAlignment.Left;
            MyLine.VerticalAlignment = VerticalAlignment.Center;
            CanvasGraf.Children.Add(MyLine);

            p_newA.X /= 10;
            p_newA.Y /= 10;
            p_newB.X /= 10;
            p_newB.Y /= 10;

            double outputpnewAX = Math.Round(p_newA.X, 2);
            double outputpnewAY = Math.Round(p_newA.Y, 2);
            double outputpnewBX = Math.Round(p_newB.X, 2);
            double outputpnewBY = Math.Round(p_newB.Y, 2);

            tbX1_1.Text = Convert.ToString(outputpnewAX);
            tbY1_1.Text = Convert.ToString(outputpnewAY);
            tbX1_2.Text = Convert.ToString(outputpnewBX);
            tbY1_2.Text = Convert.ToString(outputpnewBY);

            Label label = new Label();
            label.Margin = new Thickness(240 + (p_newA.X * 10), 185, 0, 0);
            label.Content = outputpnewAX.ToString();
            CanvasGraf.Children.Add(label);

            Label label2 = new Label();
            label2.Margin = new Thickness(235, 190 - (p_newA.Y * 10), 0, 0);
            label2.Content = outputpnewAY.ToString();
            CanvasGraf.Children.Add(label2);

            Label label3 = new Label();
            label3.Margin = new Thickness(240 + (p_newB.X * 10), 190, 0, 0);
            label3.Content = outputpnewBX.ToString();
            CanvasGraf.Children.Add(label3);

            Label label4 = new Label();
            label4.Margin = new Thickness(235, 185 - (p_newB.Y * 10), 0, 0);
            label4.Content = outputpnewBY.ToString();
            CanvasGraf.Children.Add(label4);

            /*MessageBox.Show("new A x1 " + p_newA.X.ToString() + " new A y1 " + p_newA.Y.ToString());
            MessageBox.Show("new B x1 " + p_newB.X.ToString() + " new B y1 " + p_newB.Y.ToString());*/
        }

        private void Contact_Click(object sender, RoutedEventArgs e)
        {
            double x1 = Convert.ToDouble(tbX1_1.Text) * 10;
            double y1 = Convert.ToDouble(tbY1_1.Text) * 10;
            double x2 = Convert.ToDouble(tbX1_2.Text) * 10;
            double y2 = Convert.ToDouble(tbY1_2.Text) * 10;

            double lambdaA = Convert.ToDouble(ContactA.Text);
            double lambdaB = Convert.ToDouble(ContactB.Text);
            double lambdaC = Convert.ToDouble(ContactC.Text);
            double lambdaD = Convert.ToDouble(ContactD.Text);

            double LambdaP1 = lambdaA / lambdaB;
            double LambdaP2 = LambdaP1 / lambdaC;
            double LambdaP3 = LambdaP2 / lambdaD;

            double LambdaX1 = (x1 + LambdaP1 * x2) / (1 + LambdaP1);
            double outputlambdaX1 = Math.Round(LambdaX1, 2);
            double LambdaY1 = (y1 + LambdaP1 * y2) / (1 + LambdaP1);
            double outputlambdaY1 = Math.Round(LambdaY1, 2);

            double LambdaX2 = (x1 + LambdaP2 * x2) / (1 + LambdaP2);
            double outputlambdaX2 = Math.Round(LambdaX2, 2);
            double LambdaY2 = (y1 + LambdaP2 * y2) / (1 + LambdaP2);
            double outputlambdaY2 = Math.Round(LambdaY2, 2);

            double LambdaX3 = (x1 + LambdaP3 * x2) / (1 + LambdaP3);
            double outputlambdaX3 = Math.Round(LambdaX3, 2);
            double LambdaY3 = (y1 + LambdaP3 * y2) / (1 + LambdaP3);
            double outputlambdaY3 = Math.Round(LambdaY3, 2);

            Ellipse elipse = new Ellipse();
            elipse.Width = 4;
            elipse.Height = 4;
            elipse.StrokeThickness = 5;
            elipse.Stroke = Brushes.Yellow;
            elipse.Fill = System.Windows.Media.Brushes.Yellow;
            elipse.Margin = new Thickness(248 + outputlambdaX1, 198 - outputlambdaY1, 0, 0);
            CanvasGraf.Children.Add(elipse);

            Ellipse elipse1 = new Ellipse();
            elipse1.Width = 4;
            elipse1.Height = 4;
            elipse1.StrokeThickness = 5;
            elipse1.Stroke = Brushes.White;
            elipse1.Fill = System.Windows.Media.Brushes.White;
            elipse1.Margin = new Thickness(248 + outputlambdaX2, 198 - outputlambdaY2, 0, 0);
            CanvasGraf.Children.Add(elipse1);

            Ellipse elipse2 = new Ellipse();
            elipse2.Width = 4;
            elipse2.Height = 4;
            elipse2.StrokeThickness = 5;
            elipse2.Stroke = Brushes.Green;
            elipse2.Fill = System.Windows.Media.Brushes.Purple;
            elipse2.Margin = new Thickness(248 + outputlambdaX3, 198 - outputlambdaY3, 0, 0);
            CanvasGraf.Children.Add(elipse2);

            //MessageBox.Show(outputlambdaX.ToString() + " " + outputlambdaY.ToString());
        }

        public bool TestPeresechenie(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double x = 0;
            double y = 0;
            if (x1 <= x2 && x3 <= x4)
            {
                if (x1 >= x2)
                {
                    x1 = x1 + x2 - (x2 = x1);
                    y1 = y1 + y2 - (y2 = y1);
                }
                if (x3 >= x4)
                {
                    x3 = x3 + x4 - (x4 = x3);
                    y3 = y3 + y4 - (y4 = y3);
                }

                if (y2 == y1)
                {
                    double k1 = 0;

                    if (y3 == y4)
                    {
                        double k2 = (y4 - y3) / (x4 - x3);

                        if (k1 == k2)
                        {

                        }
                        else
                        {
                            double b1 = y1 - k1 * x1;
                            double b2 = y3 - k2 * x3;

                            x = (b2 - b1) / (k1 - k2);
                            y = k1 * x + b1;

                            MessageBox.Show(x.ToString() + " " + y.ToString());
                            return true;
                        }
                    }
                }
                else
                {
                    double k1 = (y2 - y1) / (x2 - x1);
                    if (y3 == y4)
                    {
                        double k2 = 0;


                        if (k1 == k2)
                        {

                        }
                        else
                        {
                            double b1 = y1 - k1 * x1;
                            double b2 = y3 - k2 * x3;

                            x = (b2 - b1) / (k1 - k2);
                            y = k1 * x + b1;
                            MessageBox.Show(x.ToString() + " " + y.ToString());
                            return true;
                        }
                    }
                    else
                    {
                        double k2 = (y4 - y3) / (x4 - x3);

                        if (k1 == k2)
                        {

                        }
                        else
                        {
                            double b1 = y1 - k1 * x1;
                            double b2 = y3 - k2 * x3;


                            x = (b2 - b1) / (k1 - k2);
                            y = k1 * x + b1;

                            MessageBox.Show(x.ToString() + " " + y.ToString());
                            return true;

                        }
                    }
                }
            }
            else
            {
                if (y2 == y1)
                {
                    double k1 = 0;

                    if (y3 == y4)
                    {
                        double k2 = (y4 - y3) / (x4 - x3);

                        if (k1 == k2)
                        {

                        }
                        else
                        {
                            double b1 = y1 - k1 * x1;
                            double b2 = y3 - k2 * x3;

                            x = (b2 - b1) / (k1 - k2);
                            y = k1 * x + b1;

                            MessageBox.Show(x.ToString() + " " + y.ToString());
                        }
                    }
                }
                else
                {
                    double k1 = (y2 - y1) / (x2 - x1);
                    if (y3 == y4)
                    {
                        double k2 = 0;

                        if (k1 == k2)
                        {

                        }
                        else
                        {
                            double b1 = y1 - k1 * x1;
                            double b2 = y3 - k2 * x3;

                            x = (b2 - b1) / (k1 - k2);
                            y = k1 * x + b1;
                        }
                    }
                    else
                    {
                        double k2 = (y4 - y3) / (x4 - x3);

                        if (k1 == k2)
                        {

                        }
                        else
                        {
                            double b1 = y1 - k1 * x1;
                            double b2 = y3 - k2 * x3;


                            x = (b2 - b1) / (k1 - k2);
                            y = k1 * x + b1;

                            MessageBox.Show(x.ToString() + " " + y.ToString());
                        }
                    }
                }
            }
            MessageBox.Show(x.ToString() + " " + y.ToString());
            return true;
        }



        public bool TestUgol(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double radians1 = Math.Atan2(y2 - y1, x2 - x1);
            radians1 = (radians1 * 180) / Math.PI;
            double outputradians1 = Math.Round(radians1, 2);

            MessageBox.Show("угол отрезка 1: " + outputradians1.ToString() + "°");

            double radians2 = Math.Atan2(y4 - y3, x4 - x3);
            radians2 = (radians2 * 180) / Math.PI;
            double outputradians2 = Math.Round(radians2, 2);

            MessageBox.Show("угол отрезка 2: " + outputradians2.ToString() + "°");

            return true;
        }

        public bool TestTurn(double x1, double y1, double x2, double y2, double TurnX, double TurnY, double TurnAngle)
        {
            Point pointTurn = new Point(TurnX, TurnY);
            Point pointx1 = new Point(x1, y1);
            Point pointx2 = new Point(x2, y2);

            Point p_newA = new Point();
            Point p_newB = new Point();
            double rad = (Math.PI / 180) * TurnAngle;

            p_newA.X = pointTurn.X + (pointx1.X - pointTurn.X) * Math.Cos(rad) - (pointx1.Y - pointTurn.Y) * Math.Sin(rad) + pointTurn.X;
            p_newA.Y = pointTurn.Y + (pointx1.X - pointTurn.X) * Math.Sin(rad) + (pointx1.Y - pointTurn.Y) * Math.Cos(rad) + pointTurn.Y;

            p_newB.X = pointTurn.X + (pointx2.X - pointTurn.X) * Math.Cos(rad) - (pointx2.Y - pointTurn.Y) * Math.Sin(rad) + pointTurn.X;
            p_newB.Y = pointTurn.Y + (pointx2.X - pointTurn.X) * Math.Sin(rad) + (pointx2.Y - pointTurn.Y) * Math.Cos(rad) + pointTurn.Y;

            p_newA.X /= 10;
            p_newA.Y /= 10;
            p_newB.X /= 10;
            p_newB.Y /= 10;

            MessageBox.Show("новая кооридината A x1 " + p_newA.X.ToString() + " новая кооридината A y1 " + p_newA.Y.ToString());
            MessageBox.Show("новая кооридината B x1 " + p_newB.X.ToString() + " новая кооридината B y1 " + p_newB.Y.ToString());

            return true;
        }

        public bool TestContact(double x1, double y1, double x2, double y2, double lambdaA, double lambdaB, double lambdaC, double lambdaD)
        {
            double LambdaP1 = lambdaA / lambdaB;
            double LambdaP2 = LambdaP1 / lambdaC;
            double LambdaP3 = LambdaP2 / lambdaD;

            double LambdaX1 = (x1 + LambdaP1 * x2) / (1 + LambdaP1);
            double outputlambdaX1 = Math.Round(LambdaX1, 2);
            double LambdaY1 = (y1 + LambdaP1 * y2) / (1 + LambdaP1);
            double outputlambdaY1 = Math.Round(LambdaY1, 2);

            double LambdaX2 = (x1 + LambdaP2 * x2) / (1 + LambdaP2);
            double outputlambdaX2 = Math.Round(LambdaX2, 2);
            double LambdaY2 = (y1 + LambdaP2 * y2) / (1 + LambdaP2);
            double outputlambdaY2 = Math.Round(LambdaY2, 2);

            double LambdaX3 = (x1 + LambdaP3 * x2) / (1 + LambdaP3);
            double outputlambdaX3 = Math.Round(LambdaX3, 2);
            double LambdaY3 = (y1 + LambdaP3 * y2) / (1 + LambdaP3);
            double outputlambdaY3 = Math.Round(LambdaY3, 2);

            MessageBox.Show("точка отношения 1 " + outputlambdaX1 + "/" + outputlambdaY1);
            MessageBox.Show("точка отношения 2 " + outputlambdaX2 + "/" + outputlambdaY2);
            MessageBox.Show("точка отношения 3 " + outputlambdaX3 + "/" + outputlambdaY3);

            return true;
        }
    }
}

