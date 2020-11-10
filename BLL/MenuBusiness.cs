using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public partial class MenuBusiness: IMenuBusiness
    {
        private IMenuRepository _res;
        public MenuBusiness(IMenuRepository MenuGroupRes)
        {
            _res = MenuGroupRes;
        }
        public List<MenuModel> GetMenuAll()
        {
            return _res.GetMenuAll();
        }
        public bool Create(MenuModel model)
        {
            return _res.Create(model);
        }
       public MenuModel GetMenuID(int IDmenu)
        {
            return _res.GetMenuID(IDmenu);
        }
    }
}
