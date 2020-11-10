using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public partial interface IMenuRepository
    {
        MenuModel GetMenuID(int IDmenu);
        bool Create(MenuModel model);
        List<MenuModel> GetMenuAll();
    }
}
