<h1 align="center"> Instruções para executar e testar </h1>

- `Passo 1` Baixar o zip do projeto e descompactar
- `Passo 2` Clicar com o botão direito do mouse na pasta "SuperGasBras-main"
- `Passo 3` Clicar em "Abrir no terminal" (Pode estar escrito de forma diferente variando com sua versão do Windows)
- `Passo 4` Dar o comando "dotnet run" (Ele vai usar a porta 7026, deixe ela aberta)
- `Passo 5` Abrir o Postman para testar (Pode ser a versão web ou aplicativo)
- `Passo 6` Criar uma nova coleção e um novo espaço de trabalho Http no Postman
- `Passo 7` Configurar para o método POST com esse endereço: "http://localhost:7026/api/process/string" (Não há authorization por enquanto)
- `Passo 8` Na aba "Body" selecionar a opção "raw" no formato "JSON"
- `Passo 9` Passar uma requisição nesse formato: 
{
"inputString": "Insira Sua String Aqui"
}
- `Passo 10` Clicar em "Send"
