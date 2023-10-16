using SistemaGestionBussiness;
using SistemaGestionEntities;
using SistemaGestionData;



namespace SistemaGestionEF
{
    public partial class FormPrincipal : Form
    {
#pragma warning disable CS0169 // El campo 'Form1.dbContext' nunca se usa
        private SistemaGestionContext dbContext;
#pragma warning restore CS0169 // El campo 'Form1.dbContext' nunca se usa
#pragma warning disable CS0169 // El campo 'Form1.usuarioData' nunca se usa
        private UsuarioData usuarioData;
#pragma warning restore CS0169 // El campo 'Form1.usuarioData' nunca se usa


#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public FormPrincipal()
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        {
            InitializeComponent();


        }

        // ----------------------------------------------- // Form Load de las 4 clases para que cuando abra me levante toda la info de lo registrado 

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Producto> productos = ProductoBussiness.GetProductos();
            dgProductos.AutoGenerateColumns = true;
            dgProductos.DataSource = productos;

            List<ProductoVendido> productoVendidos = ProductoVendidoBussiness.ListarProductoVendido();
            dgProductosVendidos.AutoGenerateColumns = true;
            dgProductosVendidos.DataSource = productoVendidos;

            List<Usuario> usuarios = UsuarioBussiness.ListarUsuario();
            dgUsuarios.AutoGenerateColumns = true;
            dgUsuarios.DataSource = usuarios;

            List<Venta> ventas = VentaBussiness.ListarVentaData();
            dgVenta.AutoGenerateColumns = true;
            dgVenta.DataSource = ventas;
        }


        //  --------------------------------------------------------------------------- // Agregar datos a la bd cuando haga click en agregar 
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Obtener los valores ingresados en los campos txt que le damos el nombre mas comprensible posible
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string nombreUsuario = txtNombreUsuario.Text;
            string contraseña = txtContraseña.Text;
            string mail = txtMail.Text;

            // Crear una instancia de Usuario con los valores ingresados 
            Usuario nuevoUsuario = new Usuario
            {
                Nombre = nombre,
                Apellido = apellido,
                NombreUsuario = nombreUsuario,
                Contraseña = contraseña,
                Mail = mail
            };

            // Llamar al método CrearUsuario para agregar el nuevo usuario 
            UsuarioBussiness.CrearUsuario(nuevoUsuario);

            // por ultimo limpiamos los campos
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtNombreUsuario.Text = "";
            txtContraseña.Text = "";
            txtMail.Text = "";

            // Actualizar la lista de usuarios para que muestre la grid
            ActualizarListaDeUsuarios();
        }

        // definimos un metodo para actualizar la lista de datos al terminar de cargar
        private void ActualizarListaDeUsuarios()
        {
            // Llamar al método para obtener la lista de usuarios y mostrarla en el datagrid
            List<Usuario> listaUsuarios = UsuarioBussiness.ListarUsuario();
            dgUsuarios.DataSource = listaUsuarios;
        }

        //-----------------------------------------------------------------------  boton para limpiar los campos  boton cancelar.... !


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCamposTexto();
        }

        //- ---------------------------------------------------------------  boton Elimianar ! 
        private void button2_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView
            if (dgUsuarios.SelectedRows.Count > 0)
            {
                // Obtener el ID del usuario seleccionado
                int usuarioId = Convert.ToInt32(dgUsuarios.SelectedRows[0].Cells["Id"].Value);

                // Mostrar un cuadro de diálogo de confirmación
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este usuario?", "Confirmación de eliminación", MessageBoxButtons.YesNo);

                // Verificar la respuesta del usuario
                if (resultado == DialogResult.Yes)
                {
                    // El usuario confirmó la eliminación, llama al método de la capa de negocios para eliminar el usuario
                    UsuarioBussiness.EliminarUsuario(usuarioId);

                    // Actualizar el DataGridView
                    ActualizarListaDeUsuarios(); // llama al método para actualizar la lista de usuarios en el DataGridView
                }
            }
            else
            {
                MessageBox.Show("Selecciona un usuario para eliminar.");
            }
        }
        // ---------------------------------------------------------- MODIFICAR USUARIO ----------------------------- 
        private void button3_Click(object sender, EventArgs e)
        {
            
        }



        //--------------------------------------------------------------------------------------------------------------------------



        //metodo para limpiar los campos txt
        private void LimpiarCamposTexto()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtNombreUsuario.Text = "";
            txtContraseña.Text = "";
            txtMail.Text = "";
        }


        // ---------------------------------------------------------------------  filtramos por id ! 
        private void button4_Click(object sender, EventArgs e)
        {
            // Obtener el criterio de búsqueda desde el txtFiltro
            string criterio = txtFiltro.Text;

            List<Usuario> usuarios;

            if (int.TryParse(criterio, out int usuarioId))
            {
                // Llamar al método de la capa de negocios para buscar al usuario por su ID
                Usuario usuarioSeleccionado = UsuarioBussiness.ObtenerUsuario(usuarioId);

                if (usuarioSeleccionado != null)
                {
                    List<Usuario> usuariosFiltrados = new List<Usuario>();
                    usuariosFiltrados.Add(usuarioSeleccionado);
                    usuarios = usuariosFiltrados;
                }
                else
                {
                    MessageBox.Show("No se encontró ningún usuario con el ID especificado.");
                    usuarios = new List<Usuario>(); // Lista vacía si no se encuentra un usuario
                }
            }
            else
            {
                MessageBox.Show("El criterio de búsqueda debe ser un número (ID).");
                usuarios = UsuarioBussiness.ListarUsuario(); // Lista completa de usuarios
            }

            dgUsuarios.DataSource = usuarios;
        }

    }
}






