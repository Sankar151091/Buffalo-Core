﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Buffalo.Entities.DataTransferObjects
{
    public class CompanyDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string FullAddress { get; set; }
    }
}
