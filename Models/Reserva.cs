namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            int capacidade = Suite.Capacidade;
            int quantidadeHospedes = hospedes.Count;
            if (quantidadeHospedes <= capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception ("Capacidade de hospedes superada");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = 0;

            if (DiasReservados < 10)
            {
                valor = DiasReservados * Suite.ValorDiaria;
            }
            else
            {
                valor = (DiasReservados * Suite.ValorDiaria) - ((DiasReservados * Suite.ValorDiaria) * 0.10M);
            }

            return valor;
        }
    }
}