using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLeasing.Prism.ViewModels
{

    public class MenuItemViewModelMasterMenuItem
    {
        public MenuItemViewModelMasterMenuItem()
        {
            TargetType = typeof(MenuItemViewModelMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}