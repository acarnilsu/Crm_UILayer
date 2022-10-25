using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfMessageDal : GenericRepository<Message>, IMessageDal
    {
        Context context = new Context();
        public List<Message> GetReceiverMessageList(string mail)
        {
            return context.Messages.Where(x=>x.ReceiverMail == mail).ToList();
        }

        public List<Message> GetSenderMessageList(string mail)
        {
            return context.Messages.Where(x => x.SenderMail == mail).ToList();
        }
    }
}
