Imports System.IO
Imports Dominio
Imports Persistencia



Public Class Form1

    Dim gPersona As gestorPersona = New gestorPersona
    Dim gPelicula As gestorPelicula = New gestorPelicula
    Dim gRol As gestorRoles = New gestorRoles
    Dim gGenero As gestorGeneros = New gestorGeneros
    Dim gPeliGen As gestorPeliGen = New gestorPeliGen
    Dim gParticipa As gestorParticipa = New gestorParticipa
    Dim participa As Participa = New Participa
    Dim peligen As PeliGen = New PeliGen
    Dim p As Persona = New Persona
    Dim pl As Pelicula = New Pelicula
    Dim r As Rol = New Rol
    Dim gen As Genero = New Genero

    ' ---------- CARGA INICIAL DEL PROGRAMA -----------

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' ---------- CARGA DE LA BASE DE DATOS -----------

    Private Sub botonRutaBD_Click(sender As Object, e As EventArgs) Handles botonRutaBD.Click
        Dim abrirBD As OpenFileDialog = New OpenFileDialog
        abrirBD.Filter = "Base de datos de Access | *.accdb"

        If abrirBD.ShowDialog = DialogResult.OK Then
            textoRuta.Text = abrirBD.FileName
            botonConectar.Enabled = True
        End If
    End Sub

    Private Sub botonConectar_Click(sender As Object, e As EventArgs) Handles botonConectar.Click

        If ((String.Equals(UCase(Path.GetFileName(textoRuta.Text)), UCase("imdb.accdb"))) = False And ((String.Equals(UCase(Path.GetFileName(textoRuta.Text)), UCase("imdb"))) = False)) Then
            MsgBox("Sólo se acepta la BD de IMDB cuyo nombre debe ser 'IMDB' o 'imdb'. Vuelva a intentarlo.", MsgBoxStyle.Information)
            Exit Sub
        End If

        Try

            AgenteDB._rutaBD = textoRuta.Text

            recargaDatos()

            textoConectado.Text = "¡Conectado!"
            textoConectado.ForeColor = Color.Green
            textoConectado.Show()

            activarControles()
            botonConectar.Enabled = False

        Catch ex As Exception

            MsgBox("Error en la conexión con la BBDD", MsgBoxStyle.Critical)
            textoConectado.Text = "¡Error!"
            textoConectado.ForeColor = Color.Red
            textoConectado.Show()

        End Try
    End Sub

    ' ---------- AÑADIR ELEMENTOS A LA BASE DE DATOS -----------

    Private Sub añadirPersona_Click(sender As Object, e As EventArgs) Handles añadirPersona.Click

        If (mostrarFecha.Text <> "") Then
            If (IsDate(Replace(mostrarFecha.Text, "-", "/")) = False) Then
                MsgBox("El formato para la fecha debe ser 'DD/MM/AAAA'")
                Exit Sub
            End If
        End If


        Dim imagen As String = Path.GetFileName(rutaImagenPersona.Text)

        Dim p As Persona = New Persona(mostrarNombre.Text, mostrarApellido.Text, mostrarNacionalidad.Text, Replace(mostrarFecha.Text, "-", "/"), mostrarCiudad.Text, mostrarPais.Text, imagen)

        p.insertar(gPersona)
        recargaDatos()
    End Sub

    Private Sub añadirPelicula_Click(sender As Object, e As EventArgs) Handles añadirPelicula.Click

        If ((comprobarNumeros(mostrarAño.Text) = False) Or comprobarNumeros(mostrarDuración.Text) = False) Then
            MsgBox("El año y la duración deben ser números enteros positivos.", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim imagen As String = Path.GetFileName(rutaImagenPelicula.Text)

        Dim p As Pelicula = New Pelicula(mostrarTitulo.Text, mostrarTituloOriginal.Text, mostrarAño.Text, mostrarDuración.Text, mostrarSinopsis.Text, imagen)
        p.insertar(gPelicula)
        recargaDatos()
    End Sub

    Private Sub añadirParticipante_Click(sender As Object, e As EventArgs) Handles añadirParticipante.Click
        Dim participante As Participa = New Participa(seleccionarPersona.SelectedValue._idPersona, seleccionarPelicula.SelectedValue._idPelicula, seleccionarRol.SelectedValue._idRol)
        participante.insertar(gParticipa)
        recargaDatos()
    End Sub

    Private Sub añadirPeliGen_Click(sender As Object, e As EventArgs) Handles añadirPeliGen.Click
        Dim peliGen As PeliGen = New PeliGen(seleccionarPeliGen.SelectedValue._idPelicula, seleccionarGenero.SelectedValue._idGenero)
        peliGen.insertar(gPeliGen)
        recargaDatos()
    End Sub

    Private Sub añadirGenero_Click(sender As Object, e As EventArgs) Handles añadirGenero.Click
        Dim genero As Genero = New Genero(mostrarDescrGenero.Text)
        genero.insertar(gGenero)
        recargaDatos()
    End Sub

    Private Sub añadirRol_Click(sender As Object, e As EventArgs) Handles añadirRol.Click
        Dim rol As Rol = New Rol(mostrarDescrRol.Text)
        rol.insertar(gRol)
        recargaDatos()
    End Sub

    ' ---------- MODIFICAR ELEMENTOS EN LA BASE DE DATOS -----------

    Private Sub modificarPersona_Click(sender As Object, e As EventArgs) Handles modificarPersona.Click

        Dim id As Integer = listaPersonas.SelectedItem._idPersona

        If (mostrarFecha.Text <> "") Then
            If (IsDate(Replace(mostrarFecha.Text, "-", "/")) = False) Then
                MsgBox("El formato para la fecha debe ser 'DD/MM/AAAA'")
                Exit Sub
            End If
        End If

        Dim imagen As String = Path.GetFileName(rutaImagenPersona.Text)

        Dim p As Persona = New Persona(mostrarNombre.Text, mostrarApellido.Text, mostrarNacionalidad.Text, Replace(mostrarFecha.Text, "-", "/"), mostrarCiudad.Text, mostrarPais.Text, imagen)
        p._idPersona = id
        p.modificar(gPersona)
        recargaDatos()
    End Sub

    Private Sub modificarPelicula_Click(sender As Object, e As EventArgs) Handles modificarPelicula.Click

        Dim id As Integer = listaPeliculas.SelectedItem._idPelicula

        If ((comprobarNumeros(mostrarAño.Text) = False) Or comprobarNumeros(mostrarDuración.Text) = False) Then
            MsgBox("El año y la duración deben ser números enteros positivos.", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim imagen As String = Path.GetFileName(rutaImagenPelicula.Text)

        Dim pl As Pelicula = New Pelicula(mostrarTitulo.Text, mostrarTituloOriginal.Text, mostrarAño.Text, mostrarDuración.Text, mostrarSinopsis.Text, imagen)

        pl._idPelicula = id
        pl.modificar(gPelicula)
        recargaDatos()

    End Sub

    Private Sub modificarRol_Click(sender As Object, e As EventArgs) Handles modificarRol.Click
        Dim id As Integer = listaRoles.SelectedItem._idRol

        Dim r As Rol = New Rol(mostrarDescrRol.Text)
        r._idRol = id
        r.modificar(gRol)
        recargaDatos()
    End Sub

    Private Sub modificarGenero_Click(sender As Object, e As EventArgs) Handles modificarGenero.Click
        Dim id As Integer = listaGeneros.SelectedItem._idRol

        Dim g As Genero = New Genero(mostrarDescrGenero.Text)
        g._idGenero = id
        g.modificar(gGenero)
        recargaDatos()
    End Sub

    ' ---------- ELIMINAR ELEMENTOS DE LA BASE DE DATOS -----------

    Private Sub eliminarPersona_Click(sender As Object, e As EventArgs) Handles eliminarPersona.Click

        Dim p As Persona = New Persona
        p._idPersona = listaPersonas.SelectedItem._idPersona
        p.eliminar(gPersona)
        recargaDatos()

    End Sub

    Private Sub eliminarPelicula_Click(sender As Object, e As EventArgs) Handles eliminarPelicula.Click

        Dim p As Pelicula = New Pelicula
        p._idPelicula = listaPeliculas.SelectedItem._idPelicula
        p.eliminar(gPelicula)
        recargaDatos()

    End Sub

    Private Sub eliminarRol_Click(sender As Object, e As EventArgs) Handles eliminarRol.Click

        Dim r As Rol = New Rol
        r._idRol = listaRoles.SelectedItem._idRol
        r.eliminar(gRol)
        recargaDatos()

    End Sub

    Private Sub eliminarGenero_Click(sender As Object, e As EventArgs) Handles eliminarGenero.Click

        Dim g As Genero = New Genero
        g._idGenero = listaGeneros.SelectedItem._idGenero
        g.eliminar(gGenero)
        recargaDatos()

    End Sub

    Private Sub eliminarParticipante_Click(sender As Object, e As EventArgs) Handles eliminarParticipante.Click

        If (seleccionarPersona.Text = "" Or seleccionarPelicula.Text = "" Or seleccionarRol.Text = "") Then
            MsgBox("Ningún campo puede estar vacío para que dicho participante pueda eliminarse.", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim participante As Participa = New Participa(seleccionarPersona.SelectedValue._idPersona, seleccionarPelicula.SelectedValue._idPelicula, seleccionarRol.SelectedValue._idRol)
        participante.eliminar(gParticipa)
        recargaDatos()
    End Sub

    Private Sub eliminarPeliGen_Click(sender As Object, e As EventArgs) Handles eliminarPeliGen.Click
        If (seleccionarPeliGen.Text = "" Or seleccionarGenero.Text = "") Then
            MsgBox("Ningún campo puede estar vacío para que dicha película y género puedan eliminarse.", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim peliGen As PeliGen = New PeliGen(seleccionarPeliGen.SelectedValue._idPelicula, seleccionarGenero.SelectedValue._idGenero)
        peliGen.eliminar(gPeliGen)
        recargaDatos()
    End Sub

    ' ---------- LIMPIAR CUADROS DE TEXTO -----------

    Private Sub limpiarPersonas_Click(sender As Object, e As EventArgs) Handles limpiarPersonas.Click
        mostrarNombre.Clear()
        mostrarApellido.Clear()
        mostrarNacionalidad.Clear()
        mostrarFecha.Clear()
        mostrarCiudad.Clear()
        mostrarPais.Clear()
        rutaImagenPersona.Clear()
        imagenPersona.Image = Nothing
    End Sub

    Private Sub limpiarPeliculas_Click(sender As Object, e As EventArgs) Handles limpiarPeliculas.Click
        mostrarTitulo.Clear()
        mostrarTituloOriginal.Clear()
        mostrarSinopsis.Clear()
        mostrarAño.Clear()
        mostrarDuración.Clear()
        rutaImagenPelicula.Clear()
        imagenPelicula.Image = Nothing
    End Sub

    Private Sub limpiarRoles_Click(sender As Object, e As EventArgs) Handles limpiarRoles.Click
        mostrarDescrRol.Clear()
    End Sub

    Private Sub limpiarGeneros_Click(sender As Object, e As EventArgs) Handles limpiarGeneros.Click
        mostrarDescrGenero.Clear()
    End Sub

    ' ---------- FUNCIONES DE CAMBIO DE ELEMENTO SELECCIONADO EN LISTBOX Y COMBOBOX -----------

    Private Sub listaPersonas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listaPersonas.SelectedIndexChanged
        mostrarNombre.Text = listaPersonas.SelectedValue._nombre
        mostrarApellido.Text = listaPersonas.SelectedValue._apellido
        mostrarNacionalidad.Text = listaPersonas.SelectedValue._nacionalidad
        mostrarFecha.Text = listaPersonas.SelectedValue._fechaNacimiento
        mostrarCiudad.Text = listaPersonas.SelectedValue._ciudadNacimiento
        mostrarPais.Text = listaPersonas.SelectedValue._paisNacimiento
        rutaImagenPersona.Text = listaPersonas.SelectedValue._fotoPersona
        Try
            If (listaPersonas.SelectedValue._fotoPersona = "") Then
                imagenPersona.Image = Nothing
            Else
                If (Path.GetFileName(textoRuta.Text).Length = 4) Then
                    Dim ruta As String = textoRuta.Text.Substring(0, textoRuta.Text.Length - 4)
                    imagenPersona.Image = Image.FromFile(ruta & listaPersonas.SelectedValue._fotoPersona)
                ElseIf (Path.GetFileName(textoRuta.Text).Length = 10) Then
                    Dim ruta As String = textoRuta.Text.Substring(0, textoRuta.Text.Length - 10)
                    imagenPersona.Image = Image.FromFile(ruta & listaPersonas.SelectedValue._fotoPersona)
                End If

            End If
        Catch fnf As FileNotFoundException
            MsgBox("Error en la carga de la imagen de la persona. Es probable que la ruta o el archivo no sean correctos.", MsgBoxStyle.Critical)
            imagenPersona.Image = Nothing
        End Try
    End Sub

    Private Sub listaPeliculas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listaPeliculas.SelectedIndexChanged

        mostrarTitulo.Text = listaPeliculas.SelectedValue._titulo
        mostrarTituloOriginal.Text = listaPeliculas.SelectedValue._tituloOriginal
        mostrarAño.Text = listaPeliculas.SelectedValue._añoEstreno
        mostrarDuración.Text = listaPeliculas.SelectedValue._duracion
        mostrarSinopsis.Text = listaPeliculas.SelectedValue._sinopsis
        rutaImagenPelicula.Text = listaPeliculas.SelectedValue._cartel

        Try
            If (listaPeliculas.SelectedItem._cartel = "") Then
                imagenPelicula.Image = Nothing
            Else
                If (Path.GetFileName(textoRuta.Text).Length = 4) Then
                    Dim ruta As String = textoRuta.Text.Substring(0, textoRuta.Text.Length - 4)
                    imagenPelicula.Image = Image.FromFile(ruta & listaPeliculas.SelectedValue._cartel)
                ElseIf (Path.GetFileName(textoRuta.Text).Length = 10) Then
                    Dim ruta As String = textoRuta.Text.Substring(0, textoRuta.Text.Length - 10)
                    imagenPelicula.Image = Image.FromFile(ruta & listaPeliculas.SelectedValue._cartel)
                End If

            End If
        Catch fnf As FileNotFoundException
            MsgBox("Error en la carga de la imagen de la pelicula. Es probable que la ruta o el archivo no sean correctos.", MsgBoxStyle.Critical)
            imagenPelicula.Image = Nothing
        End Try

    End Sub

    Private Sub listaRoles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listaRoles.SelectedIndexChanged
        mostrarDescrRol.Text = listaRoles.SelectedValue._descripcion
    End Sub

    Private Sub listaGeneros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listaGeneros.SelectedIndexChanged
        mostrarDescrGenero.Text = listaGeneros.SelectedValue._descripcion
    End Sub

    Private Sub listaActoresFichaActores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listaActoresFichaActores.SelectedIndexChanged
        peliculaFichaActores.Items.Clear()
        rolFichaActores.Items.Clear()
        gParticipa.mListaPeliculasP = New Collection
        gParticipa.mListaRolP = New Collection

        participa = New Participa(listaActoresFichaActores.SelectedValue._idPersona, Nothing, Nothing)

        participa.leerParticipa(gParticipa)

        nombreFichaActores.Text = listaActoresFichaActores.SelectedValue._nombre
        apellidoFichaActores.Text = listaActoresFichaActores.SelectedValue._apellido
        fechaFichaActores.Text = listaActoresFichaActores.SelectedValue._fechaNacimiento
        nacionalidadFichaActores.Text = listaActoresFichaActores.SelectedValue._nacionalidad
        ciudadFichaActores.Text = listaActoresFichaActores.SelectedValue._ciudadNacimiento

        For i As Integer = 1 To gParticipa.mListaPeliculasP.Count
            peliculaFichaActores.Items.Add(gParticipa.mListaPeliculasP.Item(i))
        Next

        For i As Integer = 1 To gParticipa.mListaRolP.Count
            rolFichaActores.Items.Add(gParticipa.mListaRolP.Item(i))
        Next

        Try
            If (listaActoresFichaActores.SelectedValue._fotoPersona = "") Then
                imagenFichaActores.Image = Nothing
            Else
                If (Path.GetFileName(textoRuta.Text).Length = 4) Then
                    Dim ruta As String = textoRuta.Text.Substring(0, textoRuta.Text.Length - 4)
                    imagenFichaActores.Image = Image.FromFile(ruta & listaActoresFichaActores.SelectedValue._fotoPersona)
                ElseIf (Path.GetFileName(textoRuta.Text).Length = 10) Then
                    Dim ruta As String = textoRuta.Text.Substring(0, textoRuta.Text.Length - 10)
                    imagenFichaActores.Image = Image.FromFile(ruta & listaActoresFichaActores.SelectedValue._fotoPersona)
                End If
            End If
        Catch fnf As FileNotFoundException
            MsgBox("Error en la carga de la imagen de la persona dentro de su ficha. Es probable que la ruta o el archivo no sean correctos.", MsgBoxStyle.Critical)
            imagenPersona.Image = Nothing
        End Try

    End Sub

    Private Sub listaFichaPeliculas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listaFichaPeliculas.SelectedIndexChanged
        listaGenerosFichaPeliculas.Items.Clear()
        listaPersonasFichaPeliculas.Items.Clear()
        gPeliGen.mListaGenerosPG = New Collection
        gPeliGen.mListaPersonasPG = New Collection

        peligen = New PeliGen(listaFichaPeliculas.SelectedValue._idPelicula, Nothing)

        peligen.leerPeliGen(gPeliGen)

        tituloFichaPeliculas.Text = listaFichaPeliculas.SelectedValue._titulo
        tituloOFichaPeliculas.Text = listaFichaPeliculas.SelectedValue._tituloOriginal
        añoFichaPeliculas.Text = listaFichaPeliculas.SelectedValue._añoEstreno
        duraciónFichaPeliculas.Text = listaFichaPeliculas.SelectedValue._duracion
        sinopsisFichaPeliculas.Text = listaFichaPeliculas.SelectedValue._sinopsis

        For i As Integer = 1 To gPeliGen.mListaPersonasPG.Count
            listaPersonasFichaPeliculas.Items.Add(gPeliGen.mListaPersonasPG.Item(i))
        Next

        For i As Integer = 1 To gPeliGen.mListaGenerosPG.Count
            listaGenerosFichaPeliculas.Items.Add(gPeliGen.mListaGenerosPG.Item(i))
        Next

        Try
            If (listaFichaPeliculas.SelectedValue._cartel = "") Then
                imagenFichaPeliculas.Image = Nothing
            Else
                If (Path.GetFileName(textoRuta.Text).Length = 4) Then
                    Dim ruta As String = textoRuta.Text.Substring(0, textoRuta.Text.Length - 4)
                    imagenFichaPeliculas.Image = Image.FromFile(ruta & listaFichaPeliculas.SelectedValue._cartel)
                ElseIf (Path.GetFileName(textoRuta.Text).Length = 10) Then
                    Dim ruta As String = textoRuta.Text.Substring(0, textoRuta.Text.Length - 10)
                    imagenFichaPeliculas.Image = Image.FromFile(ruta & listaFichaPeliculas.SelectedValue._cartel)
                End If
            End If
        Catch fnf As FileNotFoundException
            MsgBox("Error en la carga de la imagen de la película dentro de su ficha. Es probable que la ruta o el archivo no sean correctos.", MsgBoxStyle.Critical)
            imagenFichaPeliculas.Image = Nothing
        End Try

    End Sub

    ' ---------- BOTONES PARA LA CARGA DE IMÁGENES -----------

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles botonImagenPersona.Click
        Dim abrirImagen As OpenFileDialog = New OpenFileDialog
        abrirImagen.Filter = "Imagen (JPG, JPEG, PNG, BMP)|*.jpg;*.png;*.bmp;*.jpeg"

        If abrirImagen.ShowDialog = DialogResult.OK Then
            rutaImagenPersona.Text = abrirImagen.FileName
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles botonImagenPelicula.Click
        Dim abrirImagen As OpenFileDialog = New OpenFileDialog
        abrirImagen.Filter = "Imagen (JPG, JPEG, PNG, BMP)|*.jpg;*.png;*.bmp;*.jpeg"

        If abrirImagen.ShowDialog = DialogResult.OK Then
            rutaImagenPelicula.Text = abrirImagen.FileName
        End If
    End Sub

    ' ---------- MÉTODOS AUXILIARES -----------

    Private Sub activarControles()
        añadirParticipante.Enabled = True
        añadirPeliGen.Enabled = True
        añadirGenero.Enabled = True
        añadirPelicula.Enabled = True
        añadirPersona.Enabled = True
        añadirRol.Enabled = True

        modificarGenero.Enabled = True
        modificarPelicula.Enabled = True
        modificarPersona.Enabled = True
        modificarRol.Enabled = True

        eliminarGenero.Enabled = True
        eliminarPelicula.Enabled = True
        eliminarPersona.Enabled = True
        eliminarRol.Enabled = True
        eliminarParticipante.Enabled = True
        eliminarPeliGen.Enabled = True

        mostrarApellido.Enabled = True
        mostrarAño.Enabled = True
        mostrarCiudad.Enabled = True
        mostrarDescrGenero.Enabled = True
        mostrarDescrRol.Enabled = True
        mostrarDuración.Enabled = True
        mostrarFecha.Enabled = True
        mostrarNacionalidad.Enabled = True
        mostrarNombre.Enabled = True
        mostrarPais.Enabled = True
        mostrarSinopsis.Enabled = True
        mostrarTitulo.Enabled = True
        mostrarTituloOriginal.Enabled = True
        rutaImagenPelicula.Enabled = True
        rutaImagenPersona.Enabled = True

        limpiarGeneros.Enabled = True
        limpiarPeliculas.Enabled = True
        limpiarPersonas.Enabled = True
        limpiarRoles.Enabled = True

        botonImagenPersona.Enabled = True
        botonImagenPelicula.Enabled = True

        listaActoresFichaActores.Enabled = True
        listaFichaPeliculas.Enabled = True
        seleccionarGenero.Enabled = True
        seleccionarPelicula.Enabled = True
        seleccionarPeliGen.Enabled = True
        seleccionarRol.Enabled = True
        seleccionarPersona.Enabled = True
    End Sub

    Private Sub recargaDatos()

        gPersona.mListaPersonas = New Collection
        gPelicula.mListaPeliculas = New Collection
        gRol.mListaRol = New Collection
        gGenero.mListaGeneros = New Collection
        gParticipa.mlistaParticipa = New Collection
        gParticipa.mListaPeliculasP = New Collection
        gParticipa.mListaRolP = New Collection
        gPeliGen.mlistaPeliGen = New Collection
        gPeliGen.mListaPersonasPG = New Collection
        gPeliGen.mListaGenerosPG = New Collection

        p.leerTodos(gPersona)
        pl.leerTodos(gPelicula)
        r.leerTodos(gRol)
        gen.leerTodos(gGenero)
        participa.leerTodos(gParticipa)
        peligen.leerTodos(gPeliGen)

        BindingContext(gPersona.mListaPersonas).EndCurrentEdit()
        BindingContext(gPelicula.mListaPeliculas).EndCurrentEdit()
        BindingContext(gGenero.mListaGeneros).EndCurrentEdit()
        BindingContext(gRol.mListaRol).EndCurrentEdit()

        listaPersonas.DataSource = gPersona.mListaPersonas
        listaPeliculas.DataSource = gPelicula.mListaPeliculas
        listaGeneros.DataSource = gGenero.mListaGeneros
        listaRoles.DataSource = gRol.mListaRol

        seleccionarPersona.DataSource = gPersona.mListaPersonas
        seleccionarPelicula.DataSource = gPelicula.mListaPeliculas
        seleccionarRol.DataSource = gRol.mListaRol
        seleccionarPeliGen.DataSource = gPelicula.mListaPeliculas
        seleccionarGenero.DataSource = gGenero.mListaGeneros

        listaActoresFichaActores.DataSource = gPersona.mListaPersonas
        listaFichaPeliculas.DataSource = gPelicula.mListaPeliculas

    End Sub

    Private Function comprobarNumeros(num As String) As Boolean

        If (num = "") Then
            Return True
        ElseIf (num.Chars(0) = "-") Then
            Return False
        Else
            Return Integer.TryParse(num, 0)
        End If

    End Function

End Class
