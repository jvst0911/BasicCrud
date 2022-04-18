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


# Como encontrar bugs (git diff, git log, git bisect, git blame)

# Como escolher determinados commits

