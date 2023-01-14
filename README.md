# Geometry-Output

Teste técnico do processo seletivo para o Grupo Voalle

## IMPORTANTE

O projeto utiliza uma API externa, e é necessária uma API key, que por motivos de segurança não pode estar diretamente no código. Foi enviada juntamente com o link do repositório, já que se trata apenas de um projeto avaliativo sem implicações de usuários terceiros.

Tenho em mente que o ideal seria utilizar uma ferramenta como um KMS ou uma variável de ambiente, mas por conta do prazo essa foi a solução mais viável

## Utilização do projeto

Basta clonar o projeto, entrar na pasta GeometryOutput, adicionar a API key no arquivo ```SecretKeys```, rodar o comando ```dotnet restore``` e em seguida ```dotnet run```. Será gerado um pdf automaticamente, e o usuário poderá optar por receber um email com o resultado.
