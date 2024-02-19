using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SchoolDataLibrary
{
    public class SchoolManagement
    {
        static List<School> listSchools = new List<School>()
        {
            new School()
            {
               Id=1,Name="Sam",Age=34,DOJ=new DateTime(day:12,month:3,year:2023)
            },
            new School()
            {
               Id=2,Name="Arsh",Age=23,DOJ=new DateTime(day:23,month:5,year:2000)
            },
            new School()
            {
               Id=3,Name="Vini",Age=45,DOJ=new DateTime(day:6,month:8,year:2012)
            },
            new School()
            {
               Id=4,Name="Gaurav",Age=56,DOJ=new DateTime(day:9,month:7,year:2022)
            },
            new School()
            {
               Id=5,Name="Vikas",Age=67,DOJ=new DateTime(day:10,month:4,year:2019)
            },
        };
        public List<School> AllSchols()
        {
            return listSchools;
        }
        public List<School>SearchSchols(int id)
        {
            List<School> searchList = listSchools.FindAll(s => s.Id == id);
            return searchList;
        }





    }
}
