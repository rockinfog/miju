using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AowenPlatform.Cars.Dto
{
    [AutoMapFrom(typeof(Car))]
    public class CarDto : EntityDto<int>
    {
        /// <summary>
        /// 车型名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 车型描述
        /// </summary>
        public string Desc { get; set; }

    }
}
