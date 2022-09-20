using BrasilShopAccesoDate.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace BrasilShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriaControllers : Controller
    {
        private readonly IContenedorTrabajo _contenedorTrabajo;

        public CategoriaControllers(IContenedorTrabajo contenedorTrabajo)
        {

            _contenedorTrabajo = contenedorTrabajo;
        }
        public IActionResult Index()
        {
            return View();
        }

        #region 
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = _contenedorTrabajo.Categoria.GetAll() });
        }

        #endregion

    }
}
