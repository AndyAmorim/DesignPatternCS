using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DesignPatternsEmCS
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, Imposto imposto)

        //ESSE COMENTARIO É PARA MOSTRAR COMO SERIA O CODIGO SEM DESIGN PATTERNS
        /*
      {
        if ("ICMS".Equals(imposto))
        {
            double icms = new ICMS().CalculaICMS(orcamento);
            Console.WriteLine(icms);
        }
        else if ("ISS".Equals(imposto))
        {
            double iss = new ISS().CalculaISS(orcamento);
            Console.WriteLine(iss);
        }
      }
        */
        //
        // A PARTIR DAQUI O CODIGO FOI OTIMIZADO ATRAVES DO DESING PATTERN STRATEGY
        {
            double icms = imposto.Calcula(orcamento);
            Console.WriteLine(icms);
        }
        
        


    }
}
