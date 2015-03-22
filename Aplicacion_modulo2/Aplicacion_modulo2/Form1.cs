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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

//Equipo Mario

namespace Aplicacion_modulo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader p = new StreamReader("Respuesta.txt");
            string res = p.ReadLine();
            //Parseando JSON
            JObject o = JObject.Parse(res);
            int n = 1;
            String respuesta=string.Empty;
            

            foreach (var item in o)
            {
               respuesta += "titulo = " + o[n.ToString()]["titulo"]+"<br>" +
                             "categoria = " + o[n.ToString()]["categoria"]+"<br>"+
                             "imagen = "+"<br> <IMG SRC=\""+o[n.ToString()]["imagen"]+"\"><br>" +
                             //"imagen = "+"<br> <IMG SRC=\""+"http://107.170.246.222/prototipo/sites/default/files/field/image/manzana.jpg"+"\"><br>" +
                             "cuerpo = " + o[n.ToString()]["cuerpo"]+"<br>" +
                             "comentarios = " + o[n.ToString()]["comentarios"]+"<br>"+                
                             "fecha = " + o[n.ToString()]["fecha"]+"<br><br>";
               n++;
           }

            //Mostrando en Webrowser
            webBrowser1.DocumentText = respuesta;

          
        }


    }
}
