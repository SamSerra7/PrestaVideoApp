namespace Cliente
{
    partial class PantallaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_titulo = new Label();
            label1 = new Label();
            btn_categoria_pelicula = new Button();
            btn_pelicula = new Button();
            btn_encargado = new Button();
            btn_sucursal = new Button();
            btn_cliente = new Button();
            btn_pelicula_sucursal = new Button();
            SuspendLayout();
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.BackColor = SystemColors.ControlLight;
            lbl_titulo.BorderStyle = BorderStyle.Fixed3D;
            lbl_titulo.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_titulo.Location = new Point(230, 9);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(343, 197);
            lbl_titulo.TabIndex = 0;
            lbl_titulo.Text = "Préstamo \r\nde \r\nAudiovisuales";
            lbl_titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(230, 221);
            label1.Name = "label1";
            label1.Size = new Size(349, 20);
            label1.TabIndex = 1;
            label1.Text = "Presiona cualquier botón para realizar una acción";
            // 
            // btn_categoria_pelicula
            // 
            btn_categoria_pelicula.BackColor = SystemColors.ActiveCaption;
            btn_categoria_pelicula.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_categoria_pelicula.ForeColor = SystemColors.Info;
            btn_categoria_pelicula.Location = new Point(12, 270);
            btn_categoria_pelicula.Name = "btn_categoria_pelicula";
            btn_categoria_pelicula.Size = new Size(126, 61);
            btn_categoria_pelicula.TabIndex = 2;
            btn_categoria_pelicula.Text = "Categoría\r\nPelícula";
            btn_categoria_pelicula.UseVisualStyleBackColor = false;
            btn_categoria_pelicula.Click += btn_categoria_pelicula_Click;
            // 
            // btn_pelicula
            // 
            btn_pelicula.BackColor = SystemColors.ActiveCaption;
            btn_pelicula.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_pelicula.ForeColor = SystemColors.Info;
            btn_pelicula.Location = new Point(144, 270);
            btn_pelicula.Name = "btn_pelicula";
            btn_pelicula.Size = new Size(126, 61);
            btn_pelicula.TabIndex = 3;
            btn_pelicula.Text = "Película";
            btn_pelicula.UseVisualStyleBackColor = false;
            // 
            // btn_encargado
            // 
            btn_encargado.BackColor = SystemColors.ActiveCaption;
            btn_encargado.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_encargado.ForeColor = SystemColors.Info;
            btn_encargado.Location = new Point(276, 270);
            btn_encargado.Name = "btn_encargado";
            btn_encargado.Size = new Size(126, 61);
            btn_encargado.TabIndex = 4;
            btn_encargado.Text = "Encargado";
            btn_encargado.UseVisualStyleBackColor = false;
            // 
            // btn_sucursal
            // 
            btn_sucursal.BackColor = SystemColors.ActiveCaption;
            btn_sucursal.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_sucursal.ForeColor = SystemColors.Info;
            btn_sucursal.Location = new Point(408, 270);
            btn_sucursal.Name = "btn_sucursal";
            btn_sucursal.Size = new Size(126, 61);
            btn_sucursal.TabIndex = 5;
            btn_sucursal.Text = "Sucursal";
            btn_sucursal.UseVisualStyleBackColor = false;
            // 
            // btn_cliente
            // 
            btn_cliente.BackColor = SystemColors.ActiveCaption;
            btn_cliente.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cliente.ForeColor = SystemColors.Info;
            btn_cliente.Location = new Point(540, 270);
            btn_cliente.Name = "btn_cliente";
            btn_cliente.Size = new Size(126, 61);
            btn_cliente.TabIndex = 6;
            btn_cliente.Text = "Cliente";
            btn_cliente.UseVisualStyleBackColor = false;
            // 
            // btn_pelicula_sucursal
            // 
            btn_pelicula_sucursal.BackColor = SystemColors.ActiveCaption;
            btn_pelicula_sucursal.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_pelicula_sucursal.ForeColor = SystemColors.Info;
            btn_pelicula_sucursal.Location = new Point(672, 270);
            btn_pelicula_sucursal.Name = "btn_pelicula_sucursal";
            btn_pelicula_sucursal.Size = new Size(126, 61);
            btn_pelicula_sucursal.TabIndex = 7;
            btn_pelicula_sucursal.Text = "Pelicula por Sucursal";
            btn_pelicula_sucursal.UseVisualStyleBackColor = false;
            // 
            // PantallaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 451);
            Controls.Add(btn_pelicula_sucursal);
            Controls.Add(btn_cliente);
            Controls.Add(btn_sucursal);
            Controls.Add(btn_encargado);
            Controls.Add(btn_pelicula);
            Controls.Add(btn_categoria_pelicula);
            Controls.Add(label1);
            Controls.Add(lbl_titulo);
            Name = "PantallaPrincipal";
            Text = "Aplicación para el prestamo de Audiovisuales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_titulo;
        private Label label1;
        private Button btn_categoria_pelicula;
        private Button btn_pelicula;
        private Button btn_encargado;
        private Button btn_sucursal;
        private Button btn_cliente;
        private Button btn_pelicula_sucursal;
    }
}