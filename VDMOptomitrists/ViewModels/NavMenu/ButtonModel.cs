using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDMOptomitrists.ViewModels.NavMenu
{
    public class ButtonModel
    {
        public NavButtonType ButtonType { get; set; }
        public List<LinkModel> Links { get; set; }
    }
}
