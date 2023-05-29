using Contatos.Helper;
using Contatos.Models;
using Contatos.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Contatos.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly ISessao _sessao;
        public LoginController(IUsuarioRepositorio usuarioRepositorio, ISessao sessao)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _sessao = sessao;
        }
        public IActionResult Index()
        {
            if (_sessao.BuscarSessao() != null) return RedirectToAction(actionName: "Index", controllerName: "Home");
            return View();
        }
        public IActionResult Sair()
        {
            _sessao.RemoverSessao();
            return RedirectToAction(actionName: "Index", controllerName: "Login");
        }
        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    UsuarioModel usuario = _usuarioRepositorio.BuscarUsuario(loginModel.Login);

                    if (usuario != null)
                    {

                        if (usuario.SenhaValida(senha: loginModel.Senha))
                        {
                            _sessao.CriarSessao(usuario);
                            return RedirectToAction(actionName: "Index", controllerName: "Home");
                        }
                        TempData["MensagemErro"] = $"Senha inválida. Por favor, tente novamente.";
                    }
                    TempData["MensagemErro"] = $"Usuário e/ou senha inválidos.";
                }
                return View("Index");
            }
            catch (Exception ex)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos realizar seu login. Tente novamente. Detalhe: {ex.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
