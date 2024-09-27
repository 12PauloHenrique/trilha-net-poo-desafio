namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        protected string Modelo {get; set; }
        protected string Imei { get; set; }
        protected int Memoria { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        // Implementado

        public Smartphone(string numero)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            // Implementado
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando..");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}