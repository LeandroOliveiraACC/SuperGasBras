<h1 align="center"> Instruções para testar </h1>

- `Passo 1` Baixar o zip do projeto e descompactar
- `Passo 2` Clicar com o botão direito do mouse na pasta descompactada
- `Passo 3` Clicar em Abrir no terminal
- `Passo 4` Dar o comando "dotnet run"
- `Passo 5`Abrir o Postman para testar
- `Passo 6`Criar uma nova coleção e um novo espaço de trabalho no Postman
- `Passo 7`Configurar para o método POST com esse endereço: "http://localhost:7026/api/process/string"
- `Passo 8`Na aba "Body" selecionar a opção "raw" no formato JSON
- `Passo 9`Passar uma requisição nesse formato: 
<br>{
<br>"inputString": "Insira Sua String Aqui"
<br>}
- `Passo 10`Clicar em "Send"
