namespace ClienteViews
{
    partial class ClienteView
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
            button1 = new Button();
            lbl_error = new Label();
            txt_identificacion = new TextBox();
            txt_nombre = new TextBox();
            txt_apellido_1 = new TextBox();
            txt_apellido_2 = new TextBox();
            dt_fecha_nacimiento = new DateTimePicker();
            label1 = new Label();
            cb_activo = new ComboBox();
            label2 = new Label();
            button2 = new Button();
            dgv_clientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_clientes).BeginInit();
            SuspendLayout();
            // 
            // label_titulo
            // 
            label_titulo.AutoSize = true;
            label_titulo.BackColor = SystemColors.ControlLight;
            label_titulo.BorderStyle = BorderStyle.Fixed3D;
            label_titulo.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label_titulo.Location = new Point(284, 9);
            label_titulo.Name = "label_titulo";
            label_titulo.Size = new Size(204, 67);
            label_titulo.TabIndex = 3;
            label_titulo.Text = "Clientes";
            label_titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(53, 28);
            button1.TabIndex = 9;
            button1.Text = "Volver ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbl_error
            // 
            lbl_error.AutoSize = true;
            lbl_error.ForeColor = Color.Red;
            lbl_error.Location = new Point(181, 83);
            lbl_error.Name = "lbl_error";
            lbl_error.Size = new Size(0, 15);
            lbl_error.TabIndex = 11;
            // 
            // txt_identificacion
            // 
            txt_identificacion.Location = new Point(40, 115);
            txt_identificacion.Name = "txt_identificacion";
            txt_identificacion.PlaceholderText = "Identificación";
            txt_identificacion.Size = new Size(115, 23);
            txt_identificacion.TabIndex = 12;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(172, 115);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.PlaceholderText = "Nombre";
            txt_nombre.Size = new Size(122, 23);
            txt_nombre.TabIndex = 13;
            // 
            // txt_apellido_1
            // 
            txt_apellido_1.Location = new Point(303, 113);
            txt_apellido_1.Name = "txt_apellido_1";
            txt_apellido_1.PlaceholderText = "Apellido 1";
            txt_apellido_1.Size = new Size(118, 23);
            txt_apellido_1.TabIndex = 14;
            // 
            // txt_apellido_2
            // 
            txt_apellido_2.Location = new Point(427, 113);
            txt_apellido_2.Name = "txt_apellido_2";
            txt_apellido_2.PlaceholderText = "Apellido 2";
            txt_apellido_2.Size = new Size(111, 23);
            txt_apellido_2.TabIndex = 15;
            // 
            // dt_fecha_nacimiento
            // 
            dt_fecha_nacimiento.Location = new Point(559, 115);
            dt_fecha_nacimiento.Name = "dt_fecha_nacimiento";
            dt_fecha_nacimiento.Size = new Size(200, 23);
            dt_fecha_nacimiento.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(558, 96);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 17;
            label1.Text = "Fecha Nacimiento:";
            // 
            // cb_activo
            // 
            cb_activo.FormattingEnabled = true;
            cb_activo.Items.AddRange(new object[] { "Activar", "Desactivar" });
            cb_activo.Location = new Point(40, 164);
            cb_activo.Name = "cb_activo";
            cb_activo.Size = new Size(121, 23);
            cb_activo.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 146);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 19;
            label2.Text = "Activar/desactivar:";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 192);
            button2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(192, 150);
            button2.Name = "button2";
            button2.Size = new Size(147, 37);
            button2.TabIndex = 20;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dgv_clientes
            // 
            dgv_clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_clientes.Location = new Point(41, 217);
            dgv_clientes.Name = "dgv_clientes";
            dgv_clientes.RowTemplate.Height = 25;
            dgv_clientes.Size = new Size(716, 221);
            dgv_clientes.TabIndex = 21;
            // 
            // ClienteView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv_clientes);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(cb_activo);
            Controls.Add(label1);
            Controls.Add(dt_fecha_nacimiento);
            Controls.Add(txt_apellido_2);
            Controls.Add(txt_apellido_1);
            Controls.Add(txt_nombre);
            Controls.Add(txt_identificacion);
            Controls.Add(lbl_error);
            Controls.Add(button1);
            Controls.Add(label_titulo);
            Name = "ClienteView";
            Text = "ClienteView";
            ((System.ComponentModel.ISupportInitialize)dgv_clientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_titulo;
        private Button button1;
        private Label lbl_error;
        private TextBox txt_identificacion;
        private TextBox txt_nombre;
        private TextBox txt_apellido_1;
        private TextBox txt_apellido_2;
        private DateTimePicker dt_fecha_nacimiento;
        private Label label1;
        private ComboBox cb_activo;
        private Label label2;
        private Button button2;
        private DataGridView dgv_clientes;
    }
}