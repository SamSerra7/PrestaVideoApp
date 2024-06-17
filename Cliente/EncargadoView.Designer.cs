namespace ClienteViews
{
    partial class EncargadoView
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
            label1 = new Label();
            dt_fecha_nacimiento = new DateTimePicker();
            txt_apellido_2 = new TextBox();
            txt_apellido_1 = new TextBox();
            txt_nombre = new TextBox();
            txt_identificacion = new TextBox();
            lbl_error = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            dgv_encargados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_encargados).BeginInit();
            SuspendLayout();
            // 
            // label_titulo
            // 
            label_titulo.AutoSize = true;
            label_titulo.BackColor = SystemColors.ControlLight;
            label_titulo.BorderStyle = BorderStyle.Fixed3D;
            label_titulo.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label_titulo.Location = new Point(252, 9);
            label_titulo.Name = "label_titulo";
            label_titulo.Size = new Size(282, 67);
            label_titulo.TabIndex = 4;
            label_titulo.Text = "Encargados";
            label_titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 9);
            button1.Name = "button1";
            button1.Size = new Size(53, 28);
            button1.TabIndex = 10;
            button1.Text = "Volver ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(556, 107);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 24;
            label1.Text = "Fecha Nacimiento:";
            // 
            // dt_fecha_nacimiento
            // 
            dt_fecha_nacimiento.Location = new Point(557, 126);
            dt_fecha_nacimiento.Name = "dt_fecha_nacimiento";
            dt_fecha_nacimiento.Size = new Size(200, 23);
            dt_fecha_nacimiento.TabIndex = 23;
            // 
            // txt_apellido_2
            // 
            txt_apellido_2.Location = new Point(425, 124);
            txt_apellido_2.Name = "txt_apellido_2";
            txt_apellido_2.PlaceholderText = "Apellido 2";
            txt_apellido_2.Size = new Size(111, 23);
            txt_apellido_2.TabIndex = 22;
            // 
            // txt_apellido_1
            // 
            txt_apellido_1.Location = new Point(301, 124);
            txt_apellido_1.Name = "txt_apellido_1";
            txt_apellido_1.PlaceholderText = "Apellido 1";
            txt_apellido_1.Size = new Size(118, 23);
            txt_apellido_1.TabIndex = 21;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(170, 126);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.PlaceholderText = "Nombre";
            txt_nombre.Size = new Size(122, 23);
            txt_nombre.TabIndex = 20;
            // 
            // txt_identificacion
            // 
            txt_identificacion.Location = new Point(38, 126);
            txt_identificacion.Name = "txt_identificacion";
            txt_identificacion.PlaceholderText = "Identificación";
            txt_identificacion.Size = new Size(115, 23);
            txt_identificacion.TabIndex = 19;
            // 
            // lbl_error
            // 
            lbl_error.AutoSize = true;
            lbl_error.ForeColor = Color.Red;
            lbl_error.Location = new Point(179, 94);
            lbl_error.Name = "lbl_error";
            lbl_error.Size = new Size(0, 15);
            lbl_error.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 161);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 25;
            label2.Text = "Fecha Ingreso:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(38, 181);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(194, 23);
            dateTimePicker1.TabIndex = 26;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 192);
            button2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(272, 167);
            button2.Name = "button2";
            button2.Size = new Size(147, 37);
            button2.TabIndex = 27;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dgv_encargados
            // 
            dgv_encargados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_encargados.Location = new Point(38, 223);
            dgv_encargados.Name = "dgv_encargados";
            dgv_encargados.RowTemplate.Height = 25;
            dgv_encargados.Size = new Size(719, 215);
            dgv_encargados.TabIndex = 28;
            // 
            // EncargadoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv_encargados);
            Controls.Add(button2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dt_fecha_nacimiento);
            Controls.Add(txt_apellido_2);
            Controls.Add(txt_apellido_1);
            Controls.Add(txt_nombre);
            Controls.Add(txt_identificacion);
            Controls.Add(lbl_error);
            Controls.Add(button1);
            Controls.Add(label_titulo);
            Name = "EncargadoView";
            Text = "EncargadoView";
            ((System.ComponentModel.ISupportInitialize)dgv_encargados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_titulo;
        private Button button1;
        private Label label1;
        private DateTimePicker dt_fecha_nacimiento;
        private TextBox txt_apellido_2;
        private TextBox txt_apellido_1;
        private TextBox txt_nombre;
        private TextBox txt_identificacion;
        private Label lbl_error;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Button button2;
        private DataGridView dgv_encargados;
    }
}