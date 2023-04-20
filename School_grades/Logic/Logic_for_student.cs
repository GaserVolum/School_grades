using System;   
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Data_model;
using School_grades;

namespace Logic
{
    public class Logic_for_student
    {
        //public void info_ab_student(List<Student> st)
        //{

        //    Console.WriteLine("           Информация\n                    " +
        //      $"▌ Имя: {st[st.StudentID].Name}\n                                       ▌" +
        //      $"▌Возраст: {st.Age}\n                                     ▌" +
        //      $"▌Класс: {st.school_class_student}\n                      ▌" +
        //      $"▌День рождения: {st.Birthday}\n                          ▌" +
        //      $"▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬\n" +
        //      $"");
        //}
        public void info_ab_student(Student st)
        {
            Console.WriteLine($"           Информация об студенте({st.Login_for_ADMIN})\n                    " +
               $"▌Имя: {st.Name}\n" +
               $"▌Возраст: {st.Age}\n" +
               $"▌Группа: {st.group}\n" +
               $"▌День рождения: {st.Birthday}\n" +
               $"▌Ваш ID:{st.StudentID}\n" +
               $"▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬\n" +
               $"");
            Main_logic.exit();
        }
        public void see_grade_for_student(ref Student student)
        {
            Console.WriteLine("Предметы\\оценки");
            for (int i = 0; i < student.subjects_for_student.Count; i++)
            {
                Console.Write(student.subjects_for_student[i].Name);
                for (int g = 0; g < student.subjects_for_student[i].grades.Count; g++)
                {
                    Console.Write(" "+student.subjects_for_student[i].grades[g]);
                }
                Console.WriteLine();
            }
            Main_logic.exit();

        }
        public void registration_for_student(List<Student> group)
        {
            Random rnd = new Random();
            Student student = new Student();
            Console.WriteLine("Регистрация ");
            Console.Write($"Логин:"); student.Login_for_student = Console.ReadLine();
            //for (int i = 0; i <= group.Count; i++)
            //{
            //    if (student.Login_for_ADMIN == group[i].Login_for_ADMIN)
            //    {
            //        Console.WriteLine("Такой логин уже есть");

            //        break;
            //    }
            //}

            Console.Write($"Пароль(Запомните свой пароль, он нужен для входа):"); student.Password_for_student = Console.ReadLine();
            Console.Write("ФИО-"); student.Name = Console.ReadLine();
            Console.Write("Возраст-"); student.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Дата рождения:");
            Console.Write("год(хххх)-"); string temp_year = Console.ReadLine();
            Console.Write("месяц(хх):"); string temp_mounth = Console.ReadLine();
            Console.Write("день(х-хх):"); string temp_day = Console.ReadLine();
            student.Birthday = temp_day + " " + temp_mounth + " " + temp_year;
            Console.WriteLine(student.Birthday);
            int rnd_g = rnd.Next(0, 5);
            switch (rnd_g)
            {
                case 1:
                    student.group = 1;
                    //groups[0].students.Add(student);
                    //student.StudentID = groups[0].students.Count;
                    break;
                case 2:
                    student.group = 2;
                    //groups[1].students.Add(student);
                    //student.StudentID = groups[1].students.Count;
                    break;
                case 3:
                    student.group = 3;
                    //groups[2].students.Add(student);
                    //student.StudentID = groups[2].students.Count;
                    break;
                case 4:
                    student.group = 4;
                    //groups[3].students.Add(student);
                    //student.StudentID = groups[3].students.Count;
                    break;
            }
            Console.WriteLine($"Ваша группа {student.group}");

            student.StudentID = group.Count;
            group.Add(student);
            //using (FileStream fstream = new FileStream("note3.txt", FileMode.OpenOrCreate))
            //{
            //   using(StreamWriter sw = new StreamWriter(fstream))
            //    {
            //        Console.WriteLine(student);
            //    }
            //}
            Console.WriteLine($"{student.Name}, вы успешно прошли регистрацию");
            //using (FileStream fstream = new FileStream("_Data_/note3.txt", FileMode.OpenOrCreate))
            //{
            //    using (StreamReader sr = new StreamReader(fstream))
            //    {
            //        while (sr.ReadLine != null)
            //        {
            //            List<>
            //        }
            //    }
            //}
            Main_logic.exit();
        }




    
        public void log_out_of_your_account(ref Student student, List<Student> group )
        {
            student.login_status_for_student = false;
            student = group[student.StudentID];
            Console.WriteLine("Вы вышли из учетной записи ученика");
            Main_logic.exit();
        }
        public void Log_in_for_student(List<Student> group,ref Student student)
        {
           
            
                int tempID = -1;
                Console.WriteLine("Вход");
                Console.Write("Логин:");
                string temp_input_data_for_login = Console.ReadLine();
                for (int i = 0; i < group.Count; i++)
                {

                if (group[i].Login_for_ADMIN == temp_input_data_for_login)
                    {
                        tempID = group[i].StudentID;
                        break;
                    }
                 
                    else
                    {

                    }
                }
                
                if(tempID>-1)
                {
                    Console.Write("Пароль:");
                    string temp_input_data_for_password = Console.ReadLine();
                    if (temp_input_data_for_password == group[tempID].Password_for_ADMIN)
                    {
                 
                    Console.WriteLine($"Здравствуйте, {group[tempID].Name}");

                    student = group[tempID];
                    if(student.login_status_for_student==false) { student.login_status_for_student = true; }
                    else
                    {
                        Console.WriteLine("Ошибка");
                    }
                      
                        Main_logic.exit();
                    }
                    else
                    {
                        Console.WriteLine("Неверный пароль");
                    Main_logic.exit();
                    }
                }
             else if(tempID == -1)
            {
                Console.WriteLine("Такого логина нет");
                Main_logic.exit();
            }


        }
    }
    public class Logic_for_school_class
    {
        general_class gc = new general_class();
        public string[] sch_subject = new string[10]
        {
            $"▌{general_class.school_subjects.русский_язык} " ,
            $"▌{general_class.school_subjects.иностранный_язык} " ,
            $"▌{general_class.school_subjects.история}" ,
            $"▌{general_class.school_subjects.литература} " ,
            $"▌{general_class.school_subjects.математика} " ,
            $"▌{general_class.school_subjects.технология}" ,
            $"▌{general_class.school_subjects.физическая_культура}" ,
            $"▌{general_class.school_subjects.музыка} " ,
            $"▌ " ,
            $"▌ " ,
        };

    }

}

