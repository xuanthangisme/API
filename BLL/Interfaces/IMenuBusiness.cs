using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public partial interface IMenuBusiness
    {
        MenuModel GetMenuID(int IDmenu);
        bool Create(MenuModel model);
        List<MenuModel> GetMenuAll();
    }
}
