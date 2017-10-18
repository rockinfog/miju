using Abp.AutoMapper;
using Abp.Runtime.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AowenPlatform.Cars.Dto
{
    [AutoMapTo(typeof(Car))]
    public class CreateCarDto
    {
        [Required(ErrorMessage = "{0}必填")]
        [DisplayName("车型名称")]
        [StringLength(Car.MaxNameLength, ErrorMessage = "{0}最大长度{1}")]
        public string Name { get; set; }



        [DisplayName("车型描述")]
        [StringLength(Car.MaxDescLength, ErrorMessage = "{0}最大长度{1}")]
        public string Desc { get; set; }
    }
}
