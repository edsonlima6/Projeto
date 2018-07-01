using System;
using EP.IdentityIsolation.Infra.CrossCutting.Identity.Model;
using Microsoft.AspNet.Identity.EntityFramework;

namespace EP.IdentityIsolation.Infra.CrossCutting.Identity.Context
{
    public class ApplicationDbContext2 : IdentityDbContext<ApplicationUser>, IDisposable
    {
        public ApplicationDbContext2()
            : base("MyBI", throwIfV1Schema: false)
        {

        }

        public static ApplicationDbContext2 Create()
        {
            return new ApplicationDbContext2();
        }
    }
}