using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooScenario
{
    /// <summary>
    /// The class which is used to represent an employee.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class Employee
    {
        /// <summary>
        /// The name of the employee.
        /// </summary>
        public string Name;

        /// <summary>
        /// The employee's identification number.
        /// </summary>
        public int Number;

        public Animal DeliverAnimal(Animal mother)
        {
            Animal babyAnimal = mother.Reproduce();
            return babyAnimal;
        }

        public void SterilizeBirthingArea()
        {
            //employee will sterilize the birthing area.
        }

        public void WashUpBirthingArea()
        {
            //employee will wash down the birthing area
        }
    }
}