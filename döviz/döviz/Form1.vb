Imports System.Xml
Imports System.Threading

Public Class Form1

    Sub formgetir(acilanform As Form)
        Panel2.Controls.Clear()
        acilanform.TopLevel = False
        Panel2.Controls.Add(acilanform)
        acilanform.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rdr As XmlTextReader = New XmlTextReader("http://www.tcmb.gov.tr/kurlar/today.xml")
        Dim ds As DataSet = New DataSet()
        ds.ReadXml(rdr)
        DataGridView1.DataSource = ds.Tables("Currency")

        For x = 0 To DataGridView1.Rows.Count - 1
            If Not String.IsNullOrEmpty(DataGridView1.Rows(x).Cells(10).Value) Then
                If DataGridView1.Rows(x).Cells(10).Value.ToString().Contains("USD") Then
                    Label20.Text = DataGridView1.Rows(x).Cells(4).Value.ToString()
                End If
                If DataGridView1.Rows(x).Cells(10).Value.ToString().Contains("EUR") Then
                    Label22.Text = DataGridView1.Rows(x).Cells(4).Value.ToString()
                End If
                If DataGridView1.Rows(x).Cells(10).Value.ToString().Contains("CNY") Then
                    Label50.Text = DataGridView1.Rows(x).Cells(4).Value.ToString()
                End If
                If DataGridView1.Rows(x).Cells(10).Value.ToString().Contains("RUB") Then
                    Label51.Text = DataGridView1.Rows(x).Cells(4).Value.ToString()
                End If

                If DataGridView1.Rows(x).Cells(10).Value.ToString().Contains("GBP") Then
                    Label21.Text = DataGridView1.Rows(x).Cells(4).Value.ToString()
                End If
                If DataGridView1.Rows(x).Cells(10).Value.ToString().Contains("USD") Then
                    Label17.Text = DataGridView1.Rows(x).Cells(3).Value.ToString()
                End If
                If DataGridView1.Rows(x).Cells(10).Value.ToString().Contains("EUR") Then
                    Label15.Text = DataGridView1.Rows(x).Cells(3).Value.ToString()
                End If
                If DataGridView1.Rows(x).Cells(10).Value.ToString().Contains("CNY") Then
                    Label14.Text = DataGridView1.Rows(x).Cells(3).Value.ToString()
                End If
                If DataGridView1.Rows(x).Cells(10).Value.ToString().Contains("RUB") Then
                    Label13.Text = DataGridView1.Rows(x).Cells(3).Value.ToString()
                End If
                If DataGridView1.Rows(x).Cells(10).Value.ToString().Contains("GBP") Then
                    Label16.Text = DataGridView1.Rows(x).Cells(3).Value.ToString()
                End If
            End If
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim sonuc As Double
        sonuc = Val(TextBox1.Text) * Val(Label20.Text) + Val(TextBox2.Text) * Val(Label21.Text) + Val(TextBox3.Text) * Val(Label22.Text) + Val(TextBox4.Text) * Val(Label50.Text) + Val(TextBox5.Text) * Val(Label51.Text)
        TextBox6.Text = sonuc.ToString("N1") + "     TL"
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sonuc As Double
        sonuc = Val(TextBox1.Text) * Val(Label17.Text) + Val(TextBox2.Text) * Val(Label16.Text) + Val(TextBox3.Text) * Val(Label15.Text) + Val(TextBox4.Text) * Val(Label14.Text) + Val(TextBox5.Text) * Val(Label13.Text)
        TextBox7.Text = sonuc.ToString("N1") + "     TL"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim wc As New System.Net.WebClient()
        Dim url As String = "https://www.tcmb.gov.tr/wps/wcm/connect/262f6943-1f47-44b8-9471-a488940f31d4/302x61pxLogo-01-01.png?MOD=AJPERES&CACHEID=ROOTWORKSPACE-262f6943-1f47-44b8-9471-a488940f31d4-nrp8FQu"
        Dim imgData As Byte() = wc.DownloadData(url)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom

        Dim ms As New System.IO.MemoryStream(imgData)
        PictureBox1.Image = Image.FromStream(ms)

    End Sub
End Class
