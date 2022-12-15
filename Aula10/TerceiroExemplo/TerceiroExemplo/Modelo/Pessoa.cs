﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerceiroExemplo.Modelo
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string? Nome { get; set; }


        public override string ToString()
        {
            return $"Id: {Id}\nNome: {Nome}\n-------------";
        }
    }
}
