using Aplikasi_Reservasi_Lapangan_Badminton.Auth;

var builder = WebApplication.CreateBuilder(args);

// Mengaktifkan controller API
builder.Services.AddControllers();

// Membaca AuthSettings dari appsettings.json
builder.Services.Configure<AuthSettings>(
    builder.Configuration.GetSection("AuthSettings")
);

// Satu AuthService digunakan selama API berjalan
builder.Services.AddSingleton<AuthService>();

var app = builder.Build();

// Menghubungkan controller dengan endpoint API
app.MapControllers();

// Membuat akun admin bawaan
AuthService authService =
    app.Services.GetRequiredService<AuthService>();

try
{
    RegisterRequest admin =
        new RegisterRequest();

    admin.Name = "Administrator";
    admin.Email = "admin@gmail.com";
    admin.Password = "password123";
    admin.Role = "Admin";

    authService.Register(admin);

    Console.WriteLine(
        "Akun admin berhasil dibuat."
    );
}
catch (Exception ex)
{
    Console.WriteLine(
        "Akun admin gagal dibuat: " +
        ex.Message
    );
}

app.Run();