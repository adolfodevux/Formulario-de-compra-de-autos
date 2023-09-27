<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCompra
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
        Me.lblprecio = New System.Windows.Forms.Label()
        Me.lblmarca = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ptbimage = New System.Windows.Forms.PictureBox()
        Me.txtapea = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtapem = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.rbtnefe = New System.Windows.Forms.RadioButton()
        Me.rbtncre = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnlefe = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lblpf1 = New System.Windows.Forms.Label()
        Me.lbli1 = New System.Windows.Forms.Label()
        Me.lblp1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pnlcre = New System.Windows.Forms.Panel()
        Me.txtpago = New System.Windows.Forms.MaskedTextBox()
        Me.pnldata = New System.Windows.Forms.Panel()
        Me.lblpf2 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblres = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblmes = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblapa = New System.Windows.Forms.Label()
        Me.lbli2 = New System.Windows.Forms.Label()
        Me.lblpago = New System.Windows.Forms.Label()
        Me.lblp2 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.nummes = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.pnlpago = New System.Windows.Forms.Panel()
        CType(Me.ptbimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlefe.SuspendLayout()
        Me.pnlcre.SuspendLayout()
        Me.pnldata.SuspendLayout()
        CType(Me.nummes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlpago.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblprecio
        '
        Me.lblprecio.AutoSize = True
        Me.lblprecio.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprecio.Location = New System.Drawing.Point(12, 131)
        Me.lblprecio.Name = "lblprecio"
        Me.lblprecio.Size = New System.Drawing.Size(0, 18)
        Me.lblprecio.TabIndex = 11
        '
        'lblmarca
        '
        Me.lblmarca.AutoSize = True
        Me.lblmarca.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmarca.Location = New System.Drawing.Point(12, 174)
        Me.lblmarca.Name = "lblmarca"
        Me.lblmarca.Size = New System.Drawing.Size(0, 18)
        Me.lblmarca.TabIndex = 12
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(12, 88)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(0, 18)
        Me.lblname.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(101, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 18)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "DATOS DEL CARRO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 265)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 18)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "NOMBRE(s):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 302)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 18)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "APELLIDO P:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 334)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 18)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "APELLIDO M:"
        '
        'ptbimage
        '
        Me.ptbimage.Location = New System.Drawing.Point(117, 62)
        Me.ptbimage.Name = "ptbimage"
        Me.ptbimage.Size = New System.Drawing.Size(236, 142)
        Me.ptbimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbimage.TabIndex = 14
        Me.ptbimage.TabStop = False
        '
        'txtapea
        '
        Me.txtapea.Location = New System.Drawing.Point(151, 300)
        Me.txtapea.Name = "txtapea"
        Me.txtapea.Size = New System.Drawing.Size(156, 20)
        Me.txtapea.TabIndex = 19
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(151, 265)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(156, 20)
        Me.txtname.TabIndex = 20
        '
        'txtapem
        '
        Me.txtapem.Location = New System.Drawing.Point(151, 332)
        Me.txtapem.Name = "txtapem"
        Me.txtapem.Size = New System.Drawing.Size(156, 20)
        Me.txtapem.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(165, 376)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 30)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "CONTINUAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'rbtnefe
        '
        Me.rbtnefe.AutoSize = True
        Me.rbtnefe.Location = New System.Drawing.Point(10, 50)
        Me.rbtnefe.Name = "rbtnefe"
        Me.rbtnefe.Size = New System.Drawing.Size(77, 17)
        Me.rbtnefe.TabIndex = 23
        Me.rbtnefe.TabStop = True
        Me.rbtnefe.Text = "EFECTIVO"
        Me.rbtnefe.UseVisualStyleBackColor = True
        '
        'rbtncre
        '
        Me.rbtncre.AutoSize = True
        Me.rbtncre.Location = New System.Drawing.Point(14, 83)
        Me.rbtncre.Name = "rbtncre"
        Me.rbtncre.Size = New System.Drawing.Size(73, 17)
        Me.rbtncre.TabIndex = 24
        Me.rbtncre.TabStop = True
        Me.rbtncre.Text = "CREDITO"
        Me.rbtncre.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(92, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(232, 18)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "DATOS DEL COMPRADOR"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(78, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(172, 18)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "METODO DE PAGO"
        '
        'pnlefe
        '
        Me.pnlefe.Controls.Add(Me.Label10)
        Me.pnlefe.Controls.Add(Me.Label9)
        Me.pnlefe.Controls.Add(Me.Label8)
        Me.pnlefe.Controls.Add(Me.Button4)
        Me.pnlefe.Controls.Add(Me.Button3)
        Me.pnlefe.Controls.Add(Me.lblpf1)
        Me.pnlefe.Controls.Add(Me.lbli1)
        Me.pnlefe.Controls.Add(Me.lblp1)
        Me.pnlefe.Controls.Add(Me.Label7)
        Me.pnlefe.Location = New System.Drawing.Point(359, 124)
        Me.pnlefe.Name = "pnlefe"
        Me.pnlefe.Size = New System.Drawing.Size(375, 292)
        Me.pnlefe.TabIndex = 27
        Me.pnlefe.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(34, 175)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(142, 18)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "PRECIO FINAL:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(59, 130)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 18)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "IVA 10%:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(34, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(180, 18)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "PRECIO ORIGINAL:"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(214, 232)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(101, 36)
        Me.Button4.TabIndex = 32
        Me.Button4.Text = "CONFIRMAR"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(51, 232)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(101, 36)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "CANCELAR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lblpf1
        '
        Me.lblpf1.AutoSize = True
        Me.lblpf1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpf1.Location = New System.Drawing.Point(234, 178)
        Me.lblpf1.Name = "lblpf1"
        Me.lblpf1.Size = New System.Drawing.Size(0, 18)
        Me.lblpf1.TabIndex = 31
        '
        'lbli1
        '
        Me.lbli1.AutoSize = True
        Me.lbli1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbli1.Location = New System.Drawing.Point(234, 130)
        Me.lbli1.Name = "lbli1"
        Me.lbli1.Size = New System.Drawing.Size(0, 18)
        Me.lbli1.TabIndex = 30
        '
        'lblp1
        '
        Me.lblp1.AutoSize = True
        Me.lblp1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblp1.Location = New System.Drawing.Point(234, 89)
        Me.lblp1.Name = "lblp1"
        Me.lblp1.Size = New System.Drawing.Size(0, 18)
        Me.lblp1.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(136, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 18)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "EFECTIVO"
        '
        'pnlcre
        '
        Me.pnlcre.Controls.Add(Me.txtpago)
        Me.pnlcre.Controls.Add(Me.pnldata)
        Me.pnlcre.Controls.Add(Me.Button7)
        Me.pnlcre.Controls.Add(Me.nummes)
        Me.pnlcre.Controls.Add(Me.Label11)
        Me.pnlcre.Controls.Add(Me.Label12)
        Me.pnlcre.Controls.Add(Me.Label17)
        Me.pnlcre.Location = New System.Drawing.Point(359, 124)
        Me.pnlcre.Name = "pnlcre"
        Me.pnlcre.Size = New System.Drawing.Size(375, 292)
        Me.pnlcre.TabIndex = 36
        Me.pnlcre.Visible = False
        '
        'txtpago
        '
        Me.txtpago.AllowPromptAsInput = False
        Me.txtpago.Location = New System.Drawing.Point(266, 60)
        Me.txtpago.Name = "txtpago"
        Me.txtpago.Size = New System.Drawing.Size(100, 20)
        Me.txtpago.TabIndex = 37
        '
        'pnldata
        '
        Me.pnldata.Controls.Add(Me.lblpf2)
        Me.pnldata.Controls.Add(Me.Label20)
        Me.pnldata.Controls.Add(Me.lblres)
        Me.pnldata.Controls.Add(Me.Label19)
        Me.pnldata.Controls.Add(Me.lblmes)
        Me.pnldata.Controls.Add(Me.Label18)
        Me.pnldata.Controls.Add(Me.lblapa)
        Me.pnldata.Controls.Add(Me.lbli2)
        Me.pnldata.Controls.Add(Me.lblpago)
        Me.pnldata.Controls.Add(Me.lblp2)
        Me.pnldata.Controls.Add(Me.Label16)
        Me.pnldata.Controls.Add(Me.Label15)
        Me.pnldata.Controls.Add(Me.Label14)
        Me.pnldata.Controls.Add(Me.Label13)
        Me.pnldata.Controls.Add(Me.Button5)
        Me.pnldata.Controls.Add(Me.Button6)
        Me.pnldata.Location = New System.Drawing.Point(4, 105)
        Me.pnldata.Name = "pnldata"
        Me.pnldata.Size = New System.Drawing.Size(368, 187)
        Me.pnldata.TabIndex = 47
        Me.pnldata.Visible = False
        '
        'lblpf2
        '
        Me.lblpf2.AutoSize = True
        Me.lblpf2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpf2.Location = New System.Drawing.Point(230, 79)
        Me.lblpf2.Name = "lblpf2"
        Me.lblpf2.Size = New System.Drawing.Size(0, 18)
        Me.lblpf2.TabIndex = 59
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(35, 79)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(142, 18)
        Me.Label20.TabIndex = 58
        Me.Label20.Text = "PRECIO FINAL:"
        '
        'lblres
        '
        Me.lblres.AutoSize = True
        Me.lblres.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblres.Location = New System.Drawing.Point(230, 123)
        Me.lblres.Name = "lblres"
        Me.lblres.Size = New System.Drawing.Size(0, 18)
        Me.lblres.TabIndex = 57
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(35, 123)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(103, 18)
        Me.Label19.TabIndex = 56
        Me.Label19.Text = "A RESTAR:"
        '
        'lblmes
        '
        Me.lblmes.AutoSize = True
        Me.lblmes.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmes.Location = New System.Drawing.Point(230, 61)
        Me.lblmes.Name = "lblmes"
        Me.lblmes.Size = New System.Drawing.Size(0, 18)
        Me.lblmes.TabIndex = 55
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(35, 61)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(190, 18)
        Me.Label18.TabIndex = 54
        Me.Label18.Text = "MONTO POR MESES:"
        '
        'lblapa
        '
        Me.lblapa.AutoSize = True
        Me.lblapa.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblapa.Location = New System.Drawing.Point(230, 102)
        Me.lblapa.Name = "lblapa"
        Me.lblapa.Size = New System.Drawing.Size(0, 18)
        Me.lblapa.TabIndex = 53
        '
        'lbli2
        '
        Me.lbli2.AutoSize = True
        Me.lbli2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbli2.Location = New System.Drawing.Point(230, 43)
        Me.lbli2.Name = "lbli2"
        Me.lbli2.Size = New System.Drawing.Size(0, 18)
        Me.lbli2.TabIndex = 52
        '
        'lblpago
        '
        Me.lblpago.AutoSize = True
        Me.lblpago.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpago.Location = New System.Drawing.Point(230, 25)
        Me.lblpago.Name = "lblpago"
        Me.lblpago.Size = New System.Drawing.Size(0, 18)
        Me.lblpago.TabIndex = 51
        '
        'lblp2
        '
        Me.lblp2.AutoSize = True
        Me.lblp2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblp2.Location = New System.Drawing.Point(230, 7)
        Me.lblp2.Name = "lblp2"
        Me.lblp2.Size = New System.Drawing.Size(0, 18)
        Me.lblp2.TabIndex = 50
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(35, 7)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(180, 18)
        Me.Label16.TabIndex = 49
        Me.Label16.Text = "PRECIO ORIGINAL:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(35, 106)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(93, 18)
        Me.Label15.TabIndex = 48
        Me.Label15.Text = "A PAGAR:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(66, 43)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 18)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "IVA 10%:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(35, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(141, 18)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "PAGO INICIAL:"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(233, 144)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(101, 36)
        Me.Button5.TabIndex = 45
        Me.Button5.Text = "CONFIRMAR"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(58, 144)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(101, 36)
        Me.Button6.TabIndex = 44
        Me.Button6.Text = "CANCELAR"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(118, 73)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(101, 26)
        Me.Button7.TabIndex = 46
        Me.Button7.Text = "VERIFICAR"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'nummes
        '
        Me.nummes.Location = New System.Drawing.Point(266, 31)
        Me.nummes.Name = "nummes"
        Me.nummes.Size = New System.Drawing.Size(100, 20)
        Me.nummes.TabIndex = 45
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(17, 52)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(243, 18)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "MONTO DE PAGO INICIAL:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(17, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(233, 18)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "ELIGA SU MENSUALIDAD:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(136, 7)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(91, 18)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "CREDITO"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 376)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 30)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "REGRESAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'pnlpago
        '
        Me.pnlpago.Controls.Add(Me.Label6)
        Me.pnlpago.Controls.Add(Me.rbtnefe)
        Me.pnlpago.Controls.Add(Me.rbtncre)
        Me.pnlpago.Location = New System.Drawing.Point(382, 12)
        Me.pnlpago.Name = "pnlpago"
        Me.pnlpago.Size = New System.Drawing.Size(314, 106)
        Me.pnlpago.TabIndex = 29
        Me.pnlpago.Visible = False
        '
        'FormCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 418)
        Me.Controls.Add(Me.pnlcre)
        Me.Controls.Add(Me.pnlpago)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.pnlefe)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtapem)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtapea)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ptbimage)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.lblmarca)
        Me.Controls.Add(Me.lblprecio)
        Me.Name = "FormCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PAGO DEL AUTO"
        CType(Me.ptbimage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlefe.ResumeLayout(False)
        Me.pnlefe.PerformLayout()
        Me.pnlcre.ResumeLayout(False)
        Me.pnlcre.PerformLayout()
        Me.pnldata.ResumeLayout(False)
        Me.pnldata.PerformLayout()
        CType(Me.nummes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlpago.ResumeLayout(False)
        Me.pnlpago.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblprecio As Label
    Friend WithEvents lblmarca As Label
    Friend WithEvents lblname As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ptbimage As PictureBox
    Friend WithEvents txtapea As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtapem As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents rbtnefe As RadioButton
    Friend WithEvents rbtncre As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents pnlefe As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents pnlpago As Panel
    Friend WithEvents lblpf1 As Label
    Friend WithEvents lbli1 As Label
    Friend WithEvents lblp1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents pnlcre As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents nummes As NumericUpDown
    Friend WithEvents Label11 As Label
    Friend WithEvents pnldata As Panel
    Friend WithEvents lblapa As Label
    Friend WithEvents lbli2 As Label
    Friend WithEvents lblpago As Label
    Friend WithEvents lblp2 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents lblmes As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lblres As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lblpf2 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtpago As MaskedTextBox
End Class
