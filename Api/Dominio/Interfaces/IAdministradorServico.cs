
using MinimalApi.Dominio.Entidades;
using MinimalApi.DTOs;

namespace MinimalApi.Dominio.Interfaces;

public interface IAdministradorServico
{
    /// <exception cref="ArgumentNullException"></exception>
    Administrador? Login(LoginDTO loginDTO);

    Administrador Incluir(Administrador administrador);

    /// <exception cref="ArgumentNullException"></exception>
    Administrador? BuscaPorId(int id);

    /// <exception cref="ArgumentNullException"></exception>
    List<Administrador> Todos(int? pagina);
}