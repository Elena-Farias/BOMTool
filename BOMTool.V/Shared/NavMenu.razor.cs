using Blazorise.Sidebar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOMTool.V.Shared
{
    public partial class NavMenu
    {
        private Sidebar sidebar;
        SidebarSubItem adminSidebarSubItems;

        void ToggleSidebar()
        {
            sidebar.Toggle();
        }

    }
}
