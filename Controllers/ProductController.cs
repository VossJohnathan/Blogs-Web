using Microsoft.AspNetCore.Mvc;
using System.Linq;

public class ProductController : Controller
{
  // this controller depends on the BloggingRepository
  private DataContext _dataContext;
  public ProductController(DataContext db) => _dataContext = db;

  public IActionResult Index() => View(_dataContext.Products.OrderBy(p => p.ProductName));
}