using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Draft;

namespace Mesozoicos
{
    public static class GameService
    {
        // ==================== HEADER PADRAO ====================

        public static void AplicarHeader(Form form, Label lblVersion, Label lblGrupo)
        {
            lblVersion.Text = "v" + Jogo.versao;
            lblGrupo.Text = "Mesozóicos";
        }

        // ==================== TABULEIRO OPONENTE ====================

        public static List<string[]> GetBoardStateOponente(int idJogador)
        {
            var result = new List<string[]>();
            string tabuleiro = Jogo.ExibirTabuleiro(idJogador);
            if (string.IsNullOrEmpty(tabuleiro)) return result;

            string[] lines = ParseResponse(tabuleiro);
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                string[] play = line.Split(',');
                if (play.Length >= 3)
                {
                    string cercadoName = GetCercadoName(play[0]);
                    string dinoName = GetDinossauroName(play[1]);
                    result.Add(new string[] { play[0], cercadoName ?? play[0], play[1], dinoName ?? play[1], play[2] });
                }
            }
            return result;
        }

        public static string[] ParseResponse(string response)
        {
            if (string.IsNullOrEmpty(response)) return new string[0];
            response = response.Replace("\r", "");
            if (response.EndsWith("\n"))
                response = response.Substring(0, response.Length - 1);
            return response.Split('\n');
        }

        // ==================== DINOSSAUROS ====================

        public static string GetDinossauroName(string idDinossauro)
        {
            string[] dinossauros = ParseResponse(Jogo.ListarDinossauros(true));
            foreach (var dino in dinossauros)
            {
                string[] info = dino.Split(',');
                if (info.Length >= 2 && info[0] == idDinossauro) return info[1];
            }
            return null;
        }

        public static string GetDinossauroCode(string nameDinossauro)
        {
            string[] dinossauros = ParseResponse(Jogo.ListarDinossauros(true));
            foreach (var dino in dinossauros)
            {
                string[] info = dino.Split(',');
                if (info.Length >= 2 && info[1] == nameDinossauro) return info[0];
            }
            return null;
        }

        public static List<string[]> GetAllDinossauros()
        {
            var result = new List<string[]>();
            string[] dinossauros = ParseResponse(Jogo.ListarDinossauros(true));
            foreach (var dino in dinossauros)
            {
                string[] info = dino.Split(',');
                if (info.Length >= 2)
                    result.Add(info);
            }
            return result;
        }

        public static Color GetDinoColor(string corNome)
        {
            if (string.IsNullOrEmpty(corNome)) return Color.Gray;
            string cor = corNome.Trim().ToLower();
            if (cor.Contains("azul")) return Color.FromArgb(41, 128, 185);
            if (cor.Contains("vermelh")) return Color.FromArgb(192, 57, 43);
            if (cor.Contains("verde")) return Color.FromArgb(39, 174, 96);
            if (cor.Contains("amarel")) return Color.FromArgb(241, 196, 15);
            if (cor.Contains("laranja")) return Color.FromArgb(230, 126, 34);
            if (cor.Contains("rosa") || cor.Contains("pink")) return Color.FromArgb(205, 132, 174);
            return Color.Gray;
        }

        // ==================== CERCADOS ====================

        public static string GetCercadoName(string idCercado)
        {
            string[] cercados = ParseResponse(Jogo.ListarCercados());
            foreach (var cercado in cercados)
            {
                string[] info = cercado.Split(',');
                if (info.Length >= 2 && info[0] == idCercado) return info[1];
            }
            return null;
        }

        public static string GetCercadoCode(string nameCercado)
        {
            string[] cercados = ParseResponse(Jogo.ListarCercados());
            foreach (var cercado in cercados)
            {
                string[] info = cercado.Split(',');
                if (info.Length >= 2 && info[1] == nameCercado) return info[0];
            }
            return null;
        }

        public static List<string[]> GetAllCercados()
        {
            var result = new List<string[]>();
            string[] cercados = ParseResponse(Jogo.ListarCercados());
            foreach (var cercado in cercados)
            {
                string[] info = cercado.Split(',');
                if (info.Length >= 2)
                    result.Add(info);
            }
            return result;
        }

        // ==================== JOGADORES ====================

        public static string GetUsernameById(string idJogo, string idPlayer)
        {
            string[] players = ParseResponse(Jogo.ListarJogadores(int.Parse(idJogo)));
            foreach (var player in players)
            {
                string[] info = player.Split(',');
                if (info.Length >= 2 && info[0] == idPlayer) return info[1];
            }
            return null;
        }

        public static List<string[]> GetAllPlayers(string idJogo)
        {
            var result = new List<string[]>();
            string[] players = ParseResponse(Jogo.ListarJogadores(int.Parse(idJogo)));
            foreach (var player in players)
            {
                string[] info = player.Split(',');
                if (info.Length >= 2)
                    result.Add(info);
            }
            return result;
        }

        // ==================== DADO ====================

        public static string GetDiceSideName(string diceSideCode)
        {
            string[] sides = ParseResponse(Jogo.ListarFacesDado());
            foreach (var side in sides)
            {
                string[] info = side.Split(',');
                if (info.Length >= 2 && info[0] == diceSideCode) return info[1];
            }
            return null;
        }

        // ==================== PARTIDA ====================

        public static string[] GetGameStatus(string idGame)
        {
            string atualGame = Jogo.VerificarPartida(int.Parse(idGame));
            if (string.IsNullOrEmpty(atualGame)) return null;
            atualGame = atualGame.Replace("\r", "").TrimEnd('\n');
            if (atualGame.EndsWith(","))
                atualGame = atualGame.Substring(0, atualGame.Length - 1);
            return atualGame.Split(',');
        }

        // ==================== VALIDACAO DE JOGADA ====================

        private static readonly Dictionary<string, List<string>> CercadosDadoValido = new Dictionary<string, List<string>>()
        {
            {"FI", new List<string>(){"FL", "AL", "VZ", "TI" }},
            {"MT", new List<string>(){"FL", "AL", "VZ", "TI" }},
            {"RS", new List<string>(){"FL", "WC", "VZ", "TI" }},
            {"CD", new List<string>(){"PR", "WC", "VZ", "TI" }},
            {"PA", new List<string>(){"PR", "AL", "VZ", "TI" }},
            {"IS", new List<string>(){"PR", "WC", "VZ", "TI" }}
        };

        public static bool IsValidPlay(string cercadoCode, string diceSideCode)
        {
            if (!CercadosDadoValido.ContainsKey(cercadoCode))
                return false;
            return CercadosDadoValido[cercadoCode].Contains(diceSideCode);
        }

        // ==================== MAO DO JOGADOR ====================

        public static List<string[]> GetPlayerHand(int idJogador, string senha)
        {
            var result = new List<string[]>();
            string returned = Jogo.ExibirMao(idJogador, senha);
            if (string.IsNullOrEmpty(returned)) return result;

            string[] lines = ParseResponse(returned);
            for (int i = 1; i < lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i])) continue;
                string[] info = lines[i].Split(',');
                if (info.Length >= 2)
                {
                    string dinoName = GetDinossauroName(info[0]);
                    result.Add(new string[] { info[0], dinoName ?? info[0], info[1] });
                }
            }
            return result;
        }

        // ==================== TABULEIRO ====================

        public static List<string[]> GetBoardState(int idJogador, string senha)
        {
            var result = new List<string[]>();
            string tabuleiro = Jogo.ExibirTabuleiro(idJogador, senha);
            if (string.IsNullOrEmpty(tabuleiro)) return result;

            string[] lines = ParseResponse(tabuleiro);
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                string[] play = line.Split(',');
                if (play.Length >= 3)
                {
                    string cercadoName = GetCercadoName(play[0]);
                    string dinoName = GetDinossauroName(play[1]);
                    result.Add(new string[] { play[0], cercadoName ?? play[0], play[1], dinoName ?? play[1], play[2] });
                }
            }
            return result;
        }

        // ==================== HISTORICO ====================

        public static string GetHistory(int idPartida)
        {
            return Jogo.ListarHistorico(idPartida);
        }

        // ==================== VERIFICAR TURNO ====================

        // Retorna: status turno, jogador dado, dado sorteado + lista jogadas
        public static string GetTurnInfoRaw(int idPartida)
        {
            return Jogo.VerificarTurno(idPartida);
        }

        public static string GetTurnInfoRaw(int idPartida, int turno)
        {
            return Jogo.VerificarTurno(idPartida, turno);
        }

        // ==================== BUILD TABULEIRO OPONENTE VIA TURNOS ====================

        // Constroi o tabuleiro de um oponente percorrendo todos os turnos fechados
        // Retorna lista de [cercadoCode, cercadoName, dinoCode, dinoName, quantidade]
        public static List<string[]> BuildBoardFromTurns(int idPartida, int idOponente)
        {
            // Pegar turno atual
            string[] gameInfo = GetGameStatus(Convert.ToString(idPartida));
            if (gameInfo == null || gameInfo.Length < 2) return new List<string[]>();

            int turnoAtual;
            if (!int.TryParse(gameInfo[1], out turnoAtual)) return new List<string[]>();

            // Dicionario: cercadoCode -> (dinoCode -> quantidade)
            var board = new Dictionary<string, Dictionary<string, int>>();

            // Percorre todos os turnos fechados (1 ate turnoAtual-1)
            for (int t = 1; t < turnoAtual; t++)
            {
                try
                {
                    string turnData = Jogo.VerificarTurno(idPartida, t);
                    if (string.IsNullOrEmpty(turnData)) continue;

                    string[] lines = ParseResponse(turnData);

                    // Primeira linha = header (status, jogador dado, dado)
                    // Linhas seguintes = jogadas (formato depende da DLL)
                    for (int i = 1; i < lines.Length; i++)
                    {
                        if (string.IsNullOrWhiteSpace(lines[i])) continue;
                        string[] parts = lines[i].Split(',');

                        // Tenta encontrar o jogador nessa jogada
                        // Formato esperado: idJogador, dinossauro, cercado (ou variacao)
                        if (parts.Length < 3) continue;

                        string jogadorId = parts[0].Trim();
                        if (jogadorId != Convert.ToString(idOponente)) continue;

                        // Formato: idJogador, codigoDinossauro, codigoCercado
                        string dinoCode = parts[1].Trim();
                        string cercadoCode = parts.Length >= 3 ? parts[2].Trim() : "??";

                        if (!board.ContainsKey(cercadoCode))
                            board[cercadoCode] = new Dictionary<string, int>();

                        if (!board[cercadoCode].ContainsKey(dinoCode))
                            board[cercadoCode][dinoCode] = 0;

                        board[cercadoCode][dinoCode]++;
                    }
                }
                catch { continue; }
            }

            // Converte pra lista no formato padrao
            var result = new List<string[]>();
            foreach (var cercado in board)
            {
                string cercadoName = GetCercadoName(cercado.Key) ?? cercado.Key;
                foreach (var dino in cercado.Value)
                {
                    string dinoName = GetDinossauroName(dino.Key) ?? dino.Key;
                    result.Add(new string[] { cercado.Key, cercadoName, dino.Key, dinoName, dino.Value.ToString() });
                }
            }
            return result;
        }
    }
}
