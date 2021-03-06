using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dwapi.ExtractsManagement.Core.Model.Source.Hts;
using Dwapi.SharedKernel.Interfaces;

namespace Dwapi.ExtractsManagement.Core.Interfaces.Repository.Hts
{
    public interface ITempHTSClientPartnerExtractRepository : IRepository<TempHTSClientPartnerExtract,Guid>
    {
        Task Clear();
        bool BatchInsert(IEnumerable<TempHTSClientPartnerExtract> extracts);
    }
}