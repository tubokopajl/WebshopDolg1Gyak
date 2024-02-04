using WebshopDolg1Gyak.Modells;

namespace WebshopDolg1Gyak
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            builder.Services.AddDbContext<VasarlasContext>();   
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            var app = builder.Build();

     
            app.MapControllers();

            //redirect  to swagger
            app.UseSwagger();
            app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebshopDolg1Gyakv1"); });
         
            app.Run();
        }
    }
}
