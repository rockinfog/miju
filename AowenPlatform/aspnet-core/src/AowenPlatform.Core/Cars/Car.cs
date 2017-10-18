using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AowenPlatform.Cars
{
    public class Car : FullAuditedEntity
    {
        public const int MaxNameLength = 32;
        public const int MaxPathLength = 128;
        public const int MaxDescLength = 512;
        /// <summary>
        /// 车型名称
        /// </summary>
        [MaxLength(32)]
        public string Name { get; set; }



        /// <summary>
        /// 车型描述
        /// </summary>
        [MaxLength(512)]
        public string Desc { get; set; }


        
    }
}
