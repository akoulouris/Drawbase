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
//using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DrawBase
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

        //private bool isMouseDown = false;


        //private void moving_menu_MouseDown(object sender, MouseEventArgs e)

        //{
         
        //    isMouseDown = true;

        //}
        //private void Main_Grid_MouseMove(object sender, MouseEventArgs e)

        //{
        //    fp_Move_Control(sender, e);
        //}
 
       
        //private void moving_menu_MouseMove(object sender, MouseEventArgs e)

        //{
        //    Mouse.OverrideCursor = Cursors.Hand;
        //    fp_Move_Control(sender, e);
        //}

        //private void fp_Move_Control(object sender, MouseEventArgs e)
        //{
        //    if(e.LeftButton == MouseButtonState.Pressed)
        //    {
        //        Point mouse = e.GetPosition(this);

        //        int actheight = (int)Application.Current.MainWindow.Height;
        //        int margin_button = actheight - ((int)mouse.Y + (int)moving_menu.Height + (int)SystemParameters.CaptionHeight + (int)SystemParameters.BorderWidth + 4);
                    
        //          int actwidth = (int)Application.Current.MainWindow.Width;
        //        int margin_right = actwidth - ((int)mouse.X + (int)moving_menu.Width + (int)SystemParameters.BorderWidth);


        //        moving_menu.Margin = new Thickness(mouse.X, mouse.Y, margin_right, margin_button);
        //    }
        //}

        //--------------------------------------------------------------------------------------------------------------
        //private void userControl11_MouseMove(object sender, MouseEventArgs e)

        //{

        //    if (isMouseDown == true)

        //    {

        //        userControl11.Location = new Point(e.X, e.Y);

        //    }

        //}



        //private void userControl11_MouseUp(object sender, MouseEventArgs e)

        //{

        //    isMouseDown = false;

        //}


        //private void MenuItem_Click(object sender, RoutedEventArgs e)
        //{

        //}
    }
}
