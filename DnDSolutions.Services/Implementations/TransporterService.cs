using AutoMapper;
using AutoMapper.QueryableExtensions;
using DnDSolutions.Data;
using DnDSolutions.Services.Models;
using System.Linq;

namespace DnDSolutions.Services.Implementations
{
    public class TransporterService : ITransporterService
    {
        private readonly DnDSolutionsDbContext db;
        private readonly IConfigurationProvider provider;

        public TransporterService(DnDSolutionsDbContext db, IConfigurationProvider provider)
        {
            this.db = db;
            this.provider = provider;
        }

        public IQueryable<TransporterDetailsServiceModel> Details(string id)
        => this.db
            .Users
            .Where(u => u.Id == id)
            .ProjectTo<TransporterDetailsServiceModel>(this.provider);
    }
}
