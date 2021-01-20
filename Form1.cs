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

namespace ProyectoFicherosCarpetas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_ruta.Text = Directory.GetCurrentDirectory();
        }

        private void buttonListarFicheros_Click(object sender, EventArgs e)
        {
            string newPath, errorMessage = null, sourceDirectory, fileName, directoryName, ultimoCaracter;
            listBox_listar.Items.Clear();
            newPath = textBox_ruta.Text;
            try
            {
                Directory.SetCurrentDirectory(newPath);
                sourceDirectory = newPath;
                var txtFiles = Directory.EnumerateFiles(sourceDirectory);
                foreach (string currentFile in txtFiles)
                {
                    ultimoCaracter = newPath.Substring(newPath.Length - 1);
                    if (ultimoCaracter.CompareTo("\\") == 0 || (ultimoCaracter.CompareTo(":") == 0))
                    {
                        fileName = currentFile.Substring(sourceDirectory.Length);
                        listBox_listar.Items.Add(fileName);
                    }
                    else
                    {
                        fileName = currentFile.Substring(sourceDirectory.Length + 1);
                        listBox_listar.Items.Add(fileName);
                    }
                }
                var txtDirectories = Directory.EnumerateDirectories(sourceDirectory);
                foreach (string currentDirectory in txtDirectories)
                {
                    ultimoCaracter = newPath.Substring(newPath.Length - 1);
                    if (ultimoCaracter.CompareTo("\\") == 0 || (ultimoCaracter.CompareTo(":") == 0))
                    {
                        directoryName = currentDirectory.Substring(sourceDirectory.Length);
                        listBox_listar.Items.Add(directoryName);
                    }
                    else
                    {
                        directoryName = currentDirectory.Substring(sourceDirectory.Length + 1);
                        listBox_listar.Items.Add(directoryName);
                    }
                }
            }
            catch (DirectoryNotFoundException f)
            {
                errorMessage = "Debes introducir una ruta válida";
                Console.WriteLine(f.ToString());
            }
            catch (ArgumentException a)
            {
                Console.WriteLine(a.ToString());
                errorMessage = "Debes introducir una ruta válida";
            }
            finally
            {
                if (errorMessage != null)
                {
                    MessageBox.Show(errorMessage);
                }
            }
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            string ruta;
            try
            {
                ruta = textBox_ruta.Text + "/" + textBox_directorioOFichero.Text;
                if (radioButton_fichero.Checked)
                {
                    if (File.Exists(@ruta))
                    {
                        MessageBox.Show("El fichero ya existe");
                        return;
                    }
                    StreamWriter streamWriter = File.CreateText(@ruta);
                    streamWriter.Close();
                }
                if (radioButton_carpeta.Checked)
                {
                    if (Directory.Exists(@ruta))
                    {
                        MessageBox.Show("La carpeta ya existe");
                        return;
                    }
                    DirectoryInfo directoryInfo = Directory.CreateDirectory(@ruta);
                }
                button_listarFicheros.PerformClick();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error, inténtalo de nuevo");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            string ruta;
            try
            {
                ruta = textBox_ruta.Text + "/" + textBox_directorioOFichero.Text;
                if (radioButton_fichero.Checked)
                    File.Delete(@ruta);
                if (radioButton_carpeta.Checked)
                    Directory.Delete(@ruta);
                button_listarFicheros.PerformClick();
            }
            catch
            {
                MessageBox.Show("No se ha podido eliminar, algo ha fallado");
            }
        }

        private void buttonRenombrarMover_Click(object sender, EventArgs e)
        {
            string fuente = "", destino = "";
            if (listBox_listar.SelectedItem != null)
            {
                fuente = textBox_ruta.Text + "/" + listBox_listar.SelectedItem.ToString();
                destino = textBox_directorioOFichero.Text;
            }
            else
            {
                MessageBox.Show("Debes seleccionar un fichero/directorio de la lista");
                return;
            }

            if (textBox_ruta.Text.EndsWith("/"))
                fuente = textBox_ruta.Text + listBox_listar.SelectedItem.ToString();
            try
            {
                if (radioButton_fichero.Checked)
                    File.Move(@fuente, @destino);
                if (radioButton_carpeta.Checked)
                    Directory.Move(@fuente, @destino);
                button_listarFicheros.PerformClick();
            }
            catch (FileNotFoundException fne)
            {
                Console.WriteLine(fne.ToString());
                if (radioButton_fichero.Checked)
                    MessageBox.Show("Has elegido fichero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("No ha logrado renombrar o mover");
            }
        }

        private void buttonVisualizarFichero_Click(object sender, EventArgs e)
        {
            textBox_VisualizarFichero.Text = String.Empty;
            try
            {
                if (listBox_listar.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un fichero");
                    return;
                }
                System.IO.FileInfo thisFile = new FileInfo(listBox_listar.SelectedItem.ToString());
                if (thisFile.Exists)
                    textBox_VisualizarFichero.Text = System.IO.File.ReadAllText(thisFile.FullName);
            }
            catch
            {
                MessageBox.Show("Es un directorio");
            }
        }

        private void buttonModificarFichero_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox_listar.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, elija un elemento de la lista");
                    return;
                }
                System.IO.FileInfo thisFile = new FileInfo(listBox_listar.SelectedItem.ToString());
                if (thisFile.Exists)
                    System.IO.File.WriteAllText(thisFile.FullName, textBox_VisualizarFichero.Text);
            }
            catch
            {
                MessageBox.Show("Es una carpeta");
            }
        }

    }
}
