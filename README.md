# La Pape 🥔

Sistema de gestión de productos desarrollado en **.NET Framework 4.5** con arquitectura en capas y servicios **WCF**: catálogo de productos con SKU, precios, unidades y paquetes, más catálogos de grupos, familias, marcas, tipos y proveedores.

## ✨ Módulos principales

- **Productos**: catálogo con SKU, precios, unidades y paquetes
- **Catálogos**: grupos, familias, marcas, tipos y proveedores
- **Notas**: registro de notas del sistema

## 🏗️ Arquitectura

| Capa | Proyecto | Responsabilidad |
|------|----------|-----------------|
| Entidades | `Entidades` | Clases del modelo: `Producto`, `Cat_Grupos_Productos`, `Cat_Familias_Productos`, `Cat_Marcas_Prodcutos`, `Cat_Provedores`, `Cat_Tipos_Prodcutos`, `Precios_Prodcutos`, `Productos_Unidades_Paquetes`, `Nota` |
| Datos | `CapaDatos` | Acceso a datos con Entity Framework 6.1.3 (Database First, `LaPapeModelo.edmx`) y ADO.NET |
| Lógica | `CapaLogica` | Reglas de negocio: `ProductoLogica`, `GrupoLogica` (insertar, modificar, buscar por SKU, listar) |
| Contratos | `Contratos` | Interfaces de los servicios WCF (`ILaPape` agrupa `IProducto`, `IGruposProducto`, `IFamiliasProdcuto`, `IMarcasProducto`, `INotas`, `IPreciosProducto`, `IProveedores`, `ITiposProducto`, `IUnidadesPaquetes`) |
| Servicios | `Servicios` | Implementación del servicio (`LaPape : ILaPape`) y validador de usuario/contraseña |
| Hospedaje | `ImplementacionesServicios` | Hospedaje WCF (`LaPape.svc`, `Web.config`) |

### Clientes

| Proyecto | Tipo | Descripción |
|----------|------|-------------|
| `LaPapeConsola` | Consola | Cliente de consola que consume el servicio WCF |
| `LaPapeWPF` | WPF (MVVM) | Cliente de escritorio con Modelos, VistaModelos y Vistas |
| `LaPape-DataTable` | WinForms | Cliente de escritorio con DataTable |

## 🛠️ Tecnologías

- .NET Framework 4.5 · C#
- WCF (Windows Communication Foundation)
- Entity Framework 6.1.3 (Database First con EDMX)
- ADO.NET
- SQL Server
- WPF con patrón MVVM · Windows Forms

## 🚀 Cómo empezar

1. Clona el repositorio:
   ```bash
   git clone https://github.com/psehgaft/la-p-pe.git
   ```
2. Abre `LaPape.sln` en Visual Studio (2015 o superior).
3. Restaura los paquetes NuGet (`packages.config` en `CapaDatos`; también hay una copia local en `packages/`).
4. Configura la cadena de conexión a SQL Server en `CapaDatos/App.Config` (y en `ImplementacionesServicios/Web.config` para el hospedaje).
5. Compila la solución y hospeda `LaPape.svc`.

## 📝 Estado del proyecto

Proyecto en desarrollo: varias operaciones del servicio (`Eliminar*` y búsquedas en `Servicios/LaPape.cs`) aún lanzan `NotImplementedException`. Las operaciones implementadas son las de `ProductoLogica` y `GrupoLogica` (insertar, modificar, buscar por SKU y listar).

## 🤝 Cómo contribuir

1. Haz un fork del repositorio.
2. Crea una rama (`git checkout -b mejora/nombre-del-cambio`).
3. Haz tus cambios y crea el commit **con coautores**, siguiendo [la guía de GitHub](https://docs.github.com/es/pull-requests/how-tos/commit-changes/creating-a-commit-with-multiple-authors):
   ```bash
   git commit -m "Descripción del cambio.

   Co-authored-by: Nombre <correo@ejemplo.com>"
   ```
   Usa el correo asociado a la cuenta de GitHub de cada coautor (o su correo `no-reply` si lo mantiene privado).
4. Haz push a tu fork y abre un Pull Request.

## 📄 Licencia

Este proyecto está bajo la licencia **GNU General Public License v3.0**. Ver [LICENSE](LICENSE).

## 👥 Autores

- [@psehgaft](https://github.com/psehgaft)
- [@frankjunker87-arch](https://github.com/frankjunker87-arch)
