﻿using Core.Common.Contracts;
using Core.Common.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Business.Entities
{
    [DataContract]
    public class Account : EntityBase, IIdentifiableEntity
    {
        [DataMember]
        public int AccountId { get; set; }

        [DataMember]
        public string LoginEmail { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string Zone { get; set; }

        [DataMember]
        public string DevelopmentRegion { get; set; }

        [DataMember]
        public string CreditCard { get; set; }

        [DataMember]
        public string ExpDate { get; set; }

        //IIdentifiable Members
        public int EntityId
        {
            get { return AccountId; }
            set { AccountId = value; }
        }
    }
}
