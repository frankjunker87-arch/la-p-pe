# La Pape 🥔

Sistema de gestión de productos desarrollado en .NET Framework con arquitectura en capas y servicios WCF.

## Arquitectura

| Capa | Proyecto | Responsabilidad |
|------|----------|-----------------|
| Entidades | `Entidades` | Clases del modelo: productos, grupos, familias, marcas, proveedores, precios, notas |
| Datos | `CapaDatos` | Acceso a datos con Entity Framework (EDMX `LaPapeModelo`) y ADO.NET |
| Contratos | `Contratos` | Interfaces de los servicios WCF (`IProducto`, `IGruposProducto`, `INotas`, etc.) |
| Lógica | `CapaLogica` | Reglas de negocio (`ProductoLogica`, `GrupoLogica`) |
| Servicios | `ImplementacionesServicios` | Implementación de los servicios WCF (`LaPape.svc`) |

## Requisitos

- Visual Studio (2015 o superior)
- .NET Framework
- SQL Server (configura la cadena de conexión en `App.Config` / `Web.config`)

## Cómo empezar

1. Clona el repositorio.
2. Abre la solución en Visual Studio.
3. Restaura los paquetes NuGet (`packages.config` en `CapaDatos`).
4. Configura la cadena de conexión en `CapaDatos/App.Config`.
5. Compila la solución.

## Módulos principales

- **Productos**: catálogo, precios, unidades y paquetes
- **Catálogos**: grupos, familias, marcas, tipos y proveedores
- **Notas**: registro de notas del sistema

---

Hecho con 💛 por [@frankjunker87-arch](https://github.com/frankjunker87-arch)
# la-p-pe

Web portal para trmites

Tramites SAT

Tramites RENAPO

Tramites IMSS

Tramites Transito
