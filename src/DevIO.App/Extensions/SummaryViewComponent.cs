using DevIO.Business.Interfaces.InterfacesServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.App.Extensions
{
    public class SummaryViewComponent : ViewComponent
    {
        private readonly INotificador _notificador;

        public SummaryViewComponent(INotificador notificador)
        {
            _notificador = notificador;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var notificacoes = await Task.FromResult(_notificador.Obternotificacoes());

            notificacoes.ForEach(c => ViewData.ModelState.AddModelError(string.Empty, c.Menssagem));

            return View();
        }
    }
}
