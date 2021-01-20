
namespace ProyectoFicherosCarpetas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_ruta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_listarFicheros = new System.Windows.Forms.Button();
            this.button_crear = new System.Windows.Forms.Button();
            this.button_renombrarMover = new System.Windows.Forms.Button();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.radioButton_fichero = new System.Windows.Forms.RadioButton();
            this.radioButton_carpeta = new System.Windows.Forms.RadioButton();
            this.groupBox_radioButtons = new System.Windows.Forms.GroupBox();
            this.label_directorioOFichero = new System.Windows.Forms.Label();
            this.textBox_directorioOFichero = new System.Windows.Forms.TextBox();
            this.button_modificarFichero = new System.Windows.Forms.Button();
            this.button_visualizarFichero = new System.Windows.Forms.Button();
            this.textBox_VisualizarFichero = new System.Windows.Forms.TextBox();
            this.listBox_listar = new System.Windows.Forms.ListBox();
            this.groupBox_radioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_ruta
            // 
            this.textBox_ruta.Location = new System.Drawing.Point(131, 37);
            this.textBox_ruta.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ruta.Name = "textBox_ruta";
            this.textBox_ruta.Size = new System.Drawing.Size(919, 22);
            this.textBox_ruta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Directorio actual:";
            // 
            // button_listarFicheros
            // 
            this.button_listarFicheros.Location = new System.Drawing.Point(11, 81);
            this.button_listarFicheros.Margin = new System.Windows.Forms.Padding(4);
            this.button_listarFicheros.Name = "button_listarFicheros";
            this.button_listarFicheros.Size = new System.Drawing.Size(219, 34);
            this.button_listarFicheros.TabIndex = 2;
            this.button_listarFicheros.Text = "Listar ficheros y carpetas";
            this.button_listarFicheros.UseVisualStyleBackColor = true;
            this.button_listarFicheros.Click += new System.EventHandler(this.buttonListarFicheros_Click);
            // 
            // button_crear
            // 
            this.button_crear.Location = new System.Drawing.Point(11, 310);
            this.button_crear.Margin = new System.Windows.Forms.Padding(4);
            this.button_crear.Name = "button_crear";
            this.button_crear.Size = new System.Drawing.Size(217, 31);
            this.button_crear.TabIndex = 4;
            this.button_crear.Text = "Crear";
            this.button_crear.UseVisualStyleBackColor = true;
            this.button_crear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // button_renombrarMover
            // 
            this.button_renombrarMover.Location = new System.Drawing.Point(461, 310);
            this.button_renombrarMover.Margin = new System.Windows.Forms.Padding(4);
            this.button_renombrarMover.Name = "button_renombrarMover";
            this.button_renombrarMover.Size = new System.Drawing.Size(217, 31);
            this.button_renombrarMover.TabIndex = 5;
            this.button_renombrarMover.Text = "Renombrar o mover";
            this.button_renombrarMover.UseVisualStyleBackColor = true;
            this.button_renombrarMover.Click += new System.EventHandler(this.buttonRenombrarMover_Click);
            // 
            // button_eliminar
            // 
            this.button_eliminar.Location = new System.Drawing.Point(236, 310);
            this.button_eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(217, 31);
            this.button_eliminar.TabIndex = 6;
            this.button_eliminar.Text = "Eliminar";
            this.button_eliminar.UseVisualStyleBackColor = true;
            this.button_eliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // radioButton_fichero
            // 
            this.radioButton_fichero.AutoSize = true;
            this.radioButton_fichero.Checked = true;
            this.radioButton_fichero.Location = new System.Drawing.Point(0, 12);
            this.radioButton_fichero.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_fichero.Name = "radioButton_fichero";
            this.radioButton_fichero.Size = new System.Drawing.Size(76, 21);
            this.radioButton_fichero.TabIndex = 7;
            this.radioButton_fichero.TabStop = true;
            this.radioButton_fichero.Text = "Fichero";
            this.radioButton_fichero.UseVisualStyleBackColor = true;
            // 
            // radioButton_carpeta
            // 
            this.radioButton_carpeta.AutoSize = true;
            this.radioButton_carpeta.Location = new System.Drawing.Point(127, 12);
            this.radioButton_carpeta.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_carpeta.Name = "radioButton_carpeta";
            this.radioButton_carpeta.Size = new System.Drawing.Size(79, 21);
            this.radioButton_carpeta.TabIndex = 8;
            this.radioButton_carpeta.Text = "Carpeta";
            this.radioButton_carpeta.UseVisualStyleBackColor = true;
            // 
            // groupBox_radioButtons
            // 
            this.groupBox_radioButtons.Controls.Add(this.radioButton_carpeta);
            this.groupBox_radioButtons.Controls.Add(this.radioButton_fichero);
            this.groupBox_radioButtons.Location = new System.Drawing.Point(11, 348);
            this.groupBox_radioButtons.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_radioButtons.Name = "groupBox_radioButtons";
            this.groupBox_radioButtons.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_radioButtons.Size = new System.Drawing.Size(217, 41);
            this.groupBox_radioButtons.TabIndex = 9;
            this.groupBox_radioButtons.TabStop = false;
            // 
            // label_directorioOFichero
            // 
            this.label_directorioOFichero.AutoSize = true;
            this.label_directorioOFichero.Location = new System.Drawing.Point(8, 406);
            this.label_directorioOFichero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_directorioOFichero.Name = "label_directorioOFichero";
            this.label_directorioOFichero.Size = new System.Drawing.Size(132, 17);
            this.label_directorioOFichero.TabIndex = 10;
            this.label_directorioOFichero.Text = "Directorio o fichero:";
            // 
            // textBox_directorioOFichero
            // 
            this.textBox_directorioOFichero.Location = new System.Drawing.Point(148, 402);
            this.textBox_directorioOFichero.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_directorioOFichero.Name = "textBox_directorioOFichero";
            this.textBox_directorioOFichero.Size = new System.Drawing.Size(901, 22);
            this.textBox_directorioOFichero.TabIndex = 11;
            // 
            // button_modificarFichero
            // 
            this.button_modificarFichero.Location = new System.Drawing.Point(236, 446);
            this.button_modificarFichero.Margin = new System.Windows.Forms.Padding(4);
            this.button_modificarFichero.Name = "button_modificarFichero";
            this.button_modificarFichero.Size = new System.Drawing.Size(217, 31);
            this.button_modificarFichero.TabIndex = 12;
            this.button_modificarFichero.Text = "Modificar fichero";
            this.button_modificarFichero.UseVisualStyleBackColor = true;
            this.button_modificarFichero.Click += new System.EventHandler(this.buttonModificarFichero_Click);
            // 
            // button_visualizarFichero
            // 
            this.button_visualizarFichero.Location = new System.Drawing.Point(11, 446);
            this.button_visualizarFichero.Margin = new System.Windows.Forms.Padding(4);
            this.button_visualizarFichero.Name = "button_visualizarFichero";
            this.button_visualizarFichero.Size = new System.Drawing.Size(217, 31);
            this.button_visualizarFichero.TabIndex = 13;
            this.button_visualizarFichero.Text = "Visualizar fichero";
            this.button_visualizarFichero.UseVisualStyleBackColor = true;
            this.button_visualizarFichero.Click += new System.EventHandler(this.buttonVisualizarFichero_Click);
            // 
            // textBox_VisualizarFichero
            // 
            this.textBox_VisualizarFichero.Location = new System.Drawing.Point(11, 496);
            this.textBox_VisualizarFichero.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_VisualizarFichero.Multiline = true;
            this.textBox_VisualizarFichero.Name = "textBox_VisualizarFichero";
            this.textBox_VisualizarFichero.Size = new System.Drawing.Size(1033, 232);
            this.textBox_VisualizarFichero.TabIndex = 14;
            // 
            // listBox_listar
            // 
            this.listBox_listar.FormattingEnabled = true;
            this.listBox_listar.ItemHeight = 16;
            this.listBox_listar.Location = new System.Drawing.Point(11, 139);
            this.listBox_listar.Name = "listBox_listar";
            this.listBox_listar.Size = new System.Drawing.Size(1039, 148);
            this.listBox_listar.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 743);
            this.Controls.Add(this.listBox_listar);
            this.Controls.Add(this.textBox_VisualizarFichero);
            this.Controls.Add(this.button_visualizarFichero);
            this.Controls.Add(this.button_modificarFichero);
            this.Controls.Add(this.textBox_directorioOFichero);
            this.Controls.Add(this.label_directorioOFichero);
            this.Controls.Add(this.groupBox_radioButtons);
            this.Controls.Add(this.button_eliminar);
            this.Controls.Add(this.button_renombrarMover);
            this.Controls.Add(this.button_crear);
            this.Controls.Add(this.button_listarFicheros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_ruta);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Proyecto de manipulación de ficheros y carpetas (Diego Méndez)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_radioButtons.ResumeLayout(false);
            this.groupBox_radioButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ruta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_listarFicheros;
        private System.Windows.Forms.Button button_crear;
        private System.Windows.Forms.Button button_renombrarMover;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.RadioButton radioButton_fichero;
        private System.Windows.Forms.RadioButton radioButton_carpeta;
        private System.Windows.Forms.GroupBox groupBox_radioButtons;
        private System.Windows.Forms.Label label_directorioOFichero;
        private System.Windows.Forms.TextBox textBox_directorioOFichero;
        private System.Windows.Forms.Button button_modificarFichero;
        private System.Windows.Forms.Button button_visualizarFichero;
        private System.Windows.Forms.TextBox textBox_VisualizarFichero;
        private System.Windows.Forms.ListBox listBox_listar;
    }
}

