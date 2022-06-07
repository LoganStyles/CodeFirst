BEGIN TRANSACTION;

ALTER TABLE "Tags" ADD "Description" TEXT NOT NULL DEFAULT '';

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20220309111305_AddedDescriptionPropToTagEntity', '6.0.2');

COMMIT;



