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
        Me.LblDatos = New System.Windows.Forms.Label()
        Me.LblSector = New System.Windows.Forms.Label()
        Me.PbImagenListados = New System.Windows.Forms.PictureBox()
        Me.LviLegajos = New System.Windows.Forms.ListView()
        Me.nombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.apellido = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.LBLRutaImagen = New System.Windows.Forms.Label()
        Me.BtnCargarImagen = New System.Windows.Forms.Button()
        Me.PbxImagen = New System.Windows.Forms.PictureBox()
        Me.CmbSector = New System.Windows.Forms.ComboBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtDni = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.BtnGuardarM = New System.Windows.Forms.Button()
        Me.LBLRutaImagenM = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CmbSectorM = New System.Windows.Forms.ComboBox()
        Me.TxtApellidoM = New System.Windows.Forms.TextBox()
        Me.TxtNombreM = New System.Windows.Forms.TextBox()
        Me.TxtDniM = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PbxImagenM = New System.Windows.Forms.PictureBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.LBLRutaImagenE = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CmbSectorE = New System.Windows.Forms.ComboBox()
        Me.TxtApellidoE = New System.Windows.Forms.TextBox()
        Me.TxtNombreE = New System.Windows.Forms.TextBox()
        Me.TxtDniE = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PbxImagenE = New System.Windows.Forms.PictureBox()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PbImagenListados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PbxImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.PbxImagenM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.PbxImagenE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
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
        'LblDatos
        '
        Me.LblDatos.Location = New System.Drawing.Point(453, 226)
        Me.LblDatos.Name = "LblDatos"
        Me.LblDatos.Size = New System.Drawing.Size(248, 50)
        Me.LblDatos.TabIndex = 3
        Me.LblDatos.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        'PbImagenListados
        '
        Me.PbImagenListados.Location = New System.Drawing.Point(501, 93)
        Me.PbImagenListados.Name = "PbImagenListados"
        Me.PbImagenListados.Size = New System.Drawing.Size(152, 118)
        Me.PbImagenListados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbImagenListados.TabIndex = 1
        Me.PbImagenListados.TabStop = False
        '
        'LviLegajos
        '
        Me.LviLegajos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LviLegajos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.nombre, Me.apellido, Me.ColumnHeader1, Me.ColumnHeader2})
        Me.LviLegajos.HideSelection = False
        Me.LviLegajos.Location = New System.Drawing.Point(37, 33)
        Me.LviLegajos.Name = "LviLegajos"
        Me.LviLegajos.Size = New System.Drawing.Size(376, 273)
        Me.LviLegajos.TabIndex = 0
        Me.LviLegajos.UseCompatibleStateImageBehavior = False
        Me.LviLegajos.View = System.Windows.Forms.View.Details
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
        Me.ColumnHeader2.Width = 80
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
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(336, 269)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(103, 31)
        Me.BtnCancelar.TabIndex = 12
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
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
        'LBLRutaImagen
        '
        Me.LBLRutaImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLRutaImagen.Location = New System.Drawing.Point(169, 203)
        Me.LBLRutaImagen.Name = "LBLRutaImagen"
        Me.LBLRutaImagen.Size = New System.Drawing.Size(275, 22)
        Me.LBLRutaImagen.TabIndex = 10
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
        'PbxImagen
        '
        Me.PbxImagen.Location = New System.Drawing.Point(461, 44)
        Me.PbxImagen.Name = "PbxImagen"
        Me.PbxImagen.Size = New System.Drawing.Size(170, 138)
        Me.PbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxImagen.TabIndex = 8
        Me.PbxImagen.TabStop = False
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
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(150, 127)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(149, 20)
        Me.TxtApellido.TabIndex = 6
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(150, 91)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(194, 20)
        Me.TxtNombre.TabIndex = 5
        '
        'TxtDni
        '
        Me.TxtDni.Location = New System.Drawing.Point(150, 55)
        Me.TxtDni.Name = "TxtDni"
        Me.TxtDni.Size = New System.Drawing.Size(100, 20)
        Me.TxtDni.TabIndex = 4
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Apellido:"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "DNI:"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.BtnGuardarM)
        Me.TabPage3.Controls.Add(Me.LBLRutaImagenM)
        Me.TabPage3.Controls.Add(Me.Button1)
        Me.TabPage3.Controls.Add(Me.CmbSectorM)
        Me.TabPage3.Controls.Add(Me.TxtApellidoM)
        Me.TabPage3.Controls.Add(Me.TxtNombreM)
        Me.TabPage3.Controls.Add(Me.TxtDniM)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.PbxImagenM)
        Me.TabPage3.Controls.Add(Me.ListView1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(744, 346)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Modificar"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'BtnGuardarM
        '
        Me.BtnGuardarM.Enabled = False
        Me.BtnGuardarM.Location = New System.Drawing.Point(470, 282)
        Me.BtnGuardarM.Name = "BtnGuardarM"
        Me.BtnGuardarM.Size = New System.Drawing.Size(122, 28)
        Me.BtnGuardarM.TabIndex = 21
        Me.BtnGuardarM.Text = "guardar"
        Me.BtnGuardarM.UseVisualStyleBackColor = True
        '
        'LBLRutaImagenM
        '
        Me.LBLRutaImagenM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLRutaImagenM.Location = New System.Drawing.Point(470, 242)
        Me.LBLRutaImagenM.Name = "LBLRutaImagenM"
        Me.LBLRutaImagenM.Size = New System.Drawing.Size(268, 22)
        Me.LBLRutaImagenM.TabIndex = 20
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(339, 239)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 26)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Cambiar Imagen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CmbSectorM
        '
        Me.CmbSectorM.FormattingEnabled = True
        Me.CmbSectorM.Items.AddRange(New Object() {"Administración", "Comercialización", "Industria", "Mantenimiento"})
        Me.CmbSectorM.Location = New System.Drawing.Point(451, 201)
        Me.CmbSectorM.Name = "CmbSectorM"
        Me.CmbSectorM.Size = New System.Drawing.Size(149, 21)
        Me.CmbSectorM.TabIndex = 18
        '
        'TxtApellidoM
        '
        Me.TxtApellidoM.Location = New System.Drawing.Point(451, 166)
        Me.TxtApellidoM.Name = "TxtApellidoM"
        Me.TxtApellidoM.Size = New System.Drawing.Size(149, 20)
        Me.TxtApellidoM.TabIndex = 17
        '
        'TxtNombreM
        '
        Me.TxtNombreM.Location = New System.Drawing.Point(451, 130)
        Me.TxtNombreM.Name = "TxtNombreM"
        Me.TxtNombreM.Size = New System.Drawing.Size(194, 20)
        Me.TxtNombreM.TabIndex = 16
        '
        'TxtDniM
        '
        Me.TxtDniM.Location = New System.Drawing.Point(451, 94)
        Me.TxtDniM.Name = "TxtDniM"
        Me.TxtDniM.Size = New System.Drawing.Size(100, 20)
        Me.TxtDniM.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(358, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Sector:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(352, 173)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Apellido:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(352, 137)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Nombre:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(370, 101)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "DNI:"
        '
        'PbxImagenM
        '
        Me.PbxImagenM.Location = New System.Drawing.Point(651, 104)
        Me.PbxImagenM.Name = "PbxImagenM"
        Me.PbxImagenM.Size = New System.Drawing.Size(87, 118)
        Me.PbxImagenM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxImagenM.TabIndex = 5
        Me.PbxImagenM.TabStop = False
        '
        'ListView1
        '
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(40, 37)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(296, 273)
        Me.ListView1.TabIndex = 4
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "nombre"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "apellido"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "dni"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "sector"
        Me.ColumnHeader6.Width = 80
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.BtnEliminar)
        Me.TabPage4.Controls.Add(Me.LBLRutaImagenE)
        Me.TabPage4.Controls.Add(Me.Button2)
        Me.TabPage4.Controls.Add(Me.CmbSectorE)
        Me.TabPage4.Controls.Add(Me.TxtApellidoE)
        Me.TabPage4.Controls.Add(Me.TxtNombreE)
        Me.TabPage4.Controls.Add(Me.TxtDniE)
        Me.TabPage4.Controls.Add(Me.Label12)
        Me.TabPage4.Controls.Add(Me.Label13)
        Me.TabPage4.Controls.Add(Me.Label14)
        Me.TabPage4.Controls.Add(Me.Label15)
        Me.TabPage4.Controls.Add(Me.PbxImagenE)
        Me.TabPage4.Controls.Add(Me.ListView2)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(744, 346)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Eliminar"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'LBLRutaImagenE
        '
        Me.LBLRutaImagenE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLRutaImagenE.Location = New System.Drawing.Point(453, 242)
        Me.LBLRutaImagenE.Name = "LBLRutaImagenE"
        Me.LBLRutaImagenE.Size = New System.Drawing.Size(268, 22)
        Me.LBLRutaImagenE.TabIndex = 32
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(322, 239)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 26)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Cambiar Imagen"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CmbSectorE
        '
        Me.CmbSectorE.Enabled = False
        Me.CmbSectorE.FormattingEnabled = True
        Me.CmbSectorE.Items.AddRange(New Object() {"Administración", "Comercialización", "Industria", "Mantenimiento"})
        Me.CmbSectorE.Location = New System.Drawing.Point(434, 201)
        Me.CmbSectorE.Name = "CmbSectorE"
        Me.CmbSectorE.Size = New System.Drawing.Size(149, 21)
        Me.CmbSectorE.TabIndex = 30
        '
        'TxtApellidoE
        '
        Me.TxtApellidoE.Enabled = False
        Me.TxtApellidoE.Location = New System.Drawing.Point(434, 166)
        Me.TxtApellidoE.Name = "TxtApellidoE"
        Me.TxtApellidoE.Size = New System.Drawing.Size(149, 20)
        Me.TxtApellidoE.TabIndex = 29
        '
        'TxtNombreE
        '
        Me.TxtNombreE.Enabled = False
        Me.TxtNombreE.Location = New System.Drawing.Point(434, 130)
        Me.TxtNombreE.Name = "TxtNombreE"
        Me.TxtNombreE.Size = New System.Drawing.Size(194, 20)
        Me.TxtNombreE.TabIndex = 28
        '
        'TxtDniE
        '
        Me.TxtDniE.Enabled = False
        Me.TxtDniE.Location = New System.Drawing.Point(434, 94)
        Me.TxtDniE.Name = "TxtDniE"
        Me.TxtDniE.Size = New System.Drawing.Size(100, 20)
        Me.TxtDniE.TabIndex = 27
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(341, 209)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Sector:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(335, 173)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Apellido:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(335, 137)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 13)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Nombre:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(353, 101)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(29, 13)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "DNI:"
        '
        'PbxImagenE
        '
        Me.PbxImagenE.Location = New System.Drawing.Point(634, 104)
        Me.PbxImagenE.Name = "PbxImagenE"
        Me.PbxImagenE.Size = New System.Drawing.Size(87, 118)
        Me.PbxImagenE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxImagenE.TabIndex = 22
        Me.PbxImagenE.TabStop = False
        '
        'ListView2
        '
        Me.ListView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(23, 37)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(296, 273)
        Me.ListView2.TabIndex = 21
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "nombre"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "apellido"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "dni"
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "sector"
        Me.ColumnHeader10.Width = 80
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
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(457, 283)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(154, 26)
        Me.BtnEliminar.TabIndex = 33
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
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
        CType(Me.PbImagenListados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PbxImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.PbxImagenM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.PbxImagenE, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents LBLRutaImagenM As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CmbSectorM As ComboBox
    Friend WithEvents TxtApellidoM As TextBox
    Friend WithEvents TxtNombreM As TextBox
    Friend WithEvents TxtDniM As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PbxImagenM As PictureBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents LBLRutaImagenE As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents CmbSectorE As ComboBox
    Friend WithEvents TxtApellidoE As TextBox
    Friend WithEvents TxtNombreE As TextBox
    Friend WithEvents TxtDniE As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents PbxImagenE As PictureBox
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents BtnGuardarM As Button
    Friend WithEvents BtnEliminar As Button
End Class
