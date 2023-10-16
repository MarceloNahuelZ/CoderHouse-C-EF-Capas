namespace SistemaGestionEF
{
    partial class FormPrincipal
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
            components = new System.ComponentModel.Container();
            Label lblApellido;
            Users = new TabControl();
            tabPage3 = new TabPage();
            label2 = new Label();
            label1 = new Label();
            txtMail = new TextBox();
            txtContraseña = new TextBox();
            txtNombreUsuario = new TextBox();
            txtApellido = new TextBox();
            label5 = new Label();
            label4 = new Label();
            lblNombreUsuario = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            txtFiltro = new TextBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            btnAgregar = new Button();
            dgUsuarios = new DataGridView();
            tabPage1 = new TabPage();
            dgProductos = new DataGridView();
            productoBussinessBindingSource1 = new BindingSource(components);
            tabPage2 = new TabPage();
            dgProductosVendidos = new DataGridView();
            productoVendidoBussinessBindingSource = new BindingSource(components);
            tabPage4 = new TabPage();
            dgVenta = new DataGridView();
            ventaBussinessBindingSource = new BindingSource(components);
            productoBindingSource1 = new BindingSource(components);
            productoBindingSource = new BindingSource(components);
            productoBussinessBindingSource = new BindingSource(components);
            usuarioBussinessBindingSource = new BindingSource(components);
            lblApellido = new Label();
            Users.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoBussinessBindingSource1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgProductosVendidos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoVendidoBussinessBindingSource).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ventaBussinessBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoBussinessBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBussinessBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(18, 140);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(64, 17);
            lblApellido.TabIndex = 9;
            lblApellido.Text = "Apellido: ";
            // 
            // Users
            // 
            Users.Controls.Add(tabPage3);
            Users.Controls.Add(tabPage1);
            Users.Controls.Add(tabPage2);
            Users.Controls.Add(tabPage4);
            Users.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Users.Location = new Point(12, 12);
            Users.Multiline = true;
            Users.Name = "Users";
            Users.SelectedIndex = 0;
            Users.Size = new Size(969, 444);
            Users.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.Yellow;
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(txtMail);
            tabPage3.Controls.Add(txtContraseña);
            tabPage3.Controls.Add(txtNombreUsuario);
            tabPage3.Controls.Add(txtApellido);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(lblNombreUsuario);
            tabPage3.Controls.Add(lblApellido);
            tabPage3.Controls.Add(lblNombre);
            tabPage3.Controls.Add(txtNombre);
            tabPage3.Controls.Add(txtFiltro);
            tabPage3.Controls.Add(button5);
            tabPage3.Controls.Add(button4);
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(btnAgregar);
            tabPage3.Controls.Add(dgUsuarios);
            tabPage3.Location = new Point(4, 26);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(961, 414);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Usuarios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 57);
            label2.Name = "label2";
            label2.Size = new Size(94, 17);
            label2.TabIndex = 18;
            label2.Text = "CODERHOUSE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 40);
            label1.Name = "label1";
            label1.Size = new Size(128, 17);
            label1.TabIndex = 17;
            label1.Text = "Sistema De Gestion ";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(88, 247);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(154, 25);
            txtMail.TabIndex = 16;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(88, 210);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(154, 25);
            txtContraseña.TabIndex = 15;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(88, 172);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(154, 25);
            txtNombreUsuario.TabIndex = 14;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(88, 132);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(154, 25);
            txtApellido.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 255);
            label5.Name = "label5";
            label5.Size = new Size(49, 17);
            label5.TabIndex = 12;
            label5.Text = "E-mail:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 218);
            label4.Name = "label4";
            label4.Size = new Size(78, 17);
            label4.TabIndex = 11;
            label4.Text = "Contraseña:";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(26, 180);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(56, 17);
            lblNombreUsuario.TabIndex = 10;
            lblNombreUsuario.Text = "Usuario:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(24, 101);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(58, 17);
            lblNombre.TabIndex = 8;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(88, 93);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(154, 25);
            txtNombre.TabIndex = 7;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(358, 15);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(297, 25);
            txtFiltro.TabIndex = 6;
            // 
            // button5
            // 
            button5.Location = new Point(167, 327);
            button5.Name = "button5";
            button5.Size = new Size(75, 31);
            button5.TabIndex = 5;
            button5.Text = "Cancelar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btnCancelar_Click;
            // 
            // button4
            // 
            button4.Location = new Point(277, 11);
            button4.Name = "button4";
            button4.Size = new Size(75, 31);
            button4.TabIndex = 4;
            button4.Text = "Filtrar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(794, 11);
            button3.Name = "button3";
            button3.Size = new Size(75, 31);
            button3.TabIndex = 3;
            button3.Text = "Modificar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(661, 11);
            button2.Name = "button2";
            button2.Size = new Size(75, 31);
            button2.TabIndex = 2;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(33, 327);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 31);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgUsuarios
            // 
            dgUsuarios.BackgroundColor = SystemColors.ActiveCaptionText;
            dgUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUsuarios.Location = new Point(277, 57);
            dgUsuarios.Name = "dgUsuarios";
            dgUsuarios.RowTemplate.Height = 25;
            dgUsuarios.Size = new Size(646, 329);
            dgUsuarios.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.LightSteelBlue;
            tabPage1.Controls.Add(dgProductos);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(961, 414);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Productos";
            // 
            // dgProductos
            // 
            dgProductos.AutoGenerateColumns = false;
            dgProductos.BackgroundColor = SystemColors.ButtonFace;
            dgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductos.DataSource = productoBussinessBindingSource1;
            dgProductos.Location = new Point(279, 20);
            dgProductos.Name = "dgProductos";
            dgProductos.RowTemplate.Height = 25;
            dgProductos.Size = new Size(659, 376);
            dgProductos.TabIndex = 0;
            // 
            // productoBussinessBindingSource1
            // 
            productoBussinessBindingSource1.DataSource = typeof(SistemaGestionBussiness.ProductoBussiness);
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.LightSteelBlue;
            tabPage2.Controls.Add(dgProductosVendidos);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(961, 414);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "ProductoVendido";
            // 
            // dgProductosVendidos
            // 
            dgProductosVendidos.AutoGenerateColumns = false;
            dgProductosVendidos.BackgroundColor = SystemColors.ButtonFace;
            dgProductosVendidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductosVendidos.DataSource = productoVendidoBussinessBindingSource;
            dgProductosVendidos.Location = new Point(354, 13);
            dgProductosVendidos.Name = "dgProductosVendidos";
            dgProductosVendidos.RowTemplate.Height = 25;
            dgProductosVendidos.Size = new Size(587, 385);
            dgProductosVendidos.TabIndex = 0;
            // 
            // productoVendidoBussinessBindingSource
            // 
            productoVendidoBussinessBindingSource.DataSource = typeof(SistemaGestionBussiness.ProductoVendidoBussiness);
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.LightSteelBlue;
            tabPage4.Controls.Add(dgVenta);
            tabPage4.Location = new Point(4, 26);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(961, 414);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Ventas";
            // 
            // dgVenta
            // 
            dgVenta.AutoGenerateColumns = false;
            dgVenta.BackgroundColor = SystemColors.ButtonFace;
            dgVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgVenta.DataSource = ventaBussinessBindingSource;
            dgVenta.Location = new Point(351, 18);
            dgVenta.Name = "dgVenta";
            dgVenta.RowTemplate.Height = 25;
            dgVenta.Size = new Size(594, 379);
            dgVenta.TabIndex = 0;
            // 
            // ventaBussinessBindingSource
            // 
            ventaBussinessBindingSource.DataSource = typeof(SistemaGestionBussiness.VentaBussiness);
            // 
            // productoBindingSource1
            // 
            productoBindingSource1.DataSource = typeof(SistemaGestionEntities.Producto);
            // 
            // productoBindingSource
            // 
            productoBindingSource.DataSource = typeof(SistemaGestionEntities.Producto);
            // 
            // productoBussinessBindingSource
            // 
            productoBussinessBindingSource.DataSource = typeof(SistemaGestionBussiness.ProductoBussiness);
            // 
            // usuarioBussinessBindingSource
            // 
            usuarioBussinessBindingSource.DataSource = typeof(SistemaGestionBussiness.UsuarioBussiness);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1000, 476);
            Controls.Add(Users);
            Name = "Form1";
            Text = "Sistema Gestion EF";
            Load += Form1_Load;
            Users.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).EndInit();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)productoBussinessBindingSource1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgProductosVendidos).EndInit();
            ((System.ComponentModel.ISupportInitialize)productoVendidoBussinessBindingSource).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)ventaBussinessBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productoBussinessBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBussinessBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Users;
        private TabPage tabPage1;
        private DataGridView dgProductos;
        private TabPage tabPage2;
        private BindingSource usuarioBussinessBindingSource;
        private BindingSource productoBussinessBindingSource;
        private BindingSource productoBindingSource;
        private BindingSource productoBindingSource1;
        private BindingSource productoBussinessBindingSource1;
        private DataGridView dgProductosVendidos;
        private BindingSource productoVendidoBussinessBindingSource;
        private TabPage tabPage3;
        private DataGridView dgUsuarios;
        private TabPage tabPage4;
        private DataGridView dgVenta;
        private BindingSource ventaBussinessBindingSource;
        private TextBox txtFiltro;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button btnAgregar;
        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label label5;
        private Label label4;
        private Label lblNombreUsuario;
#pragma warning disable CS0169 // El campo 'Form1.lblApellido' nunca se usa
        private Label lblApellido;
#pragma warning restore CS0169 // El campo 'Form1.lblApellido' nunca se usa
        private TextBox txtMail;
        private TextBox txtContraseña;
        private TextBox txtNombreUsuario;
        private Label label1;
        private Label label2;
    }
}