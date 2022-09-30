using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpfInterdisciplinaryAssignment1.Domain
{
    public class TokenCount
    {
        private List<int> tokens = new List<int>();

        public List<int> Tokens
        {
            get => tokens;
            set => tokens = value;
        }
    }
}
