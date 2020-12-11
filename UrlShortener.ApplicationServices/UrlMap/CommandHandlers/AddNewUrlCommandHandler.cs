using System;
using UrlShortener.Domain.UniqueCode;
using UrlShortener.Domain.UrlMap.Commands;
using UrlShortener.Domain.UrlMap.Repositories;
using UrlShortener.Framework.Commands;

namespace UrlShortener.ApplicationServices.UrlMap.CommandHandlers
{
    public class AddNewUrlCommandHandler : CommandHandler, ICommandHandler<AddNewUrlCommand>
    {
        private IUrlMapRepository _urlMapRepository { get; set; }
        private UniquCodeGenerator _uniquCodeGenerator { get; set; }
        public AddNewUrlCommandHandler(IUrlMapRepository urlMapRepository, UniquCodeGenerator uniquCodeGenerator)
        {
            _urlMapRepository = urlMapRepository;
            _uniquCodeGenerator = uniquCodeGenerator;
        }

        public CommandResult Handle(AddNewUrlCommand command)
        {
            if (!isValidUrl(command.Url))
            {
                AddError("Invalid Url");
                return Failure();
            }
            var urlMap = new Domain.UrlMap.Entities.UrlMap(_uniquCodeGenerator, command.Url);
             string uniquCode = _urlMapRepository.Add(urlMap);

            return Ok(uniquCode);
        }

        bool isValidUrl(string url)
        {
            bool isUri = Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute);
            return isUri;
        }
    }
