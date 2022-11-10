using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace {$NameSpace};

public class {$ClassName}
{
    public static void Map{$ClassName}(this IEndpointRouteBuilder app)
    {
        app.MapGet("/api/employees", async ([FromServices] ??? ????) =>
        {
            //Code here
        });
    }
}
