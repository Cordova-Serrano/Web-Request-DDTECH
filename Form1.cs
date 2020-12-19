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
using System.Net;

namespace WebRequest_DDTECH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void categorias_MouseClick(object sender, MouseEventArgs e)
        {
            string urlMain = "https://ddtech.mx";

            string responseFromServer = responseWebRequest(urlMain);

            int f;
            int g;
            int h;
            int k = 0;

            for (int i = 0; i < 15; i++)
            {
                f = responseFromServer.IndexOf("ddtech-icon icon-category", k);

                g = responseFromServer.IndexOf("</i>", f);

                h = responseFromServer.IndexOf("</a>", g + 1);

                string cadena = responseFromServer.Substring(g + 4, h - g - 4);

                listCategories.Items.Add(cadena); //Se añade la categoría a la listBox

                k = responseFromServer.IndexOf("ddtech-icon icon-category", h);
            }
        }
        private void listCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            listProductos.Items.Clear(); //se limpia el arreglo de Productos para ser reemplazado por una nueva seleccion 
            listSubCat.Items.Clear(); //se limpia el arreglo de Sub Categorias para ser reemplazado por una nueva seleccion 
            labelCategoria.Text = (string)listCategories.Items[listCategories.SelectedIndex];
            labelCategoria.Visible = true;
            CategoryItems((string)listCategories.Items[listCategories.SelectedIndex]);
        }
        private void CategoryItems(string category)
        {
            string urlCat = "https://ddtech.mx";

            //Aqui se recibe toda la informacion de la url 
            string responseFromServer = responseWebRequest(urlCat);

            //Variables para las Categorías
            int f;
            int g;
            int h;
            int k = 0;
            //Variables para las Sub - Categorías
            int q;
            int w;
            int e;
            int r;

            for (int i = 0; i < 15; i++)
            {
                f = responseFromServer.IndexOf("ddtech-icon icon-category", k);

                g = responseFromServer.IndexOf("</i>", f);

                h = responseFromServer.IndexOf("</a>", g + 1);

                string cadena = responseFromServer.Substring(g + 4, h - g - 4);

                if (category == cadena)//Se encontro la categoría que se buscaba
                {
                    //Hora de obtener sus Sub - Categorías
                    //Para el ciclo debemos buscar algun patron que nos determine el fin de las SubCategorias
                    //dropdown menu-item esta cada vez que se inicia una nueva categoria
                    r = h;
                    bool flag = true;

                    while (flag)
                    {
                        q = responseFromServer.IndexOf("title=", r);

                        w = responseFromServer.IndexOf("href=", q);

                        //Aqui encontramos la Sub Categoría
                        string subCadena = responseFromServer.Substring(q + 7, w - q - 9);
                        listSubCat.Items.Add(subCadena); //Se añade la categoría a la listBox

                        r = responseFromServer.IndexOf("title=", w); //Aqui encuentra otro title =
                        //Si despues de w se encuentra un dropdown menu-item significa que termino la categoría
                        e = responseFromServer.IndexOf("dropdown menu-item", w); //Aqui ya se tiene la posicion de nuestro final = 12462

                        if (r > e)
                        {
                            flag = false;
                        }
                    }
                }
                k = responseFromServer.IndexOf("ddtech-icon icon-category", h);
            }
        }
        private void listSubCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            listProductos.Items.Clear(); //se limpia el arreglo de Productos para ser reemplazado por una nueva seleccion 
            labelSubCat.Text = (string)listSubCat.Items[listSubCat.SelectedIndex];
            labelSubCat.Visible = true;
            SubCategoryItems((string)listSubCat.Items[listSubCat.SelectedIndex]);
        }
        private void SubCategoryItems(string Subcategory) //Recibe el nombre de la sub categoria seleccionada 
        {
            //Nombre de la Categoria Padre
            string categoria = labelCategoria.Text;
            //Nombre de la Subcategoría deseada
            string subCategoria = labelSubCat.Text;

            string url;

            bool flagPaginas = true;
            int x = 1; //Se inicia en la página 1 

            while (flagPaginas)
            {
                //Variables para las Categorías
                int f = 0;
                int g;
                int h;
                int k = 0;

                if (labelSubCat.Text == "Ver todo") //Si se selecciona Ver todo 
                {
                    url = "https://ddtech.mx/productos/" + categoria + "?pagina=" + x;
                    Console.WriteLine(url); //url visitada 
                }
                else
                {
                    url = "https://ddtech.mx/productos/" + categoria + "/" + subCategoria + "?pagina=" + x;
                    Console.WriteLine(url); //url visitada 
                }
                //Hora de encontrar la informacion de esta Sub Categoría 
                string responseFromServer = responseWebRequest(url);

                //Obtenemos la cantidad de productos en la página
                bool flag = true;
                string cantidad = " ";
                int contProductos = 0;

                int end = responseFromServer.IndexOf("<div class=\"product-pagination\">", k); // Posicion del fin de los productos

                while (flag)
                {
                    f = responseFromServer.IndexOf("<div class=\"product-image\">", k); //Marca el inicio del produto

                    if (f != -1) //Si la posicion de f es diferente a -1
                    {
                        cantidad = responseFromServer.Substring(f, 27);
                    }

                    if (cantidad == "<div class=\"product-image\">") //Se encontro la palabra
                    {
                        contProductos++;
                    }

                    if (f == -1) //Si la posicion de f es -1 se termino la busqueda
                    {
                        flag = false;
                    }

                    k = f + 27;
                } //Con este While se obtienen la cantidad de productos en la página 

                contProductos -= 1;

                Console.WriteLine("Página : " + x + " " + categoria);
                Console.WriteLine("Cantidad de Productos: " + contProductos);

                for (int j = 0; j < contProductos; j++)
                {
                    f = responseFromServer.IndexOf("<div class=\"product-image\">", k);
                    //Console.WriteLine("f :" + f);

                    g = responseFromServer.IndexOf("title=", f);
                    //Console.WriteLine("g :" + g);
                    h = responseFromServer.IndexOf("href=", g);
                    //Console.WriteLine("h :" + h);

                    //Aqui encontramos el Nombre del Producto
                    string nombre = responseFromServer.Substring(g + 7, h - g - 9); // Nombre del producto 
                    Console.WriteLine("Producto : " + nombre);

                    f = responseFromServer.IndexOf("class=\"price\">", h); //Dependiendo de la cantidad de veces que se encuentra esa palabra es la cantidad de productos 
                                                                           //Console.WriteLine("f :" + f);
                    g = responseFromServer.IndexOf("</span>", f);
                    //Console.WriteLine("g :" + g);

                    //Aqui encontramos el Precio del Producto
                    string precio = responseFromServer.Substring(f + 14, g - f - 14); // Nombre del producto 
                    Console.WriteLine("Precio : " + precio);

                    //Aqui añadimos la info a la lista
                    listProductos.Items.Add(nombre + " " + precio);
                    k = g;
                } //For para la impresion de los productos de la página actual 

                //Detectamos si es la ultima página, cuando una página llega a su fin cuenta con este patron : href="javascript:return false;">Siguiente</a>
                int endPage = 0;

                endPage = responseFromServer.IndexOf("href=\"javascript:return false;\">Siguiente</a>", 0); //Se busca esta palabra en el código fuente

                if (endPage != -1)
                {
                    flagPaginas = false;
                }
                x++;
            }
        }
        public string responseWebRequest(string url)
        {
            // Create a request for the URL. 		
            WebRequest request = WebRequest.Create(url);
            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // Display the status.
            //Console.WriteLine(response.StatusDescription); //Ok si encontro la info
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd(); //Aqui se obtiene toda la informacion

            reader.Close();
            dataStream.Close();
            response.Close();

            return responseFromServer;
        }
    }
}

