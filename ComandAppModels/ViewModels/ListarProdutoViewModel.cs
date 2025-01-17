﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandApp.Domain.ViewModels
{
    public class ListarProdutoViewModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }

        public ListarCategoriaViewModel Categoria { get; set; }
    }
}
