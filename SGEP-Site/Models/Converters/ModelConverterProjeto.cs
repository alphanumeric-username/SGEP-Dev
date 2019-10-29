﻿using SGEP_Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGEP_Site.Models
{
    public sealed class ModelConverterProjeto
    {
        private ModelConverterProjeto () { }
        public static ProjetoIndexViewModel DomainToIndexView (Projeto projeto) => new ProjetoIndexViewModel ()
        {
            Id = projeto.Id,
            Nome = projeto.Nome,
            DataInicio = projeto.DataInicio,
            PrazoEstimado = projeto.PrazoEstimado,
            DataFim = projeto.DataFim,
            Estado = (projeto.DataFim == null) ? nameof(EstadoProjeto.Andamento)
                                               : nameof(EstadoProjeto.Finalizado)
        };
        
        public static ProjetoEditViewModel DomainToEditView (Projeto projeto) => new ProjetoEditViewModel ()
        {
            Id = projeto.Id,
            Nome = projeto.Nome,
            DataInicio = projeto.DataInicio,
            PrazoEstimado = projeto.PrazoEstimado,
            DataFim = projeto.DataFim
        };

        public static ProjetoDetailsViewModel DomainToDetailsView (Projeto projeto, IEnumerable<Funcionario> funcionarios, IEnumerable<Funcionario> funcionariosFora) => new ProjetoDetailsViewModel ()
        {
            Id = projeto.Id,
            Nome = projeto.Nome,
            DataInicio = projeto.DataInicio,
            PrazoEstimado = projeto.PrazoEstimado,
            DataFim = projeto.DataFim,
            Estado = (projeto.DataFim == null) ? nameof (EstadoProjeto.Andamento)
                                               : nameof (EstadoProjeto.Finalizado),
            Andamento = projeto.DataFim == null,
            Funcionarios = funcionarios,
            FuncionariosFora = funcionariosFora
        };



        public static Projeto CreateViewToDomain (ProjetoCreateViewModel projeto) => new Projeto ()
        {
            Nome = projeto.Nome,
            DataInicio = projeto.DataInicio,
            PrazoEstimado = projeto.PrazoEstimado,
            DataFim = null,
            Estado = EstadoProjeto.Andamento
        };

        public static Projeto EditViewToDomain (ProjetoEditViewModel projeto) => new Projeto ()
        {
            Id = projeto.Id,
            Nome = projeto.Nome,
            DataInicio = projeto.DataInicio,
            PrazoEstimado = projeto.PrazoEstimado,
            DataFim = projeto.DataFim,
            Estado = (projeto.DataFim == null) ? EstadoProjeto.Andamento
                                               : EstadoProjeto.Finalizado
        };
    }
}
