using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace food_truck.Business
{
    class FornecedorBusiness
    {
        Databases.FornercedorDatabases db = new Databases.FornercedorDatabases();

        public void Inserir(Model.tb_fornecedor fornecedor)
        {
            this.Validar(fornecedor);

            db.Inserir(fornecedor);
        }

        public void Alterar(Model.tb_fornecedor fornecedor)
        {

            this.Validar(fornecedor);

            db.Alterar(fornecedor);
        }


        public void Remover(Model.tb_fornecedor fornecedor)
        {
            this.Validar(fornecedor);

            db.remover(fornecedor);

        }

        public List<Model.tb_fornecedor> Listar()
        {

            List<Model.tb_fornecedor> listar = db.Listar();
            return listar;
        }

        public List<Model.tb_fornecedor> Consultar(string nome)
        {
            List<Model.tb_fornecedor> res = db.ConsultarPorNome(nome);

            return res;
        }




        public void Validar(Model.tb_fornecedor forne)
        {


            if (forne.nm_Fornecedor == String.Empty)
            {
                throw new ArgumentException("O Nome do Fornecedor deve ser informado");
            }

            if (forne.nm_endereco == String.Empty)
            {
                throw new ArgumentException("O endereço deve ser informado");
            }

            if (forne.nm_cidade == String.Empty)
            {
                throw new ArgumentException("O nome da cidade deve ser informado");
            }


            if (forne.nm_bairro == String.Empty)
            {
                throw new ArgumentException("O Nome do Bairro deve ser informado");
            }


            if (forne.tp_pessoaFJ == String.Empty)
            {
                throw new ArgumentException("Informe se a pessoa deve ser Fisica ou Juridica");
            }


            if (forne.doc_CNPJ == String.Empty)
            {
                throw new ArgumentException("O Numero do CNPJ deve ser informado");
            }

            if (forne.dt_Contrato == null)
            {
                throw new ArgumentException("A data do contrato deve ser informada");
            }


            if (forne.tb_email == String.Empty)
            {
                throw new ArgumentException("O E-mail deve ser informado");
            }


          

            if (forne.tb_email.Contains("@gmail.com") 
             || forne.tb_email.Contains( "@outlook.com") 
             || forne.tb_email.Contains("@hotmail.com")
             || forne.tb_email.Contains( "@yahoo.com"))
            {

            }
             else
            {
                throw new ArgumentException("O E-mail informado não existe");
            }


            if (forne.tb_email.Length >= 25)
            {
                throw new ArgumentException("O e-mail informado excede os limites de Caracteres");
            }

            if (forne.nm_Fornecedor.Length >= 25)
            {
                throw new ArgumentException("O Nome do Fornecedor informado excede os limites de Caracteres");
            }

            if (forne.nm_endereco.Length >= 25)
            {
                throw new ArgumentException("O Endereço informado excede os limites de Caracteres");
            }

            if (forne.nm_cidade.Length >= 15)
            {
                throw new ArgumentException("O nome da cidade informado excede os limites de Caracteres");
            }

            if (forne.nm_bairro.Length >= 25)
            {
                throw new ArgumentException("O nome do Bairro informado excede os limites de Caracteres");
            }
            if (forne.tl_celular.Length > 9)
            {
                throw new ArgumentException("O numero de Celular informado excede os limites de Caracteres");
            }

        }

    }
}