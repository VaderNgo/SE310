using Bai_tap_4.Models;

namespace Bai_tap_4.Repositories
{
    public class LoaiSpRepository : ILoaiSpRepository
    {
        private readonly QlbanVaLiContext _context;
        public LoaiSpRepository(QlbanVaLiContext context)
        {
            _context = context;
        }
        public TLoaiSp Add(TLoaiSp loaiSp)
        {
            _context.TLoaiSps.Add(loaiSp);
            _context.SaveChanges();
            return loaiSp;
        }

        public TLoaiSp Delete(string maLoaiSp)
        {
            var loaiSp = _context.TLoaiSps.Find(maLoaiSp);
            if (loaiSp != null)
            {
                _context.TLoaiSps.Remove(loaiSp);
                _context.SaveChanges();
            }
            return loaiSp;
        }

        public IEnumerable<TLoaiSp> GetAllLoaiSp()
        {
            return _context.TLoaiSps;
        }

        public TLoaiSp GetLoaiSp(string maLoaiSp)
        {
            return _context.TLoaiSps.Find(maLoaiSp);
        }


        public TLoaiSp Update(TLoaiSp loaiSp)
        {
            _context.TLoaiSps.Update(loaiSp);
            _context.SaveChanges();
            return loaiSp;
        }
    }
}
