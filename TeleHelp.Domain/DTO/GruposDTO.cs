using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleHelp.Domain.DTO.InterfacesDTO;
using TeleHelp.Domain.Entities;
using TeleHelp.Domain.Enums.Comuns;

namespace TeleHelp.Domain.DTO
{
    public class GruposDTO : IGrupoDTO
    {
        public GruposDTO()
        {
            Grupo = new Grupo();
            //PermissaoTela = new PermissaoTela();
        }
        int _grupo;
        public int IdGrupo
        {
            get { return _grupo; }
            set
            {
                _grupo = value;
                Grupo.IdGrupo = value;
            }
        }
        string _nome;
        public string Nome
        {
            get { return _nome; }
            set
            {
                _nome = value;
                Grupo.Nome = value;
            }
        }

        string _descricao; 
        public string Descricao
        {
            get { return _descricao; }
            set
            {
                _descricao = value;
                Grupo.Descricao = value;
            }
        }
        bool _ativo;
        public bool Ativo
        {
            get { return _ativo; }
            set
            {
                _ativo = value;
                Grupo.Ativo = value;
            }
        }
        
        public Grupo Grupo { get; set; }

        public IList<Grupo> Grupos { get ; set; }

        public IList<Tela> Telas { get; set; }

        public IList<PermissaoTela> GrupoTelas { get; set; }
        public PermissaoTela PermissaoTela
        {
            get { return new PermissaoTela(); }
        }

        public SistemaEnuns.Acao Acao { get; set; }

        public void NovosObjetos()
        {
            if (Grupos == null)
            {
                Grupos = new List<Grupo>();
            }
            if (Telas == null)
            {
                Telas = new List<Tela>();
            }
            if (GrupoTelas == null)
            {
                GrupoTelas = new List<PermissaoTela>();
            }
            if (Grupo == null)
            {
                Grupo = new Grupo();
            }
        }
    }
}
