using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Core.Common.Core
{
    //EntityBase is a Super Class for CarRental Business Entities.

    //IExtensibleDataObject
    //Data Contract Serializer that allows entites to become version tolerant.
    //If they receive data that they cannot accomodate, they would not just blow up contract
    //Rather they would gracefully accept the data silently, store it temporarily in the property called ExtensionData
    //so that it can be passed over.
    [DataContract]
    public abstract class EntityBase : IExtensibleDataObject
    {
        public ExtensionDataObject ExtensionData { get; set; }
    }
}
