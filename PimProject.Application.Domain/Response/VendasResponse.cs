﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimProject.Application.Domain.Response
{
    public class VendasResponse
    {
        public string venda_id {  get; set; }
        public string valor_venda { get; set; }
        public string quantidade_vendida {  get; set; }
    }
}
