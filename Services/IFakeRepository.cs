using System.Threading.Tasks;
using fakeApi.Models;

namespace fakeApi.Services
{
    public interface IFakeRepository
    {
        Task<Fake> GetFake();
    }
}