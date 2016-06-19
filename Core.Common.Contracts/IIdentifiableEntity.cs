using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Common.Contracts
{
    //It is necessary in Data Access Layer
    //The job of this interface is to let the DAL know the which of the property in the entity serves as the identifier or ID in the database.
    public interface IIdentifiableEntity
    {
        int EntityId { get; set; }
    }
}
