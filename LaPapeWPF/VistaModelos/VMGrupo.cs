using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using Entidades;

namespace LaPapeWPF.VistaModelos
{
    class VMGrupo : VMBase
    {
        private DelegateCommand insertarCommand;
        public ICommand InsertarCommannd
        {
            get { return insertarCommand; }
        }

        private DelegateCommand listarCommand;

        public ICommand ListarCommannd
        {
            get { return listarCommand; }
        }

        private Cat_Grupos_Productos grupoSeleccionado;

        public Cat_Grupos_Productos GrupoSeleccionado
        {
            get { return grupoSeleccionado; }
            set { grupoSeleccionado = value; }
        }

    }
}
