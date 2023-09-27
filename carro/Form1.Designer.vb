<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formauto
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnsig = New System.Windows.Forms.Button()
        Me.btnant = New System.Windows.Forms.Button()
        Me.lblcars = New System.Windows.Forms.Label()
        Me.lblprecios = New System.Windows.Forms.Label()
        Me.lblmarcas = New System.Windows.Forms.Label()
        Me.pnlcar1 = New System.Windows.Forms.Panel()
        Me.ptbimage = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlcar1.SuspendLayout()
        CType(Me.ptbimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(149, 363)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 34)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "COMPRAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnsig
        '
        Me.btnsig.Location = New System.Drawing.Point(284, 363)
        Me.btnsig.Name = "btnsig"
        Me.btnsig.Size = New System.Drawing.Size(105, 34)
        Me.btnsig.TabIndex = 6
        Me.btnsig.Text = "SIG."
        Me.btnsig.UseVisualStyleBackColor = True
        '
        'btnant
        '
        Me.btnant.Location = New System.Drawing.Point(15, 363)
        Me.btnant.Name = "btnant"
        Me.btnant.Size = New System.Drawing.Size(105, 34)
        Me.btnant.TabIndex = 7
        Me.btnant.Text = "ANT."
        Me.btnant.UseVisualStyleBackColor = True
        Me.btnant.Visible = False
        '
        'lblcars
        '
        Me.lblcars.AutoSize = True
        Me.lblcars.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcars.Location = New System.Drawing.Point(12, 325)
        Me.lblcars.Name = "lblcars"
        Me.lblcars.Size = New System.Drawing.Size(0, 18)
        Me.lblcars.TabIndex = 8
        '
        'lblprecios
        '
        Me.lblprecios.AutoSize = True
        Me.lblprecios.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprecios.Location = New System.Drawing.Point(146, 326)
        Me.lblprecios.Name = "lblprecios"
        Me.lblprecios.Size = New System.Drawing.Size(0, 18)
        Me.lblprecios.TabIndex = 9
        '
        'lblmarcas
        '
        Me.lblmarcas.AutoSize = True
        Me.lblmarcas.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmarcas.Location = New System.Drawing.Point(293, 326)
        Me.lblmarcas.Name = "lblmarcas"
        Me.lblmarcas.Size = New System.Drawing.Size(0, 18)
        Me.lblmarcas.TabIndex = 10
        '
        'pnlcar1
        '
        Me.pnlcar1.Controls.Add(Me.ptbimage)
        Me.pnlcar1.Location = New System.Drawing.Point(30, 44)
        Me.pnlcar1.Name = "pnlcar1"
        Me.pnlcar1.Size = New System.Drawing.Size(359, 237)
        Me.pnlcar1.TabIndex = 11
        '
        'ptbimage
        '
        Me.ptbimage.Location = New System.Drawing.Point(0, 16)
        Me.ptbimage.Name = "ptbimage"
        Me.ptbimage.Size = New System.Drawing.Size(359, 212)
        Me.ptbimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbimage.TabIndex = 0
        Me.ptbimage.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(162, 298)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 18)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "PRECIO "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(305, 298)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "MARCA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 298)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 18)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "NOMBRE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(177, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 18)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "AUTO"
        '
        'formauto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(417, 410)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.pnlcar1)
        Me.Controls.Add(Me.lblmarcas)
        Me.Controls.Add(Me.lblprecios)
        Me.Controls.Add(Me.lblcars)
        Me.Controls.Add(Me.btnant)
        Me.Controls.Add(Me.btnsig)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "formauto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COMPRA DE AUTOS"
        Me.pnlcar1.ResumeLayout(False)
        CType(Me.ptbimage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents btnsig As Button
    Friend WithEvents btnant As Button
    Friend WithEvents lblcars As Label
    Friend WithEvents lblprecios As Label
    Friend WithEvents lblmarcas As Label
    Friend WithEvents pnlcar1 As Panel
    Friend WithEvents ptbimage As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
