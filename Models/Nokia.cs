namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Type tipo = typeof(Nokia);
            Console.WriteLine($"Instalando o {nomeApp} no {tipo.Name}");
        }
    }
}
