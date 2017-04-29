using RSSReader.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRSSReader
{
    public interface IRSSReader
    {
        Task<ICollection<News>> GetNews();
    }
}
