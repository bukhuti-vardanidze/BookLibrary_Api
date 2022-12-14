using BookLibrary.Models;
using BookLibrary.Requests;
using Microsoft.AspNetCore.Mvc;

namespace BookLibrary.Controllers;

[ApiController]
[Route("[controller]")]
public class ShelfController : ControllerBase
{

    private ShelfService _shelfService;

    public ShelfController()
    {
        _shelfService = new ShelfService();
    }

    [HttpGet]
    [Route("get/{shelfId}")]
    public Shelf? Get(int shelfId)
    {
        return _shelfService.Get(shelfId);
    }



    [HttpGet]
    [Route("get-all")]
    public List<Shelf> GetAll()
    {
        return _shelfService.GetAll();
    }

    [HttpPost]
    [Route("create")]
    public Shelf Create(CreateShelfRequest request)
    {
        return _shelfService.Create(request);
    }

    [HttpPost]
    [Route("rename")]
    public Shelf? Rename(RenameShelfRequest request)
    {
        return _shelfService.Rename(request);
    }
    
}