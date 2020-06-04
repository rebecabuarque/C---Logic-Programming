using System;
using System.Collections.Generic;

namespace ExercicioLista1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many employees will be registered?");
            int n = int.Parse(Console.ReadLine());
            List <Funcionario> list = new List<Funcionario>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                list.Add(new Funcionario(id, name, salary));
                Console.WriteLine();
            }
            Console.Write("Enter the employee id that will have salary increase: ");
            int findId = int.Parse(Console.ReadLine());
            Funcionario emp = list.Find(x => x.Id == findId);
                if (emp != null)
                {
                Console.Write("Enter percentage:");
                int percentage = int.Parse(Console.ReadLine());
                emp.increaseSalary(percentage);
                }
            else
            {
                Console.WriteLine("Invalid ID");
            }
            Console.WriteLine();
            Console.WriteLine("Updated list of employee: ");
            foreach (Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }
          
            
        }
    }
}
