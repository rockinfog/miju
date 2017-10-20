using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AowenPlatform.Cars.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace AowenPlatform.Cars
{
    public interface ICarAppService : IAsyncCrudAppService<CarDto, int, PagedResultRequestDto, CreateCarDto, CarDto>
    {

    }
}
