<h1 align="center"> Instruções para testar </h1>

<br>1 - Baixar o zip do projeto e descompactar</br>
<br>2 - Clicar com o botão direito do mouse na pasta descompactada</br>
<br>3 - Clicar em Abrir no terminal</br>
<br>4 - Dar o comando "dotnet run"</br>
<br>5 - Abrir o Postman para testar</br>
<br>6 - Criar uma nova coleção e um novo espaço de trabalho no Postman</br>
<br>7 - Configurar para o método POST com esse endereço: "http://localhost:7026/api/process/string"</br>
<br>8 - Na aba "Body" selecionar a opção "raw" no formato JSON</br>
<br>9 - Passar uma requisição nesse formato: </br>
<br>{</br>
<br>  "inputString": "Insira Sua String Aqui"</br>
<br>}</br>
<br>10 - Clicar em "Send"</br>
