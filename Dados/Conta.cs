namespace Dados
{
    public class Conta
    {
        public string Numero { get; set; }
        public string Agencia { get; set; }
        public double Saldo { get; protected set; }

        /// <summary>
        /// Saca o dinheiro da conta bancária
        /// </summary>
        /// <param name="Valor">Valor a ser sacado</param>
        /// <returns>Saldo</returns>
        public virtual double Sacar(double Valor){
            this.Saldo -= Valor;
            return this.Saldo;            
        }

        /// <summary>
        /// Deposita o dinheiro da conta bancária
        /// </summary>
        /// <param name="Valor">Valor a ser depositado</param>
        /// <returns>Saldo</returns>
        public virtual double Depositar(double Valor){
            this.Saldo += Valor;
            return this.Saldo;
        }

        
        
    }
}