using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace razakov
{

    using System;

    public class Student
    {
        // Поля класса Student
        public string FullName { get; set; }
        public string Group { get; set; }
        public double AverageGrade { get; set; }

        // Конструктор класса Student
        public Student(string fullName, string group, double averageGrade)
        {
            FullName = fullName;
            Group = group;
            AverageGrade = averageGrade;
        }

        // Метод для получения суммы стипендии
        public virtual double GetScholarship()
        {
            return AverageGrade == 5.0 ? 2000 : 1900; // Стипендия в зависимости от средней оценки
        }
    }

    public class Aspirant : Student
    {
        // Поле класса Aspirant
        public string ScientificWork { get; set; }

        // Конструктор класса Aspirant
        public Aspirant(string fullName, string group, double averageGrade, string scientificWork)
            : base(fullName, group, averageGrade)
        {
            ScientificWork = scientificWork;
        }

        // Переопределение метода для получения суммы стипендии для аспирантов
        public override double GetScholarship()
        {
            return AverageGrade == 5.0 ? 2500 : 2200; // Стипендия для аспирантов
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создание объектов класса Student
            Student student1 = new Student("Иванов Иван Иванович", "Группа A", 4.5);
            Student student2 = new Student("Петров Петр Петрович", "Группа B", 3.8);

            // Создание объекта класса Aspirant
            Aspirant aspirant1 = new Aspirant("Сидоров Сидор Сидорович", "Группа C", 5.0, "Научная работа по математике");

            // Вывод информации о студентах и их стипендиях
            Console.WriteLine($"{student1.FullName}, группа: {student1.Group}, средняя оценка: {student1.AverageGrade}, стипендия: {student1.GetScholarship()} руб.");
            Console.WriteLine($"{student2.FullName}, группа: {student2.Group}, средняя оценка: {student2.AverageGrade}, стипендия: {student2.GetScholarship()} руб.");
            Console.WriteLine($"{aspirant1.FullName}, группа: {aspirant1.Group}, средняя оценка: {aspirant1.AverageGrade}, научная работа: {aspirant1.ScientificWork}, стипендия: {aspirant1.GetScholarship()} руб.");

            Console.ReadKey();
        }
    }
}