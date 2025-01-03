*Tecnologia/IDE
 Visual Studio
 Windows Forms

*Carrega lista de arquivos .xml de um diretório
	**Directory.GetFiles       
*Fazer a seleção dos arquivos para geração .xml para .txt
	**For Each row As Object In lsb1.SelectedItems
*Gravar 3 campos para o arquivo .txt final
	**sr As StreamReader = New StreamReader(arquivoTxt)
  **sb As StringBuilder = New StringBuilder
