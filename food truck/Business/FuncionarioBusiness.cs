using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace food_truck.Business
{
    class FuncionarioBusiness
    {
        public void Vali(Model.tb_funcinario fun)
        {
            if (fun.tb_CPF == string.Empty)
            {
                throw new ArgumentException("O CPF deve ser informado");
            }
            if (fun.tb_CPF.Length > 13)
            {

                throw new ArgumentException("O CPF informado excede os limetes de caracteres");

            }


            if (fun.tb_RG == string.Empty)
            {
                throw new ArgumentException("O RG deve ser informado");
            }
            if (fun.tb_RG.Length > 9)
            {

                throw new ArgumentException("O RG informado excede os limetes de caracteres");

            }




            if (fun.tl_celular == string.Empty)
            {
                throw new ArgumentException("O numero de celular deve ser informado");
            }
            if (fun.tl_celular.Length > 9)
            {

                throw new ArgumentException("O Numero de celular informado excede os limetes de caracteres");

            }




            if (fun.vl_salario == null)
            {
                throw new ArgumentException("O Valor do Salario deve ser informado");
            }

            if (fun.vl_transpote == null)
            {
                throw new ArgumentException("O valor do Transporte deve ser informado");
            }



            if (fun.nm_cidade == string.Empty)
            {
                throw new ArgumentException("A Cidade deve ser informada");
            }
            if (fun.nm_cidade.Length > 25 )
            {

                throw new ArgumentException("o Nome da Cidade excede os limetes de caracteres");

            }


            if (fun.nm_numero == string.Empty)
            {
                throw new ArgumentException("O Numero deve ser informado");
            }
            if (fun.nm_numero.Length > 13)
            {

                throw new ArgumentException("A quantidade de Numeros excede os limetes de caracteres");

            }

            

            if (fun.nm_endereco == string.Empty)
            {
                throw new ArgumentException("O Endereço deve ser informado");
            }
            if (fun.nm_endereco.Length > 25)
            {

                throw new ArgumentException("O Nome do Endereço excede os limetes de caracteres");

            }



            if (fun.nm_bairro == string.Empty)
            {
                throw new ArgumentException("O nome do Bairro deve ser informado");
            }
            if (fun.nm_bairro.Length > 25)
            {

                throw new ArgumentException("O Nome do Bairro excede os limetes de caracteres");

            }


            if (fun.nm_funcionario == string.Empty)
            {
                throw new ArgumentException("O Funcionario deve conter um nome");
            }
            if (fun.nm_funcionario.Length > 25)
            {

                throw new ArgumentException("O Nome do Funcionario excede os limetes de caracteres");

            }


            if (fun.tb_sobrenome == string.Empty)
            {
                throw new ArgumentException("O Sobrenome deve ser informado");
            }
            if (fun.tb_sobrenome.Length > 25)
            {

                throw new ArgumentException("o Sobrenome excede os limetes de caracteres");

            }


        }
    }
}
