using Dyreinternattet_Semesterprojekt_Vinter_2023.Services;
var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton<IDyreService, DyreService>();
builder.Services.AddSingleton<IVagtService, VagtService>();
//builder.Services.AddTransient<JsonFileDyrService>(); Indsæt når json er klar til at sættes ind

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
