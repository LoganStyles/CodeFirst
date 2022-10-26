BEGIN TRANSACTION;

ALTER TABLE "Departments" RENAME COLUMN "Title" TO "Name";

CREATE TABLE "ef_temp_Departments" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Departments" PRIMARY KEY AUTOINCREMENT,
    "Name" TEXT NULL
);

INSERT INTO "ef_temp_Departments" ("Id", "Name")
SELECT "Id", "Name"
FROM "Departments";

COMMIT;

PRAGMA foreign_keys = 0;

BEGIN TRANSACTION;

DROP TABLE "Departments";

ALTER TABLE "ef_temp_Departments" RENAME TO "Departments";

COMMIT;

PRAGMA foreign_keys = 1;

BEGIN TRANSACTION;

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20221026141624_RenameAndDeletePropertiesInDept', '6.0.2');

COMMIT;

