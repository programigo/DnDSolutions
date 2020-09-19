using DnDSolutions.Services.Models;
using System.Linq;

namespace DnDSolutions.Services
{
    public interface ITransporterService
    {
        IQueryable<TransporterDetailsServiceModel> Details(string id);
    }
}
