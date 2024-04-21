namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string nome, string modelo, string imei, int memoria)
                                        : base(nome, modelo, imei, memoria) { }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando app {nomeApp} de IPhone {Modelo}, IMEI {IMEI} e {Memoria}MB de memoria");
        }
    }
}