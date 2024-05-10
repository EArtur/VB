Imports System.Text
Imports System.Linq
Imports System.IO
Imports System.IO.Compression.ZipFile


Public Class Form1

    Private Sub CarregarDadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarregarDadosToolStripMenuItem.Click

        For Each f As String In Directory.GetFiles("C:\recibos-s2229")
            Me.lsb1.Items.Add(f)
        Next

    End Sub

    Private Sub CortarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CortarToolStripMenuItem.Click
        Try

            Dim sb As New StringBuilder()

            Dim selectedItemList As New List(Of Object)()

            For Each row As Object In lsb1.SelectedItems

                sb.Append(row.ToString())
                sb.AppendLine()


                selectedItemList.Add(row)
            Next

            sb.Remove(sb.Length - 1, 1)

            Clipboard.SetData(System.Windows.Forms.DataFormats.Text, sb.ToString())

            For Each ln As Object In selectedItemList
                lsb1.Items.Remove(ln)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        Try

            Dim sb As New StringBuilder()

            For Each row As Object In lsb1.SelectedItems
                sb.Append(row.ToString())
                sb.AppendLine()
            Next

            sb.Remove(sb.Length - 1, 1)

            Clipboard.SetData(System.Windows.Forms.DataFormats.Text, sb.ToString())
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ColarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColarToolStripMenuItem.Click
        Try

            Dim s As String = Clipboard.GetText()

            Dim lines As String() = s.Split(ControlChars.Lf)

            For Each ln As String In lines
                lsb2.Items.Add(ln.Trim())
            Next
            'linha = lines
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SelecionarTudoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelecionarTudoToolStripMenuItem.Click
        Try

            lsb1.SelectedItems.Clear()

            For i As Integer = 0 To lsb1.Items.Count - 1
                lsb1.SetSelected(i, True)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub LimparTudoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimparTudoToolStripMenuItem.Click

        lsb1.Items.Clear()
    End Sub

    Private Sub lsb1_MouseDown(sender As Object, e As MouseEventArgs) Handles lsb1.MouseDown
        If lsb1.Items.Count = 0 Then
            Return
        End If
        Dim index As Integer = lsb1.IndexFromPoint(e.X, e.Y)
        Dim sourceStr As String = lsb1.Items(index).ToString()
        Dim objDragDropEff As DragDropEffects = DoDragDrop(sourceStr, DragDropEffects.All)
        If objDragDropEff = DragDropEffects.All Then
            lsb1.Items.RemoveAt(lsb1.IndexFromPoint(e.X, e.Y))
        End If

    End Sub

    Private Sub lsb2_DragEnter(sender As Object, e As DragEventArgs) Handles lsb2.DragEnter
        e.Effect = DragDropEffects.All
    End Sub

    Private Sub lsb2_DragDrop(sender As Object, e As DragEventArgs) Handles lsb2.DragDrop
        Dim str As String = CStr(e.Data.GetData(DataFormats.StringFormat))

        lsb2.Items.Add(str)

    End Sub

    Private Sub DragDropToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DragDropToolStripMenuItem.Click

    End Sub

    Private Sub lsb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsb1.SelectedIndexChanged
        'For Each ln As Object In lsb1.SelectedItem
        'lsb2.Items.Add(ln)
        '//Next

    End Sub

    Private Sub btnCarregaXML_Click(sender As Object, e As EventArgs)

        Dim root As XElement
        Dim nomeArquivoXML As String

        'nomeArquivoXML = txtArquivoXML.Text
        root = XElement.Load(nomeArquivoXML)
        'carrega()


    End Sub

    Private Sub carrega()
        Dim linhaformatada As String = ""
        Dim linhaformatada1 As String = ""
        'System.IO.Directory.GetFiles(@"C: \Users\CPD\Documents\Recibos");
        Dim arquivoTxt As String

        arquivoTxt = " + nomeArquivoXML + .txt"
        Dim sr As StreamReader = New StreamReader(arquivoTxt)
        Dim sb As StringBuilder = New StringBuilder
        Try
            While Not sr.EndOfStream
                Dim s As String = sr.ReadLine
                If (s.IndexOf("nrInsc") > -1) Then
                    linhaformatada = (linhaformatada + s)
                End If

                If (s.IndexOf("dhRecepcao") > -1) Then
                    linhaformatada = (linhaformatada + s)
                    linhaformatada = linhaformatada.Replace("-", "")
                End If

                If (s.IndexOf("nrRecibo") > -1) Then
                    linhaformatada = (linhaformatada + s)
                End If

                If (s.IndexOf("cpfTrab") > -1) Then
                    linhaformatada = (linhaformatada + s)
                End If
                sb.AppendLine(s)
                sr.Close()
                linhaformatada1 = (linhaformatada1 + linhaformatada.Substring(18, 8))
                linhaformatada1 = (linhaformatada1 + linhaformatada.Substring(57, 8))
                linhaformatada1 = (linhaformatada1 + linhaformatada.Substring(111, 23))
                linhaformatada1 = (linhaformatada1 + linhaformatada.Substring(199, 11))

                'Dim sw As StreamWriter = New StreamWriter("C:\Users\CPD\Documents\Exemplos\ConsultaXML_Linq\ConsultaXML_Linq\ArqSaida.txt", True)
                Dim sw As StreamWriter = New StreamWriter("C:\recibos-s2229\ArqSaida.txt", True)
                linhaformatada = ""
                linhaformatada1 = ""
                sw.Close()
            End While
        Catch
            txtMsg.Text = "Ocorreu um erro, por favor acesse novamente"
        End Try
    End Sub

    Private Sub btnCarregaXML_Click_1(sender As Object, e As EventArgs) Handles btnCarregaXML.Click


        System.IO.Directory.GetFiles("C:\recibos-s2229")
        Dim i As Integer
            Dim cont As Integer
            Dim nomeArquivoXML As String = ""

            If lsb2.SelectedItem <> "" Then
                nomeArquivoXML = lsb2.SelectedItem
                formatar(nomeArquivoXML)
            Else
                cont = 0

                For Each s As String In Me.lsb2.Items
                    nomeArquivoXML = s.ToString()
                    formatar(nomeArquivoXML)
                    'WhenExample()
                    'Try
                    ' Throw New ArgumentOutOfRangeException()
                    'Catch
                    ' Exit While

                    'End Try
                Next
            End If

    End Sub

        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ''Dim arquivozip As String = ""

        For Each f As String In Directory.GetFiles("C:\recibos-s2229\")

            arquivozip = f

        Next
        arquivozip = arquivozip.Substring(22, 14)

    End Sub

        Private Sub WhenExample()
            Dim i As Integer = 9

            Try
                Throw New ArgumentOutOfRangeException()
            Catch e As ArgumentOutOfRangeException When e.HResult = "&H80131502"

            Finally
                cont = cont + 15
            End Try
        End Sub

        Function formatar(nomeArquivoXML)

            Dim linhaformatada As String = ""
            'Dim linhaformatada1(0 To 7, 0 To 22, 0 To 10) As String       'Dim nomeArquivoXML As String = ""
            Dim linhaformatada1 As String
            Dim recepcao As String
            Dim registro As String
		Dim matricula As String

		Dim root As XElement

		Dim cont = 0
            Dim arquivoTxt As String
        Dim a As String
        Dim tamanho As Integer
        Dim I As Integer, J As Integer, K As Integer

		arquivoTxt = root.ToString()

		System.IO.File.WriteAllText(nomeArquivoXML & ".txt", arquivoTxt)
            arquivoTxt = nomeArquivoXML & ".txt"

            Dim sr As StreamReader = New StreamReader(arquivoTxt)
            Dim sb As StringBuilder = New StringBuilder



            While Not sr.EndOfStream
                Dim s As String = sr.ReadLine

                If (s.IndexOf("dhRecepcao") > -1) Then
                    a = s.IndexOf("dhRecepcao")
                    linhaformatada = (linhaformatada + s)
                    linhaformatada = linhaformatada.Substring(22, 10)
                    linhaformatada = linhaformatada.Replace("-", "")
                End If

                If (s.IndexOf("nrRecibo") > -1) Then
                    linhaformatada = (linhaformatada + s)
                End If

            If (s.IndexOf("matricula") > -1) Then
                linhaformatada = (linhaformatada + s)
                tamanho = s.Length
                If (tamanho > 49) Then
                    linhaformatada = " "
                Else
                    cont = 3
                    sb.AppendLine(s)
                End If
            End If
			arquivoTxt = root.ToString()

		End While

            sr.Close()
            'linhaformatada1 = (linhaformatada1 + linhaformatada.Substring(22, 8))
            If (cont = 3) Then
                linhaformatada1 = (linhaformatada1 + linhaformatada.Substring(0, 8))
                'linhaformatada1 = (linhaformatada1 + linhaformatada.Substring(75, 23))
                linhaformatada1 = (linhaformatada1 + linhaformatada.Substring(28, 23))
            'linhaformatada1 = (linhaformatada1 + linhaformatada.Substring(134, 11))
            linhaformatada1 = (linhaformatada1 + linhaformatada.Substring(87, 11))

            Dim sw As StreamWriter = New StreamWriter("C:\recibos-s2229\" & arquivozip & ".txt", True)
            sw.WriteLine(linhaformatada1)
                linhaformatada = ""
                linhaformatada1 = ""
                sw.Close()
                txtMsg.Text = "Operação efetuada com sucesso"
            End If

        End Function

        Private Sub txtMsg_TextChanged(sender As Object, e As EventArgs) Handles txtMsg.TextChanged

    End Sub

    Private Sub mnu1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnu1.ItemClicked

    End Sub
End Class
