using System;
using System.Collections;
using System.Collections.Generic;

namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee omer = new Employee()
            {
                Name = "Ömer"
            };
            Employee ali = new Employee()
            {
                Name = "Ali"
            };

            omer.AddSubordnate(ali );
            Employee derin = new Employee()
            {
                Name = "Derin"
            };
            omer.AddSubordnate(derin);
            Employee ahmet = new Employee()
            {
                Name = "Ahmet"
            };

            ali.AddSubordnate(ahmet);
            Console.WriteLine(omer.Name);
            foreach (Employee manager in omer)
            {
                Console.WriteLine("  {0}",manager.Name);
                foreach (Employee employeee in manager)
                {
                    Console.WriteLine("    {0}", employeee.Name);
                }
            }
        }
    }
    interface IPerson
    {
        public string Name { get; set; }
    }
    class Employee : IPerson, IEnumerable<IPerson>
    {
        List<IPerson> _subordinates = new List<IPerson>();
        public void AddSubordnate(IPerson person)
        {
            _subordinates.Add(person);
        }
        public void RemoveSubordnate(IPerson person)
        {
            _subordinates.Remove(person);
        }

        public IPerson GetSubordinates(int index)
        {
            return _subordinates[index];
        }
        public string Name { get; set; }

        public IEnumerator<IPerson> GetEnumerator()
        {
            foreach (var subordinate in _subordinates)
            {
                yield return subordinate;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
