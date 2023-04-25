﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pClasses
{
    class Mensalista : Empregado
    {
        public Double SalarioMensal { get; set; }

        public override double SalarioBruto()
        {
            return SalarioMensal;
        }


        public Mensalista()
        {

        }
        public Mensalista(int matx, string nomex, DateTime datax, double salariox)
        {
            Matricula = matx;
            NomeEmpregado = nomex;
            DataEntradaEmpresa = datax;
            SalarioMensal = salariox;
        }
        //public Mensalista()
        //{
        //    MessageBox.Show("passei por aqui");
        //}
    }
    
}
