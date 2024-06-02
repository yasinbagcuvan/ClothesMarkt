
using ClothesMarkt.BLL.Managers.Concrete;
using ClothesMarkt.DAL.Context;
using ClothesMarkt.Entities;
using ClothesMarkt.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ClothesMarkt.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShirtsController : ControllerBase
    {
        private ShirtManager _shirtManager;

        public ShirtsController(ShirtManager shirtManager)
        {
            _shirtManager = shirtManager;
        }

        [HttpGet("Listele")]
        public IActionResult Get()
        {
            var list = _shirtManager.GetAll().ToList();
            if (!list.Any())
            {
                return BadRequest("hata");
            }
            return Ok(list);
        }     


        [HttpPost("Ekle")]
        public IActionResult Post(ShirtViewModel shirt)
        {

           var result = _shirtManager.Add(shirt);
   
            if (result < 1)
            {
                return BadRequest("hata");
            }
            return Created("", "Başarılı");
        }

        [HttpPut("Guncelle")]
        public IActionResult Put( ShirtViewModel shirtView)
        {


            if (shirtView is null)
            {
                return BadRequest("hata");
            }


            
            var result = _shirtManager.Update(shirtView);

            if (result < 1)
            {
                return BadRequest("hata");
            }
            return Ok(shirtView);
        }

        [HttpDelete("Sil")]
        public IActionResult Delete(int id)
        {
            var shirt = _shirtManager.GetById(id);
            if (shirt is null)
            {
                return BadRequest("hata");
            }
            
            var result = _shirtManager.Delete(shirt);

            if (result < 1)
            {
                return BadRequest("hata");
            }
            return Ok(shirt);
        }

        [HttpGet("Bul")]
        public IActionResult Get(int id)
        {
            var aranan = _shirtManager.GetById(id);
            if (aranan is null)
            {
                return BadRequest("Hata tablo bulunamadı");
            }

            return Ok(aranan);
        }

        [HttpGet("Arama")]
        public IActionResult Get(string kelime)
        {
            var tablolar = _shirtManager.GetAll().ToList();
            List<ShirtViewModel> tablos = new List<ShirtViewModel>();
            foreach (var item in tablolar)
            {
                if (item.Name.ToLower().Contains(kelime.ToLower()))
                {
                    tablos.Add(item);
                }
            }

            return Ok(tablos);
        }

    }
}
