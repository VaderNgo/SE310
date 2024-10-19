using Bai_tap_4.Repositories;
using Microsoft.AspNetCore.Mvc;
namespace Bai_tap_4.ViewComponents
{
    public class LoaiSpMenuViewComponent
        : ViewComponent
    {
        private readonly ILoaiSpRepository _loaiSpRepository;
        public LoaiSpMenuViewComponent(ILoaiSpRepository loaiSpRepository)
        {
            _loaiSpRepository = loaiSpRepository;
        }

        public IViewComponentResult Invoke()
        {
            var loaiSps = _loaiSpRepository.GetAllLoaiSp();
            return View(loaiSps);
        }

    }
}
