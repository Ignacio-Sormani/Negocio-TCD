namespace DATOS
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Data.Entity.ModelConfiguration.Conventions;
    public class NEGOCIO : DbContext
    {
        private static NEGOCIO instancia;
        public static NEGOCIO obtener_instancia()
        {
            if (instancia == null)
                instancia = new NEGOCIO();
            return instancia;
        }
        // El contexto se ha configurado para usar una cadena de conexión 'Negocio' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'DATOS.Negocio' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'Negocio'  en el archivo de configuración de la aplicación.
        public NEGOCIO()
            : base("name=Negocio")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MODELO.LOCALIDAD>()
                .HasKey(_ => _.codigoLocalidad);

            modelBuilder.Entity<MODELO.PROVEEDOR>()
                .HasKey(_ => _.codigoProveedor)
                .HasRequired(_ => _.localidad);

            modelBuilder.Entity<MODELO.ORDENDECOMPRA>()
                .HasKey(_ => _.codigoOrdenCompra);

            modelBuilder.Entity<MODELO.ITEM>()
                .HasKey(_ => _.codigoItem);

            modelBuilder.Entity<MODELO.CATEGORIA>()
                .HasKey(_ => _.codigoCategoria);

            modelBuilder.Entity<MODELO.MARCA>()
                .HasKey(_ => _.codigoMarca);

            modelBuilder.Entity<MODELO.PRODUCTO>()
                .HasKey(_ => _.codigoProducto)
                .HasRequired(_ => _.marca);

            modelBuilder.Entity<MODELO.PRODUCTO>()
               .HasRequired(_ => _.categoria);

            modelBuilder.Entity<MODELO.REMITODECOMPRA>()
                .HasKey(_ => _.codigoRemitoCompra);

            modelBuilder.Entity<MODELO.VENTA>()
                .HasKey(_ => _.codigoVenta);
            
            modelBuilder.Entity<MODELO.CLIENTE>()
                .HasKey(_ => _.codigoCliente)
                .HasRequired(_ => _.localidad);

            modelBuilder.Entity<MODELO.PAGO>()
                .HasKey(_ => _.codigoPago);

            modelBuilder.Entity<MODELO.FORMAPAGO>()
                .HasKey(_ => _.codigoFormaPago);

            modelBuilder.Entity<MODELO.USUARIO>()
                .HasKey(_ => _.codigoUsuario);

            modelBuilder.Entity<MODELO.GRUPO>()
                .HasKey(_ => _.codigoGrupo);

            modelBuilder.Entity<MODELO.ACCION>()
                .HasKey(_ => _.codigoAccion);

            modelBuilder.Entity<MODELO.ACCESO>()
                .HasKey(_ => _.codigoAcceso);


            modelBuilder.Entity<MODELO.ORDENDECOMPRA>()
                .HasRequired(oc => oc.proveedor)
                .WithMany(p => p.ordenesCompra);// esto no se si va

            modelBuilder.Entity<MODELO.ORDENDECOMPRA>()
                .HasMany(oc => oc.remitosCompra)
                .WithRequired(rc => rc.ordenCompra);

            modelBuilder.Entity<MODELO.ORDENDECOMPRA>()
                .HasMany(oc => oc.itemsoc)
                .WithRequired(ioc => ioc.ordenCompra);//withoptional?

            modelBuilder.Entity<MODELO.ITEM>()
                .HasRequired(i => i.producto)
                .WithMany(p => p.items);

            modelBuilder.Entity<MODELO.REMITODECOMPRA>()
                .HasMany(rc => rc.itemsrc)
                .WithRequired(irc => irc.remitoCompra);//withoptional?

            modelBuilder.Entity<MODELO.VENTA>()
                .HasRequired(v => v.cliente)
                .WithMany(c => c.ventas);

            modelBuilder.Entity<MODELO.VENTA>()
                .HasMany(v => v.itemsv)
                .WithRequired(iv => iv.venta);

            
            modelBuilder.Entity<MODELO.VENTA>()
                .HasMany(v => v.pagos)
                .WithRequired(p => p.venta);

            modelBuilder.Entity<MODELO.PAGO>()
                .HasRequired(p => p.formaPago);

            modelBuilder.Entity<MODELO.USUARIO>()
                .HasMany<MODELO.GRUPO>(u => u.grupos)
                .WithMany(g => g.usuarios)
                .Map(ug =>
                {
                    ug.MapLeftKey("codigoUsuario");
                    ug.MapRightKey("codigoGrupo");
                    ug.ToTable("USUARIO_GRUPO");
                });

            modelBuilder.Entity<MODELO.GRUPO>() //hay que ver si esta bien hecha la relacion de grupos y acciones (creo que deberia ser muchos a muchos)
                .HasMany<MODELO.ACCION>(g => g.acciones)
                .WithMany(a => a.grupos)
                .Map(ga =>
                {
                    ga.MapLeftKey("codigoGrupo");
                    ga.MapRightKey("codigoAccion");
                    ga.ToTable("GRUPO_ACCION");
                });   
        }
        public DbSet<MODELO.LOCALIDAD> LOCALIDADES { get; set; }
        public DbSet<MODELO.PROVEEDOR> PROVEEDORES { get; set; }
        public DbSet<MODELO.ORDENDECOMPRA> ORDENESDECOMPRA { get; set; }
        public DbSet<MODELO.CATEGORIA> CATEGORIAS { get; set; }
        public DbSet<MODELO.MARCA> MARCAS { get; set; }        
        public DbSet<MODELO.PRODUCTO> PRODUCTOS { get; set; }
        public DbSet<MODELO.ITEMOC> ITEMSOC { get; set; }
        public DbSet<MODELO.ITEMRC> ITEMSRC { get; set; }
        public DbSet<MODELO.ITEMV> ITEMSV { get; set; }
        public DbSet<MODELO.REMITODECOMPRA> REMITOSDECOMPRA { get; set; }
        public DbSet<MODELO.VENTA> VENTAS { get; set; }
        public DbSet<MODELO.CLIENTE> CLIENTES { get; set; }
        public DbSet<MODELO.PAGO> PAGOS { get; set; }
        public DbSet<MODELO.FORMAPAGO> FORMASPAGO { get; set; }
        public DbSet<MODELO.USUARIO> USUARIOS { get; set; }
        public DbSet<MODELO.GRUPO> GRUPOS { get; set; }
        public DbSet<MODELO.ACCION> ACCIONES { get; set; }
        public DbSet<MODELO.ACCESO> ACCESOS { get; set; }
    // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
    // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.

    // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}