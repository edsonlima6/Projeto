using System;
using TeleHelp.Domain.Entities;

namespace TeleHelp.Domain.DTO
{
    public class DepartamentoDTO
    {
        public DepartamentoDTO()
        {
            //INSTANCIA OBJETO PARA MAPEAR COM BANCO
            _departamento = new Departamento();
            
        }

        public void DisposeDepto()
        {
            _departamento = null;
        }

        Departamento _departamento;
        public Departamento departamento
        {
            get { return _departamento; }
            set
            {
                _departamento = value;
                AtualizaDeptoBD();
            }
        }

        //ATUALIZA OBJETO PARA ATUALIZAR NO BANCO DE DADOS
        private void AtualizaDeptoBD()
        {
           _departamento.Ativo = ativo;
           _departamento.Descricao =  _descricao;
           _departamento.Nome = _nome;
           _departamento.IdDepartamento =  _idDepartamento;
        }

        int _idDepartamento;
        public int IdDepartamento
        {
            get { return _idDepartamento; }
            set{
                departamento.IdDepartamento = value;
                _idDepartamento = value;
            }

        }


        string _nome;
        public string Nome
        {
            get { return _nome; }
            set
            {
                departamento.Nome = value;
                _nome = value;
            }
        }

        private string _descricao;
        public string Descricao
        {
            get { return _descricao; }
            set
            {
                departamento.Descricao = value;
                _descricao = value;
            }
        }


        private bool ativo;
        public bool Ativo
        {
            get { return ativo; }
            set
            {
                departamento.Ativo = value;
               ativo = value;
            }
        }

       public void ValidaDepartamento()
       {
            if (string.IsNullOrWhiteSpace(_nome))
            {
                throw new System.Exception("Nome deve ser preenchido");
            }
       }
    }
}
