﻿namespace GeradorSequencial.Gerador.Interfaces
{
    public interface ISequencialService
    {
        void AdicionaSequencia(ParametroGeracao parametro,Sequencia sequencia);
        string RetornaSequencia(Sequencia sequencia);
    }
}
