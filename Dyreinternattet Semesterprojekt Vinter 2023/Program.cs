using Dyreinternattet_Semesterprojekt_Vinter_2023.Services;
var builder = WebApplication.CreateBuilder(args);

//hva laver jeg?
builder.Services.AddAuthentication("MyCookieAuthenticationScheme")
	.AddCookie("MyCookieAuthenticationScheme", options =>
	{
		options.Cookie.Name = "MyCookie";
		options.LoginPath = "/Account/Login"; 
		options.AccessDeniedPath = "/Account/AccessDenied"; 
	});

builder.Services.AddAuthorization(); //login

// Add servces to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton<IDyreService, _dyreService>();
builder.Services.AddSingleton<IVagtService, VagtService>();
builder.Services.AddSingleton<IFrivilligService, FrivilligService>();
builder.Services.AddSingleton<IIndService, IndService>();
builder.Services.AddTransient<JsonFileDyrService>();
builder.Services.AddTransient<JsonFileVagtService>();
builder.Services.AddTransient<JsonFileFrivilligService>();
builder.Services.AddTransient<JsonFileIndService>();


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


app.UseAuthentication(); //Noget til login
app.UseAuthorization();
app.MapRazorPages();

app.Run();
