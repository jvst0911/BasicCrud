<!-- Equipe: Eduardo Augusto Ferreira, João Vitor Tomio -->

# Tutorial GIT

# Como inicializar repositórios
- git init
Para criar um novo repositório, você vai usar o comando "git init" este é um comando único que você usa durante a configuração inicial de um novo repositório.

# Como fazer o primeiro commit em um projeto
- git commit -m "primeiro commit" 
A flag -m indica que vamos adicionar uma mensagem para aquele commit, isso é importante para identificar o que foi feito no commit.

# Como realizar commit de mudanças
- git add -A 
Este comando adiciona automaticamente todas as alterações (novos arquivos, modificados e deletados).

# Como compartilhar suas mudanças com outras pessoas da equipe
- git push
Usado para incluir as alterações de sua branch local no repositório remoto compartilhado.

# Como desfazer alterações
- git commit --amend
Esta é uma forma conveniente de modificar o commit mais recente.
- git rebase
Este comando permite que você reescreva o histórico, aplicando commits automaticamente em sua ramificação de trabalho.

# Como resolver conflitos de merge
Para resolver este tipo de conflito é necessário uma intervenção manual, alterando o código em questão e submetendo um novo commit com as correções.
- git add
- git commit -m "Resolvendo conflitos"
- git push

# Como usar branches
- git checkout
Com este comando você pode navegar entre ramificações preexistentes de seu repositório.
- git branch 
Este comando exibe uma lista de todas as branches (ramificações) existentes em seu reposítório, em seguida pode-se utilizar o git checkout para "entrar" na branch escolhida.

# Como encontrar bugs (git diff, git log, git bisect, git blame)
- git-diff
Exibe as mudanças entre os commits, o commit, a árvore de trabalho, etc
- git log
Para ver o histórico de commits, com informações tais como SHA1, autor, data e descrição, você pode usar este comando
- git-bisect
Utilize a pesquisa binária para localizar o commit que introduziu um bug
- git-blame
Mostra qual revisão e autor modificou por último cada linha de um arquivo

# Como escolher determinados commits
- git cherry-pick
O git cherry pick é um comando que permite ao usuário selecionar commits específicos para trazer à branch desejado.

# Como instalar o Stryker para realizar testes de mutação

## Versões utilizadas:
- Dotnet 6.0;
- xUnit 2.4.1;
- xUnit.Runner.VisualStudio 2.4.5
- dotnet-stryker 2.0

## Passo a passo de como foi feito:
- Foi acessada a pasta de testes
```sh
cd ./BasicCrud.Test/
```
- Executado os seguintes comandos no cmd
```sh
dotnet new tool-manifest
dotnet tool install dotnet-stryker
dotnet stryker
```
## Documentação
Para a documentação completa em como usar o Stryker.NET, veja a [documentação](https://stryker-mutator.io/docs/stryker-net/Configuration)

