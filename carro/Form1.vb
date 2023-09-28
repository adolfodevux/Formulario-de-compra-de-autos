Public Class formauto
    Dim nomcars As String() = {"Rio Sedán", "Versa", "Aveo", "Model S", "Gypsy Rose"}
    Dim precios As String() = {"$288,900", "$323,900", "$284,400", "$2,899,900", "$441,900"}
    Dim marcas As String() = {"KIA", "Nissan", "Chevrolet", "Tesla", "Lowrider"}
    Dim imagenes As String() = {"E:\codes\recurses\1carro.png", "E:\codes\recurses\2carro.png", "E:\codes\recurses\3carro.png", "E:\codes\recurses\4carro.png", "E:\codes\recurses\5carro.png"}
    Dim indice As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carro()
        imagen()
    End Sub

    Private Sub btnsig_Click(sender As Object, e As EventArgs) Handles btnsig.Click
        indice += 1
        If indice >= nomcars.Length - 1 Then
            indice = nomcars.Length - 1
            btnsig.Visible = False
        End If
        btnant.Visible = True
        carro()
    End Sub

    Public Sub New()
        Me.MaximizeBox = False
        InitializeComponent()

    End Sub

    Private Sub btnant_Click(sender As Object, e As EventArgs) Handles btnant.Click
        indice -= 1
        If indice <= 0 Then
            indice = 0
            btnant.Visible = False
        End If
        btnsig.Visible = True
        carro()
    End Sub

    Private Sub carro()
        lblcars.Text = nomcars(indice)
        lblprecios.Text = precios(indice)
        lblmarcas.Text = marcas(indice)
        imagen()
    End Sub

    Private Sub imagen()
        Me.MaximizeBox = False
        ptbimage.Image = Image.FromFile(imagenes(indice))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim formCompra As New FormCompra()

        formCompra.precio = lblprecios.Text
        formCompra.nombre = lblcars.Text
        formCompra.marca = lblmarcas.Text
        formCompra.imagen = ptbimage.Image
        Me.Hide()
        formCompra.Visible = True
    End Sub

End Class
