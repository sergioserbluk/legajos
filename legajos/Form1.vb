'El objetivo es crear una aplicación de escritorio sencilla que permita gestionar un legajo de personal, guardando los datos en un archivo de texto plano y almacenando la ruta de la foto asociada.
Imports System.IO

Public Class Form1
    'creo un procedimiento para que lea los datos de un archivo de texto y los muestre en el lviLegajos
    Sub CargarLegajos()
        'limpio la lista de items
        LviLegajos.Items.Clear()
        ListView1.Items.Clear()
        ListView2.Items.Clear()
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
            ListView1.Items.Add(item.Clone) 'clono el item para mostrarlo en el listview1, si no clono el item, se moverá de un listview a otro
            ListView2.Items.Add(item.Clone) 'clono el item para mostrarlo en el listview2, si no clono el item, se moverá de un listview a otro
        Loop
        sr.Close()
    End Sub
    Sub LimpiarFormulario()
        'limpio los controles del formulario
        TxtNombre.Clear()
        TxtApellido.Clear()
        TxtDni.Clear()
        CmbSector.SelectedIndex = -1
        LBLRutaImagen.Text = ""
        PbxImagen.Image = Nothing

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
        LimpiarFormulario()

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

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        'muestro los datos del empleado seleccionado en los textbox y combobox y la imagen en el picture box
        If ListView1.SelectedItems.Count = 0 Then
            Return
        End If
        TxtNombreM.Text = ListView1.SelectedItems(0).SubItems(0).Text
        TxtApellidoM.Text = ListView1.SelectedItems(0).SubItems(1).Text
        TxtDniM.Text = ListView1.SelectedItems(0).SubItems(2).Text
        CmbSectorM.Text = ListView1.SelectedItems(0).SubItems(3).Text
        PbxImagenM.Image = Image.FromFile(ListView1.SelectedItems(0).SubItems(4).Text)
        LBLRutaImagenM.Text = ListView1.SelectedItems(0).SubItems(4).Text

    End Sub

    Private Sub ListView2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView2.SelectedIndexChanged
        'muestro los datos del empleado seleccionado en los textbox y combobox y la imagen en el picture box
        If ListView2.SelectedItems.Count = 0 Then
            Return
        End If
        TxtNombreE.Text = ListView2.SelectedItems(0).SubItems(0).Text
        TxtApellidoE.Text = ListView2.SelectedItems(0).SubItems(1).Text
        TxtDniE.Text = ListView2.SelectedItems(0).SubItems(2).Text
        CmbSectorE.Text = ListView2.SelectedItems(0).SubItems(3).Text
        PbxImagenE.Image = Image.FromFile(ListView2.SelectedItems(0).SubItems(4).Text)
        LBLRutaImagenE.Text = ListView2.SelectedItems(0).SubItems(4).Text

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'abro el cuadro de diálogo para seleccionar la imagen y si se selecciona, la muestro en el picturebox y pongo la ruta en el label correspondiente
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PbxImagenM.Image = Image.FromFile(OpenFileDialog1.FileName)
            'hago una copia de la imagen en la carpeta img del proyecto, si la carpeta no existe la creo
            If Not Directory.Exists("img") Then
                Directory.CreateDirectory("img")
            End If
            Dim rutaDestino As String = "img\" & Path.GetFileName(OpenFileDialog1.FileName)
            File.Copy(OpenFileDialog1.FileName, rutaDestino, True)
            LBLRutaImagenM.Text = rutaDestino
            'si se modifica el contenido del textbox, habilito el botón guardar
            BtnGuardarM.Enabled = True

        End If
    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub TabPage3_LostFocus(sender As Object, e As EventArgs) Handles TabPage3.LostFocus
        'si se cambia de tab, limpio los controles del formulario
        TxtApellidoM.Clear()
        TxtDniM.Clear()
        TxtNombreM.Clear()
        CmbSectorM.SelectedIndex = -1
        LBLRutaImagenM.Text = ""
        PbxImagenM.Image = Nothing
        BtnGuardarM.Enabled = False
    End Sub

    Private Sub TxtDniM_TextChanged(sender As Object, e As EventArgs) Handles TxtDniM.TextChanged


    End Sub

    Private Sub TxtDniM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDniM.KeyPress
        'si se modifica el contenido del textbox, habilito el botón guardar
        BtnGuardarM.Enabled = True

    End Sub

    Private Sub TxtNombreM_TextChanged(sender As Object, e As EventArgs) Handles TxtNombreM.TextChanged


    End Sub

    Private Sub TxtNombreM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNombreM.KeyPress
        'si se modifica el contenido del textbox, habilito el botón guardar
        BtnGuardarM.Enabled = True

    End Sub

    Private Sub TxtApellidoM_TextChanged(sender As Object, e As EventArgs) Handles TxtApellidoM.TextChanged

    End Sub

    Private Sub TxtApellidoM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtApellidoM.KeyPress
        'si se modifica el contenido del textbox, habilito el botón guardar
        BtnGuardarM.Enabled = True

    End Sub

    Private Sub CmbSectorM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSectorM.SelectedIndexChanged
        'si se modifica el contenido del textbox, habilito el botón guardar

        BtnGuardarM.Enabled = True

    End Sub

    Private Sub LBLRutaImagenM_Click(sender As Object, e As EventArgs) Handles LBLRutaImagenM.Click

    End Sub

    Private Sub BtnGuardarM_Click(sender As Object, e As EventArgs) Handles BtnGuardarM.Click
        'actualizo los datos del empleado seleccionado en el listview1, y en el archivo de texto
        If TxtNombreM.Text = "" Or TxtApellidoM.Text = "" Or TxtDniM.Text = "" Or CmbSectorM.SelectedIndex = -1 Or LBLRutaImagenM.Text = "" Then
            MessageBox.Show("Debe completar todos los campos")
            Return
        End If
        'actualizo los datos en el listview1
        ListView1.SelectedItems(0).SubItems(0).Text = TxtNombreM.Text
        ListView1.SelectedItems(0).SubItems(1).Text = TxtApellidoM.Text
        ListView1.SelectedItems(0).SubItems(2).Text = TxtDniM.Text
        ListView1.SelectedItems(0).SubItems(3).Text = CmbSectorM.Text
        ListView1.SelectedItems(0).SubItems(4).Text = LBLRutaImagenM.Text
        'actualizo los datos en el archivo de texto
        Dim sr As New StreamReader("datos\legajos.txt")
        Dim sw As New StreamWriter("datos\legajos.tmp")
        Do While Not sr.EndOfStream
            Dim linea As String = sr.ReadLine()
            Dim partes() As String = linea.Split(",")
            If partes(2) = ListView1.SelectedItems(0).SubItems(2).Text Then
                sw.WriteLine(TxtNombreM.Text & "," & TxtApellidoM.Text & "," & TxtDniM.Text & "," & CmbSectorM.Text & "," & LBLRutaImagenM.Text)
            Else
                sw.WriteLine(linea)
            End If
        Loop
        sr.Close()
        sw.Close()
        File.Delete("datos\legajos.txt")
        File.Move("datos\legajos.tmp", "datos\legajos.txt")
        MessageBox.Show("Datos actualizados correctamente")
        CargarLegajos()
        LimpiarFormulario()
        BtnGuardarM.Enabled = False

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        'elimino el empleado seleccionado del listview1 y del archivo de texto
        If ListView2.SelectedItems.Count = 0 Then
            Return
        End If
        'pregunto si está seguro de eliminar el empleado
        If MessageBox.Show("¿Está seguro de eliminar el empleado seleccionado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        'elimino el empleado del archivo de texto
        Dim sr As New StreamReader("datos\legajos.txt")
        Dim sw As New StreamWriter("datos\legajos.tmp")
        Do While Not sr.EndOfStream
            Dim linea As String = sr.ReadLine()
            Dim partes() As String = linea.Split(",")
            If partes(2) <> ListView2.SelectedItems(0).SubItems(2).Text Then
                sw.WriteLine(linea)
            End If
        Loop
        'elimino el empleado del listview1
        ListView2.Items.Remove(ListView2.SelectedItems(0))
        sr.Close()
        sw.Close()
        File.Delete("datos\legajos.txt")
        File.Move("datos\legajos.tmp", "datos\legajos.txt")
        MessageBox.Show("Empleado eliminado correctamente")
        CargarLegajos()
        LimpiarFormulario()
        BtnGuardarM.Enabled = False
        'limpio los controles del panel
        TxtNombreE.Clear()
        TxtApellidoE.Clear()
        TxtDniE.Clear()
        CmbSectorE.SelectedIndex = -1
        LBLRutaImagenE.Text = ""
        PbxImagenE.Image = Nothing


    End Sub
End Class
