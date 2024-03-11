

using static DbASP_NET_11_03_2024.ApiMessage.CommonMessages;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("", () => new StringMessage(message: "server is running"));
app.MapGet("ping", () => new StringMessage(message: "pong"));

// Create Read Update Delete (CRUD)

// План интеграции EF и БД MS SQL Server в проект:
// 0. Создать и подготовить проект ASP.NET
// 1. Установить необходимые пакеты .NET:
//  - Microsoft.EntityFrameworkCore.SqlServer
//  - Microsoft.EntityFrameworkCore.Tools
// 2. Создать класс сущности и класс ApplicationDbContext, настроить подключение к БД (можно через конфиги)
// 3. Создать и применить миграцию (Add-Migration Init -OutputDir ./DB/Migrations; Update-Database)

// ВАРИАНТЫ: 
// Книги
// Электротранзисторы
// Блюда в кафе с указанием БЖУ
// Фильмы
// Компьютерные игры
// Автомобили
