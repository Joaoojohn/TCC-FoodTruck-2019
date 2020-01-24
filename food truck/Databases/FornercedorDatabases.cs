using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace food_truck.Databases
{
    class FornercedorDatabases
    {
        Model.falcomtccEntities2 db = new Model.falcomtccEntities2();

        public void Inserir(Model.tb_fornecedor fornecedores)
        {
            db.tb_fornecedor.Add(fornecedores);
            db.SaveChanges();

        }

        public List<Model.tb_fornecedor> Listar()
        {
             List<Model.tb_fornecedor> Consultar = db.tb_fornecedor.ToList();
            return Consultar;
        }

        public void Alterar(Model.tb_fornecedor fornecedores)
        {
            Model.tb_fornecedor alterar = db.tb_fornecedor.First(t => t.id_fornecedor == fornecedores.id_fornecedor);

            alterar.nm_bairro = fornecedores.nm_bairro;
            alterar.nm_cidade = fornecedores.nm_cidade;
            alterar.nm_endereco = fornecedores.nm_endereco;
            alterar.nm_Fornecedor = fornecedores.nm_Fornecedor;
            alterar.tb_email = fornecedores.tb_email;
            alterar.tl_fixo = fornecedores.tl_fixo;
            alterar.tl_celular = fornecedores.tl_celular;
            alterar.tp_fornecimento = fornecedores.tp_fornecimento;
            alterar.tp_pessoaFJ = fornecedores.tp_pessoaFJ;
            alterar.doc_CNPJ = fornecedores.doc_CNPJ;
            alterar.dt_Contrato = fornecedores.dt_Contrato;


            db.SaveChanges();


        }

        public void remover(Model.tb_fornecedor id)
        {
            Model.tb_fornecedor remover = db.tb_fornecedor.First(t => t.id_fornecedor == id.id_fornecedor);

            db.tb_fornecedor.Remove(remover);
            db.SaveChanges();
        }

        public List<Model.tb_fornecedor> ConsultarPorNome(string nome)
        {
            List<Model.tb_fornecedor> Consultar = db.tb_fornecedor.Where(t => t.nm_Fornecedor.Contains(nome)).ToList();
            return Consultar;
        }
    }
}
