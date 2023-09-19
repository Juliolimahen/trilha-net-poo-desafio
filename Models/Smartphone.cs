namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        private string _modelo;
        private string _imei;
        private int _memoria;
        public string Modelo { get => _modelo; private set => _modelo = value; }
        public string IMEI { get => _imei; private set => _imei = value; }
        public int Memoria { get => _memoria; private set => _memoria = value; }
        public string Numero { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        // Metodo para testar 
        public void ExibirCaracteristicas()
        {
            Console.WriteLine($"Numero {Numero}, Modelo {Modelo}, IMEI {IMEI}, Memoria {Memoria}");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
