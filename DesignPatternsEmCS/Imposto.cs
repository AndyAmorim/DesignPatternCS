using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsEmCS
{
    public interface Imposto
    {
        double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }
    }
}
