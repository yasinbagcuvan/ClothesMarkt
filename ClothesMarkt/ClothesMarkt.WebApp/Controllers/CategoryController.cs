using ClothesMarkt.BLL.Managers.Concrete;
using ClothesMarkt.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClothesMarkt.WebApp.Controllers
{
	public class CategoryController : Controller
	{
        private CategoryManager _categoryManager;
        private TshirtManager _tshirtManager;
        private ShirtManager _shirtManager;
		int _rowNum = 1;

        public CategoryController(CategoryManager categoryManager, TshirtManager tshirtManager, ShirtManager shirtManager)
        {
            _categoryManager = categoryManager;
            _tshirtManager = tshirtManager;
            _shirtManager = shirtManager;
        }

        // GET: CategoryController
        public ActionResult Index()
		{
			List<CategoryViewModel> list = _categoryManager.GetAll().ToList();
			foreach (var item in list)
			{
				item.RowNum = _rowNum++;
			}
			return View(list);
		}

		// GET: CategoryController/Details/5
		public ActionResult Details(int id)
		{
            CategoryViewModel? model = _categoryManager.GetById(id);

            return View(model);
        }

		// GET: CategoryController/Create
		public ActionResult Create()
		{
            CategoryViewModel model = new CategoryViewModel();
            return View(model);
		}

		// POST: CategoryController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(CategoryViewModel model)
		{
			try
			{
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
				if (_categoryManager.Add(model) > 0)
				{
                return RedirectToAction(nameof(Index));

				}
				else
				{
					ModelState.AddModelError("DbError", "Veritabanı ekleme hatası");
					return View(model);
				}

			}
			catch(Exception ex)
			{
				ModelState.AddModelError("Exception",ex.Message);
                ModelState.AddModelError("GeneralInnerException",ex.InnerException?.Message);
                return View();
			}
		}

		// GET: CategoryController/Edit/5
		public ActionResult Edit(int id)
		{
            CategoryViewModel model = _categoryManager.GetById(id);

            return View(model);
        }

		// POST: CategoryController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(CategoryViewModel model)
		{
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                if (_categoryManager.Update(model) > 0)
                    return RedirectToAction(nameof(Index));
                else
                {
                    ModelState.AddModelError("DbError", "Veritabanı ekleme hatası");

                    return View(model);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("GeneralException", ex.Message);
                ModelState.AddModelError("GeneralInnerException",ex.InnerException?.Message);
                return View();
            }
        }

		// GET: CategoryController/Delete/5
		public ActionResult Delete(int id)
		{
            CategoryViewModel model = _categoryManager.GetById(id);
            return View(model);
		}

		// POST: CategoryController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(CategoryViewModel model)
		{
            try
            {
                if (_categoryManager.Update(model) > 0)
                    return RedirectToAction(nameof(Index));

                else
                {
                    ModelState.AddModelError("DbError", "Veritabanı silme hatası");

                    return View(model);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("GeneralException", ex.Message);
                ModelState.AddModelError("GeneralInnerException", ex.InnerException?.Message);
                return View();
            }
        }
	}
}
