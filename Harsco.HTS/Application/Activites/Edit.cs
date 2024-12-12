using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Persistence;
using System.Diagnostics;
using Persistence.Models;

namespace Application.Activites
{
  

   
        public class Edit
        {
            public class Command : IRequest
            {
                public AdminFaq Activity { get; set; }
            }

         

            public class Handler : IRequestHandler<Command>
            {
                private readonly dbtatContext _context;

                public Handler(dbtatContext context)
                {
                    _context = context;
                }

                public async Task Handle(Command request, CancellationToken cancellationToken)
                {
                    var activity = await _context.AdminFaqs.FindAsync(request.Activity.Id);

                   

                    var result = await _context.SaveChangesAsync();


                }
            }
        }
    }