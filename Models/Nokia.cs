namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    // Implementado
    public class Nokia : Smartphone
    {
        public Nokia (string numero) : base (numero)
        {

        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        // Implementado
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando aplicativo da Nokia Store");
            return ;
        }
    }
}