using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleHelp.Domain.DTO.InterfacesDTO;
using TeleHelp.Domain.Entities;
using TeleHelp.Domain.Enums.Comuns;
using TeleHelp.Domain.Validations;

namespace TeleHelp.Domain.DTO
{
    public class UsuarioDTO : IUsuarioDTO
    {
        public UsuarioDTO()
        {

        }

        public SistemaEnuns.Acao acao { get; set; }

        int _idusuario;
        public int IdUsuario
        {
            get { return _idusuario; }
            set
            {
                _idusuario = value;
                Usuario.IdUsuario = value;
            }
        }

        string _nome;
        public string Nome
        {
            get { return _nome; }
            set
            {
                _nome = value;
                Usuario.Nome = value;
            }
        }

        DateTime _datacadastro;
        public DateTime DataCadastro
        {
            get { return _datacadastro; }
            set
            {
                _datacadastro = value;
                Usuario.DataCadastro = value;
            }
        }

        byte[] _foto;
        public byte[] Foto
        {
            get { return _foto; }
            set
            {
                _foto = value;
                Usuario.Foto = value;
            }
        }

        int? _matricula;
        public int? Matricula
        {
            get { return _matricula; }
            set
            {
                _matricula = value;
                Usuario.Matricula = value;
            }
        }

        int? _turno;
        public int? Turno
        {
            get { return _turno; }
            set
            {
                _turno = value;
                Usuario.Turno = value;
            }
        }
        TimeSpan? _hentrada;
        public TimeSpan? HorarioEntrada
        {
            get { return _hentrada; }
            set
            {
                _hentrada = value;
                Usuario.HorarioEntrada = value;
            }
        }

        TimeSpan? _hsaida;
        public TimeSpan? HorarioSaida
        {
            get { return _hsaida; }
            set
            {
                _hsaida = value;
                Usuario.HorarioSaida = value;
            }
        }
        int _idtipousuario;
        public int IdTipoUsuario
        {
            get { return _idtipousuario; }
            set
            {
                _idtipousuario = value;
                Usuario.IdTipoUsuario = value;
            }
        }

        int _idtipoatendimento;
        public int IdTipoAtendimento
        {
            get { return _idtipoatendimento; }
            set
            {
                _idtipoatendimento = value;
                Usuario.IdTipoAtendimento = value;
            }
        }
        string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                Usuario.Email = value;
            }
        }

        bool _ativo;
        public bool Ativo
        {
            get { return _ativo; }
            set
            {
                _ativo = value;
                Usuario.Ativo = value;
            }
        }

        int _cargo;
        public int IdCargo
        {
            get { return _cargo; }
            set
            {
                _cargo = value;
                Usuario.IdCargo = value;
            }
        }

        int _iddepartamento;
        public int IdDepartamento
        {
            get { return _iddepartamento; }
            set
            {
                _iddepartamento = value;
                Usuario.IdDepartamento = value;
            }
        }

        string _login;
        public string Login
        {
            get { return _login; }
            set
            {
                _login = value;
                Usuario.Login = value;
            }
        }

        byte[] _senha;
        public byte[] Senha
        {
            get { return _senha; }
            set
            {
                _senha = value;
                Usuario.Senha = value;
            }
        }

        byte[] _senhaextra;
        public byte[] SenhaExtra
        {
            get { return _senhaextra; }
            set
            {
                _senhaextra = value;
                Usuario.SenhaExtra = value;
            }
        }

        DateTime? _dataalteracao;
        public DateTime? DataAlteracao
        {
            get { return _dataalteracao; }
            set
            {
                _dataalteracao = value;
                Usuario.DataAlteracao = value;
            }
        }

        public Departamento Departamento { get; set; }
        public Cargo Cargo { get; set; }
        public Usuario Usuario { get; set; }
        public List<GrupoUsuario> gruposUsuario { get; set; }
        public GrupoUsuario grupoUsuario { get; set; }
        public RepresentanteUsuario representanteUsuario { get; set; }
        public Grupo grupo { get; set; }

        public bool ValidaCadastroUsuario()
        {
            throw new NotImplementedException();
        }

        public void NovoObjeto()
        {
            throw new NotImplementedException();
        }
    }
}

