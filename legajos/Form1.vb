'El objetivo es crear una aplicación de escritorio sencilla que permita gestionar un legajo de personal, guardando los datos en un archivo de texto plano y almacenando la ruta de la foto asociada.
Imports System.IO

Public Class Form1
    'creo un procedimiento para que lea los datos de un archivo de texto y los muestre en el lviLegajos
    Sub CargarLegajos()
        'limpio la lista de items
        LviLegajos.Items.Clear()

        'si el archivo no existe, salgo del procedimiento
        If Not File.Exists("datos\legajos.txt") Then
            Return
        End If
        'si el archivo existe, lo abro y leo los datos
        Dim sr As New StreamReader("datos\legajos.txt")
        Do While Not sr.EndOfStream
            Dim linea As String = sr.ReadLine()
            Dim partes() As String = linea.Split(",")
            Dim item As New ListViewItem(partes(0))
            item.SubItems.Add(partes(1))
            item.SubItems.Add(partes(2))
            item.SubItems.Add(partes(3))
            item.SubItems.Add(partes(4))
            LviLegajos.Items.Add(item)
        Loop
        sr.Close()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenFileDialog1.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp"
        '`c:\imagenes\` es la carpeta inicial para el openfiledialog
        OpenFileDialog1.InitialDirectory = "c:\imagenes\"
        CargarLegajos()



    End Sub

    Private Sub BtnCargarImagen_Click(sender As Object, e As EventArgs) Handles BtnCargarImagen.Click
        'Abrir el cuadro de diálogo para seleccionar la imagen, y si se selecciona una, mostrarla en el PictureBox y poner la ruta en el label correspondiente
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PbxImagen.Image = Image.FromFile(OpenFileDialog1.FileName)
            'hago una copia de la imagen en la carpeta img del proyecto, si la carpeta no existe la creo
            If Not Directory.Exists("img") Then
                Directory.CreateDirectory("img")
            End If
            Dim rutaDestino As String = "img\" & Path.GetFileName(OpenFileDialog1.FileName)
            File.Copy(OpenFileDialog1.FileName, rutaDestino, True)
            LBLRutaImagen.Text = rutaDestino
        End If

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        ' valido que los campos no estén vacíos
        If TxtNombre.Text = "" Or TxtApellido.Text = "" Or TxtDni.Text = "" Or CmbSector.SelectedIndex = -1 Or LBLRutaImagen.Text = "" Then
            MessageBox.Show("Debe completar todos los campos")
            Return
        End If

        'Guardo los datos en un archivo de texto plano separado por comas en la carpeta datos del proyecto, si no existen los creo
        If Not Directory.Exists("datos") Then
            Directory.CreateDirectory("datos")
        End If
        Dim rutaArchivo As String = "datos\legajos.txt"
        Dim sw As New StreamWriter(rutaArchivo, True)
        sw.WriteLine(TxtNombre.Text & "," & TxtApellido.Text & "," & TxtDni.Text & "," & CmbSector.Text & "," & LBLRutaImagen.Text)
        sw.Close()
        MessageBox.Show("Datos guardados correctamente")
        CargarLegajos()


    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub LviLegajos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LviLegajos.SelectedIndexChanged
        'si no hay items seleccionados, salgo del procedimiento
        If LviLegajos.SelectedItems.Count = 0 Then
            Return
        End If
        'si hay seleccionado muestro la imagen en el picturebox, con la ruta que está en el item seleccionado
        Dim rutaImagen As String = LviLegajos.SelectedItems(0).SubItems(4).Text
        PbImagenListados.Image = Image.FromFile(rutaImagen)
        LblSector.Text = LviLegajos.SelectedItems(0).SubItems(3).Text
        LblDatos.Text = LviLegajos.SelectedItems(0).SubItems(0).Text & " " & LviLegajos.SelectedItems(0).SubItems(1).Text & " - DNI: " & LviLegajos.SelectedItems(0).SubItems(2).Text

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        LimpiarFormulario()

    End Sub

    Private Sub LimpiarFormulario()
        'limpio los controles del formulario
        TxtNombre.Clear()
        TxtApellido.Clear()
        TxtDni.Clear()
        CmbSector.SelectedIndex = -1
        LBLRutaImagen.Text = ""
        PbxImagen.Image = Nothing

    End Sub
End Class
