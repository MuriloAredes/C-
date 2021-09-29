using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using ProjetoLogin.Modelo;
using ProjetoLogin.DAL;

namespace ProjetoLogin.Modelo
{
    public class controle
    {
        public bool tem;
        public String mensagem = "";
        public bool acessar(String login, String senha) 
        {
            
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.verificarLogin(login, senha);

            if (!loginDao.mensagem.Equals("")) 
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }

        public String cadastrar(String email, String senha1, String confSenha) 
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
           this.mensagem = loginDao.cadastrar(email, senha1, confSenha);
            

            if (loginDao.tem) 
            {
                

                this.tem = true;
            }
            return mensagem;
        }

        //metodo criptografa a senha 

       
        
    }
}
