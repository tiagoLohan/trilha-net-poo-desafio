namespace DesafioPOO.Models
{
    // // Implementado !!!!!!!!!!!!!!
    public class Nokia : Smartphone
    {
        // Implementado !!!!!!!!!!!!!!
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo *{nomeApp}* em um Nokia.");
        }
    }
}