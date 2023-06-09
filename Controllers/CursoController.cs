using EscolaDotNet.Contexts;
using EscolaDotNet.Models;
using EscolaDotNet.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EscolaDotNet.Controllers;
public class CursoController : Controller
{

    private readonly AppDbContext _context;

    public CursoController(AppDbContext context)
    {
        _context = context;
    }



    public IActionResult Index()
    {
        // lista de cursos
        var cursos = _context.Cursos.ToList();

        // já tenho meu view model
        var viewModel = new ListaCursoViewModel { Cursos = cursos };

        return View(viewModel);
    }
    //mostrar a pagina NÃO tranporta dados
    public IActionResult Create()
    {
        ViewData["Title"] = "Cadastrar um Curso";
        return View();
    }


    public IActionResult Delete(int id)
    {
        var curso = _context.Cursos.Find(id);
        if (curso is null)
        {
            return NotFound();
        }
        _context.Remove(curso);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    //transporta dados
    [HttpPost]
    public IActionResult Create(CreateCursoViewModel data)
    {
        var curso = new Curso(data.Nome,
                                data.Titulo,
                                data.Descricao,
                                data.Perfil,
                                data.PreRequisitos,
                                data.Conteudo,
                                data.Recursos,
                                data.CargaHoraria,
                                data.PrazoMeses
                                );

        _context.Add(curso);
        _context.SaveChanges();
        //Redireciona e volta pra Index
        return RedirectToAction(nameof(Index));
    }


    public IActionResult Edit(int id)
    {
        ViewData["Title"] = "Editar Curso";
        var curso = _context.Cursos.Find(id);
        if (curso is null)
        {
            return NotFound();
        }
        var viewModel = new EditCursoViewModel
        {
            Id = curso.Id,
            Nome = curso.Nome,
            CargaHoraria = curso.CargaHoraria,
            Conteudo = curso.Conteudo,
            Descricao = curso.Descricao,
            Perfil = curso.Perfil,
            PrazoMeses = curso.PrazoMeses,
            PreRequisitos = curso.PreRequisitos,
            Recursos = curso.Recursos,
            Titulo = curso.Titulo
        };
        return View(viewModel);

    }

    [HttpPost]
    public IActionResult Edit(int id, EditCursoViewModel data)
    {

        var curso = _context.Cursos.Find(id);
        if (curso is null)
        {
            return NotFound();
        }
        curso.CargaHoraria = data.CargaHoraria;
        curso.Conteudo = data.Conteudo;
        curso.Descricao = data.Descricao;
        curso.Nome = data.Nome;
        curso.PrazoMeses = data.PrazoMeses;
        curso.Recursos = data.Recursos;
        curso.PreRequisitos = data.PreRequisitos;
        curso.Titulo = data.Titulo;
        curso.Perfil = data.Perfil;
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));

    }

    public IActionResult ModifyStatus(int id)
    {
        //Localizando pela chave primaria 
        var curso = _context.Cursos.Find(id);
        if (curso is null)
        {
            return NotFound();
        }

        curso.Status = "Concluido";
        _context.SaveChanges();

        return RedirectToAction(nameof(Index));
    }
}