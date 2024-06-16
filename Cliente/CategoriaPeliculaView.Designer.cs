using Negocios;

namespace Cliente
{
    partial class CategoriaPeliculaView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_titulo = new Label();
            txt_nombre = new TextBox();
            txt_descripcion = new TextBox();
            button_agregar_categoria = new Button();
            dataGridView1 = new DataGridView();
            lbl_error = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label_titulo
            // 
            label_titulo.AutoSize = true;
            label_titulo.BackColor = SystemColors.ControlLight;
            label_titulo.BorderStyle = BorderStyle.Fixed3D;
            label_titulo.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label_titulo.Location = new Point(181, 9);
            label_titulo.Name = "label_titulo";
            label_titulo.Size = new Size(422, 67);
            label_titulo.TabIndex = 1;
            label_titulo.Text = "Categoría Película";
            label_titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(50, 108);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.PlaceholderText = "Nombre Categoría";
            txt_nombre.Size = new Size(144, 23);
            txt_nombre.TabIndex = 2;
            // 
            // txt_descripcion
            // 
            txt_descripcion.Location = new Point(200, 108);
            txt_descripcion.Name = "txt_descripcion";
            txt_descripcion.PlaceholderText = "Descripción Categoría";
            txt_descripcion.Size = new Size(403, 23);
            txt_descripcion.TabIndex = 3;
            // 
            // button_agregar_categoria
            // 
            button_agregar_categoria.BackColor = Color.DarkSeaGreen;
            button_agregar_categoria.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_agregar_categoria.Location = new Point(624, 101);
            button_agregar_categoria.Name = "button_agregar_categoria";
            button_agregar_categoria.Size = new Size(112, 38);
            button_agregar_categoria.TabIndex = 4;
            button_agregar_categoria.Text = "Agregar";
            button_agregar_categoria.UseVisualStyleBackColor = false;
            button_agregar_categoria.Click += button_agregar_categoria_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(50, 171);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(686, 235);
            dataGridView1.TabIndex = 5;
            // 
            // lbl_error
            // 
            lbl_error.AutoSize = true;
            lbl_error.ForeColor = Color.Red;
            lbl_error.Location = new Point(324, 153);
            lbl_error.Name = "lbl_error";
            lbl_error.Size = new Size(0, 15);
            lbl_error.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(53, 28);
            button1.TabIndex = 7;
            button1.Text = "Volver ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CategoriaPeliculaView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(lbl_error);
            Controls.Add(dataGridView1);
            Controls.Add(button_agregar_categoria);
            Controls.Add(txt_descripcion);
            Controls.Add(txt_nombre);
            Controls.Add(label_titulo);
            Name = "CategoriaPeliculaView";
            Text = "CategoriaPelicula";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_titulo;
        private TextBox txt_nombre;
        private TextBox txt_descripcion;
        private Button button_agregar_categoria;
        private DataGridView dataGridView1;
        private Label lbl_error;
        private Button button1;
    }
}