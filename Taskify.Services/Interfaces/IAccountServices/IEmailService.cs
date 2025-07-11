using BrainHope.Services.DTO.Email;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskify.Services.Interfaces.Account
{
    public interface IEmailService
    {
        void SendEmail(Message message);
    }
}
