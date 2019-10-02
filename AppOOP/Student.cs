using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AppOOP
{
    class Student
    {
        private string Name;

        public string StudentName
        {
            get { return Name; }
            set { Name = value; }
        }

        public Student(string stName)
        {
            this.Name = stName;
        }

        public Student(){}

        public virtual void Talk()
        {
            if (StudentName.Equals("Thinh"))
            MessageBox.Show("My name is " + this.StudentName + "\n" + "I am a college student");
            else if (StudentName.Equals("Khoa"))
            MessageBox.Show("My name is " + this.StudentName + "\n" + "I am a university student");
        }
      
 }
    }

