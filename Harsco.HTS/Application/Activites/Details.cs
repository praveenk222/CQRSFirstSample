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
    public class Details
    {
        public class Command : IRequest<AdminFaq>
        {
            public int ID { get; set; }
        }
        //for mediatr no need to send returnt type here.

        public class Handler : IRequestHandler<Command,AdminFaq>
        {
            private readonly dbtatContext _context;

            public Handler(dbtatContext context)
            {
                _context = context;
            }


            public async Task<AdminFaq> Handle(Command request, CancellationToken cancellationToken)
            {

              return await  _context.AdminFaqs.FindAsync(request.ID);


                   

            }
        }
    }
}
