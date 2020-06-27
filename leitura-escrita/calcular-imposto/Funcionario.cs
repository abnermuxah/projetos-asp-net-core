using System;
using System.Collections.Generic;
using System.Text;

namespace calcular_imposto
{
    class Funcionario
    {
        public String Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido(){
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double Porcentagem) {
            SalarioBruto = SalarioBruto + SalarioBruto * (Porcentagem / 100);
        }

        public override string ToString() {
            return Nome + " Salario R$: " + SalarioLiquido();
        }
    }
}
