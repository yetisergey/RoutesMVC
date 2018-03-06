using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Routes.Controllers
{
    public class ProjectsController : Controller
    {
        public static List<string> projects = new List<string>() { "odms", "rmpa" };
        [ActionName("ListProjects")]
        public string Index()
        {
            return string.Join(", ", projects);
        }
        public string Index(string name)
        {
            if (projects.Contains(name))
            {
                return name;
            }
            else
            {
                return "Project not found";
            }
        }
        public string Settings(string name)
        {
            if (projects.Contains(name))
            {
                return "Settings of " + name;
            }
            else
            {
                return "Project not found"; 
            }
        }
    }
}