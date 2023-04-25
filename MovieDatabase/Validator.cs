using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase
{
    class Validator
    {
        public static string ValidateEnter()
        {
            try
            {
                Console.WriteLine("What category are you interested in?");
                string enter = Console.ReadLine().ToLower().Trim();
                return enter;
            }
            catch (FormatException)
            {
                Console.WriteLine("Input was not a valid radius, lets try again");
                return ValidateEnter();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return ValidateEnter();
            }
        }

    }
}
