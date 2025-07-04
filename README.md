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
└── Resources/            // Capas de álbuns (imagens associadas às músicas)


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
<div align="center">
  <a href="https://www.linkedin.com/in/arthur-mynjko-985b482b3/" target="_blank">
    <img src="https://img.shields.io/badge/-LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white">
  </a>
  <a href="mailto:amynjko@gmail.com">
    <img src="https://img.shields.io/badge/-Gmail-D14836?style=for-the-badge&logo=gmail&logoColor=white">
  </a>
  <a href="https://github.com/Mynjko2008">
    <img src="https://img.shields.io/github/followers/Mynjko2008?style=for-the-badge&logo=github">
  </a>
  <a href="https://www.instagram.com/arthur_mynjko/" target="_blank">
    <img src="https://img.shields.io/badge/-Instagram-E4405F?style=for-the-badge&logo=instagram&logoColor=white">
  </a>
</div>
