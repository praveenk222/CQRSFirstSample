using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Domain.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Persistence.Models;


namespace Application.Activites
{
    public class List
    {
        public class Query:IRequest<List<AdminFaq>>{}

        public class Handler : IRequestHandler<Query, List<AdminFaq>>
        {
            private readonly dbtatContext _context;
            public Handler(dbtatContext context)
            {
                _context=context;
            }
            public async Task<List<AdminFaq>> Handle(Query request,CancellationToken cancellationToken){
                return await _context.AdminFaqs.ToListAsync();
            }

        }
    }

   
}