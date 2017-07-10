using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_2_PolymorphismApp_AllieBeckman
{
    class Dog : Animal
    {
        // Field 
        private string _name;

        // Constructor 
        public Dog(string name)
            : base("Dog")
        {
            _name = name;
        }

        // Name property 
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // MakeSound method
        public override void MakeSound()
        {
            MessageBox.Show("Woof! Woof!");
        } 
    }
}
