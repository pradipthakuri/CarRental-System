using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Common.Contracts
{
    //It lookes for the property in the implemented entity that specified the ID of the user Account
    public interface IAccountOwnedEntity
    {
        int OwnerAccountId { get; }
    }
}
