<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LviLegajos = New System.Windows.Forms.ListView()
        Me.PbImagenListados = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtDni = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.CmbSector = New System.Windows.Forms.ComboBox()
        Me.PbxImagen = New System.Windows.Forms.PictureBox()
        Me.BtnCargarImagen = New System.Windows.Forms.Button()
        Me.LBLRutaImagen = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.nombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.apellido = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LblSector = New System.Windows.Forms.Label()
        Me.LblDatos = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PbImagenListados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(49, 115)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(752, 372)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.LblDatos)
        Me.TabPage1.Controls.Add(Me.LblSector)
        Me.TabPage1.Controls.Add(Me.PbImagenListados)
        Me.TabPage1.Controls.Add(Me.LviLegajos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(744, 346)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Legajos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.BtnCancelar)
        Me.TabPage2.Controls.Add(Me.BtnGuardar)
        Me.TabPage2.Controls.Add(Me.LBLRutaImagen)
        Me.TabPage2.Controls.Add(Me.BtnCargarImagen)
        Me.TabPage2.Controls.Add(Me.PbxImagen)
        Me.TabPage2.Controls.Add(Me.CmbSector)
        Me.TabPage2.Controls.Add(Me.TxtApellido)
        Me.TabPage2.Controls.Add(Me.TxtNombre)
        Me.TabPage2.Controls.Add(Me.TxtDni)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(744, 346)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Nuevo"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Uighur", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(287, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 57)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Gestor de Legajos"
        '
        'LviLegajos
        '
        Me.LviLegajos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.nombre, Me.apellido, Me.ColumnHeader1, Me.ColumnHeader2})
        Me.LviLegajos.HideSelection = False
        Me.LviLegajos.Location = New System.Drawing.Point(40, 27)
        Me.LviLegajos.Name = "LviLegajos"
        Me.LviLegajos.Size = New System.Drawing.Size(376, 273)
        Me.LviLegajos.TabIndex = 0
        Me.LviLegajos.UseCompatibleStateImageBehavior = False
        Me.LviLegajos.View = System.Windows.Forms.View.Details
        '
        'PbImagenListados
        '
        Me.PbImagenListados.Location = New System.Drawing.Point(501, 93)
        Me.PbImagenListados.Name = "PbImagenListados"
        Me.PbImagenListados.Size = New System.Drawing.Size(152, 118)
        Me.PbImagenListados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbImagenListados.TabIndex = 1
        Me.PbImagenListados.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "DNI:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Apellido:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(57, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Sector:"
        '
        'TxtDni
        '
        Me.TxtDni.Location = New System.Drawing.Point(150, 55)
        Me.TxtDni.Name = "TxtDni"
        Me.TxtDni.Size = New System.Drawing.Size(100, 20)
        Me.TxtDni.TabIndex = 4
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(150, 91)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(194, 20)
        Me.TxtNombre.TabIndex = 5
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(150, 127)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(149, 20)
        Me.TxtApellido.TabIndex = 6
        '
        'CmbSector
        '
        Me.CmbSector.FormattingEnabled = True
        Me.CmbSector.Items.AddRange(New Object() {"Administración", "Comercialización", "Industria", "Mantenimiento"})
        Me.CmbSector.Location = New System.Drawing.Point(150, 162)
        Me.CmbSector.Name = "CmbSector"
        Me.CmbSector.Size = New System.Drawing.Size(149, 21)
        Me.CmbSector.TabIndex = 7
        '
        'PbxImagen
        '
        Me.PbxImagen.Location = New System.Drawing.Point(461, 44)
        Me.PbxImagen.Name = "PbxImagen"
        Me.PbxImagen.Size = New System.Drawing.Size(170, 138)
        Me.PbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxImagen.TabIndex = 8
        Me.PbxImagen.TabStop = False
        '
        'BtnCargarImagen
        '
        Me.BtnCargarImagen.Location = New System.Drawing.Point(38, 200)
        Me.BtnCargarImagen.Name = "BtnCargarImagen"
        Me.BtnCargarImagen.Size = New System.Drawing.Size(112, 26)
        Me.BtnCargarImagen.TabIndex = 9
        Me.BtnCargarImagen.Text = "Cargar Imagen"
        Me.BtnCargarImagen.UseVisualStyleBackColor = True
        '
        'LBLRutaImagen
        '
        Me.LBLRutaImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLRutaImagen.Location = New System.Drawing.Point(169, 203)
        Me.LBLRutaImagen.Name = "LBLRutaImagen"
        Me.LBLRutaImagen.Size = New System.Drawing.Size(275, 22)
        Me.LBLRutaImagen.TabIndex = 10
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(227, 269)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(103, 31)
        Me.BtnGuardar.TabIndex = 11
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(336, 269)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(103, 31)
        Me.BtnCancelar.TabIndex = 12
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(715, 525)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(97, 35)
        Me.BtnSalir.TabIndex = 2
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'nombre
        '
        Me.nombre.Text = "nombre"
        '
        'apellido
        '
        Me.apellido.Text = "apellido"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "dni"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "sector"
        '
        'LblSector
        '
        Me.LblSector.Font = New System.Drawing.Font("Microsoft Uighur", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSector.Location = New System.Drawing.Point(456, 44)
        Me.LblSector.Name = "LblSector"
        Me.LblSector.Size = New System.Drawing.Size(245, 37)
        Me.LblSector.TabIndex = 2
        Me.LblSector.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblDatos
        '
        Me.LblDatos.Location = New System.Drawing.Point(453, 226)
        Me.LblDatos.Name = "LblDatos"
        Me.LblDatos.Size = New System.Drawing.Size(248, 50)
        Me.LblDatos.TabIndex = 3
        Me.LblDatos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 578)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PbImagenListados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents PbImagenListados As PictureBox
    Friend WithEvents LviLegajos As ListView
    Friend WithEvents CmbSector As ComboBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtDni As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents LBLRutaImagen As Label
    Friend WithEvents BtnCargarImagen As Button
    Friend WithEvents PbxImagen As PictureBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents nombre As ColumnHeader
    Friend WithEvents apellido As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents LblDatos As Label
    Friend WithEvents LblSector As Label
End Class
