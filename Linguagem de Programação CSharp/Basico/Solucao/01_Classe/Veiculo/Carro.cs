namespace _01_Classe.Veiculo
{
    public class Carro
    {
        // Propriedades
        public string marca = "Fiat";
        public string modelo;
        public string cor;
        public bool luzesInternas = false;

        // Métodos
        public void AbrirPorta()
        {
            luzesInternas = true;
        }
        public void FecharPortas()
        {
            luzesInternas = false;
        }
        public string AcenderFarolAutomaticamente()
        {
            return "Médio";
        }
    }
}
