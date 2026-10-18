# 🏓 Pong CSJ Academy - Cyberpunk Edition

> Um clone moderno e polido do clássico Pong, desenvolvido em Unity, com estética Cyberpunk Neon, suporte a Multiplayer Local (PvP) e Inteligência Artificial com ajuste dinâmico de dificuldade.

<!-- ![Pong Gameplay Preview](https://via.placeholder.com/800x450.png?text=Adicione+uma+imagem+ou+GIF+da+gameplay+aqui) --> <!-- Substitua o link acima pelo link de uma imagem/GIF da sua gameplay -->

---

## 🎮 Sobre o Projeto

Este projeto foi construído para demonstrar conceitos sólidos de desenvolvimento de jogos em 2D na Unity, com foco em **arquitetura limpa**, **persistência de dados entre cenas**, **polimento visual (Juice)** e **interatividade dinâmica**.

### ✨ Principais Funcionalidades

- **Múltiplos Modos de Jogo:**
  - **Player vs. AI:** Enfrente a IA em dois níveis de dificuldade (*Fácil* e *Difícil*).
  - **Player vs. Player (Local):** Disputa direta para dois jogadores no mesmo teclado.
- **Identidade Visual Cyberpunk / Neon:**
  - Paleta de cores vibrante em alto contraste sobre fundo escuro.
  - Tipografia futurista imersiva com a fonte **Orbitron** via TextMeshPro.
- **Game Feedback & Juice:**
  - Rastro de luz (*Trail Renderer*) e partículas intensas de impacto na bola.
  - Efeitos de *Squash & Stretch* na bola ao rebater usando **DOTween**.
  - Shake de câmera sutil para dar impacto aos rebotes.
  - Paredes reativas que mudam de cor dinamicamente na colisão.
- **Interface e Fluxo Completo:**
  - Navegação entre Menu Principal, Seleção de Modo, Dificuldade e Game Over.
  - Placar interativo e verificação automática de limites de pontuação.

---

## 🛠️ Tecnologias e Ferramentas Utilizadas

- **Engine:** Unity (URP 2D)
- **Linguagem:** C#
- **Animação & Efeitos (Tweening):** DOTween (Demigiant)
- **UI & Tipografia:** TextMeshPro
- **Controle de Versão:** Git / GitHub

---

## 🧱 Arquitetura e Decisões de Código

- **Persistência de Dados (`GameSettings.cs`):** Classe estática para transicionar configurações (modo contra IA vs. PvP, nível de dificuldade) entre diferentes cenas sem acoplamento desnecessário.
- **Gerenciador de Estado (`GameManager.cs`):** Controle centralizado do ciclo de jogo, contagem de pontos, estado de Game Over e reset das animações do DOTween (`DOTween.KillAll()`) para prevenção de vazamento de memória e exceções ao descarregar objetos.
- **Comportamento Reativo de IA (`AIPaddle.cs`):** Leitura adaptativa da posição da bola baseada na velocidade máxima da raquete de acordo com a dificuldade selecionada.

---

## 🕹️ Controles

| Ação | Player 1 (Esquerda) | Player 2 (Direita) |
| :--- | :--- | :--- |
| **Mover para Cima** | `W` | `Seta para Cima (Up Arrow)` |
| **Mover para Baixo** | `S` | `Seta para Baixo (Down Arrow)` |

---

## 🚀 Como Executar o Projeto

1. Clone o repositório:
   ```bash
   git clone (https://github.com/fasnfilho/PongCSJA.git)
   
2. Abra a Unity Hub e adicione o projeto importado (recomendado usar Unity 2022 LTS ou superior).

3. Abra a cena do Menu Principal localizada em Assets/Scenes/Scene_MainMenu.unity.

4. Pressione o botão Play no editor!


Desenvolvido com ❤️ por Fábio Agostinho
