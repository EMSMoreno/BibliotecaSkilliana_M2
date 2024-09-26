use BibliotecaSkilliana
go

CREATE TABLE Utilizadores (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(100),
    Password VARCHAR(255),
    Role NVARCHAR(50)
);
