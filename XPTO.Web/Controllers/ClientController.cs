using Microsoft.AspNetCore.Mvc;
using XPTO.Web.Models;
using XPTO.Web.Repository;

namespace XPTO.Web.Controllers
{
    public class ClientController : Controller
    {
        public ClientRepository _clientRepository;

        public ClientController() 
        {
            _clientRepository = new ClientRepository();
        }

        public ActionResult Index()
        {
            var clients = _clientRepository.List();
            return View(clients);
        }

        public ActionResult Details(int id)
        {
            var clients = _clientRepository.Find(id);
            return View(clients);
        }

        public ActionResult Create()
        {
            return View(new Client());
        }

        [HttpPost]
        public ActionResult Create(Client client)
        {
            _clientRepository.Create(client);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var clients = _clientRepository.Find(id);
            return View(clients);
        }

        [HttpPost]
        public ActionResult Edit(int id, Client client)
        {
            _clientRepository.Edit(client);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var clients = _clientRepository.Find(id);
            return View(clients);
        }

        [HttpPost]
        public ActionResult Delete(int id, Client client)
        {
            _clientRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}