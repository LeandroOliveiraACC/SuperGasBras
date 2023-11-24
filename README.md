<h1 align="center"> Instruções para testar </h1>

1 - Baixar o zip do projeto e descompactar
2 - Clicar com o botão direito do mouse na pasta descompactada
3 - Clicar em Abrir no terminal
4 - Dar o comando "dotnet run"
5 - Abrir o Postman para testar
6 - Criar uma nova coleção e um novo espaço de trabalho no Postman
7 - Configurar para o método POST com esse endereço: "https://localhost:7026/api/process/string"
8 - Na aba "Body" selecionar a opção "raw" no formato JSON
9 - Passar uma requisição nesse formato: 
{
  "inputString": "Insira Sua String Aqui"
}
10 - Clicar em "Send"
