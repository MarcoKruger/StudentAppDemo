using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace StudentApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        StudentsList studentsList = new StudentsList();
        private void onLoad(object sender, RoutedEventArgs e)
        {
            foreach (var item in studentsList.student)
            {
                StudentList.Items.Add(item.Name);
            }
        }
        int clicked = 3;
        private void StudentList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            clicked++;
            StudentInfo.Text = $"Items clicked {clicked.ToString()} with {StudentList.SelectedIndex}";
            var clickedStudent = from st in studentsList.student where st.ID == StudentList.SelectedIndex select st;
            foreach (var item in clickedStudent)
            {
                StudentInfo.Text = $"Name = {item.Name}  \n Courses:  \n {item.Course[0]}  \n {item.Course[1]}";
            }
        }
    }
}
