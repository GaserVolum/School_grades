namespace Data_model
{
    public class general_class
    {
      public enum groups
        {
            group1,
            group2,
            group3,
            group4
        }

        public enum school_subjects
        {
                русский_язык,
                литература,
                математика,
                иностранный_язык,
                история,
                физическая_культура,
                музыка,
                технология,
           
        }
        public List<subject> subjects_list = new List<subject>() {
            new subject() {Name=school_subjects.русский_язык},
            new subject() {Name=school_subjects.технология},
           new subject() {Name=school_subjects.физическая_культура},
           new subject() {Name=school_subjects.музыка},
           new subject() {Name=school_subjects.математика},
           new subject() {Name=school_subjects.литература},
           new subject() {Name=school_subjects.история},
           new subject() {Name=school_subjects.иностранный_язык},
            };
        public void print_string_all_array(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}