﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    public class CriaEntidade  
    {
        public CriaEntidade()
        {
                       
        }
        public void UsaEntidade(IPessoa a)
        {
            a.Adicionar();
        }
    }
}
