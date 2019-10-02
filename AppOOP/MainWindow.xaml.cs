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

namespace AppOOP
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

        private void btnTalk_Click(object sender, RoutedEventArgs e)
        {
            StudentCollege college = new StudentCollege();
            college.StudentName = "Thinh";
            college.Talk();
            StudentUniversity university = new StudentUniversity();
            university.StudentName = "Khoa";
            university.Talk();

            Student[] studentList = new Student[3];
           
            studentList[0] = new Student("Minh");
            
            studentList[1] = new Student("Hoa");
            
            studentList[2] = new Student("Dung");
            
            for (int i = 0; i < 3; i++)
            {
                Lst.Items.Add(studentList[i].StudentName);
            }

        }

        private void Lst_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
