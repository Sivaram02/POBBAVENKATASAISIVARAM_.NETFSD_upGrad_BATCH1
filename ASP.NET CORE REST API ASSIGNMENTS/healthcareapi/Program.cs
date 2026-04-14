using healthcareapi.Data;
using healthcareapi.Repositories.Interfaces;
using healthcareapi.Repositories.Implementations;
using healthcareapi.Services;
using healthcareapi.Middleware;

using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to container
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ✅ DbContext
builder.Services.AddDbContext<HealthcareDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

// ✅ Repository
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

// ✅ Services (ALL)
builder.Services.AddScoped<PatientService>();
builder.Services.AddScoped<DoctorService>();
builder.Services.AddScoped<AppointmentService>();
builder.Services.AddScoped<PrescriptionService>();

var app = builder.Build();

// ✅ Middleware
app.UseMiddleware<ExceptionMiddleware>();

// ✅ Swagger
app.UseSwagger();
app.UseSwaggerUI();

// ✅ Map Controllers
app.MapControllers();

app.Run();