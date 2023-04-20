using System;
using Data_model;
using Logic;

namespace School_grades
{
    class Program
    {
        static void Main(string[] args)
        {


            Logic_for_school_class logic_1_ = new Logic_for_school_class();
            Logic_for_student logic_For_Student = new Logic_for_student();
            Logic_for_teacher logic_For_teacher = new Logic_for_teacher();
            Data_model.general_class general_Class = new Data_model.general_class();
            Menu menu = new Menu();
            school_class group_1 = new school_class();
            // school_class group_2 = new school_class();
            // school_class group_3 = new school_class();
            // school_class group_4 = new school_class();
            //List<school_class> array_group=new List<school_class> {group_1, group_2, group_3, group_4};
            Student student = new Student();
            Teacher teacher = new Teacher();
            //general_Class.print_string_all_array(menu.main__main_menu);         
            //general_Class.print_string_all_array(logic_1_.sch_subject);
            //logic_For_Student.registration_for_student();
            while (true)
            {
                while (student.login_status_for_student == false && teacher.login_status_for_teacher == false)
                {
                    try
                    {
                        general_Class.print_string_all_array(menu.main__main_menu);
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
                        int section_selection = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
                        switch (section_selection)
                        {
                            case 1:
                                Console.Clear();
                                logic_For_Student.Log_in_for_student(group_1.students, ref student);
                                Console.Clear();
                                break;
                            case 2:
                                Console.Clear();
                                logic_For_teacher.Log_in_for_teacher(group_1.teachers, ref teacher);
                                Console.Clear();
                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine(menu.information);
                                Main_logic.exit();
                                Console.Clear();
                                break;
                            case 4:
                                Console.Clear();
                                logic_For_Student.registration_for_student(group_1.students);
                                Console.Clear();
                                break;
                            case 5:
                                Console.Clear();
                                logic_For_teacher.registration_for_teacher(group_1.teachers);
                                Console.Clear();
                                break;
                            default: Console.Clear(); break;
                        }
                    }
                    catch (System.FormatException)
                    {
                        Console.Clear();
                    }
                }
                while (student.login_status_for_student == true && teacher.login_status_for_teacher == false)
                {
                    try
                    {

                 
                        general_Class.print_string_all_array(menu.main_menu_for_student);
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
                        int section_selection_for_student = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
                        switch (section_selection_for_student)
                        {
                            case 1:
                                Console.Clear();
                                logic_For_Student.see_grade_for_student(ref student);
                                Console.Clear();
                                break;
                            case 2:
                                break;
                            case 3:
                                Console.Clear();
                                logic_For_Student.info_ab_student(student);
                                Console.Clear();
                                break;
                            case 4:
                                Console.Clear();
                                logic_For_Student.log_out_of_your_account(ref student, group_1.students);
                                Console.Clear();
                                break;
                            default:
                                Console.Clear();
                                break;
                        }
                    }
                    catch (System.FormatException)
                    {
                        Console.Clear();
                    }
                }


                while (teacher.login_status_for_teacher == true && student.login_status_for_student == false)
                {
                    try
                    {
                        general_Class.print_string_all_array(menu.main_menu_for_teacher);


                        int section_selection_for_teacher = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
                        switch (section_selection_for_teacher)
                        {
                            case 1:
                                break;
                            case 2:
                                Console.Clear();
                                logic_For_teacher.start_lesson(teacher, group_1.students);
                                break;
                            case 3:
                                Console.Clear();
                                logic_For_teacher.info_ab_teacher(teacher, group_1.students);
                                Console.Clear();
                                break;
                            case 4:
                                Console.Clear();
                                logic_For_teacher.log_out_of_your_account(ref teacher, group_1.teachers);
                                Console.Clear();
                                break;
                            default:
                                Console.Clear();
                                break;
                        }
                    }
                    catch (System.FormatException)
                    {
                        Console.Clear();
                    }
                }
            }
        }

    }
}
    
