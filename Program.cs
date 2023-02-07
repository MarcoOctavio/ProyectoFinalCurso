using ProjectoFinal3;
using System;
using System.Data.SqlClient;

namespace ProjectoFinal3;

//Classes
public class Usuario
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string NombreUsuario { get; set; }
    public double Contraseña { get; set; }
    public double Mail { get; set; }
}
public class Producto
{
    public int Id { get; set; }
    public string Descripción { get; set; }
    public double Costo { get; set; }
    public double PrecioVenta { get; set; }
    public int Stock { get; set; }
    public long IdUsuario { get; set; }
}
public class ProductoVendido
{
    public int Id { get; set; }
    public long IdProducto { get; set; }
    public int Stock { get; set; }
    public long IdVenta { get; set; }
    public long IdUsuario { get; set; }
}
public class Venta
{
    public int Id;
    public string Comentarios { get; set; }
    public int IdUsuario { get; set; }
}

public static List<Usuario> DevolverUsuarios();
{
    var listaUsuarios = new List<Usuario>();
    string connectionString = "Data Source=VMVENEGASV9\SQLEXPRESS;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False\"";
    var query = "SELECT Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail, FROM Usuario";
    using (SqlConnection conect = new SqlConnection(connectionString))
    {
        using (SqlCommand comando = new SqlCommand(query, connectionString))
        {
            connect.Open();
            using (SqlDataReader dr = comando.ExecuteReader())
            {
                if (dr.HasRows())
                {
                    while (dr.Read())
                    {
                        var usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(dr["ID"]);
                        usuario.Nombre = dr["Nombre"].ToString();
                        usuario.Apellido = dr["Apellido"].ToString();
                        usuario.NombreUsuario = dr["NombreUsuario"].ToString();
                        usuario.Contraseña = dr["Contraseña"].ToString();
                        usuario.Mail = dr["Mail"].ToString();
                        ListaUsuarios.Add(Usuario);
                        List<Usuario> listaUsuarios = DevolverUsuarios();
                    }
                }
            }
        }
    }
    private static List<Producto> DevolverProducto();
    {
        var listaProductos = new List<Producto>();
        string connectionString = "Data Source=VMVENEGASV9\SQLEXPRESS;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        var query = "SELECT Id, Descripción, Costo, PrecioVenta, Stock, IdUsuario, FROM producto";
        using (SqlConnection conect = new SqlConnection(connectionString))
        {
            using (SqlCommand comando = new SqlCommand(query, connectionString))
            {
                connect.Open();
                using (SqlDataReader dr = comando.ExecuteReader())
                {
                    if (dr.HasRows())
                    {
                        while (dr.Read())
                        {
                            var producto = new Producto();
                            producto.Id = Convert.ToInt32(dr["ID"]);
                            producto.Descripción = dr["Descripción"].ToString();
                            producto.Costo = dr["Costo"].ToString();
                            producto.PrecioVenta = dr["PrecioVenta"].ToString();
                            producto.Stock = dr["Stock"].ToString();
                            producto.IdUsuario = dr["IdUsuario"].ToString();
                            ListaUsuarios.Add(usuario);
                            List<Producto> listaProductos = DevolverProductos();
                        }
                    }
                }
            }
        }
    }

private static List<ProductoVendido> DevolverProductoVendidos();
{
    var listaProductoVendido = new List<ProductoVendido>();
    string connectionString = "Data Source=VMVENEGASV9\SQLEXPRESS;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    var query = "SELECT Id, Descripción, Costo, PrecioVenta, Stock, IdUsuario, FROM producto";
    using (SqlConnection conect = new SqlConnection(connectionString))
    {
        using (SqlCommand comando = new SqlCommand(query, connectionString))
        {
            connect.Open();
            using (SqlDataReader dr = comando.ExecuteReader())
            {
                if (dr.HasRows())
                {
                    while (dr.Read())
                    {
                        var producto = new ProductoVendido();
                        ProductoVendido.Id = Convert.ToInt32(dr["ID"]);
                        ProductoVendido.Stock = dr["Stock"].ToString();
                        ProductoVendido.IdProducto = dr["IdProducto"].ToString();
                        ProductoVendido.IdVenta = dr["IdVenta"].ToString();
                        listaProductoVendido.Add(ProductoVendido);
                        List<ProductoVendido> listaProductos = DevolverProductoVendido();
                    }
                }
            }
        }
    }
}

private static List<Venta> DevolverVenta();
{
    var listaVenta = new List<Venta>();
    string connectionString = "Data Source=VMVENEGASV9\\SQLEXPRESS;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    var query = "SELECT Id, Descripción, Costo, PrecioVenta, Stock, IdUsuario, FROM producto";
    using (SqlConnection conect = new SqlConnection(connectionString))
    {
        using (SqlCommand comando = new SqlCommand(query, connectionString))
        {
            connect.Open();
            using (SqlDataReader dr = comando.ExecuteReader())
            {
                if (dr.HasRows())
                {
                    while (dr.Read())
                    {
                        var venta = new Venta();
                        Venta.Id = Convert.ToInt32(dr["ID"]);
                        Venta.Comentarios = dr["Comentario"].ToString();
                        listaVenta.Add(Venta);
                        List<Venta> listaProductos = DevolverVenta();
                    }
                }
            }
        }
    }
}

public static inicioSesion()
Console.WriteLine("Escribe nombre de usuario");
Console.Read
Console.WriteLine("Escribe contrasena");


int contador = 5;
string Password = "usSystem-2022";

