# Chaves

Gerenciador de senhas por linha de comando. Armazena credenciais localmente em `C:\chaves\pass.csv` com criptografia AES-128 protegida por palavra-chave definida pelo usuário.

## Tecnologias

*   .NET 10
*   C#
*   CsvHelper — leitura e escrita de arquivos CSV
*   Newtonsoft.Json — leitura do mapeamento de colunas
*   AES-128 + MD5 — criptografia das senhas

## Estrutura do projeto

```
src/
  Chaves.App      → Aplicação console (entrada, menus, telas)
  Chaves.Core     → Regras de negócio (serviços de pesquisa, cadastro e importação)
  Chaves.Data     → Modelos de dados e comparadores
  Chaves.Service  → Acesso a arquivos, criptografia e importação de CSV
```

## Como executar

**Pré-requisito:** .NET 10 SDK instalado.

```bash
dotnet run --project src/Chaves.App
```

O idioma do menu é detectado automaticamente pelo sistema operacional (`pt-BR` ou `en-US`).

## Menu principal

```
[P]esquisar | [C]adastrar | [I]mportar | [S]air
```

| Tecla (pt-BR) | Tecla (en-US) | Ação |
| --- | --- | --- |
| P | S | Pesquisar senhas armazenadas |
| C | R | Cadastrar nova senha |
| I | I | Importar senhas de um arquivo CSV |
| S | X | Sair da aplicação |

---

## Fluxos

### Cadastrar senha

1.  Informe o **Serviço** (ex: `github.com`)
2.  Informe o **Usuário** (ex: `usuario@email.com`)
3.  Informe a **Senha** em texto plano
4.  Informe a **Palavra-chave** — usada para criptografar a senha

A senha é cifrada com AES-128 antes de ser gravada. A palavra-chave nunca é armazenada.

```
Serviço: github.com
Usuário: usuario@email.com
Senha: minhasenha123
Palavra-chave: segredo
→ Cadastrado com sucesso!
```

---

### Pesquisar senhas

1.  Informe a **Palavra-chave**
2.  O app tenta descriptografar cada senha armazenada com a chave informada
3.  Senhas que correspondem à chave são exibidas em texto plano
4.  Senhas cadastradas com outra chave exibem `CRIPTOGRAFADA` (en-US: `ENCRYPTED`)

```
Palavra-chave: segredo

Servico                        Usuário                             Senha
-----------------------------------------------------------------------------------------------
github.com                     usuario@email.com                   minhasenha123
outro-site.com                 outro@email.com                     CRIPTOGRAFADA
```

Cada senha pode ter sua própria palavra-chave independente. Ao pesquisar, apenas as senhas protegidas com a chave informada são reveladas.

---

### Importar senhas de CSV

1.  Informe o **caminho completo** do arquivo CSV
2.  O app detecta automaticamente o formato pelo cabeçalho do arquivo
3.  As senhas importadas são salvas sem criptografia — o campo `Pass` é gravado como está no CSV original

Formatos suportados:

| Formato | Cabeçalho esperado |
| --- | --- |
| Padrão (interno) | `Id,Service,User,Pass` |
| Google Chrome | `name,url,username,password` |
| Norton | `Username,Password,Title,Login URL,Notes` |

```
Caminho do arquivo: C:\exportado\chrome.csv
→ Importado com sucesso (42)
```

---

## Armazenamento

As senhas ficam em `C:\chaves\pass.csv` com o seguinte formato:

```
Id,Service,User,Pass
3f2a1b...,github.com,usuario@email.com,<Base64 cifrado>
```

O campo `Pass` contém o texto cifrado em Base64. Senhas importadas de outros gerenciadores ficam em texto plano no campo `Pass` e exibirão `CRIPTOGRAFADA` ao pesquisar (pois não foram cifradas com o esquema interno).

## Criptografia

*   A palavra-chave é convertida em uma chave AES-128 via **MD5**
*   A senha é cifrada com **AES/CBC/PKCS7** com IV zerado
*   Um prefixo interno `CHAVES:` é adicionado antes de cifrar — permite verificar se a descriptografia usou a chave correta sem armazenar a palavra-chave
*   Se a descriptografia falhar ou não encontrar o prefixo, a senha é exibida como `CRIPTOGRAFADA`