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
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                try
                {
                    throw new Exception("Número de hóspedes excede a capacidade da suíte");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
            }
        }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes(int hospedes)
        {
           hospedes = Hospedes.Count;
            return hospedes;
        }

        public decimal CalcularValorDiaria(decimal valorDiaria, int diasReservados)
        {
            decimal valorTotal = valorDiaria * diasReservados;
                   
            
            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (diasReservados>=10) 
            {
             valorTotal *= 0.9M;
            }

            return valorTotal;
        }
    }
}