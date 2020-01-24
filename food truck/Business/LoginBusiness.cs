using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace food_truck.Business
{
    class LoginBusiness
    {
        Databases.LoginDatabases db = new Databases.LoginDatabases();

        public void Validar(Model.tb_login login)
        {
            if (login.nm_funcionario == string.Empty)
            {
                throw new ArgumentException("Nome de Usuario Não informado");
            }

            if (login.senha == string.Empty)
            {
                throw new ArgumentException("Senha do Usuario Não informada");
            }


            List<Model.tb_login> vali = db.ConsultarPorNome();
            if (vali.Exists(t => t.nm_funcionario.Equals(login)))
            {
 
            }
            else
            {
                throw new ArgumentException("O Nome de usuario informado não existe.");
            }

            if (vali.Exists(t => t.senha.Equals(login)))
            {

            }
            else
            {
                throw new ArgumentException("A senha informada não existe.");
            }



        }
    }
}
