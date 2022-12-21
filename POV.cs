using System;
namespace Exercicio_LogProg_2
{
    public static class POV
    {
        public static int funcaoRetornaQuantidadePOV(decimal porcentagem, int totalNegociado)
        {
            return (int)Math.Round((totalNegociado + (porcentagem * totalNegociado)) * porcentagem);
            //return (int)Math.Round((porcentagem + 1) * totalNegociado * porcentagem);
        }
    }
}

