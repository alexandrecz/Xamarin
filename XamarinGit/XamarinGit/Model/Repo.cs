using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinGit.Model
{
    public class Repo
    {
        public Repo()
        {

        }

        public int Id { get; set; }

        public string Name { get; set; }
        public string Full_Name { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        
        
    }    
}
