using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class USER_MESSAGE
    {
        public static string Sucesso => "Sucesso.";
        public static string Servico_Existente => "Esse serviço já se encontra disponível.";
        public static string Erro_Operacao => "Erro ao realizar a operação";
        public static string Ordem_Existente => "Há uma ordem aberta para esse veículo.";
        public static string Ordem_Cancelar => "Deseja mesmo cancelar essa ordem?";
        public static string Ordem_NEncontrada => "Ordem não encontrada!";
        public static string Efetue_Login => "Primeiramente efetue login nesse sistema!";
        public static string Login_Efetuado => "Login efetuado com sucesso.";
        public static string Modelo_Invalido => "Modelo inválido.";
        public static string Erro_Consultar => "Erro ao consulta o banco, banco vazio ou inacessível.";
        public static string Erro_Prencher => "Erro ao tentar apresentar dados.";
        public static string Escolha_Responsavel => "É necessário que seja selecionado um responsável.";
        public static string Exito_Atualizar => "Exito em atualizar os dados.";

        public static string Messagem_Exclusao => "Deseja mesmo excluir esse registro?";
        public static string Messagem_Bloqueio => "Deseja mesmo bloquear esse cliente?";
        public static string Senha_Nao_Coincedem => "As senhas não coincidem";
        public static string Login_Indisponivel => "Esse login se encontra em uso.";
        public static string Credenciais_Invalidas => "Erro, confira suas credenciais.";
        public static string Funcionalidade_Indisponivel => "Desculpe, essa funcionalidade não se encontra disponível.";
    }
}
