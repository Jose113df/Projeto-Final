using EscolaDotNet.Models;

namespace EscolaDotNet.ViewModels;

public class ListaCursoViewModel{

    //Lista ou coleção

    /* como uma coleção 
    figurinhas 

    Icollection<Card> Album (get;set;) new List<Card>();
    */

    public ICollection<Curso> Cursos {get;set;} = new List<Curso>();


}