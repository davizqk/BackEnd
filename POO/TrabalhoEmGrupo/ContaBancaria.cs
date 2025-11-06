
namespace TrabalhoEmGrupo
{
    public class ContaBancaria
    {
    private double saldo; // dado protegido
    public double Saldo //propriedade
    {
        get { return saldo; }          // Permite ler o valor
        private set                   // Só pode ser alterado dentro da classe
        {
            if (value >= 0)            // Garante que o saldo nunca seja negativo
                saldo = value;
        }
    }
    public void Depositar(double valor)
    {
        if (valor > 0)
            saldo += valor;
    }

    public double ConsultarSaldo()
    {
        return saldo;
    }
}