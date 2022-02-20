/*Jesse Varis, 2021-11-30
 *A short registry of the employees and their salary.
 *
 *Svar1: En klass.
 *Svar2: En metod som tar in det användaren skriver, attributen är den anställdes namn samt attributen lön.
 *Svar3: Metoden ska anropa CR och ta emot namn samt lön på den anställde. Dessa ska lagras i en lista med namn och lön.
 *Det ska finnas en metod för att kunna ta fram den anställde och då kunna se hens lön.
 *Detta ska skrivas ut med CW.
 *Famtidssäkring: Om namnet redan finns(två personer kan heta samma sak) så ska programmet vara om att du inte kan lägga till då namnet
 *finns redan, så nytt namnförslag skulle kunna implementeras så att användaren inte själv ska behöva testa fram vilka namn som är lediga te x.
 *
 */

using System;

namespace MyEmployees
{
    public class Employee
    {
        private string name;
        private int salary;

        public Employee(string name, int salary)
        {
            this.name = name;
            this.salary = salary;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("value", $"Use only positive digits!");
                }
                else
                {
                    salary = value;
                }
            }
        }
    }
}