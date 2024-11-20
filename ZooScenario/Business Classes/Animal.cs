using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ZooScenario
{
    /// <summary>
    /// The class which is used to represent an animal.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class Animal
    {
        /// <summary>
        /// The age of the animal.
        /// </summary>
        public int Age;

        /// <summary>
        /// A value indicating whether or not the animal is pregnant.
        /// </summary>
        public bool IsPregnant;

        /// <summary>
        /// The name of the animal.
        /// </summary>
        public string Name;

        /// <summary>
        /// The type of the animal.
        /// </summary>
        public string Type;

        /// <summary>
        /// The weight of the animal (in pounds).
        /// </summary>
        public double Weight;

        public void FeedNewBorn()
        {
            //new born is fed by mother
        }

        public Animal Reproduce()
        {
            //create baby animal
            Animal result = new Animal();

            //Make baby the same type as mother.
            result.Type = this.Type;

            //set baby's weight to 10% of the mother's weight;
            result.Weight = this.Weight * 0.1;

            //reduce mother's weight by 15%
            this.Weight -= this.Weight * 0.15;

            return result;

        }
    }
}