using CleanArchitectureDemo.Domain.Core.Commands;
using System.Threading.Tasks;

namespace CleanArchitectureDemo.Domain.Core.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;
    }
}