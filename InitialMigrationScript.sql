CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" TEXT NOT NULL CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY,
    "ProductVersion" TEXT NOT NULL
);

BEGIN TRANSACTION;

CREATE TABLE "Employees" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Employees" PRIMARY KEY AUTOINCREMENT,
    "FirstName" TEXT NOT NULL,
    "LastName" TEXT NOT NULL,
    "Age" INTEGER NOT NULL
);

CREATE TABLE "Tags" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Tags" PRIMARY KEY AUTOINCREMENT,
    "Title" TEXT NOT NULL
);

CREATE TABLE "Albums" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Albums" PRIMARY KEY AUTOINCREMENT,
    "Title" TEXT NOT NULL,
    "Price" REAL NOT NULL,
    "EmployeeId" INTEGER NOT NULL,
    CONSTRAINT "FK_Albums_Employees_EmployeeId" FOREIGN KEY ("EmployeeId") REFERENCES "Employees" ("Id")
);

CREATE TABLE "Studios" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Studios" PRIMARY KEY AUTOINCREMENT,
    "HouseNumber" INTEGER NOT NULL,
    "City" TEXT NOT NULL,
    "EmployeeId" INTEGER NOT NULL,
    CONSTRAINT "FK_Studios_Employees_EmployeeId" FOREIGN KEY ("EmployeeId") REFERENCES "Employees" ("Id")
);

CREATE TABLE "AlbumTags" (
    "AlbumId" INTEGER NOT NULL,
    "TagId" INTEGER NOT NULL,
    CONSTRAINT "PK_AlbumTags" PRIMARY KEY ("AlbumId", "TagId"),
    CONSTRAINT "FK_AlbumTags_Albums_AlbumId" FOREIGN KEY ("AlbumId") REFERENCES "Albums" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_AlbumTags_Tags_TagId" FOREIGN KEY ("TagId") REFERENCES "Tags" ("Id") ON DELETE CASCADE
);

CREATE INDEX "IX_Albums_EmployeeId" ON "Albums" ("EmployeeId");

CREATE INDEX "IX_AlbumTags_TagId" ON "AlbumTags" ("TagId");

CREATE UNIQUE INDEX "IX_Studios_EmployeeId" ON "Studios" ("EmployeeId");

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20220308164733_InitialMigration', '6.0.2');

COMMIT;




