using DevOps.App.Repositories;
using System.Threading.Tasks;

namespace DevOps.App.Services
{
    public interface ISeedDataService
    {
        Task Initialize(FoodDbContext context);
    }
}
