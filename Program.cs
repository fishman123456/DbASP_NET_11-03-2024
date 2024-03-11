

using static DbASP_NET_11_03_2024.ApiMessage.CommonMessages;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("", () => new StringMessage(message: "server is running"));
app.MapGet("ping", () => new StringMessage(message: "pong"));

// Create Read Update Delete (CRUD)

// ���� ���������� EF � �� MS SQL Server � ������:
// 0. ������� � ����������� ������ ASP.NET
// 1. ���������� ����������� ������ .NET:
//  - Microsoft.EntityFrameworkCore.SqlServer
//  - Microsoft.EntityFrameworkCore.Tools
// 2. ������� ����� �������� � ����� ApplicationDbContext, ��������� ����������� � �� (����� ����� �������)
// 3. ������� � ��������� �������� (Add-Migration Init -OutputDir ./DB/Migrations; Update-Database)

// ��������: 
// �����
// ������������������
// ����� � ���� � ��������� ���
// ������
// ������������ ����
// ����������
