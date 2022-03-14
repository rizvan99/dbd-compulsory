using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBD_Compulsory
{
    public class App
    {
        public App()
        {

        }

        public void Run()
        {
            string[] menuItems =
            {
                "Create department",
                "Update department name",
                "Update department manager",
                "Delete department",
                "Get department",
                "Get all departments",
                "Exit"
            };

            var selection = ShowMenu(menuItems);

            while (selection != 7)
            {
                switch (selection)
                {
                    case 1:
                        CreateDepartment();
                        break;
                    case 2:
                        UpdateDepartmentName();
                        break;
                    case 3:
                        UpdateDepartmentManager();

                        break;
                    case 4:
                        DeleteDepartment();
                        break;
                    case 5:
                        GetDepartment();
                        break;
                    case 6:
                        GetAllDepartments();
                        break;
                    default:
                        Console.WriteLine("Closing the program");
                        break;
                }

                selection = ShowMenu(menuItems);
            }
        }

        private int ShowMenu(string[] menuItems)
        {
            Console.WriteLine("SELECT YOUR CHOICE");
            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {menuItems[i]}");
            }

            int selection;

            while (!int.TryParse(Console.ReadLine(), out selection)
                || selection < 1
                || selection > 8)
            {
                Console.WriteLine("Please input a number between 1-7");
            }

            return selection;
        }

        private void CreateDepartment()
        {
            Console.WriteLine("Enter name");
            var name = Console.ReadLine();
            Console.WriteLine("Enter MgrSSN");
            var ssn = Console.ReadLine();
            var result = new Db().USP_CreateDepartment(name, ssn);
            Console.WriteLine("\nDepartment DNumber: " + result + "\n");
        }

        private void UpdateDepartmentName()
        {
            Console.WriteLine("Enter DNumber");
            var DNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter DName");
            var DName = Console.ReadLine();
            new Db().USP_UpdateDepartmentName(DNumber, DName);
        }

        private void UpdateDepartmentManager()
        {
            Console.WriteLine("Enter DNumber");
            var DNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter MgrSNN");
            var MgrSNN = Console.ReadLine();
            new Db().USP_UpdateDepartmentManager(DNumber, MgrSNN);
        }

        private void DeleteDepartment()
        {
            Console.WriteLine("Enter DNumber");
            var DNumber = int.Parse(Console.ReadLine());
            new Db().usp_DeleteDepartment(DNumber);
        }

        private void GetDepartment()
        {
            Console.WriteLine("Enter DNumber");
            var DNumber = int.Parse(Console.ReadLine());
            new Db().usp_GetDepartment(DNumber);
        }

        private void GetAllDepartments()
        {
            new Db().usp_GetAllDepartments();
        }
    }
}
