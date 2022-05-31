using System;
using System.Collections.Generic;

namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager managerOmer = new Manager() { Name = "Ömer", Salary=8500};
            Manager managerAli = new Manager() { Name = "Ali", Salary = 7000 };

            Worker workerHamza = new Worker() { Name = "Hamza" , Salary=4253};
            Worker workerBuse = new Worker() { Name = "Buse", Salary = 5500 };

            managerOmer.Subordinates.Add(managerAli);
            managerAli.Subordinates.Add(workerBuse);
            managerAli.Subordinates.Add(workerHamza);

            OrganisationalStructure organisationalStructure = new OrganisationalStructure(managerOmer);

            PayrollVisitor payrollVisitor = new PayrollVisitor();
            Payrise payrise = new Payrise();

            organisationalStructure.Accept(payrollVisitor);
            organisationalStructure.Accept(payrise );  //payrisevitor
        }
    }

    class OrganisationalStructure
    {
        public EmployeeBase Employee;
        public OrganisationalStructure(EmployeeBase firstEmployee)
        {
            Employee = firstEmployee;
        }

        public void Accept(VisitorBase visotor)
        {
            Employee.Accept(visotor);
        }

    }
    abstract class EmployeeBase
    {
        public abstract void Accept(VisitorBase visotor);
        public string Name { get; set; }
        public decimal Salary { get; set; }

    }
    class Manager : EmployeeBase
    {
        public Manager()
        {
            Subordinates = new List<EmployeeBase>();
        }
        public List<EmployeeBase> Subordinates { get; set; }
        public override void Accept(VisitorBase visotor)
        {
            visotor.Visit(this);
            foreach (var employee in Subordinates)
            {
                employee.Accept(visotor);
            }
        }
    }
    class Worker : EmployeeBase
    {
        public override void Accept(VisitorBase visotor)
        {
            visotor.Visit(this );
        }
    }
    abstract class VisitorBase
    {
        public EmployeeBase _employeeBase;

        public abstract void Visit(Worker worker);
        public abstract void Visit(Manager manager);

    }

    class PayrollVisitor : VisitorBase
    {
        public override void Visit(Worker worker)
        {
            Console.WriteLine("{0}, paid {1}",worker.Name, worker.Salary);
        }

        public override void Visit(Manager manager)
        {
            Console.WriteLine("{0}, paid {1}", manager.Name, manager.Salary);

        }
    }

    class Payrise : VisitorBase
    {
        public override void Visit(Worker worker)
        {
            Console.WriteLine("{0}, salaray increased to {1}", worker.Name, worker.Salary *  1.1M);
        }

        public override void Visit(Manager manager)
        {
            Console.WriteLine("{0}, salaray increased to {1}", manager.Name, manager.Salary*1.2M);
        }
    }
}
