using System;
using Course.Entidades.Enums;
using Microsoft.VisualBasic;
using Course.Entidades;

namespace Course.Entidades
{
    internal class Trabalhador
    {
        public string Name { get; set; }

        public LevelTrabalhador Level { get; set; }

        public double SalarioBase { get; set; }

        public Departamento Departamento { get; set; }

        public List<HoraContrato> Contratos { get; set; } = new List<HoraContrato>();

        public Trabalhador()
        {

        }

        public Trabalhador(string name, LevelTrabalhador level, double salarioBase, Departamento departamento)
        {
            Name = name;
            Level = level;
            SalarioBase = salarioBase;
            Departamento = departamento;

        }

        public void AddContratos(HoraContrato contrato)
        {
            Contratos.Add(contrato);
        }

        public void RemoveContratos(HoraContrato contrato)
        {
            Contratos.Remove(contrato);
        }

        public double Renda(int ano, int mes)
        {
            double soma = SalarioBase;
            foreach (HoraContrato contrato in Contratos)
            {
                if (contrato.Data.Year == ano && contrato.Data.Month == mes)
                {
                    soma = soma + contrato.TotalValor();
                }

            }
            return soma;
        }

    }
}
