using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UrlShortener.Domain.UrlStatistic.Commands;
using UrlShortener.Domain.UrlStatistic.Repositories;
using UrlShortener.Framework.Commands;

namespace UrlShortener.ApplicationServices.UrlStatistic.CommandHandlers
{
    public class IncreaseTotalRedirectCommandHandler : CommandHandler, ICommandHandler<IncreaseTotalRedirectCommand>
    {
        private IUrlStatisticRepository _urlStatisticRepository;

        public IncreaseTotalRedirectCommandHandler(IUrlStatisticRepository urlStatisticRepository)
        {
            this._urlStatisticRepository = urlStatisticRepository;
        }

        public CommandResult Handle(IncreaseTotalRedirectCommand command)
        {
            var urlStatistic = _urlStatisticRepository.Find(command.UniqueCode);
            urlStatistic.IncrementTotalRedirect();
            _urlStatisticRepository.Update(urlStatistic);

            return Ok();
        }
    }
}
