using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversores
{
    public partial class Form1 : Form
    {
        String[][] TiposConversores = new string[][]{
          new String[]{ "Dolar", "Euro", "Quetzal", "Lempira", "Cordoba", "Colon SV", "Colon CR", "Yenes", "Rupias India", "Libras Esterlinas" }, //Monedas
           new String[]{"Onza", "Libra", "Stone", "Tonelada Corta", "Tonelada Larga", "Microgramo", "Miligramo", "Gramo", "Kilogramo","Tonelada", },//Masa
           new String[]{"Pulgada Cúbica", "Pie Cúbico", "Chucharadita Imperial", "Cucharada Imperial", "Onza Líquida Imperal", "Taza Imperial", "Pintal Imperial", "Cuarto Imperial", "Galón Imperial", "Mililitro",},//Volumen
           new String[]{"Milla", "Pulgada", "Pie", "Yarda", "Milla", "Nanómetro", "Micrómetro", "Milímetro", "Centímetro", "Metro", },//Longitud
           new String[]{"Bit", "Kilobit", "Kibibit", "Megabit", "Megabibit", "Gigabit", "Gibibit", "Terabit", "Tebibit", "Petabit",},//Almacenamiento
           new String[]{"Milisegundo", "Segundo", "Minuto", "Hora", "Día", "Semana", "Mes", "Año", "Década", "Siglo", },//Tiempo 
           new String[]{ "Julio", "Kilojulio", "Caloría-gramo", "Kilocaloría", "Vatio-hora", "Kilovatio-hora", "Electronvoltio", "Unidad térmica británica", "Termia estadounidense", "Pie-libra fuerza",},//Energía
           new String[]{ "Bit por segundo", "Kilobit por segundo", "Kilobyte por segundo", "Kibibit por segundo", "Megabit por segundo", "Megabyte por segundo", "Mebibit por segundo", "Gigabit por segundo", "Gigabyte por segundo", "Terabit por segundo",},// Tasa de transmisión de datos
           new String[]{"Milla por Galón de Americano", "Millas por Galón (Imperial)", "Kilómetros por Litro", "Litro por 100 Kilómetros",},//Consumo de combustible
           new String[]{"Hercio", "Kilohercio", "Megahercio", "Gigahercio",},//Frecuencia
           new String[]{"Atmósfera", "Bar", "Libra por pulgada Cuadrada", "Pascal", "Torr",},//Presión 
           new String[]{"Grado Celsius", "Grado Fahrenheit", "Kelvin",},//Temperatura
           new String[]{"Grado", "Grado Centesial", "Milirradián", "Minuto de Arco", "Radián", "Segundo de arco",},//Ángulo Plano
        };//Matriz Dentada
            
            public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertirConversores_Click(object sender, EventArgs e)
        {
            int de, a;
            double cantidad, respuesta;

            de = cboDeConversores.SelectedIndex;
            a = cboAConversores.SelectedIndex;

            cantidad = double.Parse(txtCantidadConversores.Text);
            // Dolar, Euro, Quetzal, Lempira, Cordoba, Colon SV, Colon CR, Yenes, Rupias India, Libras Esterlinas
            double[][] monedas = {
                new double[]{1, 0.92, 7.86, 24.62, 36.56, 8.75, 535.14, 145.52, 83.32, 0.79}, // Array Unidimensional 
                new double[] {16, 0.0625, 0.00446429, 3.12500000, 2.790200000, 2.8350000000, 28349.5, 28.3495, 0.0283495, 2.83500000},//masa
                new double[] {1728, 0.000578704, 2.76837, 0.92279, 0.576743988284992, 0.0576744039031373, 0.0288371994142496, 0.0144185997071248, 0.0036046499267812, 16.3870629856407 },//volumen
                new double[] {0.000621371, 39.3701, 3.28084, 1.09361, 0.000621371, 1000000000, 1000000, 1.000, 100, 0.001 },//Longitud
                new double[] {1000, 0.001, 1.666700000, 2.77780000000, 0.000694444, 9.920600000, 0.00136986, 0.000114155, 1.141600000, 1.1416000000},//Tiempo
                new double[] {1000, 0.001, 0.239006, 0.000239006, 0.000277778, 2.77780000000, 6.242000000000000000000, 0.000947817, 9.4804000000000, 0.737562 },//Energía 
                new double[] {1000, 0.001, 0.000976563, 1000000, 9.53670000000, 1000000000, 9.31320000000000, 1000000000000, 9.09490000000000000, 1000000000000000}, //Almacenamiento
                new double[] {0.001, 0.000125, 0.000976563, 1000000, 1.250000000, 9.53670000000, 1000000000, 1.250000000000, 9.31320000000000, 1000000000000},//Tasa de transmisión de datos
                new double[] { 0.832674, 1.20095, 0.425144, 235.215},//Consumo de Combustible
                new double[] { 1000, 0.001, 1000000, 1000000000},//Frecuencia
                new double[] { 0.986923, 1.01325, 14.6959, 101325, 760},//Presión
                new double[] { -17.7778, 32, 273.15},//Temperatura
                new double[] { 0.9, 1.11111, 17.4533, 60, 0.0174533, 3600},//Ángulo plano                                    
            };

            MessageBox.Show(monedas[cboTipoConversor.SelectedIndex][a] + " - " + monedas[cboTipoConversor.SelectedIndex][de]);
            respuesta = monedas[cboTipoConversor.SelectedIndex][a] / monedas[cboTipoConversor.SelectedIndex][de] * cantidad;
            lblRespuestaConversores.Text = "Respuesta: " + Math.Round(respuesta, 3);
        }

        private void cboTipoConversor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboTipoConversor_TextChanged(object sender, EventArgs e)
        {
            cboDeConversores.Items.Clear();
            cboDeConversores.Items.AddRange(TiposConversores[cboTipoConversor.SelectedIndex]);

            cboAConversores.Items.Clear();
            cboAConversores.Items.AddRange(TiposConversores[cboTipoConversor.SelectedIndex]);
        }
    }
}
