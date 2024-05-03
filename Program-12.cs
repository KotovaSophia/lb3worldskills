internal class Program
{
    struct Student
    {
        public string Fam_name,
            IO,
            NumberGroup;

        public int[] Grades;

        public Student(string fam_name, string io, string number_group, int[] grades)
        {
            Fam_name = fam_name;
            IO = io;
            NumberGroup = number_group;
            Grades = grades;
        }
    }

    private static void Main(string[] args)
    {
        Student[] students = new Student[7];

        students[0] = new("Сочина", "М.В.", "22ИТ27", new int[] { 5, 4, 3, 2, 2 });
        students[1] = new("Простов", "М.С.", "23ИТ28", new int[] { 5, 5, 3, 4, 3 });
        students[2] = new("Тихонова", "Т.М.", "21ИТ16", new int[] { 5, 3, 2, 2, 5 });
        students[3] = new("Петрова", "Д.М.", "22ИТ17", new int[] { 4, 3, 3, 4, 4 });
        students[4] = new("Сахаров", "С.Т.", "21ИТ25", new int[] { 4, 5, 5, 5, 4 });
        students[5] = new("Ясенева", "В.И.", "20ИТ17", new int[] { 3, 3, 4, 5, 3 });
        students[6] = new("Советова", "М.Ю.", "21ИТ20", new int[] { 5, 5, 5, 5, 4 });

        for (int i = 0; i < students.Length; i++)
        {
            for (int j = 0; j < students.Length; j++)
            {
                if (Avverage_rating(students[i].Grades) < Avverage_rating(students[j].Grades))
                {
                    Student[] temp = new Student[1];
                    temp[0] = students[i];
                    students[i] = students[j];
                    students[j] = temp[0];
                }
            }
        }

        for (int i = 0; i < students.Length; i++)
        {
            Console.Write($"Студент группы {students[i].NumberGroup} {students[i].Fam_name} {students[i].IO} - ");
            for (int j = 0; j < students[i].Grades.Length; j++)
            {
                Console.Write($"{students[i].Grades[j]} ");
            }
            Console.WriteLine("");
        }
    }

    static double Avverage_rating(int[] nums)
    {
        double result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
               result += nums[i];
            }
        return result / nums.Length;
    }
}