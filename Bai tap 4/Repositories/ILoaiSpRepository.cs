using Bai_tap_4.Models;
namespace Bai_tap_4.Repositories
{
    public interface ILoaiSpRepository
    {
        TLoaiSp Add(TLoaiSp loaiSp);
        TLoaiSp Update(TLoaiSp loaiSp);
        TLoaiSp Delete(string maLoaiSp);
        TLoaiSp GetLoaiSp(string maLoaiSp);

        IEnumerable<TLoaiSp> GetAllLoaiSp();


    }
}
