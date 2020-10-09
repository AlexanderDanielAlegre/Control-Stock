using Sofas.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sofas_Services 
{
    public class ToDoServices : IToDoServices
    {
        private SofasContext _context;
        public ToDoServices(SofasContext context)
        {
            _context = context;
        }

    }
}
