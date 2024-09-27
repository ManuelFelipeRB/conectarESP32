using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conectarESP32
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient(); // HttpClient para solicitudes HTTP
        private System.Windows.Forms.Timer timer; // Timer de Windows Forms
        private bool isReading = false; // Para controlar la lectura
        private string esp32Ip; // Variable para almacenar la IP del ESP32

        public Form1()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer(); // Inicializa el Timer de Windows Forms
            timer.Interval = 1000; // Cada segundo
            timer.Tick += OnTimedEvent; // Asocia el evento Tick
        }

        private void desconexion_Click(object sender, EventArgs e)
        {
            CloseConnections();
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void but_conectaIP_Click(object sender, EventArgs e)
        {
            esp32Ip = comboBox_ip.SelectedItem.ToString(); // Obtener la IP del comboBox
            string url = $"http://{esp32Ip}/get_weight?boton=1"; // Cambia 'boton' según sea necesario

            try
            {
                isReading = true; // Iniciar la lectura
                timer.Start(); // Inicia el Timer al conectar

                // Obtener el peso del servidor
                string peso = await GetWeightAsync(url);
                UpdateWeightLabel(peso);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message);
            }
        }

        private void OnTimedEvent(object sender, EventArgs e)
        {
            if (isReading)
            {
                string url = $"http://{esp32Ip}/get_weight?boton=1"; // Llama al endpoint
                Task.Run(async () =>
                {
                    try
                    {
                        string peso = await GetWeightAsync(url); // Obtener el peso en tiempo real
                        UpdateWeightLabel(peso); // Actualizar el label con el nuevo peso
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al obtener el peso: " + ex.Message);
                    }
                });
            }
        }

        private async Task<string> GetWeightAsync(string url)
        {
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode(); // Asegúrate de que la respuesta sea exitosa
            string responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }

        private void UpdateWeightLabel(string data)
        {
            // Verificar si es necesario invocar en el hilo de la UI
            if (label1.InvokeRequired)
            {
                label1.Invoke(new Action<string>(UpdateWeightLabel), data);
                return;
            }

            // Asignar los datos al label directamente
            label1.Text = data;// + " gr"; // Añadir unidad
        }

        public void CloseConnections()
        {
            isReading = false; // Detener la lectura
            timer.Stop(); // Detener el timer al cerrar conexiones
        }
    }
}
