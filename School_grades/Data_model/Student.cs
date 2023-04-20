using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static Data_model.Group_grade_subject;

namespace Data_model
{
    public  class Student
    {
        general_class gc=new general_class();
        public string Name { get; set; }
        public int Age { get; set; }
        public string Birthday { get; set;}
        string login;
        string password;
        public string Login_for_student { set { login = value; } }
        public string Login_for_ADMIN { get { return login; } }
        public string Password_for_student { set { password=value; } }
        public string Password_for_ADMIN { get { return password; } }
        public int group { get; set; }
        
      
        //public bool registration_status { set { registration_status = value; } }
        public int StudentID { get; set; }
        public bool login_status_for_student { get; set; }
        //public List<grade> grades_for_subject = new List<grade>();

        //public List<Group_grade_subject.> subjects_for_student = new List<Group_grade_subject.subject>(); 
        public List<subject> subjects_for_student = new List<subject>() {
            new subject() {Name=general_class.school_subjects.русский_язык, grades=new List<int>()},
            new subject() {Name=general_class.school_subjects.технология, grades=new List<int>()},
           new subject() {Name=general_class.school_subjects.физическая_культура, grades = new List < int >()},
           new subject() {Name=general_class.school_subjects.музыка, grades = new List < int >()},
           new subject() {Name=general_class.school_subjects.математика, grades = new List < int >()},
           new subject() {Name=general_class.school_subjects.литература, grades = new List < int >()},
           new subject() {Name=general_class.school_subjects.история, grades = new List < int >()},
           new subject() {Name=general_class.school_subjects.иностранный_язык, grades = new List < int >()},
            };

    }
}
