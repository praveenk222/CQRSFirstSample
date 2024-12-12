using MediatR;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistence.Models;


namespace Application.Activites
{
    public class Delete
    {
        public class Command : IRequest
        {
            public int ID { get; set; }
        }
        //for mediatr no need to send returnt type here.

        public class Handler : IRequestHandler<Command>
        {
            private readonly dbtatContext _context;

            public Handler(dbtatContext context)
            {
                _context = context;
            }


            public async Task Handle(Command request, CancellationToken cancellationToken)
            {

              var data=  _context.AdminFaqs.FindAsync(request.ID);
                _context.Remove(data);

                    await _context.SaveChangesAsync();

            }
        }
    }
}
