using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesBasics
{
	public class Human
	{
		// member variable
		public string firstName;
        public string lastName;

        // member
        public void IntroduceMyself()
		{
			Console.WriteLine("Hi I'm {0} {1}", firstName, lastName);
		}
	}
}

