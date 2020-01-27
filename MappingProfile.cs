﻿using AutoMapper;
using CarsCatalogue.Models;
using CarsCatalogue.Models.DataTransferObjects;

namespace CarsCatalogue
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Car, CarDto>();
            CreateMap<CarForCreationDto, Car>();
            CreateMap<Car, CarDto>(); //CODEREV: Дубликат кода выше?
            CreateMap<CarForUpdateDto, Car>();
        }
    }
}