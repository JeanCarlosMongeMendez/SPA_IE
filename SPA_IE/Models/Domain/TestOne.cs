using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPA_IE.Models.Domain
{
    public class TestOne
    {

        public int sum(int numberOne, int numberTwo)
        {
            int result = 0;

            result = numberOne + numberTwo + 1;

            return result;

        }
    }
}