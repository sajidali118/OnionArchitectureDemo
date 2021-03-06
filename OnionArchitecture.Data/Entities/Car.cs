﻿using System;
using OnionArchitectureDemo.Domain.Common;

namespace OnionArchitectureDemo.Domain.Entities
{
    public class Car : IDomainEntity
    {
        public int SalesListingId { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public bool HasSpareWheel { get; set; }

        public double Price { get; set; }
    }
}
