# Teste Tecnico

Projeto criado em dotnet core (c#), vscode e SO ubuntu.

## Testes
Foi utilizado a ferramenta insomnia

## URls
## GET ID
https://localhost:5001/api/funcionario/show/2
## GET
https://localhost:5001/api/funcionario
## POST
https://localhost:5001/api/funcionario/create
```json
{
	"nome":"teste ",
	"endereco": "Rua A",
	"email": "maria.flausino@hotmail.com",
	"telefone": "319854045891"
}
```
## PUT
https://localhost:5001/api/funcionario
```json
{
	"id":"1",
	"nome":"teste",
	"endereco": "Rua BCB",
	"email": "maria.flausino@hotmail.com",
	"telefone": "319854045891"
}
```
## DELETE
https://localhost:5001/api/funcionario/1

Metodos udpate e delete alterados para não usar post.


