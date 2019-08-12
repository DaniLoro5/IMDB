<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pestañasPrincipal = New System.Windows.Forms.TabControl()
        Me.pestañaPersonas = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rutaImagenPersona = New System.Windows.Forms.TextBox()
        Me.botonImagenPersona = New System.Windows.Forms.Button()
        Me.imagenPersona = New System.Windows.Forms.PictureBox()
        Me.textoPais = New System.Windows.Forms.Label()
        Me.textoCiudad = New System.Windows.Forms.Label()
        Me.textoFecha = New System.Windows.Forms.Label()
        Me.textoNacionalidad = New System.Windows.Forms.Label()
        Me.textoApellido = New System.Windows.Forms.Label()
        Me.textoNombre = New System.Windows.Forms.Label()
        Me.mostrarPais = New System.Windows.Forms.TextBox()
        Me.mostrarCiudad = New System.Windows.Forms.TextBox()
        Me.mostrarFecha = New System.Windows.Forms.TextBox()
        Me.mostrarNacionalidad = New System.Windows.Forms.TextBox()
        Me.mostrarApellido = New System.Windows.Forms.TextBox()
        Me.mostrarNombre = New System.Windows.Forms.TextBox()
        Me.listaPersonas = New System.Windows.Forms.ListBox()
        Me.limpiarPersonas = New System.Windows.Forms.Button()
        Me.eliminarPersona = New System.Windows.Forms.Button()
        Me.modificarPersona = New System.Windows.Forms.Button()
        Me.añadirPersona = New System.Windows.Forms.Button()
        Me.pestañaPelículas = New System.Windows.Forms.TabPage()
        Me.imagenPelicula = New System.Windows.Forms.PictureBox()
        Me.rutaImagenPelicula = New System.Windows.Forms.TextBox()
        Me.botonImagenPelicula = New System.Windows.Forms.Button()
        Me.textoSinopsis = New System.Windows.Forms.Label()
        Me.textoDuración = New System.Windows.Forms.Label()
        Me.textoAño = New System.Windows.Forms.Label()
        Me.textoTituloOriginal = New System.Windows.Forms.Label()
        Me.textoTitulo = New System.Windows.Forms.Label()
        Me.mostrarSinopsis = New System.Windows.Forms.TextBox()
        Me.mostrarDuración = New System.Windows.Forms.TextBox()
        Me.mostrarAño = New System.Windows.Forms.TextBox()
        Me.mostrarTituloOriginal = New System.Windows.Forms.TextBox()
        Me.mostrarTitulo = New System.Windows.Forms.TextBox()
        Me.listaPeliculas = New System.Windows.Forms.ListBox()
        Me.limpiarPeliculas = New System.Windows.Forms.Button()
        Me.eliminarPelicula = New System.Windows.Forms.Button()
        Me.modificarPelicula = New System.Windows.Forms.Button()
        Me.añadirPelicula = New System.Windows.Forms.Button()
        Me.pestañaRoles = New System.Windows.Forms.TabPage()
        Me.textoDescrRol = New System.Windows.Forms.Label()
        Me.mostrarDescrRol = New System.Windows.Forms.TextBox()
        Me.listaRoles = New System.Windows.Forms.ListBox()
        Me.limpiarRoles = New System.Windows.Forms.Button()
        Me.eliminarRol = New System.Windows.Forms.Button()
        Me.modificarRol = New System.Windows.Forms.Button()
        Me.añadirRol = New System.Windows.Forms.Button()
        Me.pestañaGeneros = New System.Windows.Forms.TabPage()
        Me.textoDescrGenero = New System.Windows.Forms.Label()
        Me.mostrarDescrGenero = New System.Windows.Forms.TextBox()
        Me.listaGeneros = New System.Windows.Forms.ListBox()
        Me.limpiarGeneros = New System.Windows.Forms.Button()
        Me.eliminarGenero = New System.Windows.Forms.Button()
        Me.modificarGenero = New System.Windows.Forms.Button()
        Me.añadirGenero = New System.Windows.Forms.Button()
        Me.pestañaParticipantes = New System.Windows.Forms.TabPage()
        Me.eliminarParticipante = New System.Windows.Forms.Button()
        Me.textoRol = New System.Windows.Forms.Label()
        Me.textoPelícula = New System.Windows.Forms.Label()
        Me.textoActor = New System.Windows.Forms.Label()
        Me.seleccionarRol = New System.Windows.Forms.ComboBox()
        Me.seleccionarPelicula = New System.Windows.Forms.ComboBox()
        Me.seleccionarPersona = New System.Windows.Forms.ComboBox()
        Me.añadirParticipante = New System.Windows.Forms.Button()
        Me.pestañaGénerosPeliculas = New System.Windows.Forms.TabPage()
        Me.eliminarPeliGen = New System.Windows.Forms.Button()
        Me.añadirPeliGen = New System.Windows.Forms.Button()
        Me.textoGénero = New System.Windows.Forms.Label()
        Me.textoPeliGen = New System.Windows.Forms.Label()
        Me.seleccionarGenero = New System.Windows.Forms.ComboBox()
        Me.seleccionarPeliGen = New System.Windows.Forms.ComboBox()
        Me.pestañaFichaActores = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nacionalidadFichaActores = New System.Windows.Forms.TextBox()
        Me.ciudadFichaActores = New System.Windows.Forms.TextBox()
        Me.imagenFichaActores = New System.Windows.Forms.PictureBox()
        Me.rolFichaActores = New System.Windows.Forms.ListBox()
        Me.peliculaFichaActores = New System.Windows.Forms.ListBox()
        Me.fechaFichaActores = New System.Windows.Forms.TextBox()
        Me.apellidoFichaActores = New System.Windows.Forms.TextBox()
        Me.nombreFichaActores = New System.Windows.Forms.TextBox()
        Me.listaActoresFichaActores = New System.Windows.Forms.ComboBox()
        Me.pestañaFichaPelículas = New System.Windows.Forms.TabPage()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.sinopsisFichaPeliculas = New System.Windows.Forms.TextBox()
        Me.duraciónFichaPeliculas = New System.Windows.Forms.TextBox()
        Me.listaFichaPeliculas = New System.Windows.Forms.ComboBox()
        Me.listaGenerosFichaPeliculas = New System.Windows.Forms.ListBox()
        Me.imagenFichaPeliculas = New System.Windows.Forms.PictureBox()
        Me.listaPersonasFichaPeliculas = New System.Windows.Forms.ListBox()
        Me.añoFichaPeliculas = New System.Windows.Forms.TextBox()
        Me.tituloOFichaPeliculas = New System.Windows.Forms.TextBox()
        Me.tituloFichaPeliculas = New System.Windows.Forms.TextBox()
        Me.botonConectar = New System.Windows.Forms.Button()
        Me.botonRutaBD = New System.Windows.Forms.Button()
        Me.textoRuta = New System.Windows.Forms.TextBox()
        Me.textoConectado = New System.Windows.Forms.Label()
        Me.pestañasPrincipal.SuspendLayout()
        Me.pestañaPersonas.SuspendLayout()
        CType(Me.imagenPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pestañaPelículas.SuspendLayout()
        CType(Me.imagenPelicula, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pestañaRoles.SuspendLayout()
        Me.pestañaGeneros.SuspendLayout()
        Me.pestañaParticipantes.SuspendLayout()
        Me.pestañaGénerosPeliculas.SuspendLayout()
        Me.pestañaFichaActores.SuspendLayout()
        CType(Me.imagenFichaActores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pestañaFichaPelículas.SuspendLayout()
        CType(Me.imagenFichaPeliculas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pestañasPrincipal
        '
        Me.pestañasPrincipal.Controls.Add(Me.pestañaPersonas)
        Me.pestañasPrincipal.Controls.Add(Me.pestañaPelículas)
        Me.pestañasPrincipal.Controls.Add(Me.pestañaRoles)
        Me.pestañasPrincipal.Controls.Add(Me.pestañaGeneros)
        Me.pestañasPrincipal.Controls.Add(Me.pestañaParticipantes)
        Me.pestañasPrincipal.Controls.Add(Me.pestañaGénerosPeliculas)
        Me.pestañasPrincipal.Controls.Add(Me.pestañaFichaActores)
        Me.pestañasPrincipal.Controls.Add(Me.pestañaFichaPelículas)
        Me.pestañasPrincipal.Location = New System.Drawing.Point(-4, -1)
        Me.pestañasPrincipal.Name = "pestañasPrincipal"
        Me.pestañasPrincipal.SelectedIndex = 0
        Me.pestañasPrincipal.Size = New System.Drawing.Size(590, 360)
        Me.pestañasPrincipal.TabIndex = 0
        '
        'pestañaPersonas
        '
        Me.pestañaPersonas.BackColor = System.Drawing.Color.Transparent
        Me.pestañaPersonas.Controls.Add(Me.Label1)
        Me.pestañaPersonas.Controls.Add(Me.rutaImagenPersona)
        Me.pestañaPersonas.Controls.Add(Me.botonImagenPersona)
        Me.pestañaPersonas.Controls.Add(Me.imagenPersona)
        Me.pestañaPersonas.Controls.Add(Me.textoPais)
        Me.pestañaPersonas.Controls.Add(Me.textoCiudad)
        Me.pestañaPersonas.Controls.Add(Me.textoFecha)
        Me.pestañaPersonas.Controls.Add(Me.textoNacionalidad)
        Me.pestañaPersonas.Controls.Add(Me.textoApellido)
        Me.pestañaPersonas.Controls.Add(Me.textoNombre)
        Me.pestañaPersonas.Controls.Add(Me.mostrarPais)
        Me.pestañaPersonas.Controls.Add(Me.mostrarCiudad)
        Me.pestañaPersonas.Controls.Add(Me.mostrarFecha)
        Me.pestañaPersonas.Controls.Add(Me.mostrarNacionalidad)
        Me.pestañaPersonas.Controls.Add(Me.mostrarApellido)
        Me.pestañaPersonas.Controls.Add(Me.mostrarNombre)
        Me.pestañaPersonas.Controls.Add(Me.listaPersonas)
        Me.pestañaPersonas.Controls.Add(Me.limpiarPersonas)
        Me.pestañaPersonas.Controls.Add(Me.eliminarPersona)
        Me.pestañaPersonas.Controls.Add(Me.modificarPersona)
        Me.pestañaPersonas.Controls.Add(Me.añadirPersona)
        Me.pestañaPersonas.Location = New System.Drawing.Point(4, 22)
        Me.pestañaPersonas.Name = "pestañaPersonas"
        Me.pestañaPersonas.Padding = New System.Windows.Forms.Padding(3)
        Me.pestañaPersonas.Size = New System.Drawing.Size(582, 334)
        Me.pestañaPersonas.TabIndex = 0
        Me.pestañaPersonas.Text = "Personas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(190, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 12)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "(DD/MM/AAAA)"
        '
        'rutaImagenPersona
        '
        Me.rutaImagenPersona.Location = New System.Drawing.Point(288, 239)
        Me.rutaImagenPersona.Name = "rutaImagenPersona"
        Me.rutaImagenPersona.ReadOnly = True
        Me.rutaImagenPersona.Size = New System.Drawing.Size(237, 20)
        Me.rutaImagenPersona.TabIndex = 19
        '
        'botonImagenPersona
        '
        Me.botonImagenPersona.Enabled = False
        Me.botonImagenPersona.Location = New System.Drawing.Point(188, 239)
        Me.botonImagenPersona.Name = "botonImagenPersona"
        Me.botonImagenPersona.Size = New System.Drawing.Size(87, 21)
        Me.botonImagenPersona.TabIndex = 18
        Me.botonImagenPersona.Text = "Imagen"
        Me.botonImagenPersona.UseVisualStyleBackColor = True
        '
        'imagenPersona
        '
        Me.imagenPersona.Location = New System.Drawing.Point(21, 206)
        Me.imagenPersona.Name = "imagenPersona"
        Me.imagenPersona.Size = New System.Drawing.Size(112, 112)
        Me.imagenPersona.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imagenPersona.TabIndex = 17
        Me.imagenPersona.TabStop = False
        '
        'textoPais
        '
        Me.textoPais.AutoSize = True
        Me.textoPais.Location = New System.Drawing.Point(184, 213)
        Me.textoPais.Name = "textoPais"
        Me.textoPais.Size = New System.Drawing.Size(98, 13)
        Me.textoPais.TabIndex = 16
        Me.textoPais.Text = "País de nacimiento"
        '
        'textoCiudad
        '
        Me.textoCiudad.AutoSize = True
        Me.textoCiudad.Location = New System.Drawing.Point(184, 177)
        Me.textoCiudad.Name = "textoCiudad"
        Me.textoCiudad.Size = New System.Drawing.Size(96, 13)
        Me.textoCiudad.TabIndex = 15
        Me.textoCiudad.Text = "Ciudad Nacimiento"
        '
        'textoFecha
        '
        Me.textoFecha.AutoSize = True
        Me.textoFecha.Location = New System.Drawing.Point(183, 127)
        Me.textoFecha.Name = "textoFecha"
        Me.textoFecha.Size = New System.Drawing.Size(91, 13)
        Me.textoFecha.TabIndex = 14
        Me.textoFecha.Text = "Fecha nacimiento"
        '
        'textoNacionalidad
        '
        Me.textoNacionalidad.AutoSize = True
        Me.textoNacionalidad.Location = New System.Drawing.Point(205, 100)
        Me.textoNacionalidad.Name = "textoNacionalidad"
        Me.textoNacionalidad.Size = New System.Drawing.Size(69, 13)
        Me.textoNacionalidad.TabIndex = 13
        Me.textoNacionalidad.Text = "Nacionalidad"
        '
        'textoApellido
        '
        Me.textoApellido.AutoSize = True
        Me.textoApellido.Location = New System.Drawing.Point(230, 62)
        Me.textoApellido.Name = "textoApellido"
        Me.textoApellido.Size = New System.Drawing.Size(44, 13)
        Me.textoApellido.TabIndex = 12
        Me.textoApellido.Text = "Apellido"
        '
        'textoNombre
        '
        Me.textoNombre.AutoSize = True
        Me.textoNombre.Location = New System.Drawing.Point(232, 22)
        Me.textoNombre.Name = "textoNombre"
        Me.textoNombre.Size = New System.Drawing.Size(44, 13)
        Me.textoNombre.TabIndex = 11
        Me.textoNombre.Text = "Nombre"
        '
        'mostrarPais
        '
        Me.mostrarPais.Enabled = False
        Me.mostrarPais.Location = New System.Drawing.Point(288, 206)
        Me.mostrarPais.Name = "mostrarPais"
        Me.mostrarPais.Size = New System.Drawing.Size(144, 20)
        Me.mostrarPais.TabIndex = 10
        '
        'mostrarCiudad
        '
        Me.mostrarCiudad.Enabled = False
        Me.mostrarCiudad.Location = New System.Drawing.Point(288, 170)
        Me.mostrarCiudad.Name = "mostrarCiudad"
        Me.mostrarCiudad.Size = New System.Drawing.Size(144, 20)
        Me.mostrarCiudad.TabIndex = 9
        '
        'mostrarFecha
        '
        Me.mostrarFecha.Enabled = False
        Me.mostrarFecha.Location = New System.Drawing.Point(288, 130)
        Me.mostrarFecha.Name = "mostrarFecha"
        Me.mostrarFecha.Size = New System.Drawing.Size(144, 20)
        Me.mostrarFecha.TabIndex = 8
        '
        'mostrarNacionalidad
        '
        Me.mostrarNacionalidad.Enabled = False
        Me.mostrarNacionalidad.Location = New System.Drawing.Point(288, 93)
        Me.mostrarNacionalidad.Name = "mostrarNacionalidad"
        Me.mostrarNacionalidad.Size = New System.Drawing.Size(143, 20)
        Me.mostrarNacionalidad.TabIndex = 7
        '
        'mostrarApellido
        '
        Me.mostrarApellido.Enabled = False
        Me.mostrarApellido.Location = New System.Drawing.Point(288, 55)
        Me.mostrarApellido.Name = "mostrarApellido"
        Me.mostrarApellido.Size = New System.Drawing.Size(143, 20)
        Me.mostrarApellido.TabIndex = 6
        '
        'mostrarNombre
        '
        Me.mostrarNombre.Enabled = False
        Me.mostrarNombre.Location = New System.Drawing.Point(288, 19)
        Me.mostrarNombre.Name = "mostrarNombre"
        Me.mostrarNombre.Size = New System.Drawing.Size(144, 20)
        Me.mostrarNombre.TabIndex = 5
        '
        'listaPersonas
        '
        Me.listaPersonas.FormattingEnabled = True
        Me.listaPersonas.Location = New System.Drawing.Point(21, 19)
        Me.listaPersonas.Name = "listaPersonas"
        Me.listaPersonas.Size = New System.Drawing.Size(112, 121)
        Me.listaPersonas.TabIndex = 4
        '
        'limpiarPersonas
        '
        Me.limpiarPersonas.Enabled = False
        Me.limpiarPersonas.Location = New System.Drawing.Point(291, 305)
        Me.limpiarPersonas.Name = "limpiarPersonas"
        Me.limpiarPersonas.Size = New System.Drawing.Size(237, 23)
        Me.limpiarPersonas.TabIndex = 3
        Me.limpiarPersonas.Text = "Limpiar Campos"
        Me.limpiarPersonas.UseVisualStyleBackColor = True
        '
        'eliminarPersona
        '
        Me.eliminarPersona.Enabled = False
        Me.eliminarPersona.Location = New System.Drawing.Point(453, 276)
        Me.eliminarPersona.Name = "eliminarPersona"
        Me.eliminarPersona.Size = New System.Drawing.Size(75, 23)
        Me.eliminarPersona.TabIndex = 2
        Me.eliminarPersona.Text = "Eliminar"
        Me.eliminarPersona.UseVisualStyleBackColor = True
        '
        'modificarPersona
        '
        Me.modificarPersona.Enabled = False
        Me.modificarPersona.Location = New System.Drawing.Point(372, 276)
        Me.modificarPersona.Name = "modificarPersona"
        Me.modificarPersona.Size = New System.Drawing.Size(75, 23)
        Me.modificarPersona.TabIndex = 1
        Me.modificarPersona.Text = "Modificar"
        Me.modificarPersona.UseVisualStyleBackColor = True
        '
        'añadirPersona
        '
        Me.añadirPersona.Enabled = False
        Me.añadirPersona.Location = New System.Drawing.Point(291, 276)
        Me.añadirPersona.Name = "añadirPersona"
        Me.añadirPersona.Size = New System.Drawing.Size(75, 23)
        Me.añadirPersona.TabIndex = 0
        Me.añadirPersona.Text = "Añadir"
        Me.añadirPersona.UseVisualStyleBackColor = True
        '
        'pestañaPelículas
        '
        Me.pestañaPelículas.BackColor = System.Drawing.Color.Transparent
        Me.pestañaPelículas.Controls.Add(Me.imagenPelicula)
        Me.pestañaPelículas.Controls.Add(Me.rutaImagenPelicula)
        Me.pestañaPelículas.Controls.Add(Me.botonImagenPelicula)
        Me.pestañaPelículas.Controls.Add(Me.textoSinopsis)
        Me.pestañaPelículas.Controls.Add(Me.textoDuración)
        Me.pestañaPelículas.Controls.Add(Me.textoAño)
        Me.pestañaPelículas.Controls.Add(Me.textoTituloOriginal)
        Me.pestañaPelículas.Controls.Add(Me.textoTitulo)
        Me.pestañaPelículas.Controls.Add(Me.mostrarSinopsis)
        Me.pestañaPelículas.Controls.Add(Me.mostrarDuración)
        Me.pestañaPelículas.Controls.Add(Me.mostrarAño)
        Me.pestañaPelículas.Controls.Add(Me.mostrarTituloOriginal)
        Me.pestañaPelículas.Controls.Add(Me.mostrarTitulo)
        Me.pestañaPelículas.Controls.Add(Me.listaPeliculas)
        Me.pestañaPelículas.Controls.Add(Me.limpiarPeliculas)
        Me.pestañaPelículas.Controls.Add(Me.eliminarPelicula)
        Me.pestañaPelículas.Controls.Add(Me.modificarPelicula)
        Me.pestañaPelículas.Controls.Add(Me.añadirPelicula)
        Me.pestañaPelículas.Location = New System.Drawing.Point(4, 22)
        Me.pestañaPelículas.Name = "pestañaPelículas"
        Me.pestañaPelículas.Padding = New System.Windows.Forms.Padding(3)
        Me.pestañaPelículas.Size = New System.Drawing.Size(582, 334)
        Me.pestañaPelículas.TabIndex = 1
        Me.pestañaPelículas.Text = "Películas"
        '
        'imagenPelicula
        '
        Me.imagenPelicula.Location = New System.Drawing.Point(34, 166)
        Me.imagenPelicula.Name = "imagenPelicula"
        Me.imagenPelicula.Size = New System.Drawing.Size(143, 153)
        Me.imagenPelicula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imagenPelicula.TabIndex = 21
        Me.imagenPelicula.TabStop = False
        '
        'rutaImagenPelicula
        '
        Me.rutaImagenPelicula.Location = New System.Drawing.Point(322, 218)
        Me.rutaImagenPelicula.Name = "rutaImagenPelicula"
        Me.rutaImagenPelicula.ReadOnly = True
        Me.rutaImagenPelicula.Size = New System.Drawing.Size(237, 20)
        Me.rutaImagenPelicula.TabIndex = 20
        '
        'botonImagenPelicula
        '
        Me.botonImagenPelicula.Enabled = False
        Me.botonImagenPelicula.Location = New System.Drawing.Point(241, 216)
        Me.botonImagenPelicula.Name = "botonImagenPelicula"
        Me.botonImagenPelicula.Size = New System.Drawing.Size(75, 22)
        Me.botonImagenPelicula.TabIndex = 16
        Me.botonImagenPelicula.Text = "Imagen"
        Me.botonImagenPelicula.UseVisualStyleBackColor = True
        '
        'textoSinopsis
        '
        Me.textoSinopsis.AutoSize = True
        Me.textoSinopsis.Location = New System.Drawing.Point(262, 181)
        Me.textoSinopsis.Name = "textoSinopsis"
        Me.textoSinopsis.Size = New System.Drawing.Size(46, 13)
        Me.textoSinopsis.TabIndex = 15
        Me.textoSinopsis.Text = "Sinopsis"
        '
        'textoDuración
        '
        Me.textoDuración.AutoSize = True
        Me.textoDuración.Location = New System.Drawing.Point(262, 128)
        Me.textoDuración.Name = "textoDuración"
        Me.textoDuración.Size = New System.Drawing.Size(50, 13)
        Me.textoDuración.TabIndex = 14
        Me.textoDuración.Text = "Duración"
        '
        'textoAño
        '
        Me.textoAño.AutoSize = True
        Me.textoAño.Location = New System.Drawing.Point(243, 91)
        Me.textoAño.Name = "textoAño"
        Me.textoAño.Size = New System.Drawing.Size(65, 13)
        Me.textoAño.TabIndex = 13
        Me.textoAño.Text = "Año Estreno"
        '
        'textoTituloOriginal
        '
        Me.textoTituloOriginal.AutoSize = True
        Me.textoTituloOriginal.Location = New System.Drawing.Point(243, 56)
        Me.textoTituloOriginal.Name = "textoTituloOriginal"
        Me.textoTituloOriginal.Size = New System.Drawing.Size(73, 13)
        Me.textoTituloOriginal.TabIndex = 12
        Me.textoTituloOriginal.Text = "Título Original"
        '
        'textoTitulo
        '
        Me.textoTitulo.AutoSize = True
        Me.textoTitulo.Location = New System.Drawing.Point(262, 19)
        Me.textoTitulo.Name = "textoTitulo"
        Me.textoTitulo.Size = New System.Drawing.Size(35, 13)
        Me.textoTitulo.TabIndex = 11
        Me.textoTitulo.Text = "Título"
        '
        'mostrarSinopsis
        '
        Me.mostrarSinopsis.Enabled = False
        Me.mostrarSinopsis.Location = New System.Drawing.Point(322, 166)
        Me.mostrarSinopsis.Multiline = True
        Me.mostrarSinopsis.Name = "mostrarSinopsis"
        Me.mostrarSinopsis.Size = New System.Drawing.Size(237, 38)
        Me.mostrarSinopsis.TabIndex = 10
        '
        'mostrarDuración
        '
        Me.mostrarDuración.Enabled = False
        Me.mostrarDuración.Location = New System.Drawing.Point(322, 125)
        Me.mostrarDuración.Name = "mostrarDuración"
        Me.mostrarDuración.Size = New System.Drawing.Size(157, 20)
        Me.mostrarDuración.TabIndex = 9
        '
        'mostrarAño
        '
        Me.mostrarAño.Enabled = False
        Me.mostrarAño.Location = New System.Drawing.Point(322, 84)
        Me.mostrarAño.Name = "mostrarAño"
        Me.mostrarAño.Size = New System.Drawing.Size(157, 20)
        Me.mostrarAño.TabIndex = 8
        '
        'mostrarTituloOriginal
        '
        Me.mostrarTituloOriginal.Enabled = False
        Me.mostrarTituloOriginal.Location = New System.Drawing.Point(322, 49)
        Me.mostrarTituloOriginal.Name = "mostrarTituloOriginal"
        Me.mostrarTituloOriginal.Size = New System.Drawing.Size(157, 20)
        Me.mostrarTituloOriginal.TabIndex = 7
        '
        'mostrarTitulo
        '
        Me.mostrarTitulo.Enabled = False
        Me.mostrarTitulo.Location = New System.Drawing.Point(322, 14)
        Me.mostrarTitulo.Name = "mostrarTitulo"
        Me.mostrarTitulo.Size = New System.Drawing.Size(157, 20)
        Me.mostrarTitulo.TabIndex = 6
        '
        'listaPeliculas
        '
        Me.listaPeliculas.FormattingEnabled = True
        Me.listaPeliculas.Location = New System.Drawing.Point(34, 14)
        Me.listaPeliculas.Name = "listaPeliculas"
        Me.listaPeliculas.Size = New System.Drawing.Size(167, 134)
        Me.listaPeliculas.TabIndex = 5
        '
        'limpiarPeliculas
        '
        Me.limpiarPeliculas.Enabled = False
        Me.limpiarPeliculas.Location = New System.Drawing.Point(288, 296)
        Me.limpiarPeliculas.Name = "limpiarPeliculas"
        Me.limpiarPeliculas.Size = New System.Drawing.Size(237, 23)
        Me.limpiarPeliculas.TabIndex = 4
        Me.limpiarPeliculas.Text = "Limpiar Campos"
        Me.limpiarPeliculas.UseVisualStyleBackColor = True
        '
        'eliminarPelicula
        '
        Me.eliminarPelicula.Enabled = False
        Me.eliminarPelicula.Location = New System.Drawing.Point(450, 255)
        Me.eliminarPelicula.Name = "eliminarPelicula"
        Me.eliminarPelicula.Size = New System.Drawing.Size(75, 23)
        Me.eliminarPelicula.TabIndex = 2
        Me.eliminarPelicula.Text = "Eliminar"
        Me.eliminarPelicula.UseVisualStyleBackColor = True
        '
        'modificarPelicula
        '
        Me.modificarPelicula.Enabled = False
        Me.modificarPelicula.Location = New System.Drawing.Point(369, 255)
        Me.modificarPelicula.Name = "modificarPelicula"
        Me.modificarPelicula.Size = New System.Drawing.Size(75, 23)
        Me.modificarPelicula.TabIndex = 1
        Me.modificarPelicula.Text = "Modificar"
        Me.modificarPelicula.UseVisualStyleBackColor = True
        '
        'añadirPelicula
        '
        Me.añadirPelicula.Enabled = False
        Me.añadirPelicula.Location = New System.Drawing.Point(288, 255)
        Me.añadirPelicula.Name = "añadirPelicula"
        Me.añadirPelicula.Size = New System.Drawing.Size(75, 23)
        Me.añadirPelicula.TabIndex = 0
        Me.añadirPelicula.Text = "Añadir"
        Me.añadirPelicula.UseVisualStyleBackColor = True
        '
        'pestañaRoles
        '
        Me.pestañaRoles.BackColor = System.Drawing.Color.Transparent
        Me.pestañaRoles.Controls.Add(Me.textoDescrRol)
        Me.pestañaRoles.Controls.Add(Me.mostrarDescrRol)
        Me.pestañaRoles.Controls.Add(Me.listaRoles)
        Me.pestañaRoles.Controls.Add(Me.limpiarRoles)
        Me.pestañaRoles.Controls.Add(Me.eliminarRol)
        Me.pestañaRoles.Controls.Add(Me.modificarRol)
        Me.pestañaRoles.Controls.Add(Me.añadirRol)
        Me.pestañaRoles.Location = New System.Drawing.Point(4, 22)
        Me.pestañaRoles.Name = "pestañaRoles"
        Me.pestañaRoles.Size = New System.Drawing.Size(582, 334)
        Me.pestañaRoles.TabIndex = 2
        Me.pestañaRoles.Text = "Roles"
        '
        'textoDescrRol
        '
        Me.textoDescrRol.AutoSize = True
        Me.textoDescrRol.Location = New System.Drawing.Point(344, 33)
        Me.textoDescrRol.Name = "textoDescrRol"
        Me.textoDescrRol.Size = New System.Drawing.Size(94, 13)
        Me.textoDescrRol.TabIndex = 7
        Me.textoDescrRol.Text = "Descripción del rol"
        '
        'mostrarDescrRol
        '
        Me.mostrarDescrRol.Enabled = False
        Me.mostrarDescrRol.Location = New System.Drawing.Point(252, 67)
        Me.mostrarDescrRol.Name = "mostrarDescrRol"
        Me.mostrarDescrRol.Size = New System.Drawing.Size(262, 20)
        Me.mostrarDescrRol.TabIndex = 6
        '
        'listaRoles
        '
        Me.listaRoles.FormattingEnabled = True
        Me.listaRoles.Location = New System.Drawing.Point(30, 33)
        Me.listaRoles.Name = "listaRoles"
        Me.listaRoles.Size = New System.Drawing.Size(128, 121)
        Me.listaRoles.TabIndex = 5
        '
        'limpiarRoles
        '
        Me.limpiarRoles.Enabled = False
        Me.limpiarRoles.Location = New System.Drawing.Point(292, 282)
        Me.limpiarRoles.Name = "limpiarRoles"
        Me.limpiarRoles.Size = New System.Drawing.Size(237, 23)
        Me.limpiarRoles.TabIndex = 4
        Me.limpiarRoles.Text = "Limpiar Campos"
        Me.limpiarRoles.UseVisualStyleBackColor = True
        '
        'eliminarRol
        '
        Me.eliminarRol.Enabled = False
        Me.eliminarRol.Location = New System.Drawing.Point(454, 234)
        Me.eliminarRol.Name = "eliminarRol"
        Me.eliminarRol.Size = New System.Drawing.Size(75, 23)
        Me.eliminarRol.TabIndex = 2
        Me.eliminarRol.Text = "Eliminar"
        Me.eliminarRol.UseVisualStyleBackColor = True
        '
        'modificarRol
        '
        Me.modificarRol.Enabled = False
        Me.modificarRol.Location = New System.Drawing.Point(373, 234)
        Me.modificarRol.Name = "modificarRol"
        Me.modificarRol.Size = New System.Drawing.Size(75, 23)
        Me.modificarRol.TabIndex = 1
        Me.modificarRol.Text = "Modificar"
        Me.modificarRol.UseVisualStyleBackColor = True
        '
        'añadirRol
        '
        Me.añadirRol.Enabled = False
        Me.añadirRol.Location = New System.Drawing.Point(292, 234)
        Me.añadirRol.Name = "añadirRol"
        Me.añadirRol.Size = New System.Drawing.Size(75, 23)
        Me.añadirRol.TabIndex = 0
        Me.añadirRol.Text = "Añadir"
        Me.añadirRol.UseVisualStyleBackColor = True
        '
        'pestañaGeneros
        '
        Me.pestañaGeneros.BackColor = System.Drawing.Color.Transparent
        Me.pestañaGeneros.Controls.Add(Me.textoDescrGenero)
        Me.pestañaGeneros.Controls.Add(Me.mostrarDescrGenero)
        Me.pestañaGeneros.Controls.Add(Me.listaGeneros)
        Me.pestañaGeneros.Controls.Add(Me.limpiarGeneros)
        Me.pestañaGeneros.Controls.Add(Me.eliminarGenero)
        Me.pestañaGeneros.Controls.Add(Me.modificarGenero)
        Me.pestañaGeneros.Controls.Add(Me.añadirGenero)
        Me.pestañaGeneros.Location = New System.Drawing.Point(4, 22)
        Me.pestañaGeneros.Name = "pestañaGeneros"
        Me.pestañaGeneros.Size = New System.Drawing.Size(582, 334)
        Me.pestañaGeneros.TabIndex = 3
        Me.pestañaGeneros.Text = "Géneros"
        '
        'textoDescrGenero
        '
        Me.textoDescrGenero.AutoSize = True
        Me.textoDescrGenero.Location = New System.Drawing.Point(330, 33)
        Me.textoDescrGenero.Name = "textoDescrGenero"
        Me.textoDescrGenero.Size = New System.Drawing.Size(116, 13)
        Me.textoDescrGenero.TabIndex = 7
        Me.textoDescrGenero.Text = "Descripción del género"
        '
        'mostrarDescrGenero
        '
        Me.mostrarDescrGenero.Enabled = False
        Me.mostrarDescrGenero.Location = New System.Drawing.Point(252, 67)
        Me.mostrarDescrGenero.Name = "mostrarDescrGenero"
        Me.mostrarDescrGenero.Size = New System.Drawing.Size(262, 20)
        Me.mostrarDescrGenero.TabIndex = 6
        '
        'listaGeneros
        '
        Me.listaGeneros.FormattingEnabled = True
        Me.listaGeneros.Location = New System.Drawing.Point(30, 33)
        Me.listaGeneros.Name = "listaGeneros"
        Me.listaGeneros.Size = New System.Drawing.Size(128, 121)
        Me.listaGeneros.TabIndex = 5
        '
        'limpiarGeneros
        '
        Me.limpiarGeneros.Enabled = False
        Me.limpiarGeneros.Location = New System.Drawing.Point(290, 288)
        Me.limpiarGeneros.Name = "limpiarGeneros"
        Me.limpiarGeneros.Size = New System.Drawing.Size(237, 23)
        Me.limpiarGeneros.TabIndex = 4
        Me.limpiarGeneros.Text = "Limpiar Campos"
        Me.limpiarGeneros.UseVisualStyleBackColor = True
        '
        'eliminarGenero
        '
        Me.eliminarGenero.Enabled = False
        Me.eliminarGenero.Location = New System.Drawing.Point(452, 236)
        Me.eliminarGenero.Name = "eliminarGenero"
        Me.eliminarGenero.Size = New System.Drawing.Size(75, 23)
        Me.eliminarGenero.TabIndex = 2
        Me.eliminarGenero.Text = "Eliminar"
        Me.eliminarGenero.UseVisualStyleBackColor = True
        '
        'modificarGenero
        '
        Me.modificarGenero.Enabled = False
        Me.modificarGenero.Location = New System.Drawing.Point(371, 236)
        Me.modificarGenero.Name = "modificarGenero"
        Me.modificarGenero.Size = New System.Drawing.Size(75, 23)
        Me.modificarGenero.TabIndex = 1
        Me.modificarGenero.Text = "Modificar"
        Me.modificarGenero.UseVisualStyleBackColor = True
        '
        'añadirGenero
        '
        Me.añadirGenero.Enabled = False
        Me.añadirGenero.Location = New System.Drawing.Point(290, 236)
        Me.añadirGenero.Name = "añadirGenero"
        Me.añadirGenero.Size = New System.Drawing.Size(75, 23)
        Me.añadirGenero.TabIndex = 0
        Me.añadirGenero.Text = "Añadir"
        Me.añadirGenero.UseVisualStyleBackColor = True
        '
        'pestañaParticipantes
        '
        Me.pestañaParticipantes.BackColor = System.Drawing.Color.Transparent
        Me.pestañaParticipantes.Controls.Add(Me.eliminarParticipante)
        Me.pestañaParticipantes.Controls.Add(Me.textoRol)
        Me.pestañaParticipantes.Controls.Add(Me.textoPelícula)
        Me.pestañaParticipantes.Controls.Add(Me.textoActor)
        Me.pestañaParticipantes.Controls.Add(Me.seleccionarRol)
        Me.pestañaParticipantes.Controls.Add(Me.seleccionarPelicula)
        Me.pestañaParticipantes.Controls.Add(Me.seleccionarPersona)
        Me.pestañaParticipantes.Controls.Add(Me.añadirParticipante)
        Me.pestañaParticipantes.Location = New System.Drawing.Point(4, 22)
        Me.pestañaParticipantes.Name = "pestañaParticipantes"
        Me.pestañaParticipantes.Size = New System.Drawing.Size(582, 334)
        Me.pestañaParticipantes.TabIndex = 6
        Me.pestañaParticipantes.Text = "Participantes"
        '
        'eliminarParticipante
        '
        Me.eliminarParticipante.Enabled = False
        Me.eliminarParticipante.Location = New System.Drawing.Point(311, 242)
        Me.eliminarParticipante.Name = "eliminarParticipante"
        Me.eliminarParticipante.Size = New System.Drawing.Size(232, 39)
        Me.eliminarParticipante.TabIndex = 7
        Me.eliminarParticipante.Text = "Eliminar"
        Me.eliminarParticipante.UseVisualStyleBackColor = True
        '
        'textoRol
        '
        Me.textoRol.AutoSize = True
        Me.textoRol.Location = New System.Drawing.Point(471, 51)
        Me.textoRol.Name = "textoRol"
        Me.textoRol.Size = New System.Drawing.Size(23, 13)
        Me.textoRol.TabIndex = 6
        Me.textoRol.Text = "Rol"
        '
        'textoPelícula
        '
        Me.textoPelícula.AutoSize = True
        Me.textoPelícula.Location = New System.Drawing.Point(269, 51)
        Me.textoPelícula.Name = "textoPelícula"
        Me.textoPelícula.Size = New System.Drawing.Size(46, 13)
        Me.textoPelícula.TabIndex = 5
        Me.textoPelícula.Text = "Película"
        '
        'textoActor
        '
        Me.textoActor.AutoSize = True
        Me.textoActor.Location = New System.Drawing.Point(76, 51)
        Me.textoActor.Name = "textoActor"
        Me.textoActor.Size = New System.Drawing.Size(46, 13)
        Me.textoActor.TabIndex = 4
        Me.textoActor.Text = "Persona"
        '
        'seleccionarRol
        '
        Me.seleccionarRol.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.seleccionarRol.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.seleccionarRol.Enabled = False
        Me.seleccionarRol.FormattingEnabled = True
        Me.seleccionarRol.Location = New System.Drawing.Point(422, 79)
        Me.seleccionarRol.Name = "seleccionarRol"
        Me.seleccionarRol.Size = New System.Drawing.Size(121, 21)
        Me.seleccionarRol.TabIndex = 3
        '
        'seleccionarPelicula
        '
        Me.seleccionarPelicula.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.seleccionarPelicula.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.seleccionarPelicula.Enabled = False
        Me.seleccionarPelicula.FormattingEnabled = True
        Me.seleccionarPelicula.Location = New System.Drawing.Point(211, 79)
        Me.seleccionarPelicula.Name = "seleccionarPelicula"
        Me.seleccionarPelicula.Size = New System.Drawing.Size(162, 21)
        Me.seleccionarPelicula.TabIndex = 2
        '
        'seleccionarPersona
        '
        Me.seleccionarPersona.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.seleccionarPersona.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.seleccionarPersona.Enabled = False
        Me.seleccionarPersona.FormattingEnabled = True
        Me.seleccionarPersona.Location = New System.Drawing.Point(37, 79)
        Me.seleccionarPersona.Name = "seleccionarPersona"
        Me.seleccionarPersona.Size = New System.Drawing.Size(121, 21)
        Me.seleccionarPersona.TabIndex = 1
        '
        'añadirParticipante
        '
        Me.añadirParticipante.Enabled = False
        Me.añadirParticipante.Location = New System.Drawing.Point(52, 242)
        Me.añadirParticipante.Name = "añadirParticipante"
        Me.añadirParticipante.Size = New System.Drawing.Size(232, 39)
        Me.añadirParticipante.TabIndex = 0
        Me.añadirParticipante.Text = "Añadir"
        Me.añadirParticipante.UseVisualStyleBackColor = True
        '
        'pestañaGénerosPeliculas
        '
        Me.pestañaGénerosPeliculas.BackColor = System.Drawing.Color.Transparent
        Me.pestañaGénerosPeliculas.Controls.Add(Me.eliminarPeliGen)
        Me.pestañaGénerosPeliculas.Controls.Add(Me.añadirPeliGen)
        Me.pestañaGénerosPeliculas.Controls.Add(Me.textoGénero)
        Me.pestañaGénerosPeliculas.Controls.Add(Me.textoPeliGen)
        Me.pestañaGénerosPeliculas.Controls.Add(Me.seleccionarGenero)
        Me.pestañaGénerosPeliculas.Controls.Add(Me.seleccionarPeliGen)
        Me.pestañaGénerosPeliculas.Location = New System.Drawing.Point(4, 22)
        Me.pestañaGénerosPeliculas.Name = "pestañaGénerosPeliculas"
        Me.pestañaGénerosPeliculas.Size = New System.Drawing.Size(582, 334)
        Me.pestañaGénerosPeliculas.TabIndex = 7
        Me.pestañaGénerosPeliculas.Text = "Géneros de una película"
        '
        'eliminarPeliGen
        '
        Me.eliminarPeliGen.Enabled = False
        Me.eliminarPeliGen.Location = New System.Drawing.Point(311, 242)
        Me.eliminarPeliGen.Name = "eliminarPeliGen"
        Me.eliminarPeliGen.Size = New System.Drawing.Size(238, 39)
        Me.eliminarPeliGen.TabIndex = 5
        Me.eliminarPeliGen.Text = "Eliminar"
        Me.eliminarPeliGen.UseVisualStyleBackColor = True
        '
        'añadirPeliGen
        '
        Me.añadirPeliGen.Enabled = False
        Me.añadirPeliGen.Location = New System.Drawing.Point(37, 242)
        Me.añadirPeliGen.Name = "añadirPeliGen"
        Me.añadirPeliGen.Size = New System.Drawing.Size(238, 39)
        Me.añadirPeliGen.TabIndex = 4
        Me.añadirPeliGen.Text = "Añadir"
        Me.añadirPeliGen.UseVisualStyleBackColor = True
        '
        'textoGénero
        '
        Me.textoGénero.AutoSize = True
        Me.textoGénero.Location = New System.Drawing.Point(366, 42)
        Me.textoGénero.Name = "textoGénero"
        Me.textoGénero.Size = New System.Drawing.Size(47, 13)
        Me.textoGénero.TabIndex = 3
        Me.textoGénero.Text = "Géneros"
        '
        'textoPeliGen
        '
        Me.textoPeliGen.AutoSize = True
        Me.textoPeliGen.Location = New System.Drawing.Point(144, 42)
        Me.textoPeliGen.Name = "textoPeliGen"
        Me.textoPeliGen.Size = New System.Drawing.Size(51, 13)
        Me.textoPeliGen.TabIndex = 2
        Me.textoPeliGen.Text = "Películas"
        '
        'seleccionarGenero
        '
        Me.seleccionarGenero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.seleccionarGenero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.seleccionarGenero.Enabled = False
        Me.seleccionarGenero.FormattingEnabled = True
        Me.seleccionarGenero.Location = New System.Drawing.Point(321, 72)
        Me.seleccionarGenero.Name = "seleccionarGenero"
        Me.seleccionarGenero.Size = New System.Drawing.Size(138, 21)
        Me.seleccionarGenero.TabIndex = 1
        '
        'seleccionarPeliGen
        '
        Me.seleccionarPeliGen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.seleccionarPeliGen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.seleccionarPeliGen.Enabled = False
        Me.seleccionarPeliGen.FormattingEnabled = True
        Me.seleccionarPeliGen.Location = New System.Drawing.Point(94, 72)
        Me.seleccionarPeliGen.Name = "seleccionarPeliGen"
        Me.seleccionarPeliGen.Size = New System.Drawing.Size(158, 21)
        Me.seleccionarPeliGen.TabIndex = 0
        '
        'pestañaFichaActores
        '
        Me.pestañaFichaActores.AccessibleDescription = "Mostrar las fichas de los actores"
        Me.pestañaFichaActores.BackColor = System.Drawing.Color.Transparent
        Me.pestañaFichaActores.Controls.Add(Me.Label8)
        Me.pestañaFichaActores.Controls.Add(Me.Label7)
        Me.pestañaFichaActores.Controls.Add(Me.Label6)
        Me.pestañaFichaActores.Controls.Add(Me.Label5)
        Me.pestañaFichaActores.Controls.Add(Me.Label4)
        Me.pestañaFichaActores.Controls.Add(Me.Label3)
        Me.pestañaFichaActores.Controls.Add(Me.Label2)
        Me.pestañaFichaActores.Controls.Add(Me.nacionalidadFichaActores)
        Me.pestañaFichaActores.Controls.Add(Me.ciudadFichaActores)
        Me.pestañaFichaActores.Controls.Add(Me.imagenFichaActores)
        Me.pestañaFichaActores.Controls.Add(Me.rolFichaActores)
        Me.pestañaFichaActores.Controls.Add(Me.peliculaFichaActores)
        Me.pestañaFichaActores.Controls.Add(Me.fechaFichaActores)
        Me.pestañaFichaActores.Controls.Add(Me.apellidoFichaActores)
        Me.pestañaFichaActores.Controls.Add(Me.nombreFichaActores)
        Me.pestañaFichaActores.Controls.Add(Me.listaActoresFichaActores)
        Me.pestañaFichaActores.Location = New System.Drawing.Point(4, 22)
        Me.pestañaFichaActores.Name = "pestañaFichaActores"
        Me.pestañaFichaActores.Size = New System.Drawing.Size(582, 334)
        Me.pestañaFichaActores.TabIndex = 4
        Me.pestañaFichaActores.Text = "Ficha Actores"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(267, 249)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Nacionalidad"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(248, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Ciudad de nacimiento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(248, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Fecha de nacimiento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(280, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(282, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(462, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Películas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(434, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Roles desempeñados"
        '
        'nacionalidadFichaActores
        '
        Me.nacionalidadFichaActores.Location = New System.Drawing.Point(215, 275)
        Me.nacionalidadFichaActores.Name = "nacionalidadFichaActores"
        Me.nacionalidadFichaActores.ReadOnly = True
        Me.nacionalidadFichaActores.Size = New System.Drawing.Size(165, 20)
        Me.nacionalidadFichaActores.TabIndex = 8
        '
        'ciudadFichaActores
        '
        Me.ciudadFichaActores.Location = New System.Drawing.Point(215, 216)
        Me.ciudadFichaActores.Name = "ciudadFichaActores"
        Me.ciudadFichaActores.ReadOnly = True
        Me.ciudadFichaActores.Size = New System.Drawing.Size(165, 20)
        Me.ciudadFichaActores.TabIndex = 7
        '
        'imagenFichaActores
        '
        Me.imagenFichaActores.Location = New System.Drawing.Point(21, 152)
        Me.imagenFichaActores.Name = "imagenFichaActores"
        Me.imagenFichaActores.Size = New System.Drawing.Size(137, 137)
        Me.imagenFichaActores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imagenFichaActores.TabIndex = 6
        Me.imagenFichaActores.TabStop = False
        '
        'rolFichaActores
        '
        Me.rolFichaActores.Enabled = False
        Me.rolFichaActores.FormattingEnabled = True
        Me.rolFichaActores.Location = New System.Drawing.Point(409, 197)
        Me.rolFichaActores.Name = "rolFichaActores"
        Me.rolFichaActores.Size = New System.Drawing.Size(152, 108)
        Me.rolFichaActores.TabIndex = 5
        '
        'peliculaFichaActores
        '
        Me.peliculaFichaActores.Enabled = False
        Me.peliculaFichaActores.FormattingEnabled = True
        Me.peliculaFichaActores.Location = New System.Drawing.Point(409, 43)
        Me.peliculaFichaActores.Name = "peliculaFichaActores"
        Me.peliculaFichaActores.Size = New System.Drawing.Size(152, 108)
        Me.peliculaFichaActores.TabIndex = 4
        '
        'fechaFichaActores
        '
        Me.fechaFichaActores.Location = New System.Drawing.Point(215, 152)
        Me.fechaFichaActores.Name = "fechaFichaActores"
        Me.fechaFichaActores.ReadOnly = True
        Me.fechaFichaActores.Size = New System.Drawing.Size(166, 20)
        Me.fechaFichaActores.TabIndex = 3
        '
        'apellidoFichaActores
        '
        Me.apellidoFichaActores.Location = New System.Drawing.Point(215, 97)
        Me.apellidoFichaActores.Name = "apellidoFichaActores"
        Me.apellidoFichaActores.ReadOnly = True
        Me.apellidoFichaActores.Size = New System.Drawing.Size(166, 20)
        Me.apellidoFichaActores.TabIndex = 2
        '
        'nombreFichaActores
        '
        Me.nombreFichaActores.Location = New System.Drawing.Point(215, 43)
        Me.nombreFichaActores.Name = "nombreFichaActores"
        Me.nombreFichaActores.ReadOnly = True
        Me.nombreFichaActores.Size = New System.Drawing.Size(166, 20)
        Me.nombreFichaActores.TabIndex = 1
        '
        'listaActoresFichaActores
        '
        Me.listaActoresFichaActores.Enabled = False
        Me.listaActoresFichaActores.FormattingEnabled = True
        Me.listaActoresFichaActores.Location = New System.Drawing.Point(21, 32)
        Me.listaActoresFichaActores.Name = "listaActoresFichaActores"
        Me.listaActoresFichaActores.Size = New System.Drawing.Size(137, 21)
        Me.listaActoresFichaActores.TabIndex = 0
        '
        'pestañaFichaPelículas
        '
        Me.pestañaFichaPelículas.AccessibleDescription = "Mostrar las fichas de las películas"
        Me.pestañaFichaPelículas.BackColor = System.Drawing.Color.Transparent
        Me.pestañaFichaPelículas.Controls.Add(Me.Label15)
        Me.pestañaFichaPelículas.Controls.Add(Me.Label14)
        Me.pestañaFichaPelículas.Controls.Add(Me.Label13)
        Me.pestañaFichaPelículas.Controls.Add(Me.Label12)
        Me.pestañaFichaPelículas.Controls.Add(Me.Label11)
        Me.pestañaFichaPelículas.Controls.Add(Me.Label10)
        Me.pestañaFichaPelículas.Controls.Add(Me.Label9)
        Me.pestañaFichaPelículas.Controls.Add(Me.sinopsisFichaPeliculas)
        Me.pestañaFichaPelículas.Controls.Add(Me.duraciónFichaPeliculas)
        Me.pestañaFichaPelículas.Controls.Add(Me.listaFichaPeliculas)
        Me.pestañaFichaPelículas.Controls.Add(Me.listaGenerosFichaPeliculas)
        Me.pestañaFichaPelículas.Controls.Add(Me.imagenFichaPeliculas)
        Me.pestañaFichaPelículas.Controls.Add(Me.listaPersonasFichaPeliculas)
        Me.pestañaFichaPelículas.Controls.Add(Me.añoFichaPeliculas)
        Me.pestañaFichaPelículas.Controls.Add(Me.tituloOFichaPeliculas)
        Me.pestañaFichaPelículas.Controls.Add(Me.tituloFichaPeliculas)
        Me.pestañaFichaPelículas.Location = New System.Drawing.Point(4, 22)
        Me.pestañaFichaPelículas.Name = "pestañaFichaPelículas"
        Me.pestañaFichaPelículas.Size = New System.Drawing.Size(582, 334)
        Me.pestañaFichaPelículas.TabIndex = 5
        Me.pestañaFichaPelículas.Text = "Ficha Películas"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(451, 163)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(118, 13)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Personas de la película"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(483, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 13)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Géneros"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(290, 261)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 13)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Sinopsis"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(290, 195)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Duración"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(277, 142)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Año de estreno"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(277, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Título Original"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(290, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Título"
        '
        'sinopsisFichaPeliculas
        '
        Me.sinopsisFichaPeliculas.Location = New System.Drawing.Point(212, 277)
        Me.sinopsisFichaPeliculas.Multiline = True
        Me.sinopsisFichaPeliculas.Name = "sinopsisFichaPeliculas"
        Me.sinopsisFichaPeliculas.ReadOnly = True
        Me.sinopsisFichaPeliculas.Size = New System.Drawing.Size(209, 40)
        Me.sinopsisFichaPeliculas.TabIndex = 9
        '
        'duraciónFichaPeliculas
        '
        Me.duraciónFichaPeliculas.Location = New System.Drawing.Point(212, 221)
        Me.duraciónFichaPeliculas.Name = "duraciónFichaPeliculas"
        Me.duraciónFichaPeliculas.ReadOnly = True
        Me.duraciónFichaPeliculas.Size = New System.Drawing.Size(209, 20)
        Me.duraciónFichaPeliculas.TabIndex = 8
        '
        'listaFichaPeliculas
        '
        Me.listaFichaPeliculas.Enabled = False
        Me.listaFichaPeliculas.FormattingEnabled = True
        Me.listaFichaPeliculas.Location = New System.Drawing.Point(28, 34)
        Me.listaFichaPeliculas.Name = "listaFichaPeliculas"
        Me.listaFichaPeliculas.Size = New System.Drawing.Size(137, 21)
        Me.listaFichaPeliculas.TabIndex = 7
        '
        'listaGenerosFichaPeliculas
        '
        Me.listaGenerosFichaPeliculas.Enabled = False
        Me.listaGenerosFichaPeliculas.FormattingEnabled = True
        Me.listaGenerosFichaPeliculas.Location = New System.Drawing.Point(457, 34)
        Me.listaGenerosFichaPeliculas.Name = "listaGenerosFichaPeliculas"
        Me.listaGenerosFichaPeliculas.Size = New System.Drawing.Size(101, 121)
        Me.listaGenerosFichaPeliculas.TabIndex = 6
        '
        'imagenFichaPeliculas
        '
        Me.imagenFichaPeliculas.Location = New System.Drawing.Point(21, 142)
        Me.imagenFichaPeliculas.Name = "imagenFichaPeliculas"
        Me.imagenFichaPeliculas.Size = New System.Drawing.Size(144, 175)
        Me.imagenFichaPeliculas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imagenFichaPeliculas.TabIndex = 5
        Me.imagenFichaPeliculas.TabStop = False
        '
        'listaPersonasFichaPeliculas
        '
        Me.listaPersonasFichaPeliculas.Enabled = False
        Me.listaPersonasFichaPeliculas.FormattingEnabled = True
        Me.listaPersonasFichaPeliculas.Location = New System.Drawing.Point(456, 184)
        Me.listaPersonasFichaPeliculas.Name = "listaPersonasFichaPeliculas"
        Me.listaPersonasFichaPeliculas.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listaPersonasFichaPeliculas.Size = New System.Drawing.Size(102, 121)
        Me.listaPersonasFichaPeliculas.TabIndex = 4
        '
        'añoFichaPeliculas
        '
        Me.añoFichaPeliculas.Location = New System.Drawing.Point(212, 163)
        Me.añoFichaPeliculas.Name = "añoFichaPeliculas"
        Me.añoFichaPeliculas.ReadOnly = True
        Me.añoFichaPeliculas.Size = New System.Drawing.Size(209, 20)
        Me.añoFichaPeliculas.TabIndex = 3
        '
        'tituloOFichaPeliculas
        '
        Me.tituloOFichaPeliculas.Location = New System.Drawing.Point(212, 110)
        Me.tituloOFichaPeliculas.Name = "tituloOFichaPeliculas"
        Me.tituloOFichaPeliculas.ReadOnly = True
        Me.tituloOFichaPeliculas.Size = New System.Drawing.Size(209, 20)
        Me.tituloOFichaPeliculas.TabIndex = 2
        '
        'tituloFichaPeliculas
        '
        Me.tituloFichaPeliculas.Location = New System.Drawing.Point(212, 50)
        Me.tituloFichaPeliculas.Name = "tituloFichaPeliculas"
        Me.tituloFichaPeliculas.ReadOnly = True
        Me.tituloFichaPeliculas.Size = New System.Drawing.Size(209, 20)
        Me.tituloFichaPeliculas.TabIndex = 1
        '
        'botonConectar
        '
        Me.botonConectar.Enabled = False
        Me.botonConectar.Location = New System.Drawing.Point(21, 414)
        Me.botonConectar.Name = "botonConectar"
        Me.botonConectar.Size = New System.Drawing.Size(79, 23)
        Me.botonConectar.TabIndex = 1
        Me.botonConectar.Text = "Conectar"
        Me.botonConectar.UseVisualStyleBackColor = True
        '
        'botonRutaBD
        '
        Me.botonRutaBD.Location = New System.Drawing.Point(21, 373)
        Me.botonRutaBD.Name = "botonRutaBD"
        Me.botonRutaBD.Size = New System.Drawing.Size(78, 20)
        Me.botonRutaBD.TabIndex = 2
        Me.botonRutaBD.Text = "Ruta BD"
        Me.botonRutaBD.UseVisualStyleBackColor = True
        '
        'textoRuta
        '
        Me.textoRuta.Location = New System.Drawing.Point(121, 373)
        Me.textoRuta.Name = "textoRuta"
        Me.textoRuta.ReadOnly = True
        Me.textoRuta.Size = New System.Drawing.Size(407, 20)
        Me.textoRuta.TabIndex = 3
        '
        'textoConectado
        '
        Me.textoConectado.AutoSize = True
        Me.textoConectado.Location = New System.Drawing.Point(118, 419)
        Me.textoConectado.Name = "textoConectado"
        Me.textoConectado.Size = New System.Drawing.Size(40, 13)
        Me.textoConectado.TabIndex = 4
        Me.textoConectado.Text = "Estado"
        Me.textoConectado.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 449)
        Me.Controls.Add(Me.textoConectado)
        Me.Controls.Add(Me.textoRuta)
        Me.Controls.Add(Me.botonRutaBD)
        Me.Controls.Add(Me.botonConectar)
        Me.Controls.Add(Me.pestañasPrincipal)
        Me.Name = "Form1"
        Me.Text = "IMBD"
        Me.pestañasPrincipal.ResumeLayout(False)
        Me.pestañaPersonas.ResumeLayout(False)
        Me.pestañaPersonas.PerformLayout()
        CType(Me.imagenPersona, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pestañaPelículas.ResumeLayout(False)
        Me.pestañaPelículas.PerformLayout()
        CType(Me.imagenPelicula, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pestañaRoles.ResumeLayout(False)
        Me.pestañaRoles.PerformLayout()
        Me.pestañaGeneros.ResumeLayout(False)
        Me.pestañaGeneros.PerformLayout()
        Me.pestañaParticipantes.ResumeLayout(False)
        Me.pestañaParticipantes.PerformLayout()
        Me.pestañaGénerosPeliculas.ResumeLayout(False)
        Me.pestañaGénerosPeliculas.PerformLayout()
        Me.pestañaFichaActores.ResumeLayout(False)
        Me.pestañaFichaActores.PerformLayout()
        CType(Me.imagenFichaActores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pestañaFichaPelículas.ResumeLayout(False)
        Me.pestañaFichaPelículas.PerformLayout()
        CType(Me.imagenFichaPeliculas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pestañasPrincipal As TabControl
    Friend WithEvents pestañaPersonas As TabPage
    Friend WithEvents pestañaPelículas As TabPage
    Friend WithEvents pestañaRoles As TabPage
    Friend WithEvents pestañaGeneros As TabPage
    Friend WithEvents añadirPersona As Button
    Friend WithEvents eliminarPersona As Button
    Friend WithEvents modificarPersona As Button
    Friend WithEvents eliminarPelicula As Button
    Friend WithEvents modificarPelicula As Button
    Friend WithEvents añadirPelicula As Button
    Friend WithEvents botonConectar As Button
    Friend WithEvents botonRutaBD As Button
    Friend WithEvents eliminarRol As Button
    Friend WithEvents modificarRol As Button
    Friend WithEvents añadirRol As Button
    Friend WithEvents eliminarGenero As Button
    Friend WithEvents modificarGenero As Button
    Friend WithEvents añadirGenero As Button
    Friend WithEvents textoRuta As TextBox
    Friend WithEvents textoConectado As Label
    Friend WithEvents pestañaFichaActores As TabPage
    Friend WithEvents pestañaFichaPelículas As TabPage
    Friend WithEvents listaPersonas As ListBox
    Friend WithEvents limpiarPersonas As Button
    Friend WithEvents listaPeliculas As ListBox
    Friend WithEvents limpiarPeliculas As Button
    Friend WithEvents listaRoles As ListBox
    Friend WithEvents limpiarRoles As Button
    Friend WithEvents listaGeneros As ListBox
    Friend WithEvents limpiarGeneros As Button
    Friend WithEvents textoPais As Label
    Friend WithEvents textoCiudad As Label
    Friend WithEvents textoFecha As Label
    Friend WithEvents textoNacionalidad As Label
    Friend WithEvents textoApellido As Label
    Friend WithEvents textoNombre As Label
    Friend WithEvents mostrarPais As TextBox
    Friend WithEvents mostrarCiudad As TextBox
    Friend WithEvents mostrarFecha As TextBox
    Friend WithEvents mostrarNacionalidad As TextBox
    Friend WithEvents mostrarApellido As TextBox
    Friend WithEvents mostrarNombre As TextBox
    Friend WithEvents textoSinopsis As Label
    Friend WithEvents textoDuración As Label
    Friend WithEvents textoAño As Label
    Friend WithEvents textoTituloOriginal As Label
    Friend WithEvents textoTitulo As Label
    Friend WithEvents mostrarSinopsis As TextBox
    Friend WithEvents mostrarDuración As TextBox
    Friend WithEvents mostrarAño As TextBox
    Friend WithEvents mostrarTituloOriginal As TextBox
    Friend WithEvents mostrarTitulo As TextBox
    Friend WithEvents textoDescrRol As Label
    Friend WithEvents mostrarDescrRol As TextBox
    Friend WithEvents textoDescrGenero As Label
    Friend WithEvents mostrarDescrGenero As TextBox
    Friend WithEvents pestañaParticipantes As TabPage
    Friend WithEvents seleccionarRol As ComboBox
    Friend WithEvents seleccionarPelicula As ComboBox
    Friend WithEvents seleccionarPersona As ComboBox
    Friend WithEvents añadirParticipante As Button
    Friend WithEvents pestañaGénerosPeliculas As TabPage
    Friend WithEvents textoRol As Label
    Friend WithEvents textoPelícula As Label
    Friend WithEvents textoActor As Label
    Friend WithEvents textoPeliGen As Label
    Friend WithEvents seleccionarGenero As ComboBox
    Friend WithEvents seleccionarPeliGen As ComboBox
    Friend WithEvents añadirPeliGen As Button
    Friend WithEvents textoGénero As Label
    Friend WithEvents listaPersonasFichaPeliculas As ListBox
    Friend WithEvents añoFichaPeliculas As TextBox
    Friend WithEvents tituloOFichaPeliculas As TextBox
    Friend WithEvents tituloFichaPeliculas As TextBox
    Friend WithEvents imagenFichaPeliculas As PictureBox
    Friend WithEvents rutaImagenPersona As TextBox
    Friend WithEvents botonImagenPersona As Button
    Friend WithEvents imagenPersona As PictureBox
    Friend WithEvents botonImagenPelicula As Button
    Friend WithEvents imagenPelicula As PictureBox
    Friend WithEvents rutaImagenPelicula As TextBox
    Friend WithEvents listaGenerosFichaPeliculas As ListBox
    Friend WithEvents listaFichaPeliculas As ComboBox
    Friend WithEvents imagenFichaActores As PictureBox
    Friend WithEvents rolFichaActores As ListBox
    Friend WithEvents peliculaFichaActores As ListBox
    Friend WithEvents fechaFichaActores As TextBox
    Friend WithEvents apellidoFichaActores As TextBox
    Friend WithEvents nombreFichaActores As TextBox
    Friend WithEvents listaActoresFichaActores As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nacionalidadFichaActores As TextBox
    Friend WithEvents ciudadFichaActores As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents sinopsisFichaPeliculas As TextBox
    Friend WithEvents duraciónFichaPeliculas As TextBox
    Friend WithEvents eliminarParticipante As Button
    Friend WithEvents eliminarPeliGen As Button
End Class
