namespace DesafioPOO.Models
{
    public class Nokia(string numero, string modelo, string imei, int memoria) : Smartphone(numero, modelo, imei, memoria)
    {
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Nokia is installing {nome}");
        }
    }
}