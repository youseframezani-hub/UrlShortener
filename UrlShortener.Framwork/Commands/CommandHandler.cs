using System;
using System.Collections.Generic;
using System.Text;

namespace UrlShortener.Framework.Commands
{
    public interface ICommandHandler<TCommand> where TCommand : ICommand
    {
        CommandResult Handle(TCommand command);

    }
    public abstract class CommandHandler
    {
        private readonly CommandResult _result = new CommandResult();
        public CommandHandler()
        {
        }
        /// <summary>
        /// برای بازگشت نتیجه صحیح از تابع Hanlde از این متد کمکی استفاده می شود و مقادیر پیش‌فرض برای نتیجه صحیح را تنظیم می‌کند
        /// </summary>
        /// <returns></returns>
        protected CommandResult Ok()
        {
            SetOkData();
            return _result;
        }
        protected CommandResult Ok(object data)
        {
            SetOkData();
            _result.DataResult = data;
            return _result;
        }


        private void SetOkData()
        {
            _result.ClearErrors();
            _result.IsSuccess = true;
        }
        protected CommandResult Failure()
        {
            SetFailureData();
            return _result;
        }
        protected CommandResult Failure(string message)
        {
            SetFailureData();
            _result.Message = message;
            return _result;
        }

        private void SetFailureData()
        {
            _result.IsSuccess = false;
        }
        protected void AddError(string error)
        {
            _result.AddError(error);
        }


    }
}
