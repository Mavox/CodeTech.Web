using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTech.Web.App.Models
{
    public class MenuLink
    {
        public MenuLink()
        {

        }

        public MenuLink(string name, string path): this()
        {
            Name = name;
            Path = path;
        }

        public string Path { get; set; }
        public string Name { get; set; }
    }
}
