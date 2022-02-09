namespace Teste1.Classes
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public double Salario { get; set; }
        //public Date DataAdmissao { get; set;}
        public string CPF { get; set; }

        public void receberAumento(double aumento)
        {
            this.Salario += aumento;
        }

        public double calcularGanhoBrutoAnual()
        {
            return this.Salario * 12;
        }

        public double calcularImposto()
        {
            double ImpostoMensal = this.calcularGanhoLiquidoAnual();
            return ImpostoMensal * 12;
        }

        public double calcularGanhoLiquidoMensal()
        {
            double INSS = this.Salario * 1.11;
            double IR = 0.0;
            if(this.Salario > 2500.0)
            {
                IR = (this.Salario - 2500) * 1.17;
            }
            return this.Salario - (INSS + IR);
        }

        public double calcularGanhoLiquidoAnual()
        {
            double ImpostoMensal = this.calcularGanhoLiquidoAnual();
            double ImpostoAnual = ImpostoMensal * 12;
            double BrunoAnual = this.calcularGanhoBrutoAnual();
            return BrunoAnual - ImpostoAnual;
        }
    }
}