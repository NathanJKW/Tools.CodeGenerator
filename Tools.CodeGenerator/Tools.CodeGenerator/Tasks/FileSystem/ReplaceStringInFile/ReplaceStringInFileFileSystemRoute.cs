using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.CodeGenerator.Tasks.FileSystem.ReplaceStringInFile;

public class ReplaceStringInFileFileSystemRoute
{
    public static void MapReplaceStringInFileFileSystemRoute(this IEndpointRouteBuilder app)
    {
        app.MapGet("/api/employees", async ([FromServices] ??? ????) =>
        {
            //Code here
        });
    }
}
