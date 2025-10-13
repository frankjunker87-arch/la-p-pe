using System.Collections.Generic;
using Entidades;
using Contratos;
using CapaLogica;
using System;

namespace Servicios
{
    public class LaPape : ILaPape
    {
        private ProductoLogica contextoProdcuto;
        private GrupoLogica contextoGrupo;

        public LaPape()
        {
            contextoGrupo = new GrupoLogica();
            contextoProdcuto = new ProductoLogica();
        }

        public IEnumerable<Cat_Grupos_Productos> listarGrupo()
        {
            return contextoGrupo.Listar();
        }

        public Cat_Familias_Productos BorrarFamilia(Cat_Familias_Productos familiaProducto)
        {
            throw new System.NotImplementedException();
        }

        public Cat_Grupos_Productos EliminarGrupo(Cat_Grupos_Productos grupoProducto)
        {
            throw new NotImplementedException();
        }

        public Cat_Marcas_Prodcutos EliminarMarca(Cat_Marcas_Prodcutos marcaProducto)
        {
            throw new NotImplementedException();
        }

        public Nota EliminarNota(Nota nota)
        {
            throw new NotImplementedException();
        }

        public Precios_Prodcutos EliminarPrecio(Precios_Prodcutos precioProducto)
        {
            throw new NotImplementedException();
        }

        public Producto EliminarProducto(Producto producto)
        {
            throw new NotImplementedException();
        }

        public Cat_Provedores EliminarProveedor(Cat_Provedores producto)
        {
            throw new NotImplementedException();
        }

        public Cat_Tipos_Prodcutos EliminarTipo(Cat_Tipos_Prodcutos tipoProducto)
        {
            throw new NotImplementedException();
        }

        public Productos_Unidades_Paquetes EliminarUnidadPaquete(Productos_Unidades_Paquetes unidadPaqueteProducto)
        {
            throw new NotImplementedException();
        }

        public Cat_Familias_Productos InsertarFamilia(Cat_Familias_Productos familiaProducto)
        {
            throw new NotImplementedException();
        }

        public Cat_Grupos_Productos InsertarGrupo(Cat_Grupos_Productos grupoProducto)
        {
            return contextoGrupo.Insertar(grupoProducto);
        }

        public Cat_Marcas_Prodcutos InsertarMarca(Cat_Marcas_Prodcutos marcaProducto)
        {
            throw new NotImplementedException();
        }

        public Nota InsertarNota(Nota nota)
        {
            throw new NotImplementedException();
        }

        public Precios_Prodcutos InsertarPrecio(Precios_Prodcutos precioProducto)
        {
            throw new NotImplementedException();
        }

        public Producto InsertarProducto(Producto producto)
        {
            return contextoProdcuto.Insertar(producto);
        }

        public Cat_Provedores InsertarProveedor(Cat_Provedores proveedor)
        {
            throw new NotImplementedException();
        }

        public Cat_Tipos_Prodcutos InsertarTipo(Cat_Tipos_Prodcutos tipoProducto)
        {
            throw new NotImplementedException();
        }

        public Productos_Unidades_Paquetes InsertarUnidadPaquete(Productos_Unidades_Paquetes unidadPaqueteProducto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cat_Familias_Productos> ListarFamilia()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cat_Grupos_Productos> ListarGrupo()
        {
            throw new NotImplementedException();

        }

        public IEnumerable<Cat_Marcas_Prodcutos> ListarMarca()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Nota> ListarNota()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Precios_Prodcutos> ListarPrecio()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Producto> ListarProducto()
        {
            return contextoProdcuto.Listar();
        }

        public IEnumerable<Cat_Provedores> ListarProveedor()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cat_Tipos_Prodcutos> ListarTipo()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Productos_Unidades_Paquetes> ListarUnidadPaquete()
        {
            throw new NotImplementedException();
        }

        public Cat_Familias_Productos ModificarFamilia(Cat_Familias_Productos familiaProducto)
        {
            throw new NotImplementedException();
        }

        public Cat_Grupos_Productos ModificarGrupo(Cat_Grupos_Productos grupoProducto)
        {
            throw new NotImplementedException();
        }

        public Cat_Marcas_Prodcutos ModificarMarca(Cat_Marcas_Prodcutos marcaProducto)
        {
            throw new NotImplementedException();
        }

        public Nota ModificarNota(Nota nota)
        {
            throw new NotImplementedException();
        }

        public Precios_Prodcutos ModificarPrecio(Precios_Prodcutos precioProducto)
        {
            throw new NotImplementedException();
        }

        public Producto ModificarProducto(Producto producto)
        {
            throw new NotImplementedException();
        }

        public Cat_Provedores ModificarProveedor(Cat_Provedores producto)
        {
            throw new NotImplementedException();
        }

        public Cat_Tipos_Prodcutos ModificarTipo(Cat_Tipos_Prodcutos tipoProducto)
        {
            throw new NotImplementedException();
        }

        public Productos_Unidades_Paquetes ModificarUnidadPaquete(Productos_Unidades_Paquetes unidadPaqueteProducto)
        {
            throw new NotImplementedException();
        }

    }
}
