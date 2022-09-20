using BrasilShopAccesoDate.Data;
using BrasilShopAccesoDate.Data.Repository;
using BrasilShopModels.Model;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrasilShopAccesoDate.Data
{

    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoriaRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetListaCategoria()
        {
            return _db.Categorias.Select(i => new SelectListItem()
            {
                Text = i.Nombre,
                Value=i.Id.ToString()
            });
        }

        public void Update(Categoria categoria)
        {
            var objDesdeDb= _db.Categorias.FirstOrDefault(s => s.Id == categoria.Id); 
            objDesdeDb.Nombre=categoria.Nombre;
            objDesdeDb.Orden=categoria.Orden;
            _db.SaveChanges();
        }
    }
}
