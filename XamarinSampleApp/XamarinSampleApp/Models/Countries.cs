using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinSampleApp.Models
{
  public  class Countries
    {
        public string name { get; set; }

        public string code { get; set; }


        public override string ToString()
        {
            return name;
        }
    }
    
}
