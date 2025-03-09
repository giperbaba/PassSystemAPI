using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PassSystemTD.Migrations
{
    /// <inheritdoc />
    public partial class FixedRoleAgain3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Role_Users_Id",
                table: "Role");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("001caa23-7d2e-4476-849b-a4c6428ad26c"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("02dddc9b-88df-4d82-899f-41c3205b96dd"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("0404b3a0-e920-4f29-a0e7-e48e2d38575f"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("062d546a-3eb0-4e6c-9c1e-fa1f8f2f07bb"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("0aed60da-6cc0-4c44-a0b2-b4d7b248078c"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("105ec760-bb4d-4b96-8696-5a437a028d10"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("122a99e2-9216-4e7e-893c-26e358d4e7ba"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("124c74c3-018b-4e63-bd9e-070a06cf087b"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("176c23d3-1b03-4fcc-b1fa-a22b3e60b455"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("1b63f99d-6385-4faf-a2e2-006102c61549"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("1b67c649-4f90-464d-8adb-b57f58a1d6f1"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("20473cfe-6186-484c-b975-75c895c43dac"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("233cf2bd-2a8d-4dee-baec-6a6ae0016c35"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("23e79af6-ab1d-4870-aaeb-4b24350cda3c"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("250aa675-97de-4740-8493-99e59e7f4f76"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("2f3c1f5d-5f89-4086-b1ca-e1cd0e92cae4"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("2f4bdd6f-a00a-4827-9c09-2d70531dd958"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("3019593a-8242-4b46-ac24-29acc6387ca3"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("33516248-0a4a-4062-963c-ddb1400766e8"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("348f2454-29fe-4074-8562-9b5e815b1866"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("36bd800f-b289-4996-9b17-fbf422747dfc"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("3aa703d6-a480-487a-9d98-f048f0135a40"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("3bcf4929-0652-46a4-a682-ddc5da6df338"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("3cf3ed25-ba6c-4241-bfec-7728f6650e28"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("420b8d7d-9473-4bd7-929d-8cbd02f7baab"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("447d0a21-3aae-45f6-a5d4-5f43cfadc888"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("44e57b57-2852-4522-8554-a009f449ad0c"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("45eabb94-a20b-4493-b84b-77cb89ea5a07"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("4821136e-d778-4a09-9840-079aa8643a06"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("49bd9d52-73e9-43e0-bf01-3f155c4989a3"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("53181e47-eb35-4989-b562-6f057f3e09be"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("53d27349-23f6-44d4-8f6a-417c50d9e3d3"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("5a1ce0eb-2691-4349-9887-786f63f28185"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("5bd40dcd-9f32-4186-8e93-53a73cd73298"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("5e20b2ff-e3c4-447e-9367-dfc7d66c00f4"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("658e2a35-d866-415e-8ca8-1c7acacbc576"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("673a1f71-b6ce-4267-93ce-346d5d189093"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("6a52f2a2-1101-43b6-846e-801971f24dfe"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("6b959e7b-ac95-4987-af9e-59974b6db6fb"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("6d0a6a72-487e-4c17-85b4-5f2a82252ea7"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("6dff57dd-af3f-4b68-8207-bfc9c5f49ad2"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("71399692-0547-46ab-92d4-ccb7b36661a9"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("71fd97e6-76a4-4cd4-82e3-6ea9f03e0a53"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("74b58697-0ff8-46a4-9e42-7f22eea31331"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("74d7af56-258a-427b-966d-def5dd9b1fd2"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("75052669-63ee-4476-a130-76bcc888b0f3"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("762faa5c-14d6-4482-b188-0b7d1d4c5e0f"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("7732c733-d67b-4bac-8779-d409e743e338"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("7a025f28-7e82-4315-87c8-ce868a051f01"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("7b60af1f-ee48-4ee0-9589-3e91dd89dbfe"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("7d02d1ad-7c51-4edb-b70c-6585283e22e8"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("7d925875-90e8-4cf4-b363-519e083dfa85"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("82a2bc20-bb3a-410e-9186-738c374b52c5"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("844e9f8c-6439-4007-988b-3879ba374ed6"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("84bb8797-a710-489e-bea2-a9977218506e"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("85307d58-453a-4bbc-bb5d-2e1f568959f4"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("88f5f733-fc9d-4f24-af03-7be07739e880"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("8ac09b52-4c1f-4ac6-a794-e3a9d98ebd23"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("8bc2ca6a-ad75-42fb-814f-f8974e28684f"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("8d5addec-fbe4-462b-be3b-6f6cbb885e99"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("8f64e036-b311-4ea3-9ac1-e97338c7452d"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("9515dfe0-92e5-4d31-bed2-1e30f3a63e0b"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("95bb8593-37ab-4467-bf2b-e4c9749aa64d"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("9b98d26f-fd26-41cf-817a-3ebf46aac29c"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("a1d6cda1-a504-4413-8840-5f57d05582ba"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("a4b505b3-d661-4ab4-a084-0050a4dcc7de"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("a9a4614e-f824-4c98-bb78-3ed2ca386f69"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("b02100d8-0eee-4e5e-89b1-1ad9f5c362e8"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("b406d255-6fb7-46e9-b9cf-671639cad48f"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("b4ab34a2-d3f1-4015-a046-9ff2d19f40eb"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("b536ff63-308e-4d0a-a8c4-da7a22882819"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("b5ae7c19-fc35-4fe3-89e0-b38c0f5f7b35"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("b62a1125-3a23-45f8-998a-3174de08f0d2"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("ba5fcbdf-ccd3-43ac-a4d2-8942e1c6054d"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("bae48760-78f6-40f4-9d22-a41ed3434a26"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("bcddad32-a1a2-4e7b-8ebc-23e4afae7b8e"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("c0c4a00b-84f0-4257-b8e4-a27d913ccb36"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("c182d72c-c478-450f-9f50-83a748ab7947"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("c4834789-b269-4405-af6a-c23fe65c0572"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("c7561edc-4363-4aa9-8b51-55984d381836"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("cb63da90-529c-4103-8e49-50599e0a0d1e"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("ce83cdb8-d31e-4be8-9822-de04f61f8557"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("cee9c3a9-fb5d-41df-95a2-848c55334b0e"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("d1bf0218-2069-4def-8d1a-329b69ca6951"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("d3b873a0-168f-44ac-a7ae-ce3b0f0b4aa4"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("d534ae92-f3a6-44d1-875b-4852e5b84bf4"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("d808b07b-c541-464d-a0e2-41d959e6c1ca"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("d8e9d61b-deac-4607-b18e-10c07b2ef88d"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("ddae715f-98e1-42c3-8df3-07b2151029f2"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("e03d5988-77dc-4c28-9d19-1e1634d7fd15"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("e06b95d0-b2c1-4c07-920d-21bf3ad21b4c"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("e4440fa8-e56e-4cda-ad5f-cd04b96bbe67"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("e9c5ead3-9ecb-4b31-a941-aaa71918aabd"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("eb44f048-8604-40fc-abde-c0353238ea64"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("f0186f16-0494-447e-9504-d5e3c81731d1"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("f3a28da5-0106-4a55-9a6c-3836237686b6"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("f3edd59e-a94b-4c54-aff3-207c9122fe50"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("f6daa30a-1e61-45a4-a5b7-bfedd11c3734"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("fb2cf406-f302-430a-aa2c-672135b1db5a"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("fb2f2888-1e9c-4521-8a29-ec4efde60b33"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("001caa23-7d2e-4476-849b-a4c6428ad26c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("02dddc9b-88df-4d82-899f-41c3205b96dd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0404b3a0-e920-4f29-a0e7-e48e2d38575f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("062d546a-3eb0-4e6c-9c1e-fa1f8f2f07bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0aed60da-6cc0-4c44-a0b2-b4d7b248078c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("105ec760-bb4d-4b96-8696-5a437a028d10"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("122a99e2-9216-4e7e-893c-26e358d4e7ba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("124c74c3-018b-4e63-bd9e-070a06cf087b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("176c23d3-1b03-4fcc-b1fa-a22b3e60b455"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1b63f99d-6385-4faf-a2e2-006102c61549"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1b67c649-4f90-464d-8adb-b57f58a1d6f1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("20473cfe-6186-484c-b975-75c895c43dac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("233cf2bd-2a8d-4dee-baec-6a6ae0016c35"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("23e79af6-ab1d-4870-aaeb-4b24350cda3c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("250aa675-97de-4740-8493-99e59e7f4f76"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2f3c1f5d-5f89-4086-b1ca-e1cd0e92cae4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2f4bdd6f-a00a-4827-9c09-2d70531dd958"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3019593a-8242-4b46-ac24-29acc6387ca3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33516248-0a4a-4062-963c-ddb1400766e8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("348f2454-29fe-4074-8562-9b5e815b1866"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("36bd800f-b289-4996-9b17-fbf422747dfc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3aa703d6-a480-487a-9d98-f048f0135a40"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3bcf4929-0652-46a4-a682-ddc5da6df338"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3cf3ed25-ba6c-4241-bfec-7728f6650e28"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("420b8d7d-9473-4bd7-929d-8cbd02f7baab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("447d0a21-3aae-45f6-a5d4-5f43cfadc888"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44e57b57-2852-4522-8554-a009f449ad0c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("45eabb94-a20b-4493-b84b-77cb89ea5a07"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4821136e-d778-4a09-9840-079aa8643a06"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("49bd9d52-73e9-43e0-bf01-3f155c4989a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("53181e47-eb35-4989-b562-6f057f3e09be"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("53d27349-23f6-44d4-8f6a-417c50d9e3d3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5a1ce0eb-2691-4349-9887-786f63f28185"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5bd40dcd-9f32-4186-8e93-53a73cd73298"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5e20b2ff-e3c4-447e-9367-dfc7d66c00f4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("658e2a35-d866-415e-8ca8-1c7acacbc576"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("673a1f71-b6ce-4267-93ce-346d5d189093"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a52f2a2-1101-43b6-846e-801971f24dfe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6b959e7b-ac95-4987-af9e-59974b6db6fb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6d0a6a72-487e-4c17-85b4-5f2a82252ea7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6dff57dd-af3f-4b68-8207-bfc9c5f49ad2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("71399692-0547-46ab-92d4-ccb7b36661a9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("71fd97e6-76a4-4cd4-82e3-6ea9f03e0a53"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("74b58697-0ff8-46a4-9e42-7f22eea31331"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("74d7af56-258a-427b-966d-def5dd9b1fd2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("75052669-63ee-4476-a130-76bcc888b0f3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("762faa5c-14d6-4482-b188-0b7d1d4c5e0f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7732c733-d67b-4bac-8779-d409e743e338"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7a025f28-7e82-4315-87c8-ce868a051f01"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7b60af1f-ee48-4ee0-9589-3e91dd89dbfe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7d02d1ad-7c51-4edb-b70c-6585283e22e8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7d925875-90e8-4cf4-b363-519e083dfa85"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("82a2bc20-bb3a-410e-9186-738c374b52c5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("844e9f8c-6439-4007-988b-3879ba374ed6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("84bb8797-a710-489e-bea2-a9977218506e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("85307d58-453a-4bbc-bb5d-2e1f568959f4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("88f5f733-fc9d-4f24-af03-7be07739e880"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8ac09b52-4c1f-4ac6-a794-e3a9d98ebd23"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8bc2ca6a-ad75-42fb-814f-f8974e28684f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8d5addec-fbe4-462b-be3b-6f6cbb885e99"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f64e036-b311-4ea3-9ac1-e97338c7452d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9515dfe0-92e5-4d31-bed2-1e30f3a63e0b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("95bb8593-37ab-4467-bf2b-e4c9749aa64d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b98d26f-fd26-41cf-817a-3ebf46aac29c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a1d6cda1-a504-4413-8840-5f57d05582ba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a4b505b3-d661-4ab4-a084-0050a4dcc7de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a9a4614e-f824-4c98-bb78-3ed2ca386f69"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b02100d8-0eee-4e5e-89b1-1ad9f5c362e8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b406d255-6fb7-46e9-b9cf-671639cad48f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b4ab34a2-d3f1-4015-a046-9ff2d19f40eb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b536ff63-308e-4d0a-a8c4-da7a22882819"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b5ae7c19-fc35-4fe3-89e0-b38c0f5f7b35"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b62a1125-3a23-45f8-998a-3174de08f0d2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ba5fcbdf-ccd3-43ac-a4d2-8942e1c6054d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bae48760-78f6-40f4-9d22-a41ed3434a26"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bcddad32-a1a2-4e7b-8ebc-23e4afae7b8e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c0c4a00b-84f0-4257-b8e4-a27d913ccb36"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c182d72c-c478-450f-9f50-83a748ab7947"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4834789-b269-4405-af6a-c23fe65c0572"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c7561edc-4363-4aa9-8b51-55984d381836"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cb63da90-529c-4103-8e49-50599e0a0d1e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ce83cdb8-d31e-4be8-9822-de04f61f8557"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cee9c3a9-fb5d-41df-95a2-848c55334b0e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d1bf0218-2069-4def-8d1a-329b69ca6951"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d3b873a0-168f-44ac-a7ae-ce3b0f0b4aa4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d534ae92-f3a6-44d1-875b-4852e5b84bf4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d808b07b-c541-464d-a0e2-41d959e6c1ca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8e9d61b-deac-4607-b18e-10c07b2ef88d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ddae715f-98e1-42c3-8df3-07b2151029f2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e03d5988-77dc-4c28-9d19-1e1634d7fd15"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e06b95d0-b2c1-4c07-920d-21bf3ad21b4c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e4440fa8-e56e-4cda-ad5f-cd04b96bbe67"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e9c5ead3-9ecb-4b31-a941-aaa71918aabd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eb44f048-8604-40fc-abde-c0353238ea64"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0186f16-0494-447e-9504-d5e3c81731d1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f3a28da5-0106-4a55-9a6c-3836237686b6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f3edd59e-a94b-4c54-aff3-207c9122fe50"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f6daa30a-1e61-45a4-a5b7-bfedd11c3734"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fb2cf406-f302-430a-aa2c-672135b1db5a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fb2f2888-1e9c-4521-8a29-ec4efde60b33"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "Email", "Gender", "Name", "Password", "RoleId" },
                values: new object[,]
                {
                    { new Guid("0641a5ea-d749-4991-a982-330252578fae"), null, "user16@example.com", 0, "User16", "$2a$11$n0JtkeCcHU5/NZiC2rNzVeqXmycz8t7cHQC3XKxjUqi9rhDNjMViG", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("0abe5794-e3d6-4950-a75e-3d83ed9f022b"), null, "user75@example.com", 1, "User75", "$2a$11$eSY9E9KX6m.laUW9UglyHOfcKNUvuO5eVirpZxUVACOFe48YZQmQG", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("0c77ee4c-b8d6-454e-978e-be2257dd2e3c"), null, "user60@example.com", 0, "User60", "$2a$11$rzsazdFKBIsrSTeTZNcfR.g1IuMO8zNmXO9y2DCpiF.HryWsc66zW", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("0f2c23ef-8e11-4f85-85ba-78ccd150d9bb"), null, "user62@example.com", 0, "User62", "$2a$11$hMI1tkyLgyMxGKiMmVOro.jGLn1ZNoRmopZnCqEO979DhOZm6XU3m", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("0fb0c78d-3129-4405-b10f-739deea74b39"), null, "user98@example.com", 0, "User98", "$2a$11$AzSLs7U/fN/FnQfr8N8Y1usenh9BDMsIa0oFSsKU0ZB5zQLLqrVH2", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("10148a74-60c6-4888-9f69-70a74945d394"), null, "user82@example.com", 0, "User82", "$2a$11$zjXQ4nXdokomUgYrP6.jsuD1IBcq/YKfi7UBakHERWC9IJJn6.nIO", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("145b1d2f-1da3-4bec-a978-539a332c1649"), null, "user57@example.com", 1, "User57", "$2a$11$CfxXkWoU.jGEuJINiY/1ze57EY1kBRlIjhk.e7Gi2p1.iHi/xPWVS", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("1b271e5d-f143-433c-9909-18304784c0dc"), null, "user11@example.com", 1, "User11", "$2a$11$VCq7dtpX21E4.bK7mfRHUuc/YxYWX0JaF06wQozsWj8zRGYfWeTZi", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("1e67b20a-c523-4178-bdf5-16d452781b27"), null, "user58@example.com", 0, "User58", "$2a$11$JobeA36CKGL/TUk4DGQmd.OOuPetG3RgPaZnRSmBrk4rCRpvLQOkW", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("1f50e98b-1acd-432c-8d6c-49e5f94ec654"), null, "user51@example.com", 1, "User51", "$2a$11$TmKHi6zc.HoyXs6p0TcRFuQYqyEQvhzx2LKu0xoNT52KT4ggCN4me", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2027db61-452c-4bf5-8f34-493c93ddf9bf"), null, "user1@example.com", 1, "User1", "$2a$11$27o3kFYVIv5WqWd9mD/07OzEeY8p2PLqy3eF7M7DWXZfMeK3aQiii", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("21f9b2cf-b6ef-4d11-a0ba-818d26d7a006"), null, "user33@example.com", 1, "User33", "$2a$11$BhSw19mPF9KurX.etIdjc.TZAr9TOhhp6Rx5aAaSaC.VXofiozfxe", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2215e8fb-a6f5-4b37-8b50-7a6b02d581d6"), null, "user39@example.com", 1, "User39", "$2a$11$w/Ho44C9sA/bCsacEmOqpuTQiBkeLR/8zGhpOidskM7KpuBYNAvdO", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2292e013-8588-4fac-9676-8582b686d631"), null, "user88@example.com", 0, "User88", "$2a$11$q5rOcKveMQOlN7ZIheGnpO9NmTe9XQmU16rLX10I9sdCXU8tSwjUS", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2471054b-a45e-44fd-86d9-2af2f6345793"), null, "user59@example.com", 1, "User59", "$2a$11$eBqhDvbOscBvSmZC2jiUj.mHc8nELteGhNo5fchdp3B3awlGZ4Dxu", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2563db6f-4c4e-4031-b41a-850a1b243181"), null, "user21@example.com", 1, "User21", "$2a$11$wxfeUo7Hd5SW2J3.CfqVGuEtNqfr9PlEu.8eQ/1Qct9ao6ohqs9Ea", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("28223e42-61a3-4d19-a48a-46296a43de79"), null, "user49@example.com", 1, "User49", "$2a$11$95dOPgjOOqLek2NDVK.3ceefLIFNKMyhfu6Gbo8z6QxCXII/Q6e6C", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2c4dd255-2a45-45f8-ae1f-fc8851d3782a"), null, "user35@example.com", 1, "User35", "$2a$11$mavYOZ0bc4TU3OX/PZWfTuOhMTMENPNFAQloTGlD8KhAxRKmEHvDG", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2d3ec0d3-130b-4bd7-8202-f57387412d69"), null, "user56@example.com", 0, "User56", "$2a$11$a11Ceo73UjI0V4Nensy2ROorJljVMnQ.2.92u9gbRNwQdXQm36.oO", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2e89e813-5a6a-41c3-8893-190a31ef8bd5"), null, "user55@example.com", 1, "User55", "$2a$11$mcDCKzJZa2Xbhi0hthnPSeImX1bqyfQweLpmWqfEIoHkpcsvGMERC", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("30912a18-6188-4bd7-b266-1bc5a56e0e06"), null, "user85@example.com", 1, "User85", "$2a$11$SdoZ2VYT6rBJn1B4PT/zV.HodVz2pfWc2/K/pt4dy/L.Q7FGMdQUC", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("30e1d0f3-ccae-4785-ae51-52e6c994aacd"), null, "user77@example.com", 1, "User77", "$2a$11$J0/hCe1wpr40thQBicIUjec81Zh8NgW9bnWg8VoJMxh8MccZjZfca", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("33b3d7ed-c116-4351-ad2e-ae1b6bc1cd95"), null, "user14@example.com", 0, "User14", "$2a$11$pfy7R1n0/zgXY44nptpxve5Vde9RMZ2jLOnxfK/iQ8nMtjL0d1bkO", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("3bdc1960-13b5-42d4-8618-0c2e52d72721"), null, "user6@example.com", 0, "User6", "$2a$11$i0piMhHWgKqVDYvz96J3kOeYZAoBcoVKkQ1.PIG1PTxs19PtcR.oG", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("3dfce0b1-7d61-47ff-9053-1b18a3a9a69a"), null, "user61@example.com", 1, "User61", "$2a$11$E8tpArTCNbajz/6JFBdnae9k9Cs3LrZXYRk9ycPTXuaDBqY0jDpnG", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("3e546a14-ccb5-4e75-92f5-c1f3614953a5"), null, "user70@example.com", 0, "User70", "$2a$11$PCri6GqAC6xTglnlbipUBez1Z3RL7pvFMAOc0rvryjYmb2bhyB5Fa", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("3f0f7602-7055-4a5d-8aa7-a3d25c7d6ede"), null, "user30@example.com", 0, "User30", "$2a$11$I4hcWCM1tBBl5dychhrs6eziD7tiUbzPh6p5iu6D1vIfVpkGYfz0q", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4506f837-d214-48bb-8a71-5faea5494c83"), null, "user63@example.com", 1, "User63", "$2a$11$4Q0irolbqBO5qiABwQh8qOR9j8QUGxPITS/RJPVrRHjXCTelvTRd6", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("480bf0d9-39d6-4fd3-9b1e-ad138aeb3483"), null, "user29@example.com", 1, "User29", "$2a$11$FziTeKe4hlqFHcakJwnNf.X.2sjeBTvJVUckUAymQ1qIyWgW8dhoe", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("49a9aae9-2b91-4812-a7d2-c96d7a2cb973"), null, "user41@example.com", 1, "User41", "$2a$11$wCbgMm2IpanoP3kT9owH/OrhflsGEtADFmjePxoNhMI0VdYDBRg1W", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4c682287-c7d1-49bf-8baf-012590d02fff"), null, "user86@example.com", 0, "User86", "$2a$11$uUnruLYJm.Cp3weSH7PKCuUrhSYV6H0MqWyH2tlkFO58Cf0yCNAse", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4e37bbbb-642e-43f2-83bf-2e70402016a1"), null, "user83@example.com", 1, "User83", "$2a$11$wGuLASFkEnv7w7IpCuwHheX2Bf8MdMgaJ7i1WlJFDXx73raTq7ax6", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4efa3c17-9aed-4182-9bf6-1e9dce436d13"), null, "user84@example.com", 0, "User84", "$2a$11$/Mz3tnIzOh2adJdSceTIPu1TyG.F729JhjTV2Bk2U0sCYUs4BoJRm", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("50d128ec-ca48-44f3-9248-0d00c4a8cb6c"), null, "user92@example.com", 0, "User92", "$2a$11$DZuP8h579dQhcWkDj5e8SufQHvpuFCdiLFURdL48DI34ozcf3dBeG", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("5144ae96-d3bb-4199-a7a0-342774f16bf6"), null, "user23@example.com", 1, "User23", "$2a$11$Tp37Uf7Ebl7OJpaChZGMoeq2.dsZtx7FpltjJ6caJiC3kfeqgmVd6", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("5155113f-466d-4f00-93b8-e75b6c8f7189"), null, "user12@example.com", 0, "User12", "$2a$11$IVHp0G4vrsTZ5X099UbfcOOMDoX6olRiMnzy151zL9GEhEzT8J462", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("5312113a-ce17-476f-bf87-5e3a861027c2"), null, "user65@example.com", 1, "User65", "$2a$11$vICdYXZh4WJ.ncHXK8E3Oeckh1Ik2UoP4IyA4XKZuo0JaO5B7Szdu", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("57ef23b1-38f3-41fb-9bf0-c5470eb193a1"), null, "user90@example.com", 0, "User90", "$2a$11$TRG5poPl2L4HDaX3.PaZM.nlhw1nlt39v1IIV552l4dbFO02CUeae", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("5d1cc15c-b3e1-413b-9314-7933a5bed49b"), null, "user10@example.com", 0, "User10", "$2a$11$WbbBvVTApsKo/g/YNzHaYe0.b1gW3E2Soa60JJEm3TIA.VbxqI18G", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("62d062ea-4100-4138-bd9f-6e7a1fcf9dd8"), null, "user26@example.com", 0, "User26", "$2a$11$/tOid/Zg3hPWKjpsAPgNGemVfsdggWT36gvIlLaj2kwaQmScN2GEO", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("66d1eafb-4e91-4d1b-a102-9ccbcba4253a"), null, "user24@example.com", 0, "User24", "$2a$11$JXp3spXk3EcRIiQvkz21FOQWDFGVrWxnE/WqZdn6XSaEQZmSpYVwC", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("68aa8b00-622e-44fc-9f98-25b3c9c23f34"), null, "user27@example.com", 1, "User27", "$2a$11$xoRoWc1in0GUP1wdUsD2BOxrUd9rYp4ta1yP8QFkSMohFiRB4txMO", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("69af8236-db70-4c6a-b7f7-e4625e779313"), null, "user2@example.com", 0, "User2", "$2a$11$ClsYGWkrPGks.hes2AzNa.G8dUtpQ/mS35.0YYE2p.Aej2LQWVgiy", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("6bbdefc6-358d-4a57-9fea-4ac4d31cf0df"), null, "user45@example.com", 1, "User45", "$2a$11$u/X4fj3mZF0ieAG125QLs.06p61Y2UUb4q5CI2SVr6HHQZHoijlR2", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("6f77416f-8c2e-455b-82dc-346345f1cc66"), null, "user87@example.com", 1, "User87", "$2a$11$SNml2GD2lrAqudnlvzZ9penSwNMP5vLUbrjBoVMJZFLNNsVmczj4u", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7263f1f1-a731-40e0-a94a-e96eab6424a6"), null, "user37@example.com", 1, "User37", "$2a$11$rOZ9U8YAEtrA2Fxy3QCbSe9KPTCXy8BLs8NqtS71WuLMaYenhg3XC", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("731fb401-e0cd-4aee-bf79-7a3fc0e5f69d"), null, "user80@example.com", 0, "User80", "$2a$11$VLvQWsIyYoAjUZmRFYr2DusVms.R1a2S8OCErTyMslpo.xWEfp5v.", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("740a0023-5020-430b-abf7-39b8b24a398e"), null, "user47@example.com", 1, "User47", "$2a$11$npYQwB/9ZwA3mEInFdb9OO0FoTbjInIhTeS9hix8vgf2W4HMWzvoS", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7491c501-478a-4aeb-ae00-17ac630e1314"), null, "user22@example.com", 0, "User22", "$2a$11$67Nxxk0rvt6f8F5HXlElAuikDQPQdfPeEbaMnTunRxqrMcZqQfvdS", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7897a73e-7546-498d-bde6-4f0a8abdd24d"), null, "user66@example.com", 0, "User66", "$2a$11$W1hrW3dKYFeNQa6F13.rJuCU5lzkDFTk356D4qe4ClpYZ7pJNOnge", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("78e58e86-5e6c-4c00-add1-739b665768cc"), null, "user52@example.com", 0, "User52", "$2a$11$pe8/nM1f2YeIHttNzRgjcubxAO8kQttRvQvS3YusfqPj57XiRW/tC", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7bf90894-1d33-4b21-aa74-b88e6c7c244d"), null, "user3@example.com", 1, "User3", "$2a$11$ulgN2ZWhmFVWVxWtG4nG4eoDiLVvE/VuwQWU7Yn5mASwatoWoJPym", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7e80f554-4aa0-48f7-84ed-64f60ebd8099"), null, "user100@example.com", 0, "User100", "$2a$11$EpnjjI0N5k3puA6hn3Dk9epFPvOD5DPCGmb5jJke/PjXj6VFDR9Ge", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("84c17fb7-3997-4eb9-bcbe-02a606f6ea56"), null, "user53@example.com", 1, "User53", "$2a$11$VGK0o4aJ4R.s7fmilqKSQexnty7/3xyfvUhBryL2I.71B7fdWVNGm", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8533808b-75cb-448c-89a4-666b476c9f2a"), null, "user17@example.com", 1, "User17", "$2a$11$2/9NuPOyZ9J8GRhxs5IsrOMbyosIe8l7sclKZ2dDeqRtOZc93J3Iy", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8554f8f0-8c01-4ea7-9982-d9696e59f5d7"), null, "user74@example.com", 0, "User74", "$2a$11$mYU/M.Mj4i05Xs5/HVyByuLoi5N1oviXU5EutuBhMTN.J5GAR8AEe", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("860c31a6-78c2-4886-941c-be174fd55a89"), null, "user32@example.com", 0, "User32", "$2a$11$94JP16VrKUbw/P4.yLleeupQFnE/5eRANtK34KAJhzd0LN6c/kpD6", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("86a09aca-ead3-4708-916e-38f6f293236d"), null, "user48@example.com", 0, "User48", "$2a$11$TMWkOCEWe5QXinRPLtDMmOyx1duGnff.t9LJd/PKIXjUqkVSQBj.u", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8815dd6f-0311-4e85-b233-985960745df6"), null, "user38@example.com", 0, "User38", "$2a$11$ImQouVnJIQlu7saiYYlz3eoiiKhi8yD9qKPtoP8AV5o9vQaJvr.ym", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("883f74e0-5e1a-4a79-861a-ecb314a07fba"), null, "user34@example.com", 0, "User34", "$2a$11$ui3CKXT6OF0zN6UTli8JbOFrxPbReEbKTGxI99UfriGFr8EikNoPC", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8a6ee593-0716-4ecb-96a5-ecfe1ea596c9"), null, "user72@example.com", 0, "User72", "$2a$11$rif3F0uXzkF3i8yKT838P.eVUz.Q8LQG2OJ5FGCD.Tm8G8Zq7OQOa", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8abb5551-1228-4c96-9300-949f91ec7b33"), null, "user18@example.com", 0, "User18", "$2a$11$hvWsty47B//K6sOXRP97FODPZf3IXu2DmcNh0Fw1PwxIjBF0beQSq", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8b6b979d-a208-4c2e-8815-caa546dee237"), null, "user40@example.com", 0, "User40", "$2a$11$kZUouO5vY1eTV/InpZv1y.IIACuG9nTZqqum7Xc3jBVkUz9y4FTZa", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8c8d2905-6abf-456e-9044-81c184b4d223"), null, "user46@example.com", 0, "User46", "$2a$11$6SrH1UZc/lA3BNi5NjM7DuAx62nZhN61bsh5OwzX1kQnzJbPpeIBS", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("93d265cd-a39f-4cce-b97f-ed5b031eee35"), null, "user54@example.com", 0, "User54", "$2a$11$xnSUN1iv..rpxp25.GVRre.Rb5XcDt0E9VQ6mTDiq/0Bb1E8fjFse", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("992f6210-4e0d-4578-b3c5-e09a02bbdaca"), null, "user96@example.com", 0, "User96", "$2a$11$b.o.0rTon83i4/bvx11U9uIwM/qpYHCsKqrZQ0b58.p1u3wp6eWsC", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("9ac52ade-a530-4447-83c4-dbf15d463f17"), null, "user15@example.com", 1, "User15", "$2a$11$Z5CfPgDd2fXFDdoC.OOlpuxaKYCE2Qwu33LZJivBJv6HNVOe9H5ii", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("9d795ca6-def5-47ee-9a66-9605eabc97ca"), null, "user31@example.com", 1, "User31", "$2a$11$yt69FGU/EPprfaMXSgclyOkP/9HBfpgQgLlb9GvZfKN70Lmb8b0te", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("9e5e4896-b923-4cd9-841c-77fa1fe6537a"), null, "user50@example.com", 0, "User50", "$2a$11$tdQAOI5SqIcefjlTNwawnuvgMVd2KKcDa0ttDXgNPd0sGE9AXa3.C", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("9f33c46b-4abd-4fd9-bc83-7b7f9f74c491"), null, "user36@example.com", 0, "User36", "$2a$11$9p4GGX15DvDZUzHe8z612eFcxKOXhZf9tSs2N33SDOtDcAu7sFnwi", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a13bbaf6-66a3-4087-b7f4-9b5c7e472bb2"), null, "user91@example.com", 1, "User91", "$2a$11$HRZEqbcMVwUpI41XuNMRmOCU/atDcd.45ayv.31FHKlM2Mpx7kXSG", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a329d081-971e-43aa-a388-9683e85697e6"), null, "user95@example.com", 1, "User95", "$2a$11$UZLqRd.ooY1JCY2PgA7CPOWufx8Z5vC/8dmBeK.ma.lFmtx4nrfX6", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a41982b7-d58c-42ff-942b-31059e50140a"), null, "user99@example.com", 1, "User99", "$2a$11$7yiRqkRxSghTrteZ71Qe0eStSv8kFIhFxCIYuNA3IX7IQwsx3PKdm", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a521b155-dc28-4c92-bf3d-1ce2b745f892"), null, "user69@example.com", 1, "User69", "$2a$11$l5rn/fhHZFvnEI5gJyIh3Ob7rdIJgwUm/RJSQvd4FZKCsvQXVBdTG", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a5966ef9-31ea-4e17-b5f3-bfcc2920297d"), null, "user64@example.com", 0, "User64", "$2a$11$mB0gfcFZawwU1BZuFqmLQ.vWeACTs15DSn.7N7FOE2IB2vVienPJ2", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a957989e-226f-4bb8-afa2-94e6d40998e9"), null, "user97@example.com", 1, "User97", "$2a$11$Sg9ZLabBcd.o.u6CA8PO6utOLC.CO4UiJZ4emIVOP/cr31BGg7gT6", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b01b7f37-433b-4529-94d0-3644ef9724e9"), null, "user44@example.com", 0, "User44", "$2a$11$JmgohDuadLsdISbhc//Sgu4End4mpIEPkHWrySDIq6Y7oHQGIROGK", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b30cbdab-d85f-441f-8859-e9588cd6527f"), null, "user73@example.com", 1, "User73", "$2a$11$UfE2i47KsuRnXvuuJvj7m.ln8Fg6hLx4LeTm6SngEvgejf.AI8vSW", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b31e5d44-8ed3-479a-b6d6-59f632630ab0"), null, "user13@example.com", 1, "User13", "$2a$11$4QLwa1TbF.0qhjPz8bhu6uW.SxuggEzNqlf06amze2I2SOmjud.CC", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b54be218-f3ed-44f0-a88c-8e3362a2f9a1"), null, "user76@example.com", 0, "User76", "$2a$11$vRDvVTq1xaSz/aKKWmsDq.FaPt2dceFFgFxTLvnXjAVVL8qQR6Nyy", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b9f39656-a26d-45a3-8a09-ee9c162bc11d"), null, "user25@example.com", 1, "User25", "$2a$11$hrhnUhNY3WIyxORL20xeLOxzva99cveQk9OTO3kvb3kVtG3wciFSS", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("bc16147c-3863-483f-ab18-cfbdb91166d8"), null, "user68@example.com", 0, "User68", "$2a$11$ryWx9oRJ18x5GDzTpDcyN.i08.dlht7g.vpMETzef9cmWuI/jcsw6", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c6d64e0a-e373-437f-8fcd-0d83228f7c44"), null, "user28@example.com", 0, "User28", "$2a$11$LmnkravZIwwr6VBvHLKW/ODbxCY..br.nXTW5IDxeFkhfcQK8M8Nu", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("cc196503-7307-4280-a8f7-42bbca4f8c24"), null, "user43@example.com", 1, "User43", "$2a$11$/ohM4EEvESWrJp0WHIGkyeJLOS5vQmtVetb/9zPNfai6fXwzDbHPG", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("cdc515c0-6b42-4494-a936-bbbf0193ee80"), null, "user4@example.com", 0, "User4", "$2a$11$cY9oX.knCCU0GNwSNofit.zIoG7uxkcl/aoO9WrFoWD5RTgeEzo8y", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ce52fca6-72d1-4d97-a529-401a09648b9d"), null, "user71@example.com", 1, "User71", "$2a$11$ceAxm3mZZOwGQQOdk05jKOsy60GjiA9VPRhL5t/VboF1h1YYiso5C", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d5933118-eb16-4391-be5a-d4f726b1bbae"), null, "user9@example.com", 1, "User9", "$2a$11$pQvmV/IhPEB1VI3p9vX0I.r1njI9IEmmlDxZTcR4nVZbOrWF2.LiG", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("da2a8d35-b8b4-4679-b0fb-f33cfe973459"), null, "user78@example.com", 0, "User78", "$2a$11$wNxR0KLHDRhIxnNSN4LjyeVi9sL1IHxdRlexbkBb.SErXsGOvxiJS", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e038d487-a20e-4b00-8777-3730b05a7c67"), null, "user94@example.com", 0, "User94", "$2a$11$IDcZRTYXJFDAwkxWTm5HmehVAHnrvwboWhy7BkdbMp6ByX95609kW", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e4100d6d-dd3a-4a08-9206-fba2e9e9e536"), null, "user67@example.com", 1, "User67", "$2a$11$wo1FVhjefK2dGRXhd/QvS.NDiBnj4F6e30HA/8OWfnvCXN4OPLUcm", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e54eeb7c-ba03-4123-bdb8-3c2bc61211b5"), null, "user19@example.com", 1, "User19", "$2a$11$aXERz8/JIWMrqJLap5w7curZFbK3lIQPJN36Ns/1sl03.qWhAJuOa", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e719a908-f784-42c6-bb49-ee71649a442b"), null, "user8@example.com", 0, "User8", "$2a$11$e3y2ddC2MyZVXPDu0hKvkuZZ0F/Bzl/EGQueUoBT11GAgDY7RMsmG", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e77e4678-de32-42bf-bce4-097956c07c8c"), null, "user20@example.com", 0, "User20", "$2a$11$cKGZBbmEWjtMIJzkehYwzOd4Xl78J2HkeobOpJ5/dvPLrfhlJcLeC", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e83d3398-ad83-468a-96c8-2b071ab4159e"), null, "user7@example.com", 1, "User7", "$2a$11$OheHEewimKJPuCwIDGSaT.jfdeK8i8/Q6lqHApohmeHTH9HfzzICe", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("eb6abea0-0e79-4216-8c29-38d3e0c23d77"), null, "user5@example.com", 1, "User5", "$2a$11$/VbpjgbQNaQPrG0Wq.GtHeUl1tVgouHUE95qLbMcdxcDHlTHFDCnK", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("eda6168b-6515-4b5f-a4ee-6af2a31312f9"), null, "user79@example.com", 1, "User79", "$2a$11$bZMqREhCdjcEpdt8aa9BmupMBUW6N9BZTZln8z1GhAilbp/w/RqBK", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f5a82c47-1dc2-41cd-9546-8c62b5b08045"), null, "user93@example.com", 1, "User93", "$2a$11$4Miv8PD71m6qJcnKB4cYc.xn.M1YH8wdR6nV2d8qY.KEXMEAjExd2", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f75fccc3-92e9-4827-ae42-b6500c968337"), null, "user89@example.com", 1, "User89", "$2a$11$5.WnMtrBwmmt/BvKePg56e.JPXhLzRL7UOkzRVqc0hpXizTtWTMMi", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f97b231c-31da-49a3-90eb-306bef8c72c1"), null, "user81@example.com", 1, "User81", "$2a$11$gslnJKCVLQPh0D876E1ZouMmi39H4ul115Qy.yVCn.Vyy8zhSHfj6", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("fa737043-6a38-4793-a8b8-de4fa410862a"), null, "user42@example.com", 0, "User42", "$2a$11$hWYkzXskCyrqRQbIVFi5U.uHuWBt2x7.XS/NjaGUM4mH8LcZwm7yW", new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "IsAdmin", "IsDean", "IsStudent", "IsTeacher", "UserId" },
                values: new object[,]
                {
                    { new Guid("00bff54c-20b2-403d-a419-f493aa760737"), false, true, false, false, new Guid("0fb0c78d-3129-4405-b10f-739deea74b39") },
                    { new Guid("01522160-a509-4659-aa80-772b0c50d501"), false, false, true, true, new Guid("3f0f7602-7055-4a5d-8aa7-a3d25c7d6ede") },
                    { new Guid("0231cee2-5471-4658-b326-0696c17a05f1"), false, false, false, false, new Guid("a957989e-226f-4bb8-afa2-94e6d40998e9") },
                    { new Guid("035ea55f-69e8-4daa-b5e7-b0e277862828"), false, false, true, false, new Guid("f5a82c47-1dc2-41cd-9546-8c62b5b08045") },
                    { new Guid("085b2acc-dc89-4433-baa9-a89b94d54639"), false, false, false, false, new Guid("a5966ef9-31ea-4e17-b5f3-bfcc2920297d") },
                    { new Guid("087a9dff-7477-43cd-a394-069be95ca989"), false, true, true, false, new Guid("fa737043-6a38-4793-a8b8-de4fa410862a") },
                    { new Guid("0c42d1b0-068a-4891-84f2-a825a3b95c48"), false, false, false, true, new Guid("2e89e813-5a6a-41c3-8893-190a31ef8bd5") },
                    { new Guid("0e856a15-73d8-4948-ad68-b3e8155cd501"), false, false, false, true, new Guid("5d1cc15c-b3e1-413b-9314-7933a5bed49b") },
                    { new Guid("0ef255ee-5523-419e-9d7e-33b5ff92c0bd"), false, false, true, false, new Guid("5155113f-466d-4f00-93b8-e75b6c8f7189") },
                    { new Guid("1013b788-fda6-499e-8972-030a53f128ad"), false, false, false, false, new Guid("ce52fca6-72d1-4d97-a529-401a09648b9d") },
                    { new Guid("11839a6b-ba09-492e-8d74-019d07b9bbaf"), false, false, true, false, new Guid("2215e8fb-a6f5-4b37-8b50-7a6b02d581d6") },
                    { new Guid("1240c8af-580d-4cb9-92e5-5d93890040c3"), false, false, true, false, new Guid("145b1d2f-1da3-4bec-a978-539a332c1649") },
                    { new Guid("13efeb92-5001-413d-8d00-4ba5a1d8cbf5"), false, false, false, false, new Guid("860c31a6-78c2-4886-941c-be174fd55a89") },
                    { new Guid("162e6092-6bf6-4768-bca8-bbf7a30479d8"), false, false, false, false, new Guid("4c682287-c7d1-49bf-8baf-012590d02fff") },
                    { new Guid("1646abc4-5060-4684-807c-28695e9ba9c1"), false, false, true, false, new Guid("d5933118-eb16-4391-be5a-d4f726b1bbae") },
                    { new Guid("17f2b2ac-0f2c-45dd-a85a-7a8abe0d7be8"), false, false, false, false, new Guid("2471054b-a45e-44fd-86d9-2af2f6345793") },
                    { new Guid("18e83c78-812c-4de7-98ee-d751c6460f78"), false, false, true, false, new Guid("68aa8b00-622e-44fc-9f98-25b3c9c23f34") },
                    { new Guid("1c0972ff-3d9b-482f-8b36-93cda5f73123"), false, false, false, false, new Guid("9d795ca6-def5-47ee-9a66-9605eabc97ca") },
                    { new Guid("1d3c765b-d720-4bcc-a606-c5bffcc4bc31"), false, false, false, false, new Guid("1e67b20a-c523-4178-bdf5-16d452781b27") },
                    { new Guid("1fe40b16-0c97-4294-aed6-f8e9aaa3790a"), false, false, false, false, new Guid("e4100d6d-dd3a-4a08-9206-fba2e9e9e536") },
                    { new Guid("2070a997-f4a7-4770-a418-81bfd07313dd"), false, false, false, false, new Guid("eda6168b-6515-4b5f-a4ee-6af2a31312f9") },
                    { new Guid("207dd016-39e0-4b13-944f-4cb0e189f848"), false, true, true, false, new Guid("4506f837-d214-48bb-8a71-5faea5494c83") },
                    { new Guid("2b91d631-e3c3-44ab-90e2-4ba37e721797"), false, false, false, false, new Guid("b54be218-f3ed-44f0-a88c-8e3362a2f9a1") },
                    { new Guid("2d99793c-4a6c-4e13-9c44-dd0323ec3f17"), false, false, true, false, new Guid("21f9b2cf-b6ef-4d11-a0ba-818d26d7a006") },
                    { new Guid("2eac3628-02be-452a-bded-39cb31454006"), false, true, false, false, new Guid("33b3d7ed-c116-4351-ad2e-ae1b6bc1cd95") },
                    { new Guid("2ff20b14-f52d-46c2-994a-8b06f48a4802"), false, false, false, false, new Guid("1b271e5d-f143-433c-9909-18304784c0dc") },
                    { new Guid("3034079b-ffd4-4f97-a9fa-699d62795b2b"), false, false, true, false, new Guid("66d1eafb-4e91-4d1b-a102-9ccbcba4253a") },
                    { new Guid("37a40bf2-8808-43d5-9e2a-210a526015f4"), false, false, false, true, new Guid("5312113a-ce17-476f-bf87-5e3a861027c2") },
                    { new Guid("3bff0d9b-5aab-4c6f-be00-3d8bbf85189c"), false, false, false, false, new Guid("0f2c23ef-8e11-4f85-85ba-78ccd150d9bb") },
                    { new Guid("441de618-14cb-4bdb-b6a2-ba532bd86630"), false, true, false, true, new Guid("3e546a14-ccb5-4e75-92f5-c1f3614953a5") },
                    { new Guid("44339d22-f4d3-4117-9e8e-7007a6638f41"), false, false, false, false, new Guid("480bf0d9-39d6-4fd3-9b1e-ad138aeb3483") },
                    { new Guid("47c8ef3a-0ecf-4255-9be9-fc3b673c1d4e"), false, false, false, false, new Guid("2027db61-452c-4bf5-8f34-493c93ddf9bf") },
                    { new Guid("487e258f-a9a4-48af-b6a5-4ed95ce3c473"), false, false, false, true, new Guid("30912a18-6188-4bd7-b266-1bc5a56e0e06") },
                    { new Guid("49984aaa-b2ab-46ac-8a18-51e0590020af"), false, false, true, false, new Guid("1f50e98b-1acd-432c-8d6c-49e5f94ec654") },
                    { new Guid("4caa40ae-1827-4a65-bde7-f05c949a7bc3"), false, false, false, false, new Guid("7491c501-478a-4aeb-ae00-17ac630e1314") },
                    { new Guid("520587f7-8001-4c2f-ae8f-b4174c10f1e1"), false, false, true, false, new Guid("f97b231c-31da-49a3-90eb-306bef8c72c1") },
                    { new Guid("5634557f-812a-4f91-82ed-0fc96aa28dc2"), false, false, false, false, new Guid("69af8236-db70-4c6a-b7f7-e4625e779313") },
                    { new Guid("56806919-9512-479b-afdb-7d80220cefdd"), false, false, true, true, new Guid("9ac52ade-a530-4447-83c4-dbf15d463f17") },
                    { new Guid("5aca1cd8-257a-496a-bfe7-07a107ecb718"), false, true, true, false, new Guid("4efa3c17-9aed-4182-9bf6-1e9dce436d13") },
                    { new Guid("5b575eae-9b11-4842-b6e7-c6f2aeca6be9"), false, true, false, false, new Guid("30e1d0f3-ccae-4785-ae51-52e6c994aacd") },
                    { new Guid("5fdeb301-a27e-4a07-ae26-e8f777f4c7b1"), false, false, false, false, new Guid("b31e5d44-8ed3-479a-b6d6-59f632630ab0") },
                    { new Guid("61d3b18b-2db2-47aa-a9cb-011fe0fdc50d"), false, true, false, false, new Guid("2d3ec0d3-130b-4bd7-8202-f57387412d69") },
                    { new Guid("6a76d9aa-849e-4c68-b218-5898246a6e46"), false, false, true, false, new Guid("992f6210-4e0d-4578-b3c5-e09a02bbdaca") },
                    { new Guid("6b18a096-62a9-4a7c-b5d1-3c0c66093108"), false, false, false, false, new Guid("cc196503-7307-4280-a8f7-42bbca4f8c24") },
                    { new Guid("6f6ccb1e-d2e8-4c1b-b0c4-8a51a341ff06"), false, false, false, false, new Guid("10148a74-60c6-4888-9f69-70a74945d394") },
                    { new Guid("7403d73b-4d89-4c20-b5a8-1077ca33ce9e"), false, false, true, false, new Guid("6f77416f-8c2e-455b-82dc-346345f1cc66") },
                    { new Guid("74750442-13a9-431d-a990-fbb18dcc7654"), false, false, true, true, new Guid("6bbdefc6-358d-4a57-9fea-4ac4d31cf0df") },
                    { new Guid("78e92936-afc5-45f8-84e4-1f716278530e"), false, false, false, false, new Guid("50d128ec-ca48-44f3-9248-0d00c4a8cb6c") },
                    { new Guid("7a94b568-38eb-411d-9dd6-d337f7779053"), false, false, false, true, new Guid("9e5e4896-b923-4cd9-841c-77fa1fe6537a") },
                    { new Guid("7bf76e6e-17fd-436a-9f2e-6cd9e2ae76fc"), false, false, false, true, new Guid("731fb401-e0cd-4aee-bf79-7a3fc0e5f69d") },
                    { new Guid("813b32d4-4004-4df5-9671-1fd0410cfe93"), false, false, false, false, new Guid("e719a908-f784-42c6-bb49-ee71649a442b") },
                    { new Guid("83d3c4a1-465a-4beb-910f-336afb2301e1"), false, false, false, true, new Guid("b9f39656-a26d-45a3-8a09-ee9c162bc11d") },
                    { new Guid("84e862ce-f4c5-4fc7-823a-8ff2a8779f66"), false, false, false, false, new Guid("78e58e86-5e6c-4c00-add1-739b665768cc") },
                    { new Guid("851b5fe2-7847-48db-ab15-8e5734142496"), false, false, false, false, new Guid("8554f8f0-8c01-4ea7-9982-d9696e59f5d7") },
                    { new Guid("856e062c-456e-43d3-8398-81503db4c994"), false, false, true, false, new Guid("8a6ee593-0716-4ecb-96a5-ecfe1ea596c9") },
                    { new Guid("8ac0f1ed-7f7b-4c8a-aeab-e60a9be034ae"), false, false, true, true, new Guid("0c77ee4c-b8d6-454e-978e-be2257dd2e3c") },
                    { new Guid("8e83f7d9-d9cd-4d5c-be61-dfa30c4de329"), false, false, true, false, new Guid("7bf90894-1d33-4b21-aa74-b88e6c7c244d") },
                    { new Guid("94302913-78fc-4940-9754-47e7c0aa2429"), false, false, false, false, new Guid("740a0023-5020-430b-abf7-39b8b24a398e") },
                    { new Guid("97d72995-1f24-4631-a8eb-1eab1385d04a"), false, true, true, false, new Guid("2563db6f-4c4e-4031-b41a-850a1b243181") },
                    { new Guid("9861dbce-6a03-427e-a696-7f170bca80bd"), false, true, false, false, new Guid("a13bbaf6-66a3-4087-b7f4-9b5c7e472bb2") },
                    { new Guid("993e94cd-775b-4657-b8e0-68e1e48ff0db"), false, false, true, false, new Guid("3bdc1960-13b5-42d4-8618-0c2e52d72721") },
                    { new Guid("9b8e4f52-1db6-407c-8cf1-3397e79f1253"), false, false, false, false, new Guid("5144ae96-d3bb-4199-a7a0-342774f16bf6") },
                    { new Guid("9c17168e-6b19-40df-b95c-790733cb6e45"), false, false, true, true, new Guid("0abe5794-e3d6-4950-a75e-3d83ed9f022b") },
                    { new Guid("9ca74fa8-482f-497a-8caf-20d501ec93cd"), false, false, false, true, new Guid("eb6abea0-0e79-4216-8c29-38d3e0c23d77") },
                    { new Guid("9e39fedf-bc1b-4350-83c5-2eebea877644"), false, false, false, false, new Guid("84c17fb7-3997-4eb9-bcbe-02a606f6ea56") },
                    { new Guid("9fc781ab-0d0c-42f9-9208-9c729cdf093f"), false, false, true, false, new Guid("da2a8d35-b8b4-4679-b0fb-f33cfe973459") },
                    { new Guid("a087980a-726e-410e-8902-dd2bc051e255"), false, false, false, false, new Guid("b01b7f37-433b-4529-94d0-3644ef9724e9") },
                    { new Guid("a2ef0935-5f4c-4820-9d43-361bea11a096"), false, false, true, false, new Guid("8abb5551-1228-4c96-9300-949f91ec7b33") },
                    { new Guid("a7272a23-9493-412a-8838-d31a6b348058"), true, false, false, true, new Guid("7e80f554-4aa0-48f7-84ed-64f60ebd8099") },
                    { new Guid("b3dbd91a-6673-49a8-9a05-44783b5f7411"), false, false, false, true, new Guid("8b6b979d-a208-4c2e-8815-caa546dee237") },
                    { new Guid("b49a4d03-69e3-4a0e-a836-278677518123"), false, true, false, false, new Guid("e83d3398-ad83-468a-96c8-2b071ab4159e") },
                    { new Guid("b4da5b75-14a2-49ba-bd56-f662e783e632"), false, false, false, true, new Guid("e77e4678-de32-42bf-bce4-097956c07c8c") },
                    { new Guid("b5b04b06-71f4-4adc-bc71-958600532281"), false, false, false, false, new Guid("8c8d2905-6abf-456e-9044-81c184b4d223") },
                    { new Guid("b6aa6019-27da-40a2-816e-92a148f47140"), false, false, true, false, new Guid("7897a73e-7546-498d-bde6-4f0a8abdd24d") },
                    { new Guid("ba809136-2aee-4c00-bcf4-272f7e472c32"), false, false, true, true, new Guid("57ef23b1-38f3-41fb-9bf0-c5470eb193a1") },
                    { new Guid("bd40ae06-825a-4b7e-a9de-e2aaf2cae4a7"), false, false, false, false, new Guid("8815dd6f-0311-4e85-b233-985960745df6") },
                    { new Guid("be9de5da-e339-4968-85dc-032121ed74b2"), false, false, false, false, new Guid("8533808b-75cb-448c-89a4-666b476c9f2a") },
                    { new Guid("c41f7070-f624-4cf2-a434-6c93d216820b"), false, false, true, false, new Guid("a521b155-dc28-4c92-bf3d-1ce2b745f892") },
                    { new Guid("ccc1ca2a-ca80-402c-93a7-6da4768920b4"), false, false, false, false, new Guid("4e37bbbb-642e-43f2-83bf-2e70402016a1") },
                    { new Guid("ccfa113a-e520-4479-9af9-bc2365dd0897"), false, false, true, false, new Guid("a41982b7-d58c-42ff-942b-31059e50140a") },
                    { new Guid("cd05b1b6-9ec2-443e-b946-619c6d0919d2"), false, true, false, true, new Guid("2c4dd255-2a45-45f8-ae1f-fc8851d3782a") },
                    { new Guid("cf83d198-160b-404c-bc76-63fa93d80f6a"), false, false, false, false, new Guid("2292e013-8588-4fac-9676-8582b686d631") },
                    { new Guid("d73fbeb5-c0b9-460a-8cf0-f741fec099e8"), false, false, false, false, new Guid("0641a5ea-d749-4991-a982-330252578fae") },
                    { new Guid("d81add96-959f-4c94-9fad-d64066249bfa"), false, false, true, false, new Guid("93d265cd-a39f-4cce-b97f-ed5b031eee35") },
                    { new Guid("dbb2e333-d8f0-4e9b-94d1-9e7ea9c2b662"), false, false, false, false, new Guid("b30cbdab-d85f-441f-8859-e9588cd6527f") },
                    { new Guid("e1fb2018-24d2-4956-aad5-99c44d3c7c26"), false, false, false, true, new Guid("a329d081-971e-43aa-a388-9683e85697e6") },
                    { new Guid("e22d0f9a-1061-4d24-a669-acc8931d7023"), false, false, false, false, new Guid("883f74e0-5e1a-4a79-861a-ecb314a07fba") },
                    { new Guid("e8fed88a-aa3f-4144-94c0-b174005f384f"), false, false, true, false, new Guid("86a09aca-ead3-4708-916e-38f6f293236d") },
                    { new Guid("ec8f5aca-9b03-4b5d-a633-6ea6711aa0f8"), false, false, false, false, new Guid("7263f1f1-a731-40e0-a94a-e96eab6424a6") },
                    { new Guid("ee63961c-a1d4-4183-bdcd-642b7fc63c89"), false, false, false, false, new Guid("bc16147c-3863-483f-ab18-cfbdb91166d8") },
                    { new Guid("eec886f4-a9db-48bc-b0e8-e6b657970778"), false, false, false, false, new Guid("e54eeb7c-ba03-4123-bdb8-3c2bc61211b5") },
                    { new Guid("ef258e22-8e0c-478d-b963-3be1921ecc47"), false, false, false, false, new Guid("62d062ea-4100-4138-bd9f-6e7a1fcf9dd8") },
                    { new Guid("ef509d7a-437f-4de9-b664-dc97cd82b0db"), false, false, false, false, new Guid("3dfce0b1-7d61-47ff-9053-1b18a3a9a69a") },
                    { new Guid("efb280af-8b30-47af-ab12-fa9c09b526b1"), false, true, false, false, new Guid("28223e42-61a3-4d19-a48a-46296a43de79") },
                    { new Guid("f05e9441-8dfb-402e-a15e-c2d064e0e68b"), false, false, false, false, new Guid("e038d487-a20e-4b00-8777-3730b05a7c67") },
                    { new Guid("f68e256b-ee49-4326-8ac6-9f83d7af001b"), false, false, false, false, new Guid("49a9aae9-2b91-4812-a7d2-c96d7a2cb973") },
                    { new Guid("fc6e35b6-3c07-4e32-b6e1-9f0b7f34675d"), false, false, false, false, new Guid("f75fccc3-92e9-4827-ae42-b6500c968337") },
                    { new Guid("fe0099d2-f62f-4151-8c89-9aac0d32e78f"), false, false, true, false, new Guid("9f33c46b-4abd-4fd9-bc83-7b7f9f74c491") },
                    { new Guid("fed3d554-653e-4a5e-a117-b9f2274edba8"), false, false, false, false, new Guid("cdc515c0-6b42-4494-a936-bbbf0193ee80") },
                    { new Guid("ffd42a30-e582-4df8-9208-ff5fdef33d28"), false, true, false, false, new Guid("c6d64e0a-e373-437f-8fcd-0d83228f7c44") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Role_UserId",
                table: "Role",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Role_Users_UserId",
                table: "Role",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Role_Users_UserId",
                table: "Role");

            migrationBuilder.DropIndex(
                name: "IX_Role_UserId",
                table: "Role");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("00bff54c-20b2-403d-a419-f493aa760737"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("01522160-a509-4659-aa80-772b0c50d501"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("0231cee2-5471-4658-b326-0696c17a05f1"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("035ea55f-69e8-4daa-b5e7-b0e277862828"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("085b2acc-dc89-4433-baa9-a89b94d54639"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("087a9dff-7477-43cd-a394-069be95ca989"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("0c42d1b0-068a-4891-84f2-a825a3b95c48"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("0e856a15-73d8-4948-ad68-b3e8155cd501"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("0ef255ee-5523-419e-9d7e-33b5ff92c0bd"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("1013b788-fda6-499e-8972-030a53f128ad"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("11839a6b-ba09-492e-8d74-019d07b9bbaf"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("1240c8af-580d-4cb9-92e5-5d93890040c3"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("13efeb92-5001-413d-8d00-4ba5a1d8cbf5"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("162e6092-6bf6-4768-bca8-bbf7a30479d8"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("1646abc4-5060-4684-807c-28695e9ba9c1"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("17f2b2ac-0f2c-45dd-a85a-7a8abe0d7be8"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("18e83c78-812c-4de7-98ee-d751c6460f78"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("1c0972ff-3d9b-482f-8b36-93cda5f73123"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("1d3c765b-d720-4bcc-a606-c5bffcc4bc31"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("1fe40b16-0c97-4294-aed6-f8e9aaa3790a"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("2070a997-f4a7-4770-a418-81bfd07313dd"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("207dd016-39e0-4b13-944f-4cb0e189f848"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("2b91d631-e3c3-44ab-90e2-4ba37e721797"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("2d99793c-4a6c-4e13-9c44-dd0323ec3f17"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("2eac3628-02be-452a-bded-39cb31454006"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("2ff20b14-f52d-46c2-994a-8b06f48a4802"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("3034079b-ffd4-4f97-a9fa-699d62795b2b"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("37a40bf2-8808-43d5-9e2a-210a526015f4"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("3bff0d9b-5aab-4c6f-be00-3d8bbf85189c"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("441de618-14cb-4bdb-b6a2-ba532bd86630"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("44339d22-f4d3-4117-9e8e-7007a6638f41"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("47c8ef3a-0ecf-4255-9be9-fc3b673c1d4e"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("487e258f-a9a4-48af-b6a5-4ed95ce3c473"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("49984aaa-b2ab-46ac-8a18-51e0590020af"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("4caa40ae-1827-4a65-bde7-f05c949a7bc3"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("520587f7-8001-4c2f-ae8f-b4174c10f1e1"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("5634557f-812a-4f91-82ed-0fc96aa28dc2"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("56806919-9512-479b-afdb-7d80220cefdd"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("5aca1cd8-257a-496a-bfe7-07a107ecb718"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("5b575eae-9b11-4842-b6e7-c6f2aeca6be9"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("5fdeb301-a27e-4a07-ae26-e8f777f4c7b1"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("61d3b18b-2db2-47aa-a9cb-011fe0fdc50d"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("6a76d9aa-849e-4c68-b218-5898246a6e46"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("6b18a096-62a9-4a7c-b5d1-3c0c66093108"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("6f6ccb1e-d2e8-4c1b-b0c4-8a51a341ff06"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("7403d73b-4d89-4c20-b5a8-1077ca33ce9e"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("74750442-13a9-431d-a990-fbb18dcc7654"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("78e92936-afc5-45f8-84e4-1f716278530e"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("7a94b568-38eb-411d-9dd6-d337f7779053"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("7bf76e6e-17fd-436a-9f2e-6cd9e2ae76fc"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("813b32d4-4004-4df5-9671-1fd0410cfe93"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("83d3c4a1-465a-4beb-910f-336afb2301e1"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("84e862ce-f4c5-4fc7-823a-8ff2a8779f66"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("851b5fe2-7847-48db-ab15-8e5734142496"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("856e062c-456e-43d3-8398-81503db4c994"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("8ac0f1ed-7f7b-4c8a-aeab-e60a9be034ae"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("8e83f7d9-d9cd-4d5c-be61-dfa30c4de329"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("94302913-78fc-4940-9754-47e7c0aa2429"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("97d72995-1f24-4631-a8eb-1eab1385d04a"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("9861dbce-6a03-427e-a696-7f170bca80bd"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("993e94cd-775b-4657-b8e0-68e1e48ff0db"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("9b8e4f52-1db6-407c-8cf1-3397e79f1253"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("9c17168e-6b19-40df-b95c-790733cb6e45"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("9ca74fa8-482f-497a-8caf-20d501ec93cd"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("9e39fedf-bc1b-4350-83c5-2eebea877644"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("9fc781ab-0d0c-42f9-9208-9c729cdf093f"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("a087980a-726e-410e-8902-dd2bc051e255"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("a2ef0935-5f4c-4820-9d43-361bea11a096"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("a7272a23-9493-412a-8838-d31a6b348058"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("b3dbd91a-6673-49a8-9a05-44783b5f7411"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("b49a4d03-69e3-4a0e-a836-278677518123"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("b4da5b75-14a2-49ba-bd56-f662e783e632"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("b5b04b06-71f4-4adc-bc71-958600532281"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("b6aa6019-27da-40a2-816e-92a148f47140"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("ba809136-2aee-4c00-bcf4-272f7e472c32"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("bd40ae06-825a-4b7e-a9de-e2aaf2cae4a7"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("be9de5da-e339-4968-85dc-032121ed74b2"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("c41f7070-f624-4cf2-a434-6c93d216820b"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("ccc1ca2a-ca80-402c-93a7-6da4768920b4"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("ccfa113a-e520-4479-9af9-bc2365dd0897"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("cd05b1b6-9ec2-443e-b946-619c6d0919d2"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("cf83d198-160b-404c-bc76-63fa93d80f6a"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("d73fbeb5-c0b9-460a-8cf0-f741fec099e8"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("d81add96-959f-4c94-9fad-d64066249bfa"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("dbb2e333-d8f0-4e9b-94d1-9e7ea9c2b662"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("e1fb2018-24d2-4956-aad5-99c44d3c7c26"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("e22d0f9a-1061-4d24-a669-acc8931d7023"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("e8fed88a-aa3f-4144-94c0-b174005f384f"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("ec8f5aca-9b03-4b5d-a633-6ea6711aa0f8"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("ee63961c-a1d4-4183-bdcd-642b7fc63c89"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("eec886f4-a9db-48bc-b0e8-e6b657970778"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("ef258e22-8e0c-478d-b963-3be1921ecc47"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("ef509d7a-437f-4de9-b664-dc97cd82b0db"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("efb280af-8b30-47af-ab12-fa9c09b526b1"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("f05e9441-8dfb-402e-a15e-c2d064e0e68b"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("f68e256b-ee49-4326-8ac6-9f83d7af001b"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("fc6e35b6-3c07-4e32-b6e1-9f0b7f34675d"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("fe0099d2-f62f-4151-8c89-9aac0d32e78f"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("fed3d554-653e-4a5e-a117-b9f2274edba8"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("ffd42a30-e582-4df8-9208-ff5fdef33d28"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0641a5ea-d749-4991-a982-330252578fae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0abe5794-e3d6-4950-a75e-3d83ed9f022b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0c77ee4c-b8d6-454e-978e-be2257dd2e3c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0f2c23ef-8e11-4f85-85ba-78ccd150d9bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0fb0c78d-3129-4405-b10f-739deea74b39"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("10148a74-60c6-4888-9f69-70a74945d394"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("145b1d2f-1da3-4bec-a978-539a332c1649"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1b271e5d-f143-433c-9909-18304784c0dc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e67b20a-c523-4178-bdf5-16d452781b27"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1f50e98b-1acd-432c-8d6c-49e5f94ec654"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2027db61-452c-4bf5-8f34-493c93ddf9bf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("21f9b2cf-b6ef-4d11-a0ba-818d26d7a006"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2215e8fb-a6f5-4b37-8b50-7a6b02d581d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2292e013-8588-4fac-9676-8582b686d631"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2471054b-a45e-44fd-86d9-2af2f6345793"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2563db6f-4c4e-4031-b41a-850a1b243181"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("28223e42-61a3-4d19-a48a-46296a43de79"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2c4dd255-2a45-45f8-ae1f-fc8851d3782a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2d3ec0d3-130b-4bd7-8202-f57387412d69"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2e89e813-5a6a-41c3-8893-190a31ef8bd5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("30912a18-6188-4bd7-b266-1bc5a56e0e06"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("30e1d0f3-ccae-4785-ae51-52e6c994aacd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33b3d7ed-c116-4351-ad2e-ae1b6bc1cd95"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3bdc1960-13b5-42d4-8618-0c2e52d72721"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3dfce0b1-7d61-47ff-9053-1b18a3a9a69a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3e546a14-ccb5-4e75-92f5-c1f3614953a5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3f0f7602-7055-4a5d-8aa7-a3d25c7d6ede"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4506f837-d214-48bb-8a71-5faea5494c83"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("480bf0d9-39d6-4fd3-9b1e-ad138aeb3483"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("49a9aae9-2b91-4812-a7d2-c96d7a2cb973"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c682287-c7d1-49bf-8baf-012590d02fff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4e37bbbb-642e-43f2-83bf-2e70402016a1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4efa3c17-9aed-4182-9bf6-1e9dce436d13"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("50d128ec-ca48-44f3-9248-0d00c4a8cb6c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5144ae96-d3bb-4199-a7a0-342774f16bf6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5155113f-466d-4f00-93b8-e75b6c8f7189"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5312113a-ce17-476f-bf87-5e3a861027c2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("57ef23b1-38f3-41fb-9bf0-c5470eb193a1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5d1cc15c-b3e1-413b-9314-7933a5bed49b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("62d062ea-4100-4138-bd9f-6e7a1fcf9dd8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66d1eafb-4e91-4d1b-a102-9ccbcba4253a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68aa8b00-622e-44fc-9f98-25b3c9c23f34"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69af8236-db70-4c6a-b7f7-e4625e779313"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6bbdefc6-358d-4a57-9fea-4ac4d31cf0df"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6f77416f-8c2e-455b-82dc-346345f1cc66"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7263f1f1-a731-40e0-a94a-e96eab6424a6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("731fb401-e0cd-4aee-bf79-7a3fc0e5f69d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("740a0023-5020-430b-abf7-39b8b24a398e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7491c501-478a-4aeb-ae00-17ac630e1314"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7897a73e-7546-498d-bde6-4f0a8abdd24d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("78e58e86-5e6c-4c00-add1-739b665768cc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7bf90894-1d33-4b21-aa74-b88e6c7c244d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7e80f554-4aa0-48f7-84ed-64f60ebd8099"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("84c17fb7-3997-4eb9-bcbe-02a606f6ea56"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8533808b-75cb-448c-89a4-666b476c9f2a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8554f8f0-8c01-4ea7-9982-d9696e59f5d7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("860c31a6-78c2-4886-941c-be174fd55a89"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("86a09aca-ead3-4708-916e-38f6f293236d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8815dd6f-0311-4e85-b233-985960745df6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("883f74e0-5e1a-4a79-861a-ecb314a07fba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8a6ee593-0716-4ecb-96a5-ecfe1ea596c9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8abb5551-1228-4c96-9300-949f91ec7b33"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8b6b979d-a208-4c2e-8815-caa546dee237"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8c8d2905-6abf-456e-9044-81c184b4d223"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("93d265cd-a39f-4cce-b97f-ed5b031eee35"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("992f6210-4e0d-4578-b3c5-e09a02bbdaca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9ac52ade-a530-4447-83c4-dbf15d463f17"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d795ca6-def5-47ee-9a66-9605eabc97ca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9e5e4896-b923-4cd9-841c-77fa1fe6537a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9f33c46b-4abd-4fd9-bc83-7b7f9f74c491"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a13bbaf6-66a3-4087-b7f4-9b5c7e472bb2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a329d081-971e-43aa-a388-9683e85697e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a41982b7-d58c-42ff-942b-31059e50140a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a521b155-dc28-4c92-bf3d-1ce2b745f892"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a5966ef9-31ea-4e17-b5f3-bfcc2920297d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a957989e-226f-4bb8-afa2-94e6d40998e9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b01b7f37-433b-4529-94d0-3644ef9724e9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b30cbdab-d85f-441f-8859-e9588cd6527f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b31e5d44-8ed3-479a-b6d6-59f632630ab0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b54be218-f3ed-44f0-a88c-8e3362a2f9a1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b9f39656-a26d-45a3-8a09-ee9c162bc11d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bc16147c-3863-483f-ab18-cfbdb91166d8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c6d64e0a-e373-437f-8fcd-0d83228f7c44"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cc196503-7307-4280-a8f7-42bbca4f8c24"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cdc515c0-6b42-4494-a936-bbbf0193ee80"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ce52fca6-72d1-4d97-a529-401a09648b9d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5933118-eb16-4391-be5a-d4f726b1bbae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("da2a8d35-b8b4-4679-b0fb-f33cfe973459"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e038d487-a20e-4b00-8777-3730b05a7c67"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e4100d6d-dd3a-4a08-9206-fba2e9e9e536"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e54eeb7c-ba03-4123-bdb8-3c2bc61211b5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e719a908-f784-42c6-bb49-ee71649a442b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e77e4678-de32-42bf-bce4-097956c07c8c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e83d3398-ad83-468a-96c8-2b071ab4159e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eb6abea0-0e79-4216-8c29-38d3e0c23d77"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eda6168b-6515-4b5f-a4ee-6af2a31312f9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f5a82c47-1dc2-41cd-9546-8c62b5b08045"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f75fccc3-92e9-4827-ae42-b6500c968337"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f97b231c-31da-49a3-90eb-306bef8c72c1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa737043-6a38-4793-a8b8-de4fa410862a"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "Email", "Gender", "Name", "Password", "RoleId" },
                values: new object[,]
                {
                    { new Guid("001caa23-7d2e-4476-849b-a4c6428ad26c"), null, "user39@example.com", 1, "User39", "$2a$11$2fFV/XaDJkK48V/tlfnGveLWN8K4UzVpEp9xTnHtDtiwPD58VuueC", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("02dddc9b-88df-4d82-899f-41c3205b96dd"), null, "user20@example.com", 0, "User20", "$2a$11$l8JiJLEqGk1WemJTzVjn6OdU69lMjBpGdHv7s3m2BRwmDpCOnb.4u", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("0404b3a0-e920-4f29-a0e7-e48e2d38575f"), null, "user8@example.com", 0, "User8", "$2a$11$WmrJ4sfZLBtd3e9WrQciUuGvG8GA59/aqcJtIZQOtnppC/kSK6Rwy", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("062d546a-3eb0-4e6c-9c1e-fa1f8f2f07bb"), null, "user42@example.com", 0, "User42", "$2a$11$taOXhFNZHIRhiegJ6kFpVeYiDDSEJBZjCVtoJfTp9/1Vk8KIMPbdm", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("0aed60da-6cc0-4c44-a0b2-b4d7b248078c"), null, "user40@example.com", 0, "User40", "$2a$11$4Gc/Z0.1j1V/xXi6hYbREO5woOKjYV3gnCzjohXwPA2251MIrDVBK", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("105ec760-bb4d-4b96-8696-5a437a028d10"), null, "user97@example.com", 1, "User97", "$2a$11$DQahDXpS1IG3Y38D6zGTj.z5mhKNmaIdFLJkcY8pRwq5cLL59pUny", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("122a99e2-9216-4e7e-893c-26e358d4e7ba"), null, "user91@example.com", 1, "User91", "$2a$11$GL5ohrrgD0gCEhxGDrne.upUQP0NxvgUnpXR5WabsbpAun4DzS0jO", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("124c74c3-018b-4e63-bd9e-070a06cf087b"), null, "user83@example.com", 1, "User83", "$2a$11$qjI.H8pE8TqRybrHoDsHv.eZG07iTjA65O23ODbW1ua0cqPMc.4R2", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("176c23d3-1b03-4fcc-b1fa-a22b3e60b455"), null, "user56@example.com", 0, "User56", "$2a$11$tPfJeoOkKa/nFCBWJizZ3edLfDFS9Z415w0xXf1OVFTW4pMWc32vS", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("1b63f99d-6385-4faf-a2e2-006102c61549"), null, "user23@example.com", 1, "User23", "$2a$11$aTLAu/zyIEC33p3r3ZMP3OVoe1RzJp/ITKLmS6a0Z37rCwA0uG6uG", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("1b67c649-4f90-464d-8adb-b57f58a1d6f1"), null, "user73@example.com", 1, "User73", "$2a$11$FxxAwjay7PWaQuemxmjBgOJy4v8MgG61CmrMXRglBxlIem512ohWu", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("20473cfe-6186-484c-b975-75c895c43dac"), null, "user62@example.com", 0, "User62", "$2a$11$UMRVDTjFTm7SHRj5BRSBxe4fhrSrfZ7XDKEKc0IuUISnBHDxcJayG", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("233cf2bd-2a8d-4dee-baec-6a6ae0016c35"), null, "user45@example.com", 1, "User45", "$2a$11$AQ181mLpM1nfgbzbAYanUuNDegqfLWFT9mfaF8N1Cp65HeIOVQRTG", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("23e79af6-ab1d-4870-aaeb-4b24350cda3c"), null, "user100@example.com", 0, "User100", "$2a$11$ZRaKColwcVGsI1oc5siKlORfZU.47oAHUf2K.Bb6xD0stKBXSG4H2", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("250aa675-97de-4740-8493-99e59e7f4f76"), null, "user54@example.com", 0, "User54", "$2a$11$4MV4mrcjna0/ymYEDeZQYe9KRlsYh/DpIRXOp92H9UwKrsCsm//kC", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2f3c1f5d-5f89-4086-b1ca-e1cd0e92cae4"), null, "user66@example.com", 0, "User66", "$2a$11$1PmYxQMWWkLu.7ATNE.dDeqF.9ffJSbh0jaSrJxum2uKPLEhvZO02", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2f4bdd6f-a00a-4827-9c09-2d70531dd958"), null, "user99@example.com", 1, "User99", "$2a$11$ao/cH9WyFDGJz3Q5fQCRqu4MQKW4Wax0XEY6soY0B69IuQCUeagnC", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("3019593a-8242-4b46-ac24-29acc6387ca3"), null, "user31@example.com", 1, "User31", "$2a$11$4AaAGFKUqmA9dnkyK25ckOZqhxN6rN.O.cbivR1lmDL5/3G08ijE.", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("33516248-0a4a-4062-963c-ddb1400766e8"), null, "user94@example.com", 0, "User94", "$2a$11$4wjt3AKVgfMBTKI.1Iy4VewqbnfF6MnR19UaAxBSo2jwxjCKiNcsS", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("348f2454-29fe-4074-8562-9b5e815b1866"), null, "user65@example.com", 1, "User65", "$2a$11$TTFbMYNSJxvs6MixWvJkoO7v1XHO8d4xzJGtWQv8M3q/01drHcTKm", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("36bd800f-b289-4996-9b17-fbf422747dfc"), null, "user68@example.com", 0, "User68", "$2a$11$YGamWj4f3JWcHl26enrLJuelPT0a0gnJoNbElyR.1K83IEhglW5ua", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("3aa703d6-a480-487a-9d98-f048f0135a40"), null, "user14@example.com", 0, "User14", "$2a$11$CyCSTPBGDA5P.7y1nDA/AuUKNTPWAZ09//XroJ97EmFAc7cesvJYe", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("3bcf4929-0652-46a4-a682-ddc5da6df338"), null, "user18@example.com", 0, "User18", "$2a$11$HSdl8hyoKBhVPohPru3ZduQLXK6ihAp4k4HgRouG0fLaR5eeNdW.q", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("3cf3ed25-ba6c-4241-bfec-7728f6650e28"), null, "user96@example.com", 0, "User96", "$2a$11$Y4MlUyn0jJuimlvJrcMgsOCdarN7X3KRPTaPg7FHJUf3tr7ongd6C", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("420b8d7d-9473-4bd7-929d-8cbd02f7baab"), null, "user2@example.com", 0, "User2", "$2a$11$1zUfj.FkSrrCegjjNZS3WudY9Nnaf5IjWF6v4eMzCSeS7Qp0fDNBS", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("447d0a21-3aae-45f6-a5d4-5f43cfadc888"), null, "user84@example.com", 0, "User84", "$2a$11$PQT17VyPLMKxTXaem.zcIuimvkeWTpRJX8mYZej7qp4fGe4Pwde0a", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("44e57b57-2852-4522-8554-a009f449ad0c"), null, "user38@example.com", 0, "User38", "$2a$11$42b5ew9M2b4VFceYew5X7OfUUKI.zFMIz9NipAfGrO5v4WgTepGNK", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("45eabb94-a20b-4493-b84b-77cb89ea5a07"), null, "user63@example.com", 1, "User63", "$2a$11$KPFib/uVttSkZqQzYGja/.5d69fUTEWpzFHMtZYXRlZtfI5KV0yFS", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4821136e-d778-4a09-9840-079aa8643a06"), null, "user60@example.com", 0, "User60", "$2a$11$MMGFCzFa5zBz5UfhWcCh6O/pm3odJLIGfQbG2qX8UUb3qpBKea7Kq", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("49bd9d52-73e9-43e0-bf01-3f155c4989a3"), null, "user88@example.com", 0, "User88", "$2a$11$OzDdjxtVzzYITG6ymf6FE.aibjkEk/iEraz2GBl1uDpFrymURZpUC", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("53181e47-eb35-4989-b562-6f057f3e09be"), null, "user15@example.com", 1, "User15", "$2a$11$/fQLkjmNCxtgiivEQlXk8OzbGFCjQjWrx5KCYv.JEcKp7rK6/Aqg2", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("53d27349-23f6-44d4-8f6a-417c50d9e3d3"), null, "user87@example.com", 1, "User87", "$2a$11$hPs6HZppOARl/XlFhPkAL.GzN1DEaEU6339mAwuKIs4S4nif.LkLG", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("5a1ce0eb-2691-4349-9887-786f63f28185"), null, "user44@example.com", 0, "User44", "$2a$11$x0/i5qVUxSiF28PKgk5Zm.fDl.qUVfamkkCHvcASd6SPYeittJzeG", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("5bd40dcd-9f32-4186-8e93-53a73cd73298"), null, "user7@example.com", 1, "User7", "$2a$11$4KnChaptN/Q6349RjgopFOV7oMad0vLJUqM1ggOxLMIdhKJap67ci", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("5e20b2ff-e3c4-447e-9367-dfc7d66c00f4"), null, "user86@example.com", 0, "User86", "$2a$11$Thxx8/qFDKHCatpvLbk/peUaGe/KK87gu4NGG8UQVSnpmXOoZPCe.", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("658e2a35-d866-415e-8ca8-1c7acacbc576"), null, "user21@example.com", 1, "User21", "$2a$11$QZPMJV3/ooMmSJStKIMcEuPOSe9T5r4RKKCmB5EQN/HrA1.rI2WGC", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("673a1f71-b6ce-4267-93ce-346d5d189093"), null, "user90@example.com", 0, "User90", "$2a$11$QiurAznfraMZKzcmnN1X.ul7uGAJ3v6JK.Z98mYkftQu9EgzLYDXe", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("6a52f2a2-1101-43b6-846e-801971f24dfe"), null, "user41@example.com", 1, "User41", "$2a$11$irCP5nCRjgDxGItAPrjeTeBFVqlKBkRxi5660pW2ti4/U5NxsCQie", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("6b959e7b-ac95-4987-af9e-59974b6db6fb"), null, "user76@example.com", 0, "User76", "$2a$11$PSuwsUlyDPRc0Op1nPuma.jzIqNQmU1VQtg.e/y6x2yzGOjfHGJn.", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("6d0a6a72-487e-4c17-85b4-5f2a82252ea7"), null, "user1@example.com", 1, "User1", "$2a$11$MXZ8A37oh.4vhFmImEaH/uMy61Mqlh402M8fVstN6OLykHGB76QFa", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("6dff57dd-af3f-4b68-8207-bfc9c5f49ad2"), null, "user48@example.com", 0, "User48", "$2a$11$Ap4QDP5pJpyAlA5e0hUxRubzbdhRrWnHjgLs6oX5fTZDTt0jR/YWC", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("71399692-0547-46ab-92d4-ccb7b36661a9"), null, "user16@example.com", 0, "User16", "$2a$11$5NSM.cKp695rFlsYd0CYuuIEVDuUjWMFriQMQNrnY4HdP7wRab2eO", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("71fd97e6-76a4-4cd4-82e3-6ea9f03e0a53"), null, "user75@example.com", 1, "User75", "$2a$11$DQGyFBGhGLwvxDL3euCsj..e4ZyNcW4MwTOFkjXJ9B/aXG4Mz6eS2", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("74b58697-0ff8-46a4-9e42-7f22eea31331"), null, "user6@example.com", 0, "User6", "$2a$11$lJILu9XW5EvK56Upv6obROdETgxSaY6hwrzKxv3.WRQGoDGAfkVDW", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("74d7af56-258a-427b-966d-def5dd9b1fd2"), null, "user22@example.com", 0, "User22", "$2a$11$ZyYGuFPsDXGsND20aXrLWeul5qPCkJ7otRbTsZ4eMriRDOgFSq8Vq", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("75052669-63ee-4476-a130-76bcc888b0f3"), null, "user4@example.com", 0, "User4", "$2a$11$RGBiYp4RiH4jsi5uxFrCZOvzretlm9GnieUGDGrXCHfgdnxmPv2Za", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("762faa5c-14d6-4482-b188-0b7d1d4c5e0f"), null, "user70@example.com", 0, "User70", "$2a$11$UZ0WZ3kTyGTuEFjPIMt8cuEe2lW1gn7L9llkCDH191V/IGma4MJju", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7732c733-d67b-4bac-8779-d409e743e338"), null, "user49@example.com", 1, "User49", "$2a$11$SJUVCp.ao.K40mliD7lUWudxWTjxboepHHQKbPegpE.jx1sgA6reO", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7a025f28-7e82-4315-87c8-ce868a051f01"), null, "user43@example.com", 1, "User43", "$2a$11$MTEQdYiw3OH8VjBTvERIm.euDWhPvzOD9DN3ofJEqdg6Sg/sPpVAO", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7b60af1f-ee48-4ee0-9589-3e91dd89dbfe"), null, "user17@example.com", 1, "User17", "$2a$11$D8Pk8X.qJ.Vixp2Px4WLoO/sFz8hI16OiyRt6CR7d3P8HvUNxk4UC", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7d02d1ad-7c51-4edb-b70c-6585283e22e8"), null, "user72@example.com", 0, "User72", "$2a$11$LHHCgJGweoH0xNqBbmKOMudumK.fRMCLw6RBye86jcehhFI8w7seG", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7d925875-90e8-4cf4-b363-519e083dfa85"), null, "user58@example.com", 0, "User58", "$2a$11$aFoFlwLy8yXuJ8OEH7Fw/OVscVHeoiToueh3o2I6oEMmEmY2/ho7m", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("82a2bc20-bb3a-410e-9186-738c374b52c5"), null, "user82@example.com", 0, "User82", "$2a$11$6YwOFjItvQN1jCuZ6yxULOgJCA9Lk1A0W59RJ20I88V.5g6chIbnq", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("844e9f8c-6439-4007-988b-3879ba374ed6"), null, "user9@example.com", 1, "User9", "$2a$11$yGvYtlJ/DcdP94A1Qz3HSuXV7k9fScAOSYxMXeSRAmAg5BascF312", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("84bb8797-a710-489e-bea2-a9977218506e"), null, "user47@example.com", 1, "User47", "$2a$11$RxSvpquU.vIIuzIMf.iz7ew8wIt7MyESjs4c91OtCky8uJZFFfTby", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("85307d58-453a-4bbc-bb5d-2e1f568959f4"), null, "user93@example.com", 1, "User93", "$2a$11$JguvblN7O9ihUYlOAG2ZvOBksthCTZ63smYx244N/FkiOGa2txpoy", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("88f5f733-fc9d-4f24-af03-7be07739e880"), null, "user71@example.com", 1, "User71", "$2a$11$38WGL5w74jtLb5/u9TofEOMz8cJhn00hX4ALl.GMs6o92AVpod6je", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8ac09b52-4c1f-4ac6-a794-e3a9d98ebd23"), null, "user36@example.com", 0, "User36", "$2a$11$s/h1RsZEjwvULhYjOwbI.euVJAVLaqQs.rywr.b.b/Rh2Q.nXn/Ke", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8bc2ca6a-ad75-42fb-814f-f8974e28684f"), null, "user19@example.com", 1, "User19", "$2a$11$D3JkHgF9WRR8vOsFDxYOi.8pyfy35W0MBcqmcl6A8cY.lccCiFGqm", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8d5addec-fbe4-462b-be3b-6f6cbb885e99"), null, "user81@example.com", 1, "User81", "$2a$11$4yLwcsOoI7AFhCtZ1ObShOk6TFlhZGiPqEcRtbR2GqJsZXbVZsfce", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8f64e036-b311-4ea3-9ac1-e97338c7452d"), null, "user74@example.com", 0, "User74", "$2a$11$F1gJTUH10X3K.TANrjtOLuavFllNispLE0Bog2cW5vsjMABelNaSO", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("9515dfe0-92e5-4d31-bed2-1e30f3a63e0b"), null, "user12@example.com", 0, "User12", "$2a$11$i9WVb.L8Qs1w10BACZ1tmuKjqN7V3/JReM9khE0uQUq9Tk3CuPzOi", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("95bb8593-37ab-4467-bf2b-e4c9749aa64d"), null, "user46@example.com", 0, "User46", "$2a$11$P5WeZr0s5vKOX0yUBlGYuemjagdQkl.RwTwVp5b3PC0KIa94.RrZi", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("9b98d26f-fd26-41cf-817a-3ebf46aac29c"), null, "user77@example.com", 1, "User77", "$2a$11$TUMur8mQ/IPFPcpnGpF8RO7.HP4MU93v9u/bANwRQvuMIibW1510C", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a1d6cda1-a504-4413-8840-5f57d05582ba"), null, "user32@example.com", 0, "User32", "$2a$11$arWfo/.IJRaFoxkOkW3ODe0Q4S1x1Rt4pAhVcRGtBF2dmHFMynueG", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a4b505b3-d661-4ab4-a084-0050a4dcc7de"), null, "user69@example.com", 1, "User69", "$2a$11$6NliKwxS1lp/IJeXqcfBXeD1D47JH8nS1BGl0najLJs9piKgbwab2", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a9a4614e-f824-4c98-bb78-3ed2ca386f69"), null, "user78@example.com", 0, "User78", "$2a$11$vLlkdCiad2zCt1qLvceWI.Vpm51Ojpuq/Zt5Be.V1vpb9zTIc/vSi", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b02100d8-0eee-4e5e-89b1-1ad9f5c362e8"), null, "user10@example.com", 0, "User10", "$2a$11$R1Fu0A9j0TVE6d8n9sH8.uBQeXYLRSxzG1lp5rAqzZ0wpM/kRoDni", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b406d255-6fb7-46e9-b9cf-671639cad48f"), null, "user5@example.com", 1, "User5", "$2a$11$LZiQsNzCL.ob4uywIwIaruXAp/YvNTisyHQM/sXB3NLIEcuOR7Wke", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b4ab34a2-d3f1-4015-a046-9ff2d19f40eb"), null, "user80@example.com", 0, "User80", "$2a$11$5X.modgE.B34ibEYrDAsW.sMQ7.K8/1miW3QF1Ju0lNaNWwMavpvm", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b536ff63-308e-4d0a-a8c4-da7a22882819"), null, "user35@example.com", 1, "User35", "$2a$11$f8PLc1PO90hXl1Vz2Lm1L.ASLmBJZgXDvW5pi7pOibKvTh5i.N4gW", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b5ae7c19-fc35-4fe3-89e0-b38c0f5f7b35"), null, "user30@example.com", 0, "User30", "$2a$11$P1mkICmunO0DoWhFHNRG6O3.O0JF1mfnbKlJKiXS4qYXP2FxMtw1S", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b62a1125-3a23-45f8-998a-3174de08f0d2"), null, "user67@example.com", 1, "User67", "$2a$11$1eKJxLdG3uOFw1/.tyc15uWIf9pjVt7CQOzx//WU5EXSyOemxvxNK", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ba5fcbdf-ccd3-43ac-a4d2-8942e1c6054d"), null, "user51@example.com", 1, "User51", "$2a$11$mnIW4x149kX7EkcVd0jtpegVHWEdHwgvcx.p55Rba3K0scui3rxji", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("bae48760-78f6-40f4-9d22-a41ed3434a26"), null, "user24@example.com", 0, "User24", "$2a$11$e8lxfdj7mLVeXFYpI6r5B.d.kvo91Ei3uOAXQLeAbDRjSTdSNqTfS", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("bcddad32-a1a2-4e7b-8ebc-23e4afae7b8e"), null, "user33@example.com", 1, "User33", "$2a$11$oNUU52j1dndpnQSl2NmUtekb6kWtRuBOop5RLqNzjzeolKnKQSNay", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c0c4a00b-84f0-4257-b8e4-a27d913ccb36"), null, "user50@example.com", 0, "User50", "$2a$11$ogf7TQ8D42H88hqu763XmuejbW0RAWoguKPCksB.6V2f8cPN6xG0i", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c182d72c-c478-450f-9f50-83a748ab7947"), null, "user29@example.com", 1, "User29", "$2a$11$J/26MoM8byV4aSoOfTbI1eZYiRoZ2Axa.E.d528RO0BNq/4s6eZ9S", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c4834789-b269-4405-af6a-c23fe65c0572"), null, "user3@example.com", 1, "User3", "$2a$11$Vr.f.6K7VrxY.rlk3EKL.umPWoH3BVQKaSmUhL9X22ZH8C7/ZHRrC", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c7561edc-4363-4aa9-8b51-55984d381836"), null, "user89@example.com", 1, "User89", "$2a$11$0.yWmFdq1az3EUKn38Zs0ueB9XbkziY7ZJdsB.AkgJFVYVs4qzZ.i", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("cb63da90-529c-4103-8e49-50599e0a0d1e"), null, "user34@example.com", 0, "User34", "$2a$11$7i9Kz4FL.S.q8ok6BOueFOXzeKEdViiZEB6pieSSWF3Av7/tzjwne", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ce83cdb8-d31e-4be8-9822-de04f61f8557"), null, "user61@example.com", 1, "User61", "$2a$11$NX9ZqTsVcYztro3exgTgfus8bscK8svCHJM0lbfCqLUV0wEtJms/C", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("cee9c3a9-fb5d-41df-95a2-848c55334b0e"), null, "user53@example.com", 1, "User53", "$2a$11$WlRnwDCJO1rv6lP3B70aMuSjaofl/p/jmONOq4I2E0BRqpOsK/xWe", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d1bf0218-2069-4def-8d1a-329b69ca6951"), null, "user37@example.com", 1, "User37", "$2a$11$qLxjJ1WQdLGob.ZlUG2RKeETzxXF7xB/76gzM1dAUks692JS/Ia4W", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d3b873a0-168f-44ac-a7ae-ce3b0f0b4aa4"), null, "user79@example.com", 1, "User79", "$2a$11$DqN60S3.Iqpjq.ZjjwISk.5DDRiRVD8MSz2beytkZOK0uGmMZniN6", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d534ae92-f3a6-44d1-875b-4852e5b84bf4"), null, "user98@example.com", 0, "User98", "$2a$11$vUFzPazUCo1BQJ0TY.wZ4.7aYMDHJsxoiNXE1CJLGlmCAuoRTzP4y", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d808b07b-c541-464d-a0e2-41d959e6c1ca"), null, "user64@example.com", 0, "User64", "$2a$11$heUpEX8FRi6.ODm7tclvoudCXs8Zp3cSS1J2NQ6AdmOKostwCmr.i", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d8e9d61b-deac-4607-b18e-10c07b2ef88d"), null, "user59@example.com", 1, "User59", "$2a$11$yirBdCY67nhWZqQz0umdduFfN.SeqjaYOgGYrOR0yfr4UYnysfVPa", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ddae715f-98e1-42c3-8df3-07b2151029f2"), null, "user11@example.com", 1, "User11", "$2a$11$snjdilyf9RM9Y2FJww93ReePRjR8llSItBzJBg3OZXf1jVzd9Ylue", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e03d5988-77dc-4c28-9d19-1e1634d7fd15"), null, "user26@example.com", 0, "User26", "$2a$11$qAGLhKAUvTnI6ZntJPre1uAHrnr0OwWs9GLHQPb9j5f2k2QCP9z/S", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e06b95d0-b2c1-4c07-920d-21bf3ad21b4c"), null, "user57@example.com", 1, "User57", "$2a$11$TUv9twf9a0X.jvTSrRl4quY.zOW8SxUJ04Fsa1vO2qQdXtkwgSABS", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e4440fa8-e56e-4cda-ad5f-cd04b96bbe67"), null, "user28@example.com", 0, "User28", "$2a$11$lsJZ4.dwlJUZlwUyD/x/yu2KDbAIdAFu6Y4O33JOCui8Zlox/t1hC", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e9c5ead3-9ecb-4b31-a941-aaa71918aabd"), null, "user92@example.com", 0, "User92", "$2a$11$lX8GdrUIqDYC7yepMrEbVuEa1.D/mFDvv0vfqtFHpPWz6PgVeRjLC", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("eb44f048-8604-40fc-abde-c0353238ea64"), null, "user85@example.com", 1, "User85", "$2a$11$R542/eKJguRaJ3hp0XWXleSyDcdNK0JEUsmyygA5s/9nhy6Z4/LqS", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f0186f16-0494-447e-9504-d5e3c81731d1"), null, "user52@example.com", 0, "User52", "$2a$11$GglaJddO5Io62dKaUUMeU.GjM9UzC33cvBfqxdfZbJMy5HiOsXYM6", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f3a28da5-0106-4a55-9a6c-3836237686b6"), null, "user13@example.com", 1, "User13", "$2a$11$y8AIU5z.RltGfzUZB4gAmefb27CnPz5agUTzdjhe8BZzosxcLTzw.", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f3edd59e-a94b-4c54-aff3-207c9122fe50"), null, "user95@example.com", 1, "User95", "$2a$11$nj8ru5./afzMnpMHhHfaqOmD3/Fjo9ihwjb3BkxoU6grOJ67mQf5.", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f6daa30a-1e61-45a4-a5b7-bfedd11c3734"), null, "user25@example.com", 1, "User25", "$2a$11$fwfPt30zUJbVwBsq0E02YOmF3YsUTxpoQMg9wH6r1qtadzM9CLVUK", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("fb2cf406-f302-430a-aa2c-672135b1db5a"), null, "user55@example.com", 1, "User55", "$2a$11$/PFV4AUsoUGoQNAz0.jXN.2WGP91PQq3WUBvrWj1jd1TpNAr6CWua", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("fb2f2888-1e9c-4521-8a29-ec4efde60b33"), null, "user27@example.com", 1, "User27", "$2a$11$O1Zicz7eLUG6sXSLVsBfuO.kwuZsVaOmCxC.Xf9hjzwqziK3euscW", new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "IsAdmin", "IsDean", "IsStudent", "IsTeacher", "UserId" },
                values: new object[,]
                {
                    { new Guid("001caa23-7d2e-4476-849b-a4c6428ad26c"), false, false, true, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("02dddc9b-88df-4d82-899f-41c3205b96dd"), false, false, false, true, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("0404b3a0-e920-4f29-a0e7-e48e2d38575f"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("062d546a-3eb0-4e6c-9c1e-fa1f8f2f07bb"), false, true, true, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("0aed60da-6cc0-4c44-a0b2-b4d7b248078c"), false, false, false, true, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("105ec760-bb4d-4b96-8696-5a437a028d10"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("122a99e2-9216-4e7e-893c-26e358d4e7ba"), false, true, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("124c74c3-018b-4e63-bd9e-070a06cf087b"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("176c23d3-1b03-4fcc-b1fa-a22b3e60b455"), false, true, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("1b63f99d-6385-4faf-a2e2-006102c61549"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("1b67c649-4f90-464d-8adb-b57f58a1d6f1"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("20473cfe-6186-484c-b975-75c895c43dac"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("233cf2bd-2a8d-4dee-baec-6a6ae0016c35"), false, false, true, true, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("23e79af6-ab1d-4870-aaeb-4b24350cda3c"), true, false, false, true, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("250aa675-97de-4740-8493-99e59e7f4f76"), false, false, true, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2f3c1f5d-5f89-4086-b1ca-e1cd0e92cae4"), false, false, true, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2f4bdd6f-a00a-4827-9c09-2d70531dd958"), false, false, true, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("3019593a-8242-4b46-ac24-29acc6387ca3"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("33516248-0a4a-4062-963c-ddb1400766e8"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("348f2454-29fe-4074-8562-9b5e815b1866"), false, false, false, true, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("36bd800f-b289-4996-9b17-fbf422747dfc"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("3aa703d6-a480-487a-9d98-f048f0135a40"), false, true, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("3bcf4929-0652-46a4-a682-ddc5da6df338"), false, false, true, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("3cf3ed25-ba6c-4241-bfec-7728f6650e28"), false, false, true, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("420b8d7d-9473-4bd7-929d-8cbd02f7baab"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("447d0a21-3aae-45f6-a5d4-5f43cfadc888"), false, true, true, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("44e57b57-2852-4522-8554-a009f449ad0c"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("45eabb94-a20b-4493-b84b-77cb89ea5a07"), false, true, true, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4821136e-d778-4a09-9840-079aa8643a06"), false, false, true, true, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("49bd9d52-73e9-43e0-bf01-3f155c4989a3"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("53181e47-eb35-4989-b562-6f057f3e09be"), false, false, true, true, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("53d27349-23f6-44d4-8f6a-417c50d9e3d3"), false, false, true, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("5a1ce0eb-2691-4349-9887-786f63f28185"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("5bd40dcd-9f32-4186-8e93-53a73cd73298"), false, true, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("5e20b2ff-e3c4-447e-9367-dfc7d66c00f4"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("658e2a35-d866-415e-8ca8-1c7acacbc576"), false, true, true, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("673a1f71-b6ce-4267-93ce-346d5d189093"), false, false, true, true, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("6a52f2a2-1101-43b6-846e-801971f24dfe"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("6b959e7b-ac95-4987-af9e-59974b6db6fb"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("6d0a6a72-487e-4c17-85b4-5f2a82252ea7"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("6dff57dd-af3f-4b68-8207-bfc9c5f49ad2"), false, false, true, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("71399692-0547-46ab-92d4-ccb7b36661a9"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("71fd97e6-76a4-4cd4-82e3-6ea9f03e0a53"), false, false, true, true, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("74b58697-0ff8-46a4-9e42-7f22eea31331"), false, false, true, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("74d7af56-258a-427b-966d-def5dd9b1fd2"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("75052669-63ee-4476-a130-76bcc888b0f3"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("762faa5c-14d6-4482-b188-0b7d1d4c5e0f"), false, true, false, true, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7732c733-d67b-4bac-8779-d409e743e338"), false, true, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7a025f28-7e82-4315-87c8-ce868a051f01"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7b60af1f-ee48-4ee0-9589-3e91dd89dbfe"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7d02d1ad-7c51-4edb-b70c-6585283e22e8"), false, false, true, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7d925875-90e8-4cf4-b363-519e083dfa85"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("82a2bc20-bb3a-410e-9186-738c374b52c5"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("844e9f8c-6439-4007-988b-3879ba374ed6"), false, false, true, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("84bb8797-a710-489e-bea2-a9977218506e"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("85307d58-453a-4bbc-bb5d-2e1f568959f4"), false, false, true, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("88f5f733-fc9d-4f24-af03-7be07739e880"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8ac09b52-4c1f-4ac6-a794-e3a9d98ebd23"), false, false, true, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8bc2ca6a-ad75-42fb-814f-f8974e28684f"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8d5addec-fbe4-462b-be3b-6f6cbb885e99"), false, false, true, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8f64e036-b311-4ea3-9ac1-e97338c7452d"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("9515dfe0-92e5-4d31-bed2-1e30f3a63e0b"), false, false, true, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("95bb8593-37ab-4467-bf2b-e4c9749aa64d"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("9b98d26f-fd26-41cf-817a-3ebf46aac29c"), false, true, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a1d6cda1-a504-4413-8840-5f57d05582ba"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a4b505b3-d661-4ab4-a084-0050a4dcc7de"), false, false, true, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a9a4614e-f824-4c98-bb78-3ed2ca386f69"), false, false, true, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b02100d8-0eee-4e5e-89b1-1ad9f5c362e8"), false, false, false, true, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b406d255-6fb7-46e9-b9cf-671639cad48f"), false, false, false, true, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b4ab34a2-d3f1-4015-a046-9ff2d19f40eb"), false, false, false, true, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b536ff63-308e-4d0a-a8c4-da7a22882819"), false, true, false, true, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b5ae7c19-fc35-4fe3-89e0-b38c0f5f7b35"), false, false, true, true, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b62a1125-3a23-45f8-998a-3174de08f0d2"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ba5fcbdf-ccd3-43ac-a4d2-8942e1c6054d"), false, false, true, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("bae48760-78f6-40f4-9d22-a41ed3434a26"), false, false, true, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("bcddad32-a1a2-4e7b-8ebc-23e4afae7b8e"), false, false, true, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c0c4a00b-84f0-4257-b8e4-a27d913ccb36"), false, false, false, true, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c182d72c-c478-450f-9f50-83a748ab7947"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c4834789-b269-4405-af6a-c23fe65c0572"), false, false, true, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c7561edc-4363-4aa9-8b51-55984d381836"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("cb63da90-529c-4103-8e49-50599e0a0d1e"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ce83cdb8-d31e-4be8-9822-de04f61f8557"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("cee9c3a9-fb5d-41df-95a2-848c55334b0e"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d1bf0218-2069-4def-8d1a-329b69ca6951"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d3b873a0-168f-44ac-a7ae-ce3b0f0b4aa4"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d534ae92-f3a6-44d1-875b-4852e5b84bf4"), false, true, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d808b07b-c541-464d-a0e2-41d959e6c1ca"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d8e9d61b-deac-4607-b18e-10c07b2ef88d"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ddae715f-98e1-42c3-8df3-07b2151029f2"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e03d5988-77dc-4c28-9d19-1e1634d7fd15"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e06b95d0-b2c1-4c07-920d-21bf3ad21b4c"), false, false, true, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e4440fa8-e56e-4cda-ad5f-cd04b96bbe67"), false, true, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e9c5ead3-9ecb-4b31-a941-aaa71918aabd"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("eb44f048-8604-40fc-abde-c0353238ea64"), false, false, false, true, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f0186f16-0494-447e-9504-d5e3c81731d1"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f3a28da5-0106-4a55-9a6c-3836237686b6"), false, false, false, false, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f3edd59e-a94b-4c54-aff3-207c9122fe50"), false, false, false, true, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f6daa30a-1e61-45a4-a5b7-bfedd11c3734"), false, false, false, true, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("fb2cf406-f302-430a-aa2c-672135b1db5a"), false, false, false, true, new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("fb2f2888-1e9c-4521-8a29-ec4efde60b33"), false, false, true, false, new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Role_Users_Id",
                table: "Role",
                column: "Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
