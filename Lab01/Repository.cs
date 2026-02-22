using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public static class Repository
    {
        private static List<Project> _projects; 
        static Repository()
        {
            _projects = new List<Project> { new Project("Project1", "Exam preparation", ProjectType.Educational) };
         
        }
    }
}