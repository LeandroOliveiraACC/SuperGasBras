<h1 align="center"> Instruções para testar </h1>

- `Funcionalidade 1`: Baixar o zip do projeto e descompactar
- `Funcionalidade 2`: Clicar com o botão direito do mouse na pasta descompactada
- `Funcionalidade 3`: Clicar em Abrir no terminal
<br>4 - Dar o comando "dotnet run"
<br>5 - Abrir o Postman para testar
<br>6 - Criar uma nova coleção e um novo espaço de trabalho no Postman
<br>7 - Configurar para o método POST com esse endereço: "http://localhost:7026/api/process/string"
<br>8 - Na aba "Body" selecionar a opção "raw" no formato JSON
<br>9 - Passar uma requisição nesse formato: 
<br>{
<br>  "inputString": "Insira Sua String Aqui"
<br>}
<br>10 - Clicar em "Send"
