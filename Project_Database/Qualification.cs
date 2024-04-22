using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Database
{
    internal class Qualification
    {
        private int id;
        private string major;
        private string university;
        private int graduration_year;
        private int expeirence_year;
        private string degree_type;
        public Qualification() { }
        public Qualification(int id, string major, string university, int graduration_year, int expeirence_year, string degree_type)
        {
            this.Id = id;
            this.Major = major;
            this.University = university;
            this.Graduration_year = graduration_year;
            this.Expeirence_year = expeirence_year;
            this.Degree_type = degree_type;
           
        }

        public int Id { get => id; set => id = value; }
        public string Major { get => major; set => major = value; }
        public string University { get => university; set => university = value; }
        public int Graduration_year { get => graduration_year; set => graduration_year = value; }
        public int Expeirence_year { get => expeirence_year; set => expeirence_year = value; }
        public string Degree_type { get => degree_type; set => degree_type = value; }
       
    }
}
