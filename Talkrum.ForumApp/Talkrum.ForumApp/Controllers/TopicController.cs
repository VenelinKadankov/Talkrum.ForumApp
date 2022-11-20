namespace Talkrum.ForumApp.Controllers;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

public class TopicController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [Authorize]
    public IActionResult Create()
    {
        return View();
    }

    [Authorize]
    public IActionResult Edit()
    {
        return View();
    }
}
