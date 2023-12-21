using ProjetoInterfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInterfaces.Services
{
    interface IServicoEnvio
    {
        double CalcularTaxaEnvio( Produto produto);
        string EstimarTempoEntrega(Produto produto);
    }
}
