BEGIN TRANSACTION;

CREATE TABLE "ef_temp_Tags" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Tags" PRIMARY KEY AUTOINCREMENT,
    "Title" TEXT NOT NULL
);

INSERT INTO "ef_temp_Tags" ("Id", "Title")
SELECT "Id", "Title"
FROM "Tags";

COMMIT;

PRAGMA foreign_keys = 0;

BEGIN TRANSACTION;

DROP TABLE "Tags";

ALTER TABLE "ef_temp_Tags" RENAME TO "Tags";

COMMIT;

PRAGMA foreign_keys = 1;

BEGIN TRANSACTION;

DELETE FROM "__EFMigrationsHistory"
WHERE "MigrationId" = '20220309111305_AddedDescriptionPropToTagEntity';

COMMIT;

