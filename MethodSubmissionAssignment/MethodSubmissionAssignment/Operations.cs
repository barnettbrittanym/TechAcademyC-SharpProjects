using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    class Operations
    {
        //creating a method called math with an optional second parameter
        public int Math(int numberOne, int numberTwo=10)
        {
            int result = numberOne * numberTwo;
            return result;
        }
    }
}
