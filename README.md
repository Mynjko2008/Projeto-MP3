# 🎧 Projeto Toca Música (C# + Windows Forms + MySQL)

Sistema desktop desenvolvido em C# com Windows Forms que permite:

- Autenticação de usuários (cadastro, login, recuperação de senha)
- Reprodução de músicas organizadas por gênero, artista e álbum
- Integração com banco de dados MySQL para gerenciamento de usuários
- Interface gráfica personalizada com álbuns visuais e controle de volume

---

## 📦 Funcionalidades

- ✅ Cadastro de novos usuários com validação
- ✅ Login com validação no banco de dados
- ✅ Recuperação de senha por nome de usuário
- ✅ Catálogo de músicas por:
  - Nacional / Internacional
  - Estilo: MPB, Rock, Pop
  - Artistas: Queen, Gorillaz, Tim Maia, The Beatles, entre outros
- ✅ Player com controle de volume, velocidade e troca dinâmica de álbuns
- ✅ Interface com Comboboxes encadeados e imagens de capa dos álbuns

---

## 💾 Banco de Dados

Nome do banco: `bd_cadastro`  
Tabela: `tb_usuarios`  

```sql
CREATE TABLE tb_usuarios (
  id_usuario INT AUTO_INCREMENT PRIMARY KEY,
  nome_usuario VARCHAR(30) UNIQUE NOT NULL,
  senha VARCHAR(8) NOT NULL
);

📁 Estrutura de Diretórios
Projeto_Mp3/
├── Banco.cs              // Conexão com MySQL
├── Cadastro.cs           // Tela de cadastro
├── Login.cs              // Tela de login
├── Senha.cs              // Recuperação de senha
├── Musicas.cs            // Tela principal (player)
├── Variaveis.cs          // Variáveis globais (nome, senha, ID)
├── Program.cs            // Ponto de entrada da aplicação
├── Form1.cs              // Tela de acesso inicial
├── Musicas/              // Pasta com arquivos .mp3 organizados por artista
└── ALBUNS/            // Capas de álbuns (imagens associadas às músicas)


🔧 Tecnologias Utilizadas
💻 C# (Windows Forms)

🗃️ MySQL/MariaDB

🔗 MySQL Connector

🎵 WMPLib (Windows Media Player Library)

🎨 Recursos visuais personalizados

⚠️ Observações
🔐 Senhas exigem exatamente 8 caracteres

🔊 Volume pode ser controlado diretamente no player

🧪 Esse projeto foi desenvolvido como TCC de Programação Web com foco em C# Desktop

👨‍💻 Desenvolvedor
Arthur Mynjko Lara Bento
Estudante de Desenvolvimento de Sistemas | Apaixonado por Web e C#
