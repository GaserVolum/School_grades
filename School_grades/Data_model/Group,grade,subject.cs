using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_model
{
    public class Group_grade_subject
    {
     
        //public class grade
        //{

        //    public int value_gr { get; set; }
        //    public grade(int value_gr)
        //    {
        //        this.value_gr = value_gr;
        //    }



            //public DateTime Date_grade { get; set; }
        }
        public class subject
        {
        
            public general_class.school_subjects Name { get; set; }
           public List<int> grades=new List<int>();
            public Teacher teacher { get; set; }
           
        }   
       //public  List<subject> subjects1 = new() {
       //     new subject() {Name=general_class.school_subjects.русский_язык},
       //     new subject() {Name=general_class.school_subjects.технология},
       //    new subject() {Name=general_class.school_subjects.физическая_культура},
       //    new subject() {Name=general_class.school_subjects.музыка},
       //    new subject() {Name=general_class.school_subjects.математика},
       //    new subject() {Name=general_class.school_subjects.литература},
       //    new subject() {Name=general_class.school_subjects.история},
       //    new subject() {Name=general_class.school_subjects.иностранный_язык},
       //     };
    }

