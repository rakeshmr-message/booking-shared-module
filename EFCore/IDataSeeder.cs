using System.Threading.Tasks;

namespace BuildingBlocks.EFCore
{
    public interface IDataSeeder
    {
        Task SeedAllAsync();
    }

    public interface ITestDataSeeder
    {
        Task SeedAllAsync();
    }
}
