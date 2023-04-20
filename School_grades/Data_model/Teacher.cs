using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_model
{
    public class Teacher
    {

      
        public string Name { get; set; }
        public int Age { get; set; }
        public string Birthday { get; set; }
        string login;
        string password;
        public string Login_for_teacher { set { login = value; } }
        public string Login_for_ADMIN { get { return login; } }
        public string Password_for_teacher { set { password = value; } }
        public string Password_for_ADMIN { get { return password; } }
        public general_class.groups group { get; set; }
        public int group_ID { get; set; }
        public general_class.school_subjects subject_for_teacher {  get; set; }
        public int subject_id { get;set; }

        //public bool registration_status { set { registration_status = value; } }
        public int TeacherID { get; set; }
        public bool login_status_for_teacher { get; set; }
      

    }
}
