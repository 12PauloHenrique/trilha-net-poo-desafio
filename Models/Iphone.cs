namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    // Implementado
    public class Iphone : Smartphone
    {
        public Iphone(string numero) : base (numero)
        {

        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        // Implementado
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando aplicativo da IOS Store");
            //return ;
        }


    }
}