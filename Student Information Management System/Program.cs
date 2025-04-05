using Student_Information_Management_System.Interfaces;
using StudentInformationManagementSystem.Interfaces;
using StudentInformationManagementSystem.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSession();


// Đăng ký CSVServices và cung cấp tham số filePath
builder.Services.AddScoped<CSVServices>(provider =>
    new CSVServices(Path.Combine(Directory.GetCurrentDirectory(), "Data", "users.csv")));

// Đăng ký các service khác
builder.Services.AddScoped<ManageCourse>();
builder.Services.AddScoped<ManageGrades>();
builder.Services.AddScoped<IViewAcademicRecords, ViewAcademicRecords>();
builder.Services.AddScoped<IMangeCourse, ManageCourse>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseSession();
app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();
