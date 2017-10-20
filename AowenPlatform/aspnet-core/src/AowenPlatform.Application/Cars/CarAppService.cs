using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using AowenPlatform.Cars.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace AowenPlatform.Cars
{
    public class CarAppService : AsyncCrudAppService<Car, CarDto, int, PagedResultRequestDto, CreateCarDto, CarDto>, ICarAppService
    {
        public CarAppService(IRepository<Car> repository)
            : base(repository)
        {
        }
    }
}
