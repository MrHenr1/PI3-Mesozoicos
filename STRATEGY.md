# Estratégia do Bot — Mesozóicos

## Dinossauros

| Código | Nome | Cor |
|--------|------|-----|
| Br | Braquiossauro | Roxo |
| Ep | Espinossauro | Laranja |
| Et | Estegossauro | Azul |
| Pa | Parasaurolófo | Verde |
| Ti | Tiranossauro Rex | Vermelho |
| Tr | Tricérátops | Amarelo |

## Cercados e Pontuação

| Código | Nome | Regra | Pontuação |
|--------|------|-------|-----------|
| FI | Floresta da Igualdade | Só mesma espécie | 2/4/8/12/18/24 para 1/2/3/4/5/6 dinos |
| CD | Campina da Diferença | Só espécies diferentes | 1/3/6/10/15/21 para 1/2/3/4/5/6 dinos |
| PA | Pradaria do Amor | Qualquer espécie | 5 pts por casal (par da mesma espécie) |
| MT | Mata Tripla | Máx 3, qualquer espécie | 7 pts se tiver exatamente 3 dinos |
| RS | Rei da Selva | Máx 1 dino | 7 pts se sua qtd dessa espécie >= qualquer adversário |
| IS | Ilha Solitária | Máx 1 dino | 7 pts se for o único dessa espécie no seu zoo |
| RI | Rio | Ilimitado | 1 pt por dino |

**T-Rex (Ti):** cada cercado do seu zoo com pelo menos 1 Ti = +1 pt adicional. Mais de 1 Ti no mesmo cercado ainda vale apenas +1. O bônus não se aplica ao Rio.

## Faces do Dado

| Código | Nome | Restrição para não-dono |
|--------|------|------------------------|
| FL | Floresta | FI, MT ou RS |
| PR | Pradaria | CD, PA ou IS |
| AL | Alimentação | FI, MT ou PA |
| WC | Banheiros | RS, CD ou IS |
| VZ | Cercado Vazio | Qualquer cercado ainda vazio |
| TI | Tiranossauro Rex | Qualquer cercado sem T-Rex |

**O dono do dado pode jogar em qualquer cercado, ignorando a restrição.**

Para VZ: a restrição é verificada em tempo de execução — cercados com dinos são removidos da lista válida antes da decisão. Para TI: cercados que já contêm T-Rex são removidos da lista.

## Estrutura do Jogo (2 jogadores)

2 rodadas × 6 turnos = 12 dinos colocados por jogador ao final.

Cada turno: todos escolhem 1 dino simultaneamente → jogadas reveladas quando o turno fecha → passam o restante da mão para a esquerda → novo turno começa.

## Fluxo de Informação (2 jogadores)

A principal vantagem estratégica em 2 jogadores é que, após o primeiro passe, você reconstrói a mão original do adversário:

> **Mão original do adversário = dinos recebidos + dino que ele jogou (visível no tabuleiro)**

| Turno | O que o bot sabe | Comportamento |
|-------|-----------------|---------------|
| 1 | Só minha mão. Tabuleiro vazio. | Conservador — funda FI ou CD |
| 2–6 | Tabuleiro adversário atualizado. Mão adversária conhecida. | Minimax completo com denial |
| 7 | Novas mãos sorteadas. Mão adversária desconhecida de novo. | Prioriza fechar o que foi montado na R1 |
| 8–12 | Informação completa de novo. | Finaliza — RS e IS entram se condições forem favoráveis |

As jogadas são simultâneas no servidor e reveladas apenas quando o turno fecha. O bot não precisa consultar jogadas em tempo real — o tabuleiro já vem atualizado no início de cada turno.

## Algoritmo — Minimax Depth-1

Para cada combinação possível (dino D, cercado C):

```
meu_ganho        = pontuação_marginal(D, C, meu_tabuleiro) × confiança(C, turno)
ganho_adversário = max(pontuação_marginal(D2, C2, tabuleiro_adversário))
                   para cada D2 na mão que eu passo, C2 válido para adversário

valor_líquido = meu_ganho - ganho_adversário
```

Escolhe a jogada com maior valor líquido. O denial é o coração do algoritmo: às vezes vale jogar subótimo para si se isso impede o adversário de ganhar mais do que você ganharia.

## Pontuação Marginal por Cercado

### FI — Floresta da Igualdade
Score: `ScoreFI[n+1] - ScoreFI[n]` onde `ScoreFI = {0, 2, 4, 8, 12, 18, 24}`

Só válido se a espécie colocada for a mesma que já ocupa FI (ou se estiver vazio).

### CD — Campina da Diferença
Score: `ScoreCD[n+1] - ScoreCD[n]` onde `ScoreCD = {0, 1, 3, 6, 10, 15, 21}`

Só válido se a espécie ainda não estiver em CD.

### PA — Pradaria do Amor
- Espécie com contagem ímpar em PA → +5 pts (completa um casal)
- Espécie com contagem par em PA → +1.0 pt (valor de setup)

### MT — Mata Tripla
- 0 dinos → 1º: +2.0 pts (setup)
- 1 dino → 2º: +3.5 pts (setup — fica próximo de fechar)
- 2 dinos → 3º: +7.0 pts (fecha o cercado)

### RS — Rei da Selva
+7 pts se `minha_contagem_da_espécie >= contagem_adversário`. Caso contrário, 0.

### IS — Ilha Solitária
+7 pts se a espécie não aparecer em nenhum outro cercado do meu zoo. Caso contrário, 0.

### Rio
+1 pt sempre. Fallback garantido.

## Confiança por Cercado

A pontuação marginal é multiplicada por um fator de confiança que reflete o risco real de cada jogada.

### FI
- Espécie já estabelecida em FI e dino colocado é da mesma espécie → **1.0** (comprometido, sem risco)
- FI ainda vazia (R1) → **0.7** (incerteza sobre espécies futuras)
- R2 → **1.0**

### MT
- R1 → **0.9** | R2 → **1.0**

### CD e PA
- Sempre **1.0**

### RS — dinâmico por estado do jogo
- Turno < 7 (R1) → **0.05** (virtualmente ignorado)
- Turno ≥ 7 e lead ≥ 2 → **0.9** (oportunidade clara)
- Turno ≥ 7 e lead = 1 → **0.45** (moderado) / **0.85** (turno 10+)
- Turno ≥ 7 e empate → **0.1–0.35** (arriscado)

### IS — dinâmico por raridade da espécie
- Turno < 7 (R1) → **0.05** (virtualmente ignorado)
- Turno ≥ 7: base temporal (0.35 / 0.75 / 1.0) + bônus de raridade (+0.1 por cópia já vista nos dois tabuleiros, máx +0.4)

## Prioridade de Cercados

1. **FI e CD** — maior potencial de pontos, construir desde o início
2. **MT com 2 dinos** — fechar vira prioridade máxima (7 pts com qualquer dino)
3. **PA** — especialmente com 3 da mesma espécie na mão
4. **MT vazio/com 1 dino** — buffer útil quando não há opção melhor
5. **Rio** — descarte nobre, sempre garante 1 pt
6. **RS e IS** — apenas na Rodada 2, apenas quando as condições forem favoráveis

## Arquitetura

| Arquivo | Responsabilidade |
|---------|-----------------|
| `BotScoring.cs` | Pontuação marginal, validação de jogada, fatores de confiança |
| `BotStrategy.cs` | Algoritmo minimax depth-1, cálculo de denial |
| `Game.cs` | Chama `BotStrategy.EscolherJogada()` no `ExecutarJogadaBot()` |
| `GameService.cs` | Acesso aos dados do servidor — sem lógica de IA |
