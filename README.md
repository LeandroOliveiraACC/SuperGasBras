<h1 align="center"> Instruções para executar e testar </h1>

- `Passo 1` Baixar o zip do projeto e descompactar
- `Passo 2` Clicar com o botão direito do mouse na pasta "SuperGasBras-main"
- `Passo 3` Clicar em "Abrir no terminal" (Pode estar escrito de forma diferente variando com sua versão do Windows)
- `Passo 4` Dar o comando "dotnet run" (Ele vai usar a porta 7026, deixe ela aberta)
- `Passo 5` Abrir o Postman para testar (Pode ser a versão web ou aplicativo)
- `Passo 6` Criar uma nova coleção e um novo espaço de trabalho Http no Postman
- `Passo 7` Configurar para o método POST com esse endereço: "http://localhost:7026/api/process/string"
- `Passo 8` Na aba "Body" selecionar a opção "raw" no formato "JSON"
- `Passo 9` Passar uma requisição nesse formato: 
{
"inputString": "Insira Sua String Aqui"
}
- `Passo 10` Clicar em "Send"


<h2 align="center"> Resultados e Observações </h2>

- `Resultado` Esse endpoint irá receber sua string via requisição POST e retornar a mesma string concatenada com a data e hora no formato: **"[sua string] - Processed at UTC: [data e hora]"** 
- `Observação 1` UTC = Coordenadas Universais de tempo, ou seja, são 3 horas a mais que o horário local brasileiro (foi usado {DateTime.UtcNow}).
- `Observação 2` Este projeto foi criado com o Visual Studio utilizando o modelo "API WEB do ASP.NET Core" e foi usada a versão 7.0 do .net, não foi necessário mexer nos arquivos base criados pelo programa, minha unica alteração neles foi setar a porta.
- `Observação 3` Este código ainda não tem nenhuma configuração de autorização setada e não trata os erros mais incomuns, apenas mostra eles.
- `Observação 4` Pode ser que haja um alerta de "Possível argumento de referência nula para o parâmetro 'inputString'" ao executar, mas ele ocorre devido a versão do C# e a forma que foi tratada a string, não afetando em nada o programa.
