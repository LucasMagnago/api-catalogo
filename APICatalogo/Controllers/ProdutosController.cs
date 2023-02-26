using APICatalogo.Context;
using APICatalogo.Models;
using Microsoft.AspNetCore.Mvc;

namespace APICatalogo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProdutosController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Produto>> Get()
        {
            List<Produto> produtos = _context.Produtos.ToList();

            if (!produtos.Any())
                return NotFound();

            return produtos;
        }

        [HttpGet("{id:int}", Name = "GetProduto")]
        public ActionResult<Produto> Get(int id)
        {
            Produto produto = _context.Produtos.FirstOrDefault(p => p.Id == id);

            if (produto is null)
                return NotFound();

            return produto;
        }

        [HttpPost]
        public ActionResult Post(Produto produto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            _context.Produtos.Add(produto);
            _context.SaveChanges();

            return new CreatedAtRouteResult("GetProduto", new { id = produto.Id }, produto);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Produto produto)
        {
            var produtoExistente = _context.Produtos.FirstOrDefault(p => p.Id == id);

            if (produtoExistente is null)
                return NotFound();

            if (id != produto.Id)
                return BadRequest();

            _context.Entry(produtoExistente).CurrentValues.SetValues(produto);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            Produto produto = _context.Produtos.FirstOrDefault(p => p.Id == id);

            if (produto is null) return NotFound();

            _context.Produtos.Remove(produto);
            _context.SaveChanges();

            return Ok(produto); //ou retorna-se apenas Ok()
        }
    }
}
