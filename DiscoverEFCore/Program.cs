using DiscoverEFCore;
using Microsoft.EntityFrameworkCore;

DbContextOptionsBuilder builder = new DbContextOptionsBuilder();


builder.UseSqlServer("Server=DESKTOP-1446PBQ;Database=SdA.Test.Bdd;Trusted_Connection=True;TrustServerCertificate=true", options =>
{
    options.CommandTimeout(120);
});

using (var context = new DefaultContext(builder.Options))
{
    // using var context = new DefaultContext(builder.Options); // context.Dispose();


    var query = from elfe in context.Elfes
                where elfe.Name.Contains("is")
                select new { Yolo = elfe.Name.ToUpper() };

    var list = query.ToList(); // ici qu'on se connecte et qu'on envoie la requete sql


    context.Elfes.Add(new Elfe() { Name = " Tetris" });
    context.Elfes.Add(new Elfe() { Name = " Tetris 2" });
    context.SaveChanges();

}
