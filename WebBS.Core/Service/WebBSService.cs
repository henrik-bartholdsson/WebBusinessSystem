using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebBS.Data.Models;

namespace WebBS.Core.Service
{
    public class WebBSService
    {
        private readonly WebBSContext _context;
        public WebBSService(WebBSContext context)
        {
            _context = context;
        }

        public Item GetFirstItem()
        {
            return _context.Items.Where(i => i != null).FirstOrDefault();
        }

    }
}
