
namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////employees |#|#|A|#|#|S|#|#|#|#|
            ///choose index 0->9
            ///2
            ///enter id 1
            ///enter name ali
            ///enter age 22
            ///enter salary 1234
            ///continue y or n ? y
            ///choose index
            ///5
            ///enter id 2
            ///enter name Sara
            ///enter age 23
            ///enter salary 4234
            ///continue y or n ? n
            ///print Sara and ali ONLY

            Employee[] employees = new Employee[10];
            int index;
            string flag;
            do
            {
                do
                {
                    Console.WriteLine("Choose index 0->9");
                    index = int.Parse(Console.ReadLine());
                } while (index < 0 || index > 9);

                employees[index] = new Employee();
                
                Console.WriteLine("Enter id");
                employees[index].SetId(int.Parse(Console.ReadLine()));
                Console.WriteLine("Enter name");
                employees[index].SetName(Console.ReadLine());
                do
                {
                    Console.WriteLine("Enter age");
                    employees[index].SetAge(int.Parse(Console.ReadLine()));
                }
                while (employees[index].GetAge() < 18 || employees[index].GetAge() > 60);

                Console.WriteLine("Enter salary");
                employees[index].SetSalary(decimal.Parse(Console.ReadLine()));

                Console.WriteLine("Continue , yes or no");
                flag = Console.ReadLine();

            }
            while (flag.ToLower() == "yes");

            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] != null)
                {
                    Console.WriteLine(employees[i].Print());
                }
            }
        }
    }
}
