# Mesozóicos — Draftosaurus

Jogo Draftosaurus desenvolvido em C# Windows Forms (.NET Framework 4.8) para o Projeto Integrador III.

O projeto utiliza a DLL `DraftServer.dll` para comunicação com o servidor do jogo.

## Estrutura

- **Lobby** — listar, criar e entrar em partidas
- **WaitingRoom** — sala de espera, listar jogadores e iniciar partida
- **Game** — tela principal do jogo (mão, cercados, histórico, jogadas)
- **Tabuleiro** — visualização gráfica do tabuleiro próprio e dos oponentes
- **Resultado** — tela de resultado ao fim da partida
- **GameService** — acesso centralizado aos dados do servidor (mão, tabuleiro, turno, partida)
- **BotScoring** — pontuação marginal por cercado e fatores de confiança por turno
- **BotStrategy** — algoritmo de decisão do bot (Minimax Depth-1 com denial)
- **ThemeHelper** — tema visual da aplicação

## Bot Estratégico

O bot utiliza um algoritmo **Minimax de profundidade 1** adaptado para Draftosaurus:

```
valor_líquido = meu_ganho - melhor_ganho_do_adversário_com_o_que_eu_passo
```

A cada turno, o bot avalia todas as combinações possíveis de dino e cercado, considera o que passará ao adversário, e escolhe a jogada com maior valor líquido. A estratégia varia entre Rodada 1 (fundação) e Rodada 2 (finalização), com fatores de confiança distintos por cercado.

Para detalhes completos do algoritmo, ver [`STRATEGY.md`](STRATEGY.md).

## Como rodar

1. Abrir `Mesozoicos.slnx` no Visual Studio
2. Build (Ctrl+Shift+B)
3. Executar (F5)

## Autores

- [@x0r1c](https://www.linkedin.com/in/x0r1c/)
- [@cauacarvalho](https://www.linkedin.com/in/cauacarvalho97/)
- [@rp11silva](https://www.linkedin.com/in/rafael-pascual-da-silva-b895bb3b0/)
