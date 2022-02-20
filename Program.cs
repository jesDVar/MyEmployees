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
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the MyEmployees-Program.");
            Console.WriteLine("Type in all the data about your employees.");
            string person = Console.ReadLine();
            Console.WriteLine(person);

            //Employee employee = new Employee("Kalle", 10000);
            //employee.Salary = -20000;


        }
    }
}
