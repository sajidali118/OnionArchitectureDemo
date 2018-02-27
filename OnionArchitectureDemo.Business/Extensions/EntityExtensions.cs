﻿using OnionArchitectureDemo.Business.Entities;
namespace OnionArchitectureDemo.Business.Extensions
{
    internal static class EntityExtensions
    {
        internal static Car ToBusinessEntity(this Data.Entities.Car car)
        {
            return new Car()
            {
                HasSpareWheel = car.HasSpareWheel,
                Make = car.Make,
                Model = car.Model
            };
        }
    }
}
