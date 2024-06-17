namespace ClienteViews
{
    partial class SucursalView
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
            lbl_error = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            txt_nombre = new TextBox();
            cb_encargados = new ComboBox();
            cb_activo = new ComboBox();
            txt_dir = new TextBox();
            txt_tel = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            dgv_sucursales = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_sucursales).BeginInit();
            SuspendLayout();
            // 
            // label_titulo
            // 
            label_titulo.AutoSize = true;
            label_titulo.BackColor = SystemColors.ControlLight;
            label_titulo.BorderStyle = BorderStyle.Fixed3D;
            label_titulo.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label_titulo.Location = new Point(276, 9);
            label_titulo.Name = "label_titulo";
            label_titulo.Size = new Size(259, 67);
            label_titulo.TabIndex = 5;
            label_titulo.Text = "Sucursales";
            label_titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 9);
            button1.Name = "button1";
            button1.Size = new Size(53, 28);
            button1.TabIndex = 11;
            button1.Text = "Volver ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbl_error
            // 
            lbl_error.AutoSize = true;
            lbl_error.ForeColor = Color.Red;
            lbl_error.Location = new Point(210, 83);
            lbl_error.Name = "lbl_error";
            lbl_error.Size = new Size(0, 15);
            lbl_error.TabIndex = 19;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(55, 112);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.PlaceholderText = "Nombre";
            txt_nombre.Size = new Size(122, 23);
            txt_nombre.TabIndex = 21;
            // 
            // cb_encargados
            // 
            cb_encargados.FormattingEnabled = true;
            cb_encargados.Location = new Point(183, 112);
            cb_encargados.Name = "cb_encargados";
            cb_encargados.Size = new Size(121, 23);
            cb_encargados.TabIndex = 22;
            // 
            // cb_activo
            // 
            cb_activo.FormattingEnabled = true;
            cb_activo.Items.AddRange(new object[] { "Si", "No" });
            cb_activo.Location = new Point(565, 112);
            cb_activo.Name = "cb_activo";
            cb_activo.Size = new Size(104, 23);
            cb_activo.TabIndex = 23;
            // 
            // txt_dir
            // 
            txt_dir.Location = new Point(310, 112);
            txt_dir.Name = "txt_dir";
            txt_dir.PlaceholderText = "Dirección";
            txt_dir.Size = new Size(128, 23);
            txt_dir.TabIndex = 24;
            // 
            // txt_tel
            // 
            txt_tel.Location = new Point(453, 112);
            txt_tel.Name = "txt_tel";
            txt_tel.PlaceholderText = "Teléfono";
            txt_tel.Size = new Size(104, 23);
            txt_tel.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 98);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 26;
            label1.Text = "Encargado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(572, 99);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 27;
            label2.Text = "Activo";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 192);
            button2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(55, 141);
            button2.Name = "button2";
            button2.Size = new Size(147, 37);
            button2.TabIndex = 28;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dgv_sucursales
            // 
            dgv_sucursales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_sucursales.Location = new Point(43, 184);
            dgv_sucursales.Name = "dgv_sucursales";
            dgv_sucursales.RowTemplate.Height = 25;
            dgv_sucursales.Size = new Size(671, 246);
            dgv_sucursales.TabIndex = 29;
            // 
            // SucursalView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv_sucursales);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_tel);
            Controls.Add(txt_dir);
            Controls.Add(cb_activo);
            Controls.Add(cb_encargados);
            Controls.Add(txt_nombre);
            Controls.Add(lbl_error);
            Controls.Add(button1);
            Controls.Add(label_titulo);
            Name = "SucursalView";
            Text = "SucursalView";
            ((System.ComponentModel.ISupportInitialize)dgv_sucursales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_titulo;
        private Button button1;
        private Label lbl_error;
        private System.Windows.Forms.Timer timer1;
        private TextBox txt_nombre;
        private ComboBox cb_encargados;
        private ComboBox cb_activo;
        private TextBox txt_dir;
        private TextBox txt_tel;
        private Label label1;
        private Label label2;
        private Button button2;
        private DataGridView dgv_sucursales;
    }
}