using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDMOptomitrists.ViewModels.NavMenu
{
    public class LinkModel
    {
        public LinkModel(string href, string linkName)
        {
            Href = href;
            LinkName = linkName;
        }
        public string Href { get; set; }
        public string LinkName { get; set; }
    }
}
