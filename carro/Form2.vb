Public Class FormCompra
    Public Property precio As String
    Public Property nombre As String
    Public Property marca As String
    Public Property imagen As Image
    Dim pagmin As Integer
    Dim pago As Integer
    Dim mes As Integer
    Dim apa As Integer
    Dim iva As Integer
    Dim res As Integer
    Dim preciof As Integer

    Private Sub FormCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblprecio.Text = precio
        lblname.Text = nombre
        lblmarca.Text = marca
        ptbimage.Image = imagen


        iva = precio * 10 / 100
        Dim preciof As Integer
        preciof = precio + iva
        Dim ivar As String = iva.ToString("N0")
        Dim precior As String = preciof.ToString("N0")
        lblp1.Text = precio
        lbli1.Text = ivar
        lblpf1.Text = precior

        lbli2.Text = "$" & ivar
        lblp2.Text = precio
        pagmin = precio * 30 / 100

    End Sub
    Public Sub New()
        Me.MaximizeBox = False
        InitializeComponent()

    End Sub

    Private Sub lblprecio_Click(sender As Object, e As EventArgs) Handles lblprecio.Click

    End Sub

    Private Sub ptbimage_Click(sender As Object, e As EventArgs) Handles ptbimage.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        formauto.Visible = True
    End Sub

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles rbtnefe.CheckedChanged
        If rbtnefe.Checked = True Then
            pnlcre.Visible = False
            pnlefe.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (txtname.Text = "" And txtapea.Text = "" And txtapem.Text = "") Then
            MessageBox.Show("Llena los datos primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (txtname.Text = "") Then
            MessageBox.Show("Coloca un nombre(s)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (txtapea.Text = "") Then
            MessageBox.Show("Coloca un apellido p", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (txtapem.Text = "") Then
            MessageBox.Show("Coloca un apellido m", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            pnlpago.Visible = True
        End If



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        formpago.Visible = True

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        rbtnefe.Checked = False
        pnlefe.Visible = False
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles pnlcre.Paint

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rbtncre.CheckedChanged
        If rbtncre.Checked = True Then
            pnlefe.Visible = False
            pnlcre.Visible = True

        End If
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Integer.TryParse(txtpago.Text, pago)

        If nummes.Value = 0 And txtpago.Text = "" Then
            MessageBox.Show("Llena los datos primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf nummes.Value = 0 Then
            MessageBox.Show("No puedes elegir 0 como meses", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf nummes.Value > 48 Then
            MessageBox.Show("No puedes elegir mas de 48 meses", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtpago.Text = "" Then
            MessageBox.Show("El pago inicial esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtpago.Text < pagmin Then
            nummes.Value = 0
            txtpago.Clear()
            MessageBox.Show("El pago debe ser meyor al 30%", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtpago.Text = 0 Then
            MessageBox.Show("Necesitas dar un pago inicial", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf pago > precio Then
            nummes.Value = 0
            txtpago.Clear()
            MessageBox.Show("No puedes dar más del valor del auto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            pnldata.Visible = True
            Dim sincom As String = txtpago.Text.Replace(",", "")

            If Integer.TryParse(sincom, pago) Then
                lblpago.Text = "$" & pago.ToString("N0")
            End If
        End If

        If nummes.Value >= 1 And nummes.Value <= 6 Then
            mes = (precio * 1 / 100) * nummes.Value

            lblmes.Text = "$" & mes.ToString("N0")

        ElseIf nummes.Value >= 7 And nummes.Value <= 12 Then
            mes = (precio * 1.5 / 100) * nummes.Value

            lblmes.Text = "$" & mes.ToString("N0")

        ElseIf nummes.Value >= 13 And nummes.Value <= 18 Then
            mes = (precio * 2 / 100) * nummes.Value

            lblmes.Text = "$" & mes.ToString("N0")
        ElseIf nummes.Value >= 19 And nummes.Value <= 24 Then
            mes = (precio * 2.5 / 100) * nummes.Value

            lblmes.Text = "$" & mes.ToString("N0")
        ElseIf nummes.Value >= 25 And nummes.Value <= 48 Then
            mes = (precio * 3 / 100) * nummes.Value
            lblmes.Text = "$" & mes.ToString("N0")
        Else
            nummes.Value = 0
            MessageBox.Show("Solos puedes de 1 a 48 meses", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Dim pret As Integer
        pret = precio + iva + mes
        apa = pago + mes + iva
        lblapa.Text = "$" & apa.ToString("N0")

        res = pret - apa
        lblres.Text = "$" & res.ToString("N0")
        lblpf2.Text = "$" & pret.ToString("N0")


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        formpago.Visible = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        rbtncre.Checked = False
        pnlcre.Visible = False
        txtpago.Clear()
        nummes.Value = 0
        pnldata.Visible = False

    End Sub
    Private Sub txtname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtname.KeyPress

        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True
            txtapea.Focus()
        End If

    End Sub
    Private Sub txtapea_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapea.KeyPress

        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True
            txtapem.Focus()
        End If

    End Sub
    Private Sub txtapem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapem.KeyPress

        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            e.Handled = True
        End If

    End Sub
    Private Sub txtpago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpago.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            e.Handled = True
        End If
    End Sub
    Private Sub txtpago_TextChanged(sender As Object, e As EventArgs) Handles txtpago.TextChanged

        If Not String.IsNullOrEmpty(txtpago.Text) AndAlso IsNumeric(txtpago.Text) Then

            Dim valor As Double = Double.Parse(txtpago.Text)
            txtpago.Text = valor.ToString("N0")
            txtpago.SelectionStart = txtpago.Text.Length
        End If
    End Sub

End Class
