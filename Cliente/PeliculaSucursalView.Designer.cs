namespace ClienteViews
{
    partial class PeliculaSucursalView
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
            lbl_error = new Label();
            button1 = new Button();
            label_titulo = new Label();
            cb_sucursales = new ComboBox();
            label1 = new Label();
            dgv_peliculas = new DataGridView();
            label2 = new Label();
            txt_cant = new TextBox();
            button2 = new Button();
            dgv_pelicula_sucursal = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_peliculas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_pelicula_sucursal).BeginInit();
            SuspendLayout();
            // 
            // lbl_error
            // 
            lbl_error.AutoSize = true;
            lbl_error.ForeColor = Color.Red;
            lbl_error.Location = new Point(174, 85);
            lbl_error.Name = "lbl_error";
            lbl_error.Size = new Size(0, 15);
            lbl_error.TabIndex = 22;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(20, 9);
            button1.Name = "button1";
            button1.Size = new Size(53, 28);
            button1.TabIndex = 21;
            button1.Text = "Volver ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label_titulo
            // 
            label_titulo.AutoSize = true;
            label_titulo.BackColor = SystemColors.ControlLight;
            label_titulo.BorderStyle = BorderStyle.Fixed3D;
            label_titulo.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label_titulo.Location = new Point(163, 9);
            label_titulo.Name = "label_titulo";
            label_titulo.Size = new Size(481, 67);
            label_titulo.TabIndex = 20;
            label_titulo.Text = "Película por Sucursal";
            label_titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cb_sucursales
            // 
            cb_sucursales.FormattingEnabled = true;
            cb_sucursales.Location = new Point(37, 121);
            cb_sucursales.Name = "cb_sucursales";
            cb_sucursales.Size = new Size(200, 23);
            cb_sucursales.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 111);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 24;
            label1.Text = "Sucursal:";
            // 
            // dgv_peliculas
            // 
            dgv_peliculas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_peliculas.Location = new Point(275, 121);
            dgv_peliculas.Name = "dgv_peliculas";
            dgv_peliculas.RowTemplate.Height = 25;
            dgv_peliculas.Size = new Size(166, 96);
            dgv_peliculas.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(284, 111);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 26;
            label2.Text = "Peliculas:";
            // 
            // txt_cant
            // 
            txt_cant.Location = new Point(472, 125);
            txt_cant.Name = "txt_cant";
            txt_cant.PlaceholderText = "Cantidad en Stock";
            txt_cant.Size = new Size(110, 23);
            txt_cant.TabIndex = 27;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 192);
            button2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(618, 121);
            button2.Name = "button2";
            button2.Size = new Size(147, 37);
            button2.TabIndex = 29;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dgv_pelicula_sucursal
            // 
            dgv_pelicula_sucursal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_pelicula_sucursal.Location = new Point(39, 243);
            dgv_pelicula_sucursal.Name = "dgv_pelicula_sucursal";
            dgv_pelicula_sucursal.RowTemplate.Height = 25;
            dgv_pelicula_sucursal.Size = new Size(722, 195);
            dgv_pelicula_sucursal.TabIndex = 30;
            // 
            // PeliculaSucursalView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv_pelicula_sucursal);
            Controls.Add(button2);
            Controls.Add(txt_cant);
            Controls.Add(label2);
            Controls.Add(dgv_peliculas);
            Controls.Add(label1);
            Controls.Add(cb_sucursales);
            Controls.Add(lbl_error);
            Controls.Add(button1);
            Controls.Add(label_titulo);
            Name = "PeliculaSucursalView";
            Text = "PeliculaSucursalView";
            ((System.ComponentModel.ISupportInitialize)dgv_peliculas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_pelicula_sucursal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_error;
        private Button button1;
        private Label label_titulo;
        private ComboBox cb_sucursales;
        private Label label1;
        private DataGridView dgv_peliculas;
        private Label label2;
        private TextBox txt_cant;
        private Button button2;
        private DataGridView dgv_pelicula_sucursal;
    }
}