using System.Threading.Tasks;
using fakeApi.Models;

namespace fakeApi.Services
{
    public class FakeRepository : IFakeRepository
    {
        //private readonly DBContext dbcontext;
        public async Task<Fake> GetFake()
        {
            var query = dbcontext.Fake;
            return await query.FirstOrDefaultAsync();
        }
    }
}