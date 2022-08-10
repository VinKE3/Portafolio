using Portafolio.Servicios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IRepositorioProyectos, RepositorioProyectos>(); //clase repositorio pryectos configurada en el sistema de inyeccion de dependencias, automaticamente va a ser instanciada siempre que yo la pida en el constructor de la clase homecontroller

builder.Services.AddTransient<ServcioTransitorio>();
builder.Services.AddScoped<ServcioDelimitado>();
builder.Services.AddSingleton<ServcioUnico>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
