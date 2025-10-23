namespace InversaoDependencias
{
    public class Interruptor
    {
        // Privada somente leitura, variável criada como dispositivo
        private readonly IDispositivo dispositivo;

        //this.dispositivo para não confundir as variáveis
        public Interruptor(IDispositivo dispositivo) => this.dispositivo = dispositivo; // ou _dispositivo

        public void Acionar() => dispositivo.Ligar();
    }
}