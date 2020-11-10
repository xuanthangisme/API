using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Model;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private IMenuBusiness _proBusiness;
        public MenuController(IMenuBusiness menuBusiness)
        {
            _proBusiness = menuBusiness;
        }
        [Route("get-menu-all")]
        [HttpGet]
        public IEnumerable<MenuModel> GetMenuAll()
        {
            return _proBusiness.GetMenuAll();
        }
        [Route("create-menu")]
        [HttpPost]
        public MenuModel CreateMenu([FromBody] MenuModel model)
        {
            /*if (model.IMG != null)
            {
                var arrData = model.IMG.Split(';');
                if (arrData.Length == 3)
                {
                    var savePath = $@"assets/images/{arrData[0]}";
                    model.IMG = $"{savePath}";
                    SaveFileFromBase64String(savePath, arrData[2]);
                }
            }
            model.IDproduct = Guid.NewGuid().ToString();*/
            _proBusiness.Create(model);
            return model;
        }
        [Route("get-menu-id/{IDmenu}")]
        [HttpGet]
        public MenuModel GetMenuID(int IDmenu)
        {
            return _proBusiness.GetMenuID(IDmenu);
        }

    }
}