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
    public class Create
    {
        public class Command : IRequest
        {
            public AdminFaq adminFaq { get; set; }
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

                _context.AdminFaqs.Add(request.adminFaq);

                var result = await _context.SaveChangesAsync();

            }
        }
    }
}
