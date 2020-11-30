﻿using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersistenceLayer.Interfaces
{
    public interface ICrudProduto : ICrud<Produto> {

        int getProdutos();

    }
}
