namespace ClienteViews
{
    partial class PeliculaView
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
            components = new System.ComponentModel.Container();
            label_titulo = new Label();
            button1 = new Button();
            cb_categoria = new ComboBox();
            lbl_error = new Label();
            txt_titulo = new TextBox();
            txt_dioma = new TextBox();
            button2 = new Button();
            dgv_peliculas = new DataGridView();
            peliculaNegociosBindingSource = new BindingSource(components);
            txt_lanzamiento = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_peliculas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)peliculaNegociosBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label_titulo
            // 
            label_titulo.AutoSize = true;
            label_titulo.BackColor = SystemColors.ControlLight;
            label_titulo.BorderStyle = BorderStyle.Fixed3D;
            label_titulo.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label_titulo.Location = new Point(290, 9);
            label_titulo.Name = "label_titulo";
            label_titulo.Size = new Size(218, 67);
            label_titulo.TabIndex = 2;
            label_titulo.Text = "Películas";
            label_titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(53, 28);
            button1.TabIndex = 8;
            button1.Text = "Volver ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cb_categoria
            // 
            cb_categoria.FormattingEnabled = true;
            cb_categoria.Location = new Point(46, 131);
            cb_categoria.Name = "cb_categoria";
            cb_categoria.Size = new Size(121, 23);
            cb_categoria.TabIndex = 9;
            // 
            // lbl_error
            // 
            lbl_error.AutoSize = true;
            lbl_error.ForeColor = Color.Red;
            lbl_error.Location = new Point(238, 91);
            lbl_error.Name = "lbl_error";
            lbl_error.Size = new Size(0, 15);
            lbl_error.TabIndex = 10;
            // 
            // txt_titulo
            // 
            txt_titulo.Location = new Point(191, 131);
            txt_titulo.Name = "txt_titulo";
            txt_titulo.PlaceholderText = "Título";
            txt_titulo.Size = new Size(100, 23);
            txt_titulo.TabIndex = 11;
            // 
            // txt_dioma
            // 
            txt_dioma.Location = new Point(454, 130);
            txt_dioma.Name = "txt_dioma";
            txt_dioma.PlaceholderText = "Idioma";
            txt_dioma.Size = new Size(100, 23);
            txt_dioma.TabIndex = 14;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 192);
            button2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(581, 118);
            button2.Name = "button2";
            button2.Size = new Size(147, 37);
            button2.TabIndex = 15;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dgv_peliculas
            // 
            dgv_peliculas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_peliculas.Location = new Point(22, 173);
            dgv_peliculas.Name = "dgv_peliculas";
            dgv_peliculas.RowTemplate.Height = 25;
            dgv_peliculas.Size = new Size(706, 265);
            dgv_peliculas.TabIndex = 16;
            // 
            // peliculaNegociosBindingSource
            // 
            peliculaNegociosBindingSource.DataSource = typeof(Negocios.PeliculaNegocios);
            // 
            // txt_lanzamiento
            // 
            txt_lanzamiento.Location = new Point(306, 131);
            txt_lanzamiento.Name = "txt_lanzamiento";
            txt_lanzamiento.PlaceholderText = "Fecha de Lanzamiento";
            txt_lanzamiento.Size = new Size(127, 23);
            txt_lanzamiento.TabIndex = 17;
            // 
            // PeliculaView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_lanzamiento);
            Controls.Add(dgv_peliculas);
            Controls.Add(button2);
            Controls.Add(txt_dioma);
            Controls.Add(txt_titulo);
            Controls.Add(lbl_error);
            Controls.Add(cb_categoria);
            Controls.Add(button1);
            Controls.Add(label_titulo);
            Name = "PeliculaView";
            Text = "PeliculaView";
            ((System.ComponentModel.ISupportInitialize)dgv_peliculas).EndInit();
            ((System.ComponentModel.ISupportInitialize)peliculaNegociosBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_titulo;
        private Button button1;
        private ComboBox cb_categoria;
        private Label lbl_error;
        private TextBox txt_titulo;
        private TextBox txt_dioma;
        private Button button2;
        private DataGridView dgv_peliculas;
        private BindingSource peliculaNegociosBindingSource;
        private TextBox txt_lanzamiento;
    }
}