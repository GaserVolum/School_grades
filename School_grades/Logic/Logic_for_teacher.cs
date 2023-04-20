using Data_model;
using School_grades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Logic_for_teacher
    {
        public void info_ab_teacher(Teacher tch , List<Student> group)
        {
            Console.WriteLine($"  Информация об учителе({tch.Login_for_ADMIN})\n                    " +
               $"▌Имя: {tch.Name}\n" +
               $"▌Возраст: {tch.Age}\n" +
               $"▌Группа: {tch.group}\n" +
               $"▌День рождения: {tch.Birthday}\n" +
               $"▌Ваш ID:{tch.TeacherID}\n" +
               $"▌Ученики:{group.Count}\n"+
               $"▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬\n" +
               $"");
            Main_logic.exit();
        }
        public void start_lesson(Teacher teacher,List<Student> group)
        {
            bool start_lesson_status = false;
            while (start_lesson_status == false)
            {
                Console.Clear();
                try
                {
                    for (int h = 0; h < group.Count; h++)
                    {
                        Console.Write(group[h].StudentID + " " + group[h].Name+": ");
                        for (int a = 0; a < group[h].subjects_for_student[teacher.subject_id].grades.Count; a++)
                        {
                            Console.Write(" "+group[h].subjects_for_student[teacher.subject_id].grades[a]+" ");

                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("                                                                                    Закончить урок <end><lesson>");

                  
                    Console.WriteLine("Поставить оценку(Enter+личный ID ученика + enter оценка от1 до 5 + enter)");
                    string tp = Console.ReadLine();
                    if (tp == "<end><lesson>")
                    {
                        start_lesson_status = true;
                        Console.WriteLine("Урок окончен");
                        Main_logic.exit();
                    }
                    else
                    {
                        Console.WriteLine("ID ученика");
                        int i = 0;
                        int temp_id = int.Parse(Console.ReadLine());
                        for (i = 0; i < group.Count; i++)
                        {
                            if (temp_id == group[i].StudentID)
                            {
                                Console.WriteLine($"Ученик {group[i].Name}");
                                break;
                            }
                            else { }
                        }
                        Console.WriteLine("Оценка за урок");
                        int temp_grade = int.Parse(Console.ReadLine());
                        if (temp_grade > 0 && temp_grade < 6)
                        {
                            group[i].subjects_for_student[teacher.subject_id].grades.Add(temp_grade);
                        }
                        else
                        {

                        }
                    }
                    
                }
                catch (FormatException) { Console.Clear(); }


            }
        }
        public void registration_for_teacher(List<Teacher> group)
        {

            general_class sb = new general_class();   
           Teacher teacher = new Teacher();
            Console.WriteLine("Регистрация ");
            Console.Write($"Логин:"); teacher.Login_for_teacher = Console.ReadLine();
            Console.Write($"Пароль(Запомните свой пароль, он нужен для входа):"); teacher.Password_for_teacher = Console.ReadLine();
            Console.Write("ФИО-"); teacher.Name = Console.ReadLine();
            Console.Write("Возраст-"); teacher.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Дата рождения:");
            Console.Write("год(хххх)-"); string temp_year = Console.ReadLine();
            Console.Write("месяц(хх):"); string temp_mounth = Console.ReadLine();
            Console.Write("день(х-хх):"); string temp_day = Console.ReadLine();
            teacher.Birthday = temp_day + " " + temp_mounth + " " + temp_year;
            Console.WriteLine(teacher.Birthday);
            Console.WriteLine("Выберете предмет, которому будете обучать");
            for (int i = 0; i < sb.subjects_list.Count; i++)
            {
                Console.WriteLine(i+" "+sb.subjects_list[i].Name);
            }
          
            int temp = int.Parse(Console.ReadLine());
            switch (temp)
            {
                case 1:
                    teacher.subject_for_teacher = general_class.school_subjects.русский_язык;
                    teacher.subject_id = 0;
                    break;
                case 2:
                    teacher.subject_for_teacher = general_class.school_subjects.технология;
                    teacher.subject_id = 1;
                    break;
                case 3:
                    teacher.subject_for_teacher = general_class.school_subjects.физическая_культура;
                    teacher.subject_id = 2;
                    break;
                case 4:
                    teacher.subject_for_teacher = general_class.school_subjects.музыка;
                    teacher.subject_id = 3;
                    break;
                case 5:
                    teacher.subject_for_teacher = general_class.school_subjects.математика;
                    teacher.subject_id = 4;
                    break;
                case 6:
                    teacher.subject_for_teacher = general_class.school_subjects.литература;
                    teacher.subject_id = 5;
                    break;
                case 7:
                    teacher.subject_for_teacher = general_class.school_subjects.история;
                    teacher.subject_id = 6;
                    break;
                case 8:
                    teacher.subject_for_teacher = general_class.school_subjects.иностранный_язык;
                    teacher.subject_id = 7;
                    break;

                default:
                    break;
            }
           

            Console.WriteLine($"{teacher.Name}, вы успешно прошли регистрацию");
            teacher.TeacherID = group.Count;
            group.Add(teacher);
            Main_logic.exit();

        }
        public void Log_in_for_teacher(List<Teacher> group, ref Teacher teacher)
        {

            int tempID = -1;
            Console.WriteLine("Вход");
            Console.Write("Логин:");
            string temp_input_data_for_login = Console.ReadLine();
            for (int i = 0; i < group.Count; i++)
            {

                if (group[i].Login_for_ADMIN == temp_input_data_for_login)
                {
                    tempID = group[i].TeacherID;
                    break;
                }

                else
                {

                }
            }

            if (tempID > -1)
            {
                Console.Write("Пароль:");
                string temp_input_data_for_password = Console.ReadLine();
                if (temp_input_data_for_password == group[tempID].Password_for_ADMIN)
                {

                    Console.WriteLine($"Здравствуйте, {group[tempID].Name}");

                    teacher = group[tempID];
                    if (teacher.login_status_for_teacher == false) { teacher.login_status_for_teacher = true; }
                    else
                    {
                        Console.WriteLine("Ошибка! Попробуйте еще раз");
                        teacher.login_status_for_teacher = false;
                    }

                    Main_logic.exit();
                }
                else
                {
                    Console.WriteLine("Неверный пароль");
                    Main_logic.exit();
                }
            }
            else if (tempID == -1)
            {
                Console.WriteLine("Такого логина нет");
                Main_logic.exit();
            }


        }
        public void log_out_of_your_account(ref Teacher teacher, List<Teacher> group)
        {
            teacher.login_status_for_teacher = false;
            teacher = group[teacher.TeacherID];
            Console.WriteLine("Вы вышли из учетной записи учителя");
            Main_logic.exit();
        }
    }
}

