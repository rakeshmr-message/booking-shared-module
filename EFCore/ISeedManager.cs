using System.Threading.Tasks;

namespace BuildingBlocks.EFCore;

public interface ISeedManager
{
    Task ExecuteSeedAsync();
    Task ExecuteTestSeedAsync();
}
