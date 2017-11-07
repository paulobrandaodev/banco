namespace Dados
{
    public class ContaPessoaFisica : Conta
    {
        public string NomeCliente { get; set; }
        public string DataNascimento { get; set; }

        public override double Sacar(double Valor){
            this.Saldo -= Valor + 0.10;
            return this.Saldo; 
        }

        public override double Depositar(double Valor){
            this.Saldo += Valor + Saldo;
            return this.Saldo;


            
        }

    }
}