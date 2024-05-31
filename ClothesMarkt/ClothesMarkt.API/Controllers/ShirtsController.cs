using ClothesMarkt.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace ClothesMarkt.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShirtsController : Controller
    {
        private ClothesMarktDbContext _db;

        public ShirtsController(ClothesMarktDbContext db)
        {
            _db = db;
        }
        [HttpGet("Listele")]
        public IActionResult Get()
        {
            var list = _db.Tablolar.ToList();
            if (!_db.Tablolar.ToList().Any())
            {
                return BadRequest("hata");
            }
            return Ok(list);
        }
        [HttpGet("AzListele")]
        public IActionResult GetZa()
        {
            var list = _db.Tablolar.ToList().OrderByDescending(x => x.Ressam);
            if (!_db.Tablolar.ToList().Any())
            {
                return BadRequest("hata");
            }
            return Ok(list);
        }
        [HttpGet("ZaListele")]
        public IActionResult GetAz()
        {
            var list = _db.Tablolar.ToList().OrderBy(x => x.Ressam);
            if (!_db.Tablolar.ToList().Any())
            {
                return BadRequest("hata");
            }
            return Ok(list);
        }


        [HttpPost("Ekle")]
        public IActionResult Post(Tablo tablo)
        {

            _db.Tablolar.Add(tablo);
            var result = _db.SaveChanges();
            if (result < 1)
            {
                return BadRequest("hata");
            }
            return Created("", "Başarılı");
        }

        [HttpPut("Guncelle")]
        public IActionResult Put(int id, Tablo tablo)
        {

            var tabloEski = _db.Tablolar.Find(id);

            if (tabloEski is null)
            {
                return BadRequest("hata");
            }

            tabloEski.Ressam = tablo.Ressam;
            tabloEski.YapilmaTarihi = tablo.YapilmaTarihi;

            _db.Tablolar.Update(tabloEski);
            var result = _db.SaveChanges();

            if (result < 1)
            {
                return BadRequest("hata");
            }
            return Ok(tabloEski);
        }

        [HttpDelete("Sil")]
        public IActionResult Delete(int id)
        {
            var tablo = _db.Tablolar.Find(id);
            if (tablo is null)
            {
                return BadRequest("hata");
            }
            _db.Tablolar.Remove(tablo);
            var result = _db.SaveChanges();

            if (result < 1)
            {
                return BadRequest("hata");
            }
            return Ok(tablo);
        }

        [HttpGet("Bul")]
        public IActionResult Get(int id)
        {
            var aranantablo = _db.Tablolar.Find(id);
            if (aranantablo is null)
            {
                return BadRequest("Hata tablo bulunamadı");
            }

            return Ok(aranantablo);
        }

        [HttpGet("Arama")]
        public IActionResult Get(string kelime)
        {
            var tablolar = _db.Tablolar.ToList();
            List<Tablo> tablos = new List<Tablo>();
            foreach (var item in tablolar)
            {
                if (item.Ressam.ToLower().Contains(kelime.ToLower()))
                {
                    tablos.Add(item);
                }
            }

            return Ok(tablos);
        }

    }
}
