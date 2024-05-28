using ClothesMarkt.BLL.Managers.Concrete;
using ClothesMarkt.Dtos;
using ClothesMarkt.ViewModels;
using Humanizer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ClothesMarkt.WebApp.Controllers
{
    public class ShirtController : Controller
    {
        private ShirtManager _shirtManager;
        private CategoryManager _categoryManager;
        private RenkManager _renkManager;
        int _rowNum = 1;

		public ShirtController(ShirtManager shirtManager, CategoryManager categoryManager, RenkManager renkManager)
		{
			_shirtManager = shirtManager;
			_categoryManager = categoryManager;
			_renkManager = renkManager;
		}

		// GET: ShirtController
		public ActionResult Index()
        {
            List<ShirtViewModel> list = _shirtManager.GetAll().ToList();
            foreach (var item in list)
            {
                item.RowNum = _rowNum++;
            }
            return View(list);
        }

        // GET: ShirtController/Details/5
        public ActionResult Details(int id)
        {
            ShirtViewModel model = _shirtManager.GetById(id);
            return View(model);
        }

        // GET: ShirtController/Create
        public ActionResult Create()
        {
            ShirtViewModel model = new ShirtViewModel();
            List<SelectListItem> categories = new List<SelectListItem>();
            List<SelectListItem> renkler = new List<SelectListItem>();
            if (_categoryManager.GetAll().ToList() == null)
            {
                ViewBag.ErrorMessage = "Ürün ekleyebilmek için öncelikle kategori eklemelisiniz";
                return View(model);
            }

            List<CategoryViewModel> catList = _categoryManager.GetAll().ToList();
            categories.Add(new SelectListItem { Text = "Kategori seçiniz", Value = "-1", Selected = true });

            foreach (CategoryViewModel vm in catList)
            {
                categories.Add(new SelectListItem { Text = vm.Name, Value = vm.Id.ToString() });
            }

			List<RenkViewModel> renkList = _renkManager.GetAll().ToList();
			renkler.Add(new SelectListItem { Text = "Renk seçiniz", Value = "-1", Selected = true });

			foreach (RenkViewModel vm in renkList)
			{
				renkler.Add(new SelectListItem { Text = vm.Name, Value = vm.Id.ToString() });
			}
            
			ViewBag.Categories = categories;
            ViewBag.Renkler = renkler;

			return View(model);
        }

        // POST: ShirtController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ShirtViewModel vm)
        {
            try
            {
                var dosyadakiFileName = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", vm.PictureFormFile.FileName);

                if (vm.PictureFormFile is not null && vm.Picture != dosyadakiFileName)
                {
                    var konum = dosyadakiFileName;

                    //Kaydetmek için bir akış ortamı oluşturalım
                    var akisOrtami = new FileStream(konum, FileMode.Create);
                    var memory = new MemoryStream();

                    //Resmi kaydet
                    vm.PictureFormFile.CopyTo(akisOrtami);
                    vm.PictureFormFile.CopyTo(memory);

                    vm.Renkler = _renkManager.GetAll().Where(r => vm.RenkId.Contains(r.Id)).ToList();

                  
                    vm.PictureFile = memory.ToArray();

                    _shirtManager.Add(vm);

                    akisOrtami.Dispose();
                    memory.Dispose();

                    return RedirectToAction("Index");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: ShirtController/Edit/5
        public ActionResult Edit(int id)
        {
            ShirtViewModel model = _shirtManager.GetById(id);
            var categoriesList = _categoryManager.GetAll().ToList();
            List<SelectListItem> categories = new List<SelectListItem>();
            ViewBag.Categories = new SelectList(categoriesList.ToList(), "Id", "Name");


            return View(model);
        }

        // POST: ShirtController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ShirtViewModel model)
        {
            try
            {
                if (model.PictureFormFile is null)
                {
                    ModelState.Remove<ShirtViewModel>(m => m.PictureFormFile);
                }


                ModelState.Remove<ShirtViewModel>(m => m.Category);
                ModelState.Remove<ShirtViewModel>(m => m.RowNum);

                if (ModelState.IsValid)
                {


                    ShirtViewModel dtoPrOrj = _shirtManager.GetById(model.Id);


                    model.PictureFile = dtoPrOrj.PictureFile;

                    var memory = new MemoryStream();


                    if (model.PictureFormFile != null && model.PictureFormFile.Name != model.Picture)
                    {
                        model.Picture = model.PictureFormFile.FileName;

                        var konum = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", model.PictureFormFile.FileName);

                        //Kaydetmek için bir akış ortamı oluşturalım
                        var akisOrtami = new FileStream(konum, FileMode.Create);


                        //Resmi kaydet
                        model.PictureFormFile.CopyTo(akisOrtami);
                        model.PictureFormFile.CopyTo(memory);
                        model.PictureFile = memory.ToArray();

                        akisOrtami.Dispose();
                        memory.Dispose();
                    }

                    _shirtManager.Update(model);

                    return RedirectToAction("Index");
                }

                return View(model);
            }
            catch
            {
                return View();
            }
        }

        // GET: ShirtController/Delete/5
        public ActionResult Delete(int id)
        {
            ShirtViewModel model = _shirtManager.GetById(id);
            return View(model);
        }

        // POST: ShirtController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ShirtViewModel model)
        {
            try
            {
                var dosyadakiFileName = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", model.Picture);
                if (_shirtManager.Delete(model) > 0)
                {
                    System.IO.File.Delete(dosyadakiFileName);
                }

                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                return View();
            }
        }
    }
}
