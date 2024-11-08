using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using System.IO.Ports;
using System.Globalization;
using Mysqlx.Cursor;

namespace examen1p2
{
    public partial class Form1 : Form
    {
        private string SqlConection = "Server=localhost; Port=3306; Database=Exapractico1;Uid=root;Pwd=12345;";
        public SerialPort ArduinoPort { get; }
        private ToolTip toolTip;

        public Form1()
        {
            InitializeComponent();
            tbNombre.TextChanged += validarNombre;
            tbFecha.TextChanged += tbFecha_TextChanged;

            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM7";
            ArduinoPort.BaudRate = 9600;
            //ArduinoPort.Open();
            toolTip = new ToolTip();

            // Vincular eventos
            this.FormClosing += CerrandoForm1;
            this.btApagar.Click += btApagar_Click;
            this.btEncender.Click += btEncender_Click;
        }

        private void InsertarRegistro(string nombre, string fecha, decimal Temp_Celcius, decimal Temp_Fahrenheit)
        {
            try
            {
                using (MySqlConnection conection = new MySqlConnection(SqlConection))
                {
                    conection.Open();

                    string insertQuery = "INSERT INTO datos (Nombre_usuario, Fecha, Temp_Celcius, Temp_Fahrenheit) " +
                                         "VALUES (@Nombre_usuario, @Fecha, @Temp_Celcius, @Temp_Fahrenheit)";

                    using (MySqlCommand command = new MySqlCommand(insertQuery, conection))
                    {
                        // Añadir el parámetro Nombre_usuario
                        command.Parameters.AddWithValue("@Nombre_usuario", nombre);

                        // Convertir la fecha a DateTime
                        DateTime fechaDateTime;
                        if (DateTime.TryParseExact(fecha, "yyyy/MM/dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaDateTime))
                        {
                            // Añadir el parámetro Fecha como DateTime
                            command.Parameters.AddWithValue("@Fecha", fechaDateTime.Date);
                        }
                        else
                        {
                            MessageBox.Show("El formato de fecha no es válido. Por favor usa el formato yyyy/MM/dd.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Salir si la fecha no es válida
                        }

                        // Añadir los parámetros de temperatura
                        command.Parameters.AddWithValue("@Temp_Celcius", Temp_Celcius);
                        command.Parameters.AddWithValue("@Temp_Fahrenheit", Temp_Fahrenheit);

                        // Ejecutar la consulta
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbFecha_TextChanged(object sender, EventArgs e)
        {
            if (!validarFecha(tbFecha.Text))
            {
                toolTip.SetToolTip(tbFecha, "Por favor ingresa una fecha válida (formato: yyyy/MM/dd).");
            }
            else
            {
                toolTip.SetToolTip(tbFecha, string.Empty);
            }
        }


        private bool validarFecha(string Fecha)
        {
            return DateTime.TryParse(Fecha, out _);
        }

        private bool EsTextoValido(string valor)
        {
            return Regex.IsMatch(valor, @"^[a-zA-Z\s]+$");
        }

        private void validarNombre(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsTextoValido(textBox.Text))
            {
                MessageBox.Show("Ingrese un nombre válido", "Error Nombre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            // Obtener valores de entrada de los controles del formulario
            string nombre = tbNombre.Text;
            string fecha = tbFecha.Text;
            string Temp_Celcius = lbCelcius.Text;

            try
            {
                // Convertir la temperatura de Celsius a Fahrenheit
                decimal tempCelcius = decimal.Parse(Temp_Celcius);
                decimal tempFahrenheit = (tempCelcius * 9 / 5) + 32;

                // Asignar valores fijos a las etiquetas para mostrar en el formulario
                float lbCel = 25.0f; // Muestra un valor fijo de ejemplo
                float lbFar = lbCel * 9 / 5 + 32;

                // Llamar al método para insertar el registro en la base de datos
                InsertarRegistro(nombre, fecha, tempCelcius, tempFahrenheit);

                // Actualizar las etiquetas para mostrar la temperatura en Celsius y Fahrenheit
                lbCelcius.Text = $"Celsius: {lbCel}°C"; // Mostrar en Celsius
                lbFahrenheit.Text = $"Fahrenheit: {lbFar}°F"; // Mostrar en Fahrenheit

                // Crear el mensaje de confirmación para el usuario
                string usuario = $"Nombre: {nombre}\r\nFecha: {fecha}";

                // Mostrar el mensaje de éxito
                MessageBox.Show("Datos guardados con éxito: \n\n" + usuario, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Error en el formato de la temperatura. Asegúrate de que sea un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btEncender_Click(object sender, EventArgs e)
        {
            if (ArduinoPort.IsOpen)
            {
                ArduinoPort.Write("b");
            }
        }

        private void CerrandoForm1(object sender, FormClosingEventArgs e)
        {
            if (ArduinoPort.IsOpen) ArduinoPort.Close();
        }

        private void btApagar_Click(object sender, EventArgs e)
        {
            if (ArduinoPort.IsOpen)
            {
                ArduinoPort.Write("a");
            }
        }

    }
}

