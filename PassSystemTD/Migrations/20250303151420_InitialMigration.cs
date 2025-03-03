using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PassSystemTD.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BannedTokens",
                columns: table => new
                {
                    Token = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    ExpiresAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BannedTokens", x => x.Token);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Gender = table.Column<int>(type: "integer", nullable: false),
                    Email = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Passes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Reason = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    StartTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    PassStatus = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Passes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    IsAdmin = table.Column<bool>(type: "boolean", nullable: false),
                    IsStudent = table.Column<bool>(type: "boolean", nullable: false),
                    IsTeacher = table.Column<bool>(type: "boolean", nullable: false),
                    IsDean = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Role_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Proofs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FileName = table.Column<string>(type: "text", nullable: false),
                    FileUrl = table.Column<string>(type: "text", nullable: false),
                    PassId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proofs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Proofs_Passes_PassId",
                        column: x => x.PassId,
                        principalTable: "Passes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "Email", "Gender", "Name", "Password" },
                values: new object[,]
                {
                    { new Guid("0714ae77-2022-42cf-981b-c1388b8cbfea"), null, "user4@example.com", 0, "User4", "$2a$11$HsUFJLNYhgl.yEf6FQz36e7JYFpoJeIP5QO0i3yu9N.BBXA6YJSdu" },
                    { new Guid("0ad6d62a-41ea-4129-8d3e-2eac56e7baac"), null, "user8@example.com", 0, "User8", "$2a$11$2lf.nW52po0PBKv8dFxfnuhauqVN8aBB2QgoTlVsMdl0od8S5A676" },
                    { new Guid("0db5e0c8-1b1b-458d-a5fd-498cc6ce46a1"), null, "user2@example.com", 0, "User2", "$2a$11$JlYlSoEkfnu7GIGo24znAOr0r9oULFaETh19zkiHCicX6UKLXcr5u" },
                    { new Guid("0f675390-389f-41a0-9b62-534802da2335"), null, "user60@example.com", 0, "User60", "$2a$11$gk05OsU05/pANnjeXej1Lu9PF8a5WB/a0stG3yWOe8nJiAYL/QG8W" },
                    { new Guid("14e7d3fc-c460-474b-8e9a-2074d369feab"), null, "user47@example.com", 1, "User47", "$2a$11$g10PEPEm6Sds47As1nEbweSjL6C4niUDEG/uFkpNNs/5PQwn6gBv." },
                    { new Guid("157f0bdc-97f6-43db-b867-13102374e719"), null, "user59@example.com", 1, "User59", "$2a$11$6FSSVZUnIEJnTby4BCasLupp4V.Be8FAwatlxRYqgIMviSUCnGzgm" },
                    { new Guid("18206ff6-a98b-4de8-b325-304c49e8351d"), null, "user56@example.com", 0, "User56", "$2a$11$R7kej.bpPhyy6/CcUWLut..S3uFbO.xNkxPjMiRKDspWSt5VbTcQ." },
                    { new Guid("1a47d877-41ff-46ce-934b-27c58ba72c26"), null, "user68@example.com", 0, "User68", "$2a$11$/y1H6wKBHKN2F/K7FoAZ8O7uFGJpUZyGuHc.3W7LYhp4BHnBPm6.W" },
                    { new Guid("1dcaf388-9d9b-42d4-b72e-f969013443bf"), null, "user55@example.com", 1, "User55", "$2a$11$oCk8w2ucWIrXZpN55m4omOX03b6PwEN3jXAtR1hHIHdN9g/s2MrJe" },
                    { new Guid("1e1125b2-639d-4069-937c-f3b49e599bdd"), null, "user100@example.com", 0, "User100", "$2a$11$lCQeY3AAaPGOzPZbRYyCveuppwCeZHh.uLZ0aopwG.Nbt0fMe5eBW" },
                    { new Guid("1e755de5-0532-4834-991c-d6d35793b58c"), null, "user65@example.com", 1, "User65", "$2a$11$DMXkdha8RmgX13AWGZNwP.fCFZRnASI0.AjMvbLRa1ru5I4q/KX8." },
                    { new Guid("20285f4a-1ca0-4c1b-96ea-651cad573357"), null, "user5@example.com", 1, "User5", "$2a$11$IekcLcsMxzx2UB8OhRdnwOWZYo/r3hEX0yU.vvVB6/g5LZzwVjBgy" },
                    { new Guid("2574874c-abb1-40c9-83ee-7745b4e61e41"), null, "user82@example.com", 0, "User82", "$2a$11$YB5b4LiJdIjWWzPYGkgKuOTjUO1APYC4dU9v1QNfZrG3BH3LypVDO" },
                    { new Guid("26f9cd13-e2a1-4447-ae89-9a7d51adcdba"), null, "user46@example.com", 0, "User46", "$2a$11$BTxTp2Bg7HojbOcmfDx4oelB2j6ldOVdJvrKsktMUg8yYy1l20W/a" },
                    { new Guid("2708b88a-a0ab-4358-baca-b9108a7ecdf5"), null, "user15@example.com", 1, "User15", "$2a$11$G90y47Zjm/EXJsMu6lLEn.aPBycRCl9gIG1gCgHOhoQCav7mxLEKu" },
                    { new Guid("27e739fa-1a72-4971-a85e-21a568e32435"), null, "user49@example.com", 1, "User49", "$2a$11$ndMbGN46KVcA8KlZQGAxI.zgH1rKLCyFWlge53IdtjxLqlYodmVwC" },
                    { new Guid("2efc4a6c-c4b1-452f-aa8a-96faf29db414"), null, "user71@example.com", 1, "User71", "$2a$11$B9tWtmNJ9Gi9nsUB3X0qA.K1Ow9Y1YSwIwopLo3rDpHHa4eeT2FeO" },
                    { new Guid("3100c226-9d93-4f99-a883-a4593886d1e7"), null, "user48@example.com", 0, "User48", "$2a$11$qyRxdcXU6LyzNKeWfxp5UuYRD5iwysoo8RNQ0ENZDiHOYYgwtI/h." },
                    { new Guid("37ee2938-6c9e-4a8a-8baf-cf012bd4872b"), null, "user33@example.com", 1, "User33", "$2a$11$gVpdj4X4NmqK4UMGCl.3Mu0Dy8pb4BJ8vZFJU3NdgF8H3OSbF.E8i" },
                    { new Guid("39513620-8006-46ea-b5d7-bd42c238a9c9"), null, "user12@example.com", 0, "User12", "$2a$11$50PHELXN0hkGLlBnJNdfcOxlkiXHPvj1oo0UEepAvM3ZGUpJPnqmC" },
                    { new Guid("3ac05134-b1c1-4734-849d-76559018649a"), null, "user40@example.com", 0, "User40", "$2a$11$73XdunzFEX67HPuc3dl1yeLtDGmhe4/KEMO0h6G9pMhAPiOMY9R4e" },
                    { new Guid("3b70981f-c60a-4af4-8a88-d5a7a7449472"), null, "user18@example.com", 0, "User18", "$2a$11$S0eAQgTXTpaQM2Js9CEoiO0uSi7qO3lbIw026/ZVJ0tvgWkcAE2c6" },
                    { new Guid("3ccfce1a-3fbf-4812-a89c-cde8027e6e7e"), null, "user72@example.com", 0, "User72", "$2a$11$1laipALEumHTdlGHzOZH4eyz23tWOT.vKLFyJhpqj9/QLAXqaIONW" },
                    { new Guid("3de3f7bd-5869-488c-9454-fcc40a1558b5"), null, "user61@example.com", 1, "User61", "$2a$11$RMlU63yakgwjwa0wX6l28uoDxjx6uUZMPWrZpkj671zj1ApNLPDdG" },
                    { new Guid("3e99fe4c-c9d4-4354-8944-311a0da24fdb"), null, "user70@example.com", 0, "User70", "$2a$11$ozlVStpsx057u42gPioAKuS/5d/DJGtjI0pxRfgPgggzshi4uBqvS" },
                    { new Guid("3ff30d8a-1d70-493c-ba4d-a87cea6ef7c5"), null, "user91@example.com", 1, "User91", "$2a$11$LuOTEfWZF6xM0EfXcyXQhOJcMsq5iR/XEMVNibWMeNjtru9NcH5GC" },
                    { new Guid("41c13004-c5ec-4d32-920f-4d2945dc3cd6"), null, "user21@example.com", 1, "User21", "$2a$11$rUSrERRU.ez5/v0VfQz/9u3JXQ4LnJLJgHpBrRdB9FoXWHTDOHy4." },
                    { new Guid("441505bf-b2d8-421c-8e07-679133a4a352"), null, "user79@example.com", 1, "User79", "$2a$11$xQnG99ZMgtEMllNl/2wC6uumhTMQ/q.OiI.QHpGAKHxTlzjicA3iW" },
                    { new Guid("4667e5f0-e317-4055-856b-700886f17626"), null, "user16@example.com", 0, "User16", "$2a$11$NQIC1u20p72JeVJqBTOcvOJ8q4tAAEKbhkQg81fL0kJLuqNVBiM0i" },
                    { new Guid("46d9f511-ea71-4552-a072-5a84bf6b1ad3"), null, "user86@example.com", 0, "User86", "$2a$11$oJa/IL5hShJFGEwV76I/GumLrD42/mZfa3OjKUp3eIkBUWGJ8nWEa" },
                    { new Guid("4cf48994-46d1-43bb-b1a4-42fd43de96df"), null, "user13@example.com", 1, "User13", "$2a$11$dyecv5IPz3avpwsEix4aD.XDpmc7Ck7AHMrProHqZ0xcpfVNTyTti" },
                    { new Guid("4da2da52-cb8b-4ec8-be25-880470dd1551"), null, "user99@example.com", 1, "User99", "$2a$11$2EOFApJqhEjqwM5J/axv8OgieosB8qP4Tu5ftzXRmkFCTyBZlZmiS" },
                    { new Guid("4f632d81-2639-436a-a60a-616a04e01421"), null, "user54@example.com", 0, "User54", "$2a$11$7WZwrfbVrXlgPuQ1.KX4ouzBs5Y/qyeOOPiRnkx.qUBPe9kB25UDq" },
                    { new Guid("4fa43eae-1355-4255-b305-2fad4f4560dc"), null, "user80@example.com", 0, "User80", "$2a$11$Ldp5etAKNNbC00lsbwiAYecjFhIolYgHEl2Wi.5PdtoR7nn.0BTJ." },
                    { new Guid("5001e974-e693-49cc-a78d-8b4e78352ded"), null, "user62@example.com", 0, "User62", "$2a$11$QMRH8aPxmGw5vJB7t8YrHOh5MW9JdR5HWvwDuDf0q.UKuzhtJAoz." },
                    { new Guid("533f1369-d29c-4799-87cb-087d3aeae718"), null, "user81@example.com", 1, "User81", "$2a$11$dlmecx5zin8TCmCm9SGiU.J1bJ3M.j/Ygt9SbEgB/bDZj.J5fGehq" },
                    { new Guid("53ec0356-b063-47a2-ad6f-8b3452a5fb01"), null, "user23@example.com", 1, "User23", "$2a$11$BNyq2UQCs8oxc2Fn95jsnuaN6/jiEq8SwoI5gWE4TcZqXNpwIVj/i" },
                    { new Guid("5dedd314-a68c-4bd9-a459-63135bf403d7"), null, "user89@example.com", 1, "User89", "$2a$11$hFBH3yB0hXuscKEALjc0HOfcIeT1O6.CRelXoroHnfhHYG0iD9NtO" },
                    { new Guid("5e578f88-4238-4351-9fe3-695a38353fd9"), null, "user7@example.com", 1, "User7", "$2a$11$PRGdgfHgSds.D3kmOMCg6ebluiDv4JhkFH4lPQ0RnS/LvCS/npQFK" },
                    { new Guid("62774a3d-2583-4697-9e3e-6fd59a81af15"), null, "user22@example.com", 0, "User22", "$2a$11$RO4pkkMjVi8fVcZqZvfNX.vx8ZwW7LB8MoiMipH7wwOYHpEsfIdrO" },
                    { new Guid("63e165ac-06ed-432f-ba9f-cb52b732d4ed"), null, "user58@example.com", 0, "User58", "$2a$11$dGAH.whxBYpNSnc2BpGe.uihkZqVy7I05EFw97qhzKZ4yc.K28F7q" },
                    { new Guid("663a2e07-5b81-47fa-802c-0dbedf8e0295"), null, "user76@example.com", 0, "User76", "$2a$11$z51hdofU22p6W/Ow0MX4K.kJB7JHTYBNFLTdbdhFYAnNRwqRo5AQK" },
                    { new Guid("669c8f67-7a81-4afa-8640-a70c17e667ab"), null, "user51@example.com", 1, "User51", "$2a$11$mE3Y/VTjHJJvFNN28XUxue.d2dSjELEIAPMSuHLqJ3q.RycWssZfi" },
                    { new Guid("670ad33a-bb1a-4e68-a826-270bd11894dd"), null, "user87@example.com", 1, "User87", "$2a$11$KBLyj7/jo7pk40nTw0ZKZe8dozEw3GkyLy2j9t7dwzujCFPkgoIBy" },
                    { new Guid("6747d693-00f8-42b8-afe7-fc6bbe093045"), null, "user25@example.com", 1, "User25", "$2a$11$A2dPqYxqjCZ9TOUMjRSgSuD8xYG4N20A0CjJ/.1bb1l/abMJbnG2S" },
                    { new Guid("6995a437-1af4-45cb-b579-0e47604adfce"), null, "user75@example.com", 1, "User75", "$2a$11$sej21UbNSPOpLpk4WtA07O/hkVgZ2Zu8OCfyDPaNSEutAt5V3z8H." },
                    { new Guid("6995c92a-311c-48b5-b983-e68d09b701eb"), null, "user84@example.com", 0, "User84", "$2a$11$w1pcYihNFLLBXMsQ1.k73eotFvZQhMES4hGY4ofZMnFTju3gSGKuq" },
                    { new Guid("6b4a9c91-a0fe-41db-a504-ca6569d39f68"), null, "user28@example.com", 0, "User28", "$2a$11$slWqwOYWX0koY5lmgaUIhuu7i1McIe0GRpcmtPQeYusdPA11J392K" },
                    { new Guid("6dfff323-e4ec-48ad-8563-c283a9d0e9fb"), null, "user94@example.com", 0, "User94", "$2a$11$cViPpjRlKVPmDdU5kmRk/.sgJeabbf/zpT.2s03v3U4LXpTyPJiwe" },
                    { new Guid("6f9350a0-c47f-4579-8bfa-ed2533fb9d19"), null, "user10@example.com", 0, "User10", "$2a$11$9OH3xYwx8hf9hQAva8xpaulicXiNxD4D9c0GaYZWbejkNiEXQkMVG" },
                    { new Guid("6fd4fe33-2abb-46f8-9e2c-dfe306fa57f8"), null, "user53@example.com", 1, "User53", "$2a$11$iXSPWQyF7L0YBp1Lup3O0OalLJzThO2zLAYimo6Gr8ONkhygEEg/S" },
                    { new Guid("776002bf-c810-40e6-a811-b501136195cd"), null, "user36@example.com", 0, "User36", "$2a$11$hdTPbt/9qnw8wDOR6dwynOxXz7Zkm6AvxOpG6llibO.Kebikm9Ir." },
                    { new Guid("7927e736-e5bb-42c1-b9e1-3603aa1aea6c"), null, "user77@example.com", 1, "User77", "$2a$11$Oh4PoDKrx2N2yGQd5DHo8OPT1uf.0G0Dyl4ROW2aO34Tc4yJlrZ1m" },
                    { new Guid("7a68a9e9-de85-4b0e-8927-039867a34f9a"), null, "user50@example.com", 0, "User50", "$2a$11$4jdXyU0Z/WLK4ck.CxQIMOH1Hqa/NDNk0qTr9ZQqwNA.tBitTMm7m" },
                    { new Guid("804dc86f-cc5c-4590-b6d4-dd46e60293e8"), null, "user98@example.com", 0, "User98", "$2a$11$Zs.HaDJteJRgqmE24/bs9.NEywyvn1q1FLlUty.fwNKpzSFlLjcES" },
                    { new Guid("81288061-e254-4522-854b-dd1ed92a595d"), null, "user93@example.com", 1, "User93", "$2a$11$9YfQo0A8EYN4WqW51LdpF.W8HM4g/WX8NpZt5z3fkR3gYUt98qWIa" },
                    { new Guid("88a854c6-2455-4446-b568-97d6724c065b"), null, "user63@example.com", 1, "User63", "$2a$11$2.36j/GsfLfl1AtMU4VvRuZyLf9fhV5xzU.oEq0tRgZRp6/Scgqx6" },
                    { new Guid("8bd090a4-e7b1-4f00-9222-dafdc9e828ff"), null, "user38@example.com", 0, "User38", "$2a$11$zXRogTSxKzJ9TJwJ4H8w2OwDx6pAnKigQ9EztTo32Ujs1AOjUKZ6W" },
                    { new Guid("8cdc7b55-d18c-414a-b7ca-12de2869ff9f"), null, "user27@example.com", 1, "User27", "$2a$11$NpcaeS4NrxX.tYlMMS83i.rTQ09S6IHRHN16rZyxEvkrJMp359COO" },
                    { new Guid("8db1d91d-89c9-447c-a39c-86f208cdd288"), null, "user78@example.com", 0, "User78", "$2a$11$ZlgGJ1LjP6mPGvL1LI/fr.8bfIkvVC6Cse8ZA/tSh2AMGvCWswaLC" },
                    { new Guid("9ad334e1-784a-4229-b1ba-161b652fbc94"), null, "user67@example.com", 1, "User67", "$2a$11$lOPHzA4d5RoRAU8ZvFpFTecjUgGxep1MHnfrkzRXnawh0gmfw0JNa" },
                    { new Guid("9bb3e152-bb6d-4b4f-afb8-adb8e7be5626"), null, "user3@example.com", 1, "User3", "$2a$11$3CyRAK/EINFn/fZXOYQlUeCWTz5rbaX.ZSgoP3YIEN414sQCJTDyS" },
                    { new Guid("a05fac61-bd08-46b8-a88b-676a7dd020f7"), null, "user95@example.com", 1, "User95", "$2a$11$7.wKgcYlY.p6RB1/3zHAj.GJ86h4iJHsUR1M/TmHds5UQx8l5iP52" },
                    { new Guid("a06a8ec0-8d77-4549-ab96-82e2f545a0b6"), null, "user39@example.com", 1, "User39", "$2a$11$pK5hT8uEbi8kzT4k3G1fvuViC7Rd.mpOqSi6UDfqvIQjCggpDPHEW" },
                    { new Guid("a39b1f79-26a2-4c6e-a649-fda73b69f994"), null, "user90@example.com", 0, "User90", "$2a$11$uNyM30HU7QA7Y42UcBX.wOs8A.tVzEAbq/qDpoC9mh1gdFywrG69C" },
                    { new Guid("a4f3b11c-c45f-4d23-978b-200ade902e90"), null, "user44@example.com", 0, "User44", "$2a$11$7cWAdEqNOiydNwTftvXlmuMCreCxQhEn3wKr5syaEynPLOQq7fqdC" },
                    { new Guid("a6fa09bc-d822-4d73-a261-19d73364aab9"), null, "user26@example.com", 0, "User26", "$2a$11$1oYSpTAGpwE.EjKiv32gm.adhUUVyIWIe6zziHVJ6oMkv4ux4GNWK" },
                    { new Guid("b258f8ee-8118-4e5a-b0b9-2d42b181da73"), null, "user35@example.com", 1, "User35", "$2a$11$89eEgrZqdf92YE0931yhPe5tFBCt/J17XQCmwpv/yWI7YTI3gIDlW" },
                    { new Guid("b2db4b69-d922-4ec3-8991-1db12ef84aa0"), null, "user14@example.com", 0, "User14", "$2a$11$dgKwFFQYKHBlDGxwrEd0l.KRdBAq3iQR9FO4pnGwPmYXYC6/J7G72" },
                    { new Guid("b81c2f99-6dde-41d2-a940-6a261af8a03a"), null, "user19@example.com", 1, "User19", "$2a$11$Rp8muaMkUKJX7JQOh2JBkuPHwYnL1eJG8ER/YvdTPs6LHnMLAYp42" },
                    { new Guid("b81ed8ed-938a-4309-81fd-cca9dac6534a"), null, "user30@example.com", 0, "User30", "$2a$11$gByPB2Dblxh.fzqDbStbN.8sMjkQ8gn.diQgPh0oCd6spjeLq7FNq" },
                    { new Guid("c0573f21-c5be-4648-8907-c529a921748d"), null, "user24@example.com", 0, "User24", "$2a$11$aktiuRsRCdgG5IT/QD1rNO5iNcFhtfUF0Oq2YoOkRmkVBrmLUGWB2" },
                    { new Guid("c3732540-7fc8-435b-97b0-30f033c9c23d"), null, "user74@example.com", 0, "User74", "$2a$11$K2mDSJFZ8GUVqeQzcKzu9u0ydLRRMz1dWM7HplMbekCD77MCTzwqK" },
                    { new Guid("c772b7db-9a40-4ccf-a6a2-920ece594c65"), null, "user20@example.com", 0, "User20", "$2a$11$Be2egp0mZnn.zCylnmE5XOyhh75inezvLFFdUlZZN9ul0kTVfXLUm" },
                    { new Guid("c8ef223a-a8cd-4acc-8eaf-2e08c1e6a76e"), null, "user57@example.com", 1, "User57", "$2a$11$GyaE2B..82nSSUC1eI5YP.8uovlgTHfZ0N6OmDmjv.fAsMPqriee6" },
                    { new Guid("cbd0a31f-6bb6-4701-b752-2af009570ec9"), null, "user41@example.com", 1, "User41", "$2a$11$l1N5N8psIeVYA5hMmIiQ2uIC9EJnwKFcb1VW1/PuPv5KThYXnElEy" },
                    { new Guid("ccd681d3-89ce-44c9-955b-29b477041988"), null, "user45@example.com", 1, "User45", "$2a$11$wzYe1FKtZyGr4A/mlU1Kl.eWi6DyXv3xObWopduHCJUCLHJ6oUZgW" },
                    { new Guid("d2a95c02-0386-4264-9696-20d496075715"), null, "user42@example.com", 0, "User42", "$2a$11$VyJ9rGaXZ2iNYJJh1NuQkeZye60GaL/FcdBpiMxGG1dLrXcbGESke" },
                    { new Guid("d4486a21-7f32-4dc3-b2fa-03498f880075"), null, "user32@example.com", 0, "User32", "$2a$11$cBEQpW8laKFJFIYE8mOJ4OI5CKEnMFp63Wv3O8uGsv8/qAaICTC5W" },
                    { new Guid("d45ea3f4-3bc9-498e-889f-82dcf968bce9"), null, "user52@example.com", 0, "User52", "$2a$11$ZpTscxVp5hXk369r3ZJplOkEB7kXI3oP50euS6rceLamB1GetUbmC" },
                    { new Guid("d7852dda-7cec-4e14-a9bb-5c86d7b5b3c3"), null, "user17@example.com", 1, "User17", "$2a$11$OFE/0Q7N92FkhEDEtXDCluLMNichfj5iBkw/5/55ga6d9ciNmMKrq" },
                    { new Guid("d95ac8e6-1e8d-47d6-991d-7956470feb2a"), null, "user43@example.com", 1, "User43", "$2a$11$zvFgc4BP2sP7da1m8EqH/OsLX16s9l.0KfIdb8bMo7fAh/EuN5alq" },
                    { new Guid("dc0b5186-b7ef-43dd-ba95-c3d16d0f9d47"), null, "user6@example.com", 0, "User6", "$2a$11$gsczxr0mqB21gaixm8aQUuRdqrIKO.y8hFpzWo/tCXDMULeRVphBq" },
                    { new Guid("dcbb9a2e-e021-4268-ab08-bf04914f1ff1"), null, "user69@example.com", 1, "User69", "$2a$11$w/m4SxudOfnu4iShDXkaZOxzzHXgeYDAlGNHTucXkx8GSH.PVNmhm" },
                    { new Guid("df187816-efe3-4894-86d1-a74d2858a50c"), null, "user9@example.com", 1, "User9", "$2a$11$bWDZ9b.Fqb5c5qPzDGeP0OvczksD4Sad4sXOY9Fxbquk8JMGHhGvW" },
                    { new Guid("df29860a-7a1b-424d-bce1-e884b8955ebe"), null, "user92@example.com", 0, "User92", "$2a$11$g/BewKFYevW99BssQT2.2.E9Kr5gZoc7VuYPRzWQ6YWWPWpsKV0cm" },
                    { new Guid("dff221dd-d92a-4780-b09a-2d4bb02ef8dc"), null, "user31@example.com", 1, "User31", "$2a$11$eIA6eovHdQExHLg719fko.DBlFaePzbaarkr2XS8VDwzw0Do1lAWm" },
                    { new Guid("e15f9a3f-bb9b-4cc8-9b73-81b92d84cabb"), null, "user83@example.com", 1, "User83", "$2a$11$cekj1Pk7oXqsvvh8Upf7fugVXwMOkyQ.F8czhxu2J5bAks0DlsqNy" },
                    { new Guid("e59b1421-26d3-4f93-a9aa-871160869bc5"), null, "user64@example.com", 0, "User64", "$2a$11$uKjG1.7C4sPUve2MtzQ6EeRGRoMLXme8/S2oXOQDhNvL1.8nWsvEG" },
                    { new Guid("e61b5b75-242c-4fcd-ac51-3c8846cc85e9"), null, "user85@example.com", 1, "User85", "$2a$11$6eL7HCCOWaQJgUe8ky4S2OJuFU7.YsfeIb8rLpIhzLrDBMbcr/tVC" },
                    { new Guid("e6c517e3-1bbe-4723-aa4e-49e1c873e8be"), null, "user29@example.com", 1, "User29", "$2a$11$fHTAbCBfOpdL.A3YWyj0f.zlkHTHWPwtAceCj88851OPYfXCaqeP6" },
                    { new Guid("e6f4c8f0-43fd-4b45-990e-9e4937439947"), null, "user97@example.com", 1, "User97", "$2a$11$88uIDcxoLnS93L1JtADV2OS3sjABgkpCcvkJA0/XJ.udpBXe/Xmfe" },
                    { new Guid("e948ecd9-01c8-42eb-9eb1-e8d53aecc629"), null, "user96@example.com", 0, "User96", "$2a$11$XXa4nCN5QLd/2cibHGWF2udd.YZF9o8mUI05wM2aQE38kbLh.586S" },
                    { new Guid("e9a8841c-7340-4697-925a-d94d9f0cc3c1"), null, "user1@example.com", 1, "User1", "$2a$11$XSAD0kaua6lIhxA791lAGOt768ZCNFKkHtNT5XZQHGnSepOktYVJO" },
                    { new Guid("f0b83541-1365-4839-88c1-df5ae112cb05"), null, "user37@example.com", 1, "User37", "$2a$11$PL4WN1wxzI2MsdKASqNAyuC45wRcFHXc8G1F2VHvT1TyQw2lbzJ5K" },
                    { new Guid("f29d9194-3e5d-48c0-be66-681938ff45c2"), null, "user88@example.com", 0, "User88", "$2a$11$aAK2Xt1gCQEIrEamOxwo2ee3iu358eFQoN3SQ5z2TPF2aLbVsnKZW" },
                    { new Guid("f351bc0b-6573-4dca-be68-6d50f0a59b40"), null, "user66@example.com", 0, "User66", "$2a$11$f8Po/.RNMvBhlGTzrkEXUebn1TCee/T3FMNla8/A1tFsg76I17Zcq" },
                    { new Guid("f586d4ee-9646-480f-850b-785ec7b870e3"), null, "user34@example.com", 0, "User34", "$2a$11$soAXMYVXhucWAEHlEqxwKec8ErRsrdzhwAvvBKTcxp/EiOy8LNu3a" },
                    { new Guid("facc6fd2-cac5-473b-be29-9ebd328a74ad"), null, "user73@example.com", 1, "User73", "$2a$11$lz.vRfBVpAnRe.YpMgN/ke8TYWlYcQl14ctK5njYs.lALTUs.Rh8i" },
                    { new Guid("fdc9f9a5-56fd-42c8-8d44-8e45e975288b"), null, "user11@example.com", 1, "User11", "$2a$11$pH0CQnKrqUGvPpi84bxh1e0dJPYw3ha6W6nQ36EFY2D5lmKKAcoMG" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "IsAdmin", "IsDean", "IsStudent", "IsTeacher" },
                values: new object[,]
                {
                    { new Guid("0714ae77-2022-42cf-981b-c1388b8cbfea"), false, false, false, false },
                    { new Guid("0ad6d62a-41ea-4129-8d3e-2eac56e7baac"), false, false, false, false },
                    { new Guid("0db5e0c8-1b1b-458d-a5fd-498cc6ce46a1"), false, false, false, false },
                    { new Guid("0f675390-389f-41a0-9b62-534802da2335"), false, false, true, true },
                    { new Guid("14e7d3fc-c460-474b-8e9a-2074d369feab"), false, false, false, false },
                    { new Guid("157f0bdc-97f6-43db-b867-13102374e719"), false, false, false, false },
                    { new Guid("18206ff6-a98b-4de8-b325-304c49e8351d"), false, true, false, false },
                    { new Guid("1a47d877-41ff-46ce-934b-27c58ba72c26"), false, false, false, false },
                    { new Guid("1dcaf388-9d9b-42d4-b72e-f969013443bf"), false, false, false, true },
                    { new Guid("1e1125b2-639d-4069-937c-f3b49e599bdd"), true, false, false, true },
                    { new Guid("1e755de5-0532-4834-991c-d6d35793b58c"), false, false, false, true },
                    { new Guid("20285f4a-1ca0-4c1b-96ea-651cad573357"), false, false, false, true },
                    { new Guid("2574874c-abb1-40c9-83ee-7745b4e61e41"), false, false, false, false },
                    { new Guid("26f9cd13-e2a1-4447-ae89-9a7d51adcdba"), false, false, false, false },
                    { new Guid("2708b88a-a0ab-4358-baca-b9108a7ecdf5"), false, false, true, true },
                    { new Guid("27e739fa-1a72-4971-a85e-21a568e32435"), false, true, false, false },
                    { new Guid("2efc4a6c-c4b1-452f-aa8a-96faf29db414"), false, false, false, false },
                    { new Guid("3100c226-9d93-4f99-a883-a4593886d1e7"), false, false, true, false },
                    { new Guid("37ee2938-6c9e-4a8a-8baf-cf012bd4872b"), false, false, true, false },
                    { new Guid("39513620-8006-46ea-b5d7-bd42c238a9c9"), false, false, true, false },
                    { new Guid("3ac05134-b1c1-4734-849d-76559018649a"), false, false, false, true },
                    { new Guid("3b70981f-c60a-4af4-8a88-d5a7a7449472"), false, false, true, false },
                    { new Guid("3ccfce1a-3fbf-4812-a89c-cde8027e6e7e"), false, false, true, false },
                    { new Guid("3de3f7bd-5869-488c-9454-fcc40a1558b5"), false, false, false, false },
                    { new Guid("3e99fe4c-c9d4-4354-8944-311a0da24fdb"), false, true, false, true },
                    { new Guid("3ff30d8a-1d70-493c-ba4d-a87cea6ef7c5"), false, true, false, false },
                    { new Guid("41c13004-c5ec-4d32-920f-4d2945dc3cd6"), false, true, true, false },
                    { new Guid("441505bf-b2d8-421c-8e07-679133a4a352"), false, false, false, false },
                    { new Guid("4667e5f0-e317-4055-856b-700886f17626"), false, false, false, false },
                    { new Guid("46d9f511-ea71-4552-a072-5a84bf6b1ad3"), false, false, false, false },
                    { new Guid("4cf48994-46d1-43bb-b1a4-42fd43de96df"), false, false, false, false },
                    { new Guid("4da2da52-cb8b-4ec8-be25-880470dd1551"), false, false, true, false },
                    { new Guid("4f632d81-2639-436a-a60a-616a04e01421"), false, false, true, false },
                    { new Guid("4fa43eae-1355-4255-b305-2fad4f4560dc"), false, false, false, true },
                    { new Guid("5001e974-e693-49cc-a78d-8b4e78352ded"), false, false, false, false },
                    { new Guid("533f1369-d29c-4799-87cb-087d3aeae718"), false, false, true, false },
                    { new Guid("53ec0356-b063-47a2-ad6f-8b3452a5fb01"), false, false, false, false },
                    { new Guid("5dedd314-a68c-4bd9-a459-63135bf403d7"), false, false, false, false },
                    { new Guid("5e578f88-4238-4351-9fe3-695a38353fd9"), false, true, false, false },
                    { new Guid("62774a3d-2583-4697-9e3e-6fd59a81af15"), false, false, false, false },
                    { new Guid("63e165ac-06ed-432f-ba9f-cb52b732d4ed"), false, false, false, false },
                    { new Guid("663a2e07-5b81-47fa-802c-0dbedf8e0295"), false, false, false, false },
                    { new Guid("669c8f67-7a81-4afa-8640-a70c17e667ab"), false, false, true, false },
                    { new Guid("670ad33a-bb1a-4e68-a826-270bd11894dd"), false, false, true, false },
                    { new Guid("6747d693-00f8-42b8-afe7-fc6bbe093045"), false, false, false, true },
                    { new Guid("6995a437-1af4-45cb-b579-0e47604adfce"), false, false, true, true },
                    { new Guid("6995c92a-311c-48b5-b983-e68d09b701eb"), false, true, true, false },
                    { new Guid("6b4a9c91-a0fe-41db-a504-ca6569d39f68"), false, true, false, false },
                    { new Guid("6dfff323-e4ec-48ad-8563-c283a9d0e9fb"), false, false, false, false },
                    { new Guid("6f9350a0-c47f-4579-8bfa-ed2533fb9d19"), false, false, false, true },
                    { new Guid("6fd4fe33-2abb-46f8-9e2c-dfe306fa57f8"), false, false, false, false },
                    { new Guid("776002bf-c810-40e6-a811-b501136195cd"), false, false, true, false },
                    { new Guid("7927e736-e5bb-42c1-b9e1-3603aa1aea6c"), false, true, false, false },
                    { new Guid("7a68a9e9-de85-4b0e-8927-039867a34f9a"), false, false, false, true },
                    { new Guid("804dc86f-cc5c-4590-b6d4-dd46e60293e8"), false, true, false, false },
                    { new Guid("81288061-e254-4522-854b-dd1ed92a595d"), false, false, true, false },
                    { new Guid("88a854c6-2455-4446-b568-97d6724c065b"), false, true, true, false },
                    { new Guid("8bd090a4-e7b1-4f00-9222-dafdc9e828ff"), false, false, false, false },
                    { new Guid("8cdc7b55-d18c-414a-b7ca-12de2869ff9f"), false, false, true, false },
                    { new Guid("8db1d91d-89c9-447c-a39c-86f208cdd288"), false, false, true, false },
                    { new Guid("9ad334e1-784a-4229-b1ba-161b652fbc94"), false, false, false, false },
                    { new Guid("9bb3e152-bb6d-4b4f-afb8-adb8e7be5626"), false, false, true, false },
                    { new Guid("a05fac61-bd08-46b8-a88b-676a7dd020f7"), false, false, false, true },
                    { new Guid("a06a8ec0-8d77-4549-ab96-82e2f545a0b6"), false, false, true, false },
                    { new Guid("a39b1f79-26a2-4c6e-a649-fda73b69f994"), false, false, true, true },
                    { new Guid("a4f3b11c-c45f-4d23-978b-200ade902e90"), false, false, false, false },
                    { new Guid("a6fa09bc-d822-4d73-a261-19d73364aab9"), false, false, false, false },
                    { new Guid("b258f8ee-8118-4e5a-b0b9-2d42b181da73"), false, true, false, true },
                    { new Guid("b2db4b69-d922-4ec3-8991-1db12ef84aa0"), false, true, false, false },
                    { new Guid("b81c2f99-6dde-41d2-a940-6a261af8a03a"), false, false, false, false },
                    { new Guid("b81ed8ed-938a-4309-81fd-cca9dac6534a"), false, false, true, true },
                    { new Guid("c0573f21-c5be-4648-8907-c529a921748d"), false, false, true, false },
                    { new Guid("c3732540-7fc8-435b-97b0-30f033c9c23d"), false, false, false, false },
                    { new Guid("c772b7db-9a40-4ccf-a6a2-920ece594c65"), false, false, false, true },
                    { new Guid("c8ef223a-a8cd-4acc-8eaf-2e08c1e6a76e"), false, false, true, false },
                    { new Guid("cbd0a31f-6bb6-4701-b752-2af009570ec9"), false, false, false, false },
                    { new Guid("ccd681d3-89ce-44c9-955b-29b477041988"), false, false, true, true },
                    { new Guid("d2a95c02-0386-4264-9696-20d496075715"), false, true, true, false },
                    { new Guid("d4486a21-7f32-4dc3-b2fa-03498f880075"), false, false, false, false },
                    { new Guid("d45ea3f4-3bc9-498e-889f-82dcf968bce9"), false, false, false, false },
                    { new Guid("d7852dda-7cec-4e14-a9bb-5c86d7b5b3c3"), false, false, false, false },
                    { new Guid("d95ac8e6-1e8d-47d6-991d-7956470feb2a"), false, false, false, false },
                    { new Guid("dc0b5186-b7ef-43dd-ba95-c3d16d0f9d47"), false, false, true, false },
                    { new Guid("dcbb9a2e-e021-4268-ab08-bf04914f1ff1"), false, false, true, false },
                    { new Guid("df187816-efe3-4894-86d1-a74d2858a50c"), false, false, true, false },
                    { new Guid("df29860a-7a1b-424d-bce1-e884b8955ebe"), false, false, false, false },
                    { new Guid("dff221dd-d92a-4780-b09a-2d4bb02ef8dc"), false, false, false, false },
                    { new Guid("e15f9a3f-bb9b-4cc8-9b73-81b92d84cabb"), false, false, false, false },
                    { new Guid("e59b1421-26d3-4f93-a9aa-871160869bc5"), false, false, false, false },
                    { new Guid("e61b5b75-242c-4fcd-ac51-3c8846cc85e9"), false, false, false, true },
                    { new Guid("e6c517e3-1bbe-4723-aa4e-49e1c873e8be"), false, false, false, false },
                    { new Guid("e6f4c8f0-43fd-4b45-990e-9e4937439947"), false, false, false, false },
                    { new Guid("e948ecd9-01c8-42eb-9eb1-e8d53aecc629"), false, false, true, false },
                    { new Guid("e9a8841c-7340-4697-925a-d94d9f0cc3c1"), false, false, false, false },
                    { new Guid("f0b83541-1365-4839-88c1-df5ae112cb05"), false, false, false, false },
                    { new Guid("f29d9194-3e5d-48c0-be66-681938ff45c2"), false, false, false, false },
                    { new Guid("f351bc0b-6573-4dca-be68-6d50f0a59b40"), false, false, true, false },
                    { new Guid("f586d4ee-9646-480f-850b-785ec7b870e3"), false, false, false, false },
                    { new Guid("facc6fd2-cac5-473b-be29-9ebd328a74ad"), false, false, false, false },
                    { new Guid("fdc9f9a5-56fd-42c8-8d44-8e45e975288b"), false, false, false, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Passes_UserId",
                table: "Passes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Proofs_PassId",
                table: "Proofs",
                column: "PassId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BannedTokens");

            migrationBuilder.DropTable(
                name: "Proofs");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Passes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
