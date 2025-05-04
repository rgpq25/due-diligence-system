using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace watchlistScreener.Server.Migrations
{
    /// <inheritdoc />
    public partial class FixPaisesMigrationandAddedEsActivo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("00620db8-f9b7-440f-b455-0fe7b0a68217"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("01d9f210-f02a-453d-a917-bf56491fc4f5"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("01ec4c4f-c48e-4dca-bdfc-b24c8bcbd983"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("04443509-2e34-4303-b26d-bf9ed611d4c3"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("0589819d-92eb-4621-ad06-e0501a005d8e"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("07960697-5ce1-4e5d-9e20-11fd06a6ebb8"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("08f7e5d5-9379-45a6-bb4d-64baa36e9ad6"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("0a2a3596-7062-4c70-9ff8-d2e89dcd467e"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("0b99b7f2-b01a-4296-bc62-4ce98d8497fe"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("0c2b259a-3587-4b39-84d3-231e0742ecce"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("0c580693-ef58-41ba-a012-1de1371e729e"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("1042bae8-3ac0-40dd-a043-2fa0d7e1e45d"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("1055379b-9e39-4b0f-82e5-46520c6f058a"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("109bcf17-d5a2-4df4-9215-a019010c73d6"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("11418284-7934-4056-8be9-179650fed93d"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("11c44856-7a8c-4883-a621-1cc20024af08"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("16265cd1-f1b1-4747-a217-f7ce279571f3"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("162f3a5c-b5b7-4e79-90c3-591d5a36fed1"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("16974e0d-cf4c-4a3d-8e43-29e72a9dd12d"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("17bc389d-9e34-49cd-b136-a96b0dcd13e6"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("190aa0c3-6274-494c-a2d2-b6bc18581d18"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("191f316b-e767-43b2-b65f-d876f0563f99"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("1935727a-a121-4550-8625-cbb12e5edc26"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("19598843-6b3e-444a-964c-7d21020d97a2"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("1e08fa95-27d0-4556-b6a6-70145adff27d"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("2011ba9d-279c-442e-afa1-c3557b2563f2"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("24ee5e70-cfe6-46c5-adde-789872807b42"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("296e6471-bfc0-4e29-b8cf-57f84e6ed8e0"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("2b86f30b-eb8b-4d89-a92a-38fd76438b34"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("2e187b9c-2fb8-4a06-98c8-9d7799f992c0"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("2e28347b-0c1a-41f1-8acf-7db104d559fe"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("2ed8f913-0cf0-48b1-a5c0-77bd36942046"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("2edf66ca-526e-4549-ac79-e9de8424458c"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("2f76d88c-cf1f-4637-859d-6b4c2b19d55c"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("326d1da6-5ab3-495f-887d-ea6d2ff3f8a0"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("32c3c66e-1752-4765-a030-203f599b89ea"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("3396adc4-901d-47fc-9d14-63625516cd9d"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("33a1dcce-2354-4ef0-8b87-02160ec44b59"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("36a320c5-04de-49d9-a2ca-4553ccd65955"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("38719d2f-0d6b-44e7-8380-5d999c0b17ab"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("3b28bdae-d908-478b-9a15-3ca8200ec7c3"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("3b424961-94d6-4c7d-a784-77d2ab5a6b41"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("3bf7a124-83e1-45a0-bee7-d421b895a430"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("3c2f1cd7-ee8c-479a-90fa-ec7451ce61b1"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("3da12317-f88d-4127-a26d-68845e4c2888"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("3da5152e-dbfd-4b1f-8c11-b04ac3859bbc"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("3e3e624c-bff2-419e-959a-16449340ddb1"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("3e3ecd33-5d54-4aef-8fc8-067250f11152"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("3e3fdee8-5467-419e-97c1-2581e5e0d767"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("3e7bd1ba-3563-417c-8054-10800148a55c"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("4098549f-d7ee-4b11-ac84-92e9aba9bf9f"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("424214c3-b50a-487e-95da-db9861669a01"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("44765994-c197-4525-9bdc-7382f3effbfa"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("48997b6f-0d82-41b1-ab05-2fbc3302c96e"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("4be7749e-bf2e-48de-9371-1f70518de8d5"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("4f3cdf9b-9c16-4a40-8539-0c0d3c544a98"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("5148128e-fb06-4c5a-bde6-b339e7188299"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("517ebbcb-a710-48a6-8496-b4c51e0c8b86"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("532f0e0f-991a-4f6b-bf42-3e3dcc5ebdd9"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("54e7a3c1-1317-46f2-b0bc-2da6c3237be1"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("5525bc84-b82e-45dd-a568-4c607d58901c"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("55261cab-225e-4a64-ac22-562df80a28d0"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("56af8095-5280-4b04-a761-1c862eb5e317"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("583eadaa-b856-46d2-86a5-7ebe91dd6c9b"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("59505dec-cdf0-42eb-8b0b-c0e6aacda56b"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("5b30f591-20cd-4bbf-8629-c35fa10b2a2b"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("5b842a69-9499-4dc4-9be6-1ae1f4667f20"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("5d637d97-0c74-4a5b-bd40-b4a0ca154298"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("5e88db2c-9453-4535-9a87-e90103ee1b3c"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("5ff89786-52b5-4bb5-9544-00fbd045698a"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("60f247b8-1410-48b4-a57a-44852bc8e4da"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("616b4643-e363-4ba1-99fa-513ec353e523"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("616c2290-da9a-4981-b74b-675799c15202"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("620f215f-a521-4ac2-8f4a-bb16e124d022"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("625e7eb5-15c2-4e3d-9e22-e1e926db5260"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("64e752a8-bc85-4d44-85e9-ed079ecc7e04"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("65c4a624-e04c-4d13-894e-0046df0a20d7"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("68bab6e7-d3ae-4b7f-aa2d-942ed9e6e07b"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("68e0e3f6-45f4-4ff0-8eb5-f2a2a1ae55dc"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("694e0eb1-51d8-4af4-bde1-23ecbf36c63a"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("69b6ad75-c9be-45ac-a580-177af4793741"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("69d5bcb0-53aa-40fd-b070-dd2b04817a1a"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("6a10ccd3-0da7-47cf-af45-c80168ee3552"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("6b1d8329-07f3-4991-aaee-1194d0e929d7"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("6c182dbd-96ed-4e72-b5f6-916c7c242c76"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("6d48c7c2-a27c-40c1-b169-27cb3139e900"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("6defe922-f811-4afb-81e6-f66978e8d563"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("6e71e6b2-68a2-4f18-ab84-1f99c4eac6ef"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("70b0b318-4d6d-45fd-8f13-0cc2a0d4d539"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("71fd152f-3b29-4441-bc3b-9c7acad83150"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("72a3d1a4-f234-4bf1-9657-20c11f17108c"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("736b1c18-bda9-447f-8330-1e6f7ec3d996"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("76578cb4-2f01-4799-973b-5fe27eaabe79"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("76931b72-e30e-4f4f-b067-923739afb8df"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("7721285f-b341-4a7b-919a-fed7577f25c1"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("789af701-0428-43fb-afe0-de24a82454b6"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("78f044f9-8f36-44a2-86be-c824991fc2ab"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("7a034094-f00d-4f30-9b7b-910896f8b790"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("7b64b7a3-5142-4e71-815f-f9b2f06ea485"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("7d1132c8-b43c-442c-aad4-d35b47e54bf1"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("7d61e451-54a2-4fb8-a432-652ecf6418a7"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("7f45c0c7-8f31-44e9-8adc-9496d38cfe63"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("7fc62237-4a79-4071-9ac8-fad25f56a4f5"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("80252ed2-374d-4dc5-b643-404f09374057"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("81f56c9f-d0d9-483a-9ed4-c0f81fc5df65"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("82160f3f-3eb3-4830-8a0c-e85e9663d435"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("85eea948-ccb7-48ad-aa85-4598ee55d9a5"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("860d8823-e9ed-4c77-95f6-3683503dd322"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("8699e2fa-43e0-4ff8-876a-d3cd10f01622"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("8779375e-96bd-4e0e-a2f6-be7ba92dced5"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("883e7ba4-fdda-4320-a516-ce36dc79c296"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("89310a2d-89fa-4d56-b153-2e5f0731018b"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("8ad6460d-0d25-4c8a-aba8-867e01a22712"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("8b223ec3-8f0d-4990-b27e-8ba704180fa2"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("8d3fd64c-e0e3-4af3-9bcc-1a933985770b"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("8d595af9-1b4d-43ca-b204-2d6519872c93"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("8d67ab04-7154-42e4-b0f7-91ef81c87cf9"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("8e890c16-34fa-4f2c-bcd5-8fbcc60097c4"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("8efa8eb3-fbc6-4650-a56b-84df5c337e71"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("912f7edc-d547-465e-9c69-ae0be4735a27"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("913f7b51-cced-4b58-b039-dcd8b5fe7b70"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("91942d29-a42e-48c9-9b1b-80e44da51d31"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("91ec3c08-9581-461f-9b40-9455f529747b"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("93bf1334-4cd9-49fc-9f2e-3b461adec31f"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("94d8b720-3dca-4ee3-ab7a-3dc39696d689"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("952d64e4-bfee-405d-b199-52ee2c9248e8"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("97ac20f4-682f-4d55-85ea-585ef1ac6425"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("98615b67-67a3-4b57-8c2c-307ef4c2d31c"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("98b6c2a8-54f2-4902-bd82-6c7db6d11ad5"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("998832d0-6d7f-4a83-a4c8-245168eac2c0"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("99ff1e02-0769-4974-8260-2b014e15bbaf"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("9a52ed05-5af8-4419-88ce-80195ab24da1"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("9a703909-91bf-4ac4-a6ec-3c7b3ad9088f"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("9f106923-a7db-4b2d-bca4-50781d7dbec6"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("9f6786e5-68cc-491d-bc2b-e8b4df11aa23"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("a4183410-86c1-49d3-99ee-0f998fff8a86"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("a588d859-626a-40f8-99de-8cecee68e372"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("a5b34e39-9159-4dc8-b815-2d1d3d5e0def"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("a743201b-006c-4146-b1cd-8519f8086edd"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("a7876684-bd92-4242-be7a-7e8c321b9f11"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("a850ebd4-0c01-435a-a9c8-1e79532ca4e2"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("a883229d-ccc0-4567-9226-d4026b37fced"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("a99c4232-e2ee-4aec-946f-197b13dd2b15"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("a9ce8de6-d993-4847-861c-37b3afe19421"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("aa83f025-30a2-410d-bbe2-5d7906399efd"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("aca013ad-d8fb-4a95-9198-7680650c484e"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("ad40eb29-9906-41b0-ab1a-633a0d3fe8c3"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("ad682fc9-38e8-4924-b71f-35099b8005eb"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("aebed0ca-6b35-41dd-86b2-1fe0c3e93ea3"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("b1f47760-0828-4441-a18d-86ee965f9924"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("b2530d40-3e3f-4799-abea-99b2ed5e0343"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("b5257962-3670-4318-8f07-df3e6183ea3f"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("b69f48e9-0a8e-4191-bb62-9792d97d6aba"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("b8201ed4-fcf7-4f22-8cb2-fb0874b2f9d9"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("ba97cca7-a3d1-4d6e-9b47-85a0516b8fde"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("baa0fe09-d11c-48bf-a22d-92f131496b4e"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("bb29003e-c422-41a5-8bb3-02c6f6f7feba"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("bc0886a9-83e8-459b-98fd-5c880974b2fb"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("bd266a26-2edf-4e15-a5d9-293bcfcbe7b0"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("bde70f85-a357-499d-8e16-184998cd58fe"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("be87fe8d-02b3-460a-b77d-f7dd7298b522"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("be8e6c25-a3c4-4031-9ce2-58b0ff4c3a90"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("c04e0760-4057-402b-8d64-ba5474707e45"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("c0df7e80-8371-4bc4-a3ca-0f29e9e31852"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("c15e4b37-8f2e-44a9-ac30-e0e39e87c33f"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("c3f5086a-afe9-4e40-9fbe-e3cab08e0e8e"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("c6b53d16-c427-4574-a720-b061aa922534"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("c76be378-b488-41d4-a226-151cbbd10d0e"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("c865872d-b1d3-465e-981e-0107101a07c2"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("c9f99cf4-c7e5-4622-8cbf-a8b257289ca3"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("cb276fe8-d58e-4801-8887-bd68e1e30f2b"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("cbc53fbf-fff7-4405-8c28-074beda5fcda"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("cc8dea8f-acb1-4035-982f-df6353d9fd06"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("ccef45ec-8c32-4f08-86e2-5eb589401d1e"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("cd39cc01-c9cf-425e-bd32-84f9ca71bb36"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("d13de921-2711-49e3-9873-9d7e53ab715a"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("d18cd18d-0644-41c5-b4c3-f5eb186f44ce"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("d30043b7-9ced-41e3-9c36-6c07cd19ed7e"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("d35e78ef-aea1-48f0-bbf3-43640aab0e84"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("d3bd7890-a9e2-42e9-b3ef-f1dead4483ff"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("d4edc19c-542f-45ac-9fbd-20a9d96cb2e1"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("d565c05d-d54f-4e5d-829c-e01bf9fcd291"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("d5ddb81f-735d-4546-b9d8-29358bf49706"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("d7684d8d-3181-4ce0-8976-bc377cb1525f"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("d791ddbe-167c-4239-bb89-6ac9604f4404"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("d7fe994e-524e-45ef-895a-6f5b336216eb"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("d95fb4c0-9470-45fc-b372-72c3487a5d06"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("d98ace5b-25be-489a-887b-3648ed4aee7b"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("d9bb33a5-ffd9-4c90-9ab3-975262df3b0c"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("da3849a2-53de-40e7-b503-992844b17826"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("daaba39f-8b75-45e1-a0c8-09e7a9f94fee"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("dc39b266-7bf8-4f97-86a0-0caf818d7011"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("dc6e84e9-760a-4e4c-a609-2fe1862de5be"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("df8e6e02-877c-41b1-8592-ca670149f51a"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("e066f248-6d57-483d-a80c-809eaac3a49d"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("e0f0e607-135c-4b58-9ef4-22c6af85f9dc"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("e10b3793-39b8-476c-92c8-4a011d7441c2"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("e208a94f-1732-4599-ac61-ddc46686f357"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("e22402ce-a9f5-4ec7-b848-fbd8de296822"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("e5820efe-a599-4fdf-bf6b-10f94695a300"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("eae0d86d-093a-474d-8c89-b1aa4576bea4"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("eba1de11-faf4-4162-9052-041233f1044d"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("ee85b80e-e2c8-41ec-b702-e819841a00e6"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("f11da8b4-72b7-4a7a-8b19-e96417eb95e2"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("f2e33efa-6c4d-4b79-af76-ca11bc127216"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("f477f1b3-6e9c-4b37-aef1-391a84da01a0"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("f55ab587-7ed5-48b1-a546-a5bc632a83f1"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("f6e9ff0a-4902-4a01-90e4-fa66540f3364"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("f6f4d0de-553c-4277-95fe-23b3e9f21dc6"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("f74314ca-fda5-4f13-b387-dacd24746309"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("f91e2f8e-7ced-4d1c-a7a9-ff0bd84288a4"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("fa7a9f5e-a42a-40ea-b117-4743c03b3841"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("fadfd2ff-c307-41ff-9b47-bdd986af8060"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("fafcb720-3e0d-4e64-8abc-6425b847183a"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("ff24c00e-19f6-4b4c-9e34-4ca771af34fb"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("ff2b29f5-f4dc-42b7-b70c-27f24b94fb58"));

            migrationBuilder.AddColumn<bool>(
                name: "EsActivo",
                table: "Proveedores",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Paises",
                columns: new[] { "Id", "Codigo", "Nombre" },
                values: new object[,]
                {
                    { new Guid("00a8409f-00b8-45b3-9608-d2fa873e19df"), "SY", "Siria" },
                    { new Guid("00c50a5c-a946-4c33-a676-37ca6ae3a150"), "HU", "Hungría" },
                    { new Guid("0120084c-03ce-4c5f-933c-7a45f617162e"), "VI", "Islas Vírgenes de los Estados Unidos" },
                    { new Guid("029bb73b-8ad1-42c2-9cf3-a4974ced857f"), "FR", "Francia" },
                    { new Guid("02b6a498-28e1-44f4-945d-caeb78e0a37b"), "GW", "Guinea-Bisáu" },
                    { new Guid("02c4d95c-7830-4fb6-bdce-bae508943b43"), "BD", "Bangladesh" },
                    { new Guid("04887b29-7bc2-4935-a268-e67388d58601"), "GR", "Grecia" },
                    { new Guid("04f3b16d-5437-4f09-bf7a-8c9452cbb0f3"), "XK", "Kosovo" },
                    { new Guid("069abf71-8422-41d2-8f4e-3d2802d27718"), "VG", "Islas Vírgenes del Reino Unido" },
                    { new Guid("07065449-c9e3-4446-b661-47ba6ecb519a"), "CI", "Costa de Marfil" },
                    { new Guid("0cac11f0-8f91-44cd-8834-c0ea96c84e51"), "MM", "Myanmar" },
                    { new Guid("0d78fe0f-8d67-4251-af84-6a3ba46da075"), "MZ", "Mozambique" },
                    { new Guid("0d7ddd52-ca3e-4834-9bf8-21dddc6a1420"), "GG", "Guernsey" },
                    { new Guid("0ff78adc-3558-4fca-9458-aa86c0ea6bf6"), "CL", "Chile" },
                    { new Guid("11253029-0ae2-4fd7-829d-b3cf260b4039"), "CH", "Suiza" },
                    { new Guid("1192cc02-3920-4064-8f39-6bdf2f14d0df"), "IN", "India" },
                    { new Guid("14afd52c-dd47-4cc1-8161-9debfda7c2be"), "LV", "Letonia" },
                    { new Guid("14f99c1a-0e1d-4ab6-b10f-ee10d797f670"), "SM", "San Marino" },
                    { new Guid("153cb824-dc40-42af-8e45-fc7c46bb1d02"), "MA", "Marruecos" },
                    { new Guid("15829374-c08d-4eb8-b269-0c1ed852eab6"), "TJ", "Tayikistán" },
                    { new Guid("15e32b42-0163-4af4-9cd8-e960030331f2"), "MD", "Moldavia" },
                    { new Guid("16948ff4-180c-4b0e-ab76-60ecbcdac946"), "IE", "Irlanda" },
                    { new Guid("16f45316-7e79-4198-9a6a-4796efa5dfb0"), "GM", "Gambia" },
                    { new Guid("1824dce2-8efd-404f-868e-7e11bc8d1f05"), "CZ", "Chequia" },
                    { new Guid("1891068c-b50b-4ca0-a566-7b96b00a973b"), "RU", "Rusia" },
                    { new Guid("1b957d4f-3c7a-4678-bcab-ff3bb51ab273"), "GP", "Guadalupe" },
                    { new Guid("1c0950cc-064a-4739-abbd-a459c0da2d7e"), "VA", "Ciudad del Vaticano" },
                    { new Guid("1dc6d671-c094-4847-8d50-8f6d66d2dc8d"), "QA", "Catar" },
                    { new Guid("1e8b932f-4e1c-479f-b5c5-2791e42a4271"), "AQ", "Antártida" },
                    { new Guid("20349fa7-5805-4235-a554-f183270decac"), "TG", "Togo" },
                    { new Guid("207af4eb-9c90-47b3-944b-9710962f0f59"), "KW", "Kuwait" },
                    { new Guid("20847316-f585-4844-b923-065e830a56b1"), "SE", "Suecia" },
                    { new Guid("218f28d1-55f2-444d-8b75-cf28fbe8cb3d"), "BM", "Bermudas" },
                    { new Guid("2555f2c8-3435-4222-a344-eaffe17aa3e9"), "SC", "Seychelles" },
                    { new Guid("2642b83e-d9de-4b96-8d33-10efd24d1f86"), "MH", "Islas Marshall" },
                    { new Guid("269bf09e-d69b-4c92-a05b-6593e2b7f237"), "TT", "Trinidad y Tobago" },
                    { new Guid("281ed329-46ef-48ca-88e6-86fa9d7c9241"), "LK", "Sri Lanka" },
                    { new Guid("28305b90-df96-4773-b37b-5f4694654e6d"), "EC", "Ecuador" },
                    { new Guid("29d8db58-2e81-4ceb-b101-95ebb674ac95"), "UA", "Ucrania" },
                    { new Guid("29e79e81-6f2e-427a-9e30-eb7731402146"), "TO", "Tonga" },
                    { new Guid("2a6dac3c-03ff-40f7-8db4-fc8b9b5f8aed"), "SO", "Somalia" },
                    { new Guid("2ad7003e-b983-4b11-965b-20c6513d199f"), "TW", "Taiwán" },
                    { new Guid("2c0f5675-485d-4a18-a193-9fa00d08fed5"), "NP", "Nepal" },
                    { new Guid("2d00b3ef-7d38-46d8-9b0a-44fea8c387ee"), "FI", "Finlandia" },
                    { new Guid("2e7bbffb-d91c-4805-a083-86f68b8871a5"), "SN", "Senegal" },
                    { new Guid("2eea36a2-3789-4829-afd5-c57171f5dfe0"), "RW", "Ruanda" },
                    { new Guid("2f0e9eee-8796-446d-a100-161e17b8b061"), "NG", "Nigeria" },
                    { new Guid("2fdf5051-8417-43d8-8377-d04f762ed602"), "IR", "Iran" },
                    { new Guid("2fe8bbe9-e109-4562-925e-ef7bbefff534"), "HM", "Islas Heard y McDonald" },
                    { new Guid("33cde7a3-18a8-40ed-ba37-a307bf2407ec"), "WF", "Wallis y Futuna" },
                    { new Guid("33def8f3-7561-4bc0-8098-d88c504dbf0f"), "PL", "Polonia" },
                    { new Guid("3563a719-2d00-4f03-85a4-59aad03c8c6b"), "RO", "Rumania" },
                    { new Guid("36735441-22b1-47f9-9dbe-f0dfe8a0d6a6"), "BE", "Bélgica" },
                    { new Guid("373d50fa-c345-4fe1-9939-add39624ceb0"), "KZ", "Kazajistán" },
                    { new Guid("374c01bd-db21-4b49-8905-6a9039cb7eeb"), "MW", "Malawi" },
                    { new Guid("38446f2b-c4f4-4755-92c9-76c8ed85761c"), "BV", "Isla Bouvet" },
                    { new Guid("39f2c768-5f1f-42da-b66b-7ff2a0414c5b"), "AR", "Argentina" },
                    { new Guid("3a37cf79-7e20-493b-97e0-704c89442ad8"), "KI", "Kiribati" },
                    { new Guid("3af6d118-322b-477d-9ec1-1ca337df03d4"), "IM", "Isla de Man" },
                    { new Guid("3c5d56dd-05cb-4c01-bac1-c9287131bb9c"), "BF", "Burkina Faso" },
                    { new Guid("3edd0bdf-ba32-425a-b7c6-4cce725df938"), "AW", "Aruba" },
                    { new Guid("3f625a21-ed15-4579-bbf5-55e477c3d63d"), "GT", "Guatemala" },
                    { new Guid("422574d2-85b0-4642-b7c6-c269933f5688"), "ST", "Santo Tomé y Príncipe" },
                    { new Guid("42532ddc-5daf-4954-9135-09b1143a45b8"), "TC", "Islas Turks y Caicos" },
                    { new Guid("42d33ce1-3fd1-4c3c-819f-3f98b57df15c"), "UZ", "Uzbekistán" },
                    { new Guid("434c1c8d-895a-4841-8203-c43fc93c46f9"), "CY", "Chipre" },
                    { new Guid("43bcebd3-1285-4a91-bf39-4a2bf50cabfb"), "RE", "Reunión" },
                    { new Guid("45b386f1-cd2f-4cf0-bb68-49a1ef970794"), "HT", "Haití" },
                    { new Guid("468c202b-b780-4688-bb91-e550de7c48f2"), "NC", "Nueva Caledonia" },
                    { new Guid("4a205056-87e2-445e-ae12-48f4b7ee57cb"), "DO", "República Dominicana" },
                    { new Guid("4b038013-9709-4621-ad09-158b94b9dfcb"), "ER", "Eritrea" },
                    { new Guid("4d845dff-b0d6-4421-b168-53b7226b69df"), "MO", "Macao" },
                    { new Guid("4f091e9a-d45c-4b79-8ea2-5097558ff5cb"), "PR", "Puerto Rico" },
                    { new Guid("4f41d0f2-d586-488d-bd29-de20c40d9413"), "PK", "Pakistán" },
                    { new Guid("50db5220-56ea-428b-9c6b-0553c3fdb731"), "SL", "Sierra Leone" },
                    { new Guid("5118c961-45ad-4c68-88e3-7da271c14878"), "DZ", "Argelia" },
                    { new Guid("53321c78-fbde-447b-b693-59ade948943f"), "IO", "Territorio Británico del Océano Índico" },
                    { new Guid("55366336-8325-4e95-8f87-d4e0d7d9a853"), "KG", "Kirguizistán" },
                    { new Guid("55afe1e8-b328-4128-bfde-e7dae803eb55"), "LI", "Liechtenstein" },
                    { new Guid("566607ca-be86-4601-b462-bc9b3acafd80"), "KY", "Islas Caimán" },
                    { new Guid("57797178-fb1b-45f0-907d-46069b57215f"), "BA", "Bosnia y Herzegovina" },
                    { new Guid("5803c685-e5ab-4a11-bafa-3b42a1efb827"), "MG", "Madagascar" },
                    { new Guid("5b996f49-b707-4698-8aed-a3051c0d5ce3"), "LB", "Líbano" },
                    { new Guid("5baf91f7-3b29-4725-b13d-76ba2a69717c"), "MX", "México" },
                    { new Guid("5d2857c3-6b6f-409a-869c-736644ce5eff"), "AG", "Antigua y Barbuda" },
                    { new Guid("5d7ba3ed-9cd1-4883-b36e-875598ab10bc"), "MU", "Mauricio" },
                    { new Guid("5e0c8ed3-cdc0-498a-a2e1-6f24916f1412"), "IQ", "Irak" },
                    { new Guid("5e6403b9-0935-46ee-914a-1ef24196e4a8"), "KM", "Comoras" },
                    { new Guid("5e880adc-708c-47c5-a13b-96674b2033db"), "PN", "Islas Pitcairn" },
                    { new Guid("5ee35fe1-ebec-4365-af53-abe6f7b9d3d0"), "AI", "Anguilla" },
                    { new Guid("601b7882-f107-47e6-aa6e-d115fb30ab15"), "BR", "Brasil" },
                    { new Guid("6197ab51-147f-4ca8-93b4-3ba072a8d5d1"), "NR", "Nauru" },
                    { new Guid("6256f092-a05c-4b74-b469-7ec6cc24a736"), "PW", "Palau" },
                    { new Guid("630f5333-8279-437a-a0ed-a52a7a2f2f03"), "DK", "Dinamarca" },
                    { new Guid("639a28d9-68e4-48d2-a250-81f08f9c0caa"), "CK", "Islas Cook" },
                    { new Guid("63a8f010-efc4-4cef-a764-d06d67270a95"), "PY", "Paraguay" },
                    { new Guid("64229f03-02a5-4aa4-a0e2-218a731ca34d"), "DM", "Dominica" },
                    { new Guid("66e213d8-b91d-42e4-a9b1-fefe3260670a"), "CX", "Isla de Navidad" },
                    { new Guid("66e678e9-c74b-45da-a472-f9807140288a"), "CW", "Curazao" },
                    { new Guid("69e1ba48-f092-4d22-9dcd-9a33618cbfc8"), "UY", "Uruguay" },
                    { new Guid("6a0f8edd-4a1f-4300-bb99-3510f5459040"), "HK", "Hong Kong" },
                    { new Guid("6b5b9c68-e859-4f2d-bb4d-75b993f4bafe"), "AS", "Samoa Americana" },
                    { new Guid("6d590ec5-2453-45e6-9a9b-195e4e235ce8"), "SB", "Islas Salomón" },
                    { new Guid("6da02812-b230-4f0c-bb2e-7d21a831769a"), "MC", "Mónaco" },
                    { new Guid("6fed55e1-babe-4e8f-aaec-85d159cc1202"), "TV", "Tuvalu" },
                    { new Guid("70292356-c3c7-4592-baae-edfa75446073"), "EE", "Estonia" },
                    { new Guid("711686c1-2d56-4c04-9982-8ea277a67aea"), "GQ", "Guinea Ecuatorial" },
                    { new Guid("73383825-49b2-4c25-8b6b-a63252092738"), "ZM", "Zambia" },
                    { new Guid("73636a54-ae1b-40b3-be87-4a7326f83d0e"), "TR", "Turquía" },
                    { new Guid("73e8e174-335f-45eb-847d-d5adbc7b1175"), "NI", "Nicaragua" },
                    { new Guid("74bd22b6-124a-44eb-8ccf-8ba1f6f4873d"), "ZW", "Zimbabue" },
                    { new Guid("75c928c8-0e28-4c88-95fe-d091fc0c16e9"), "SI", "Eslovenia" },
                    { new Guid("7664810d-6d79-4b39-9e92-10085e25f6e8"), "PM", "San Pedro y Miquelón" },
                    { new Guid("774ff9b4-1e84-4945-a0bc-98e7345f0e64"), "BH", "Bahrein" },
                    { new Guid("78eff79a-9abe-4d30-aa26-a776e7a7338d"), "GN", "Guinea" },
                    { new Guid("7943c322-79ec-4d98-b6d1-57d85fdf1419"), "SV", "El Salvador" },
                    { new Guid("7c37bc02-1b0a-4b0c-9c33-82c76310d175"), "TN", "Túnez" },
                    { new Guid("7c8c95b1-f1d3-4c75-a256-316161219ff3"), "AU", "Australia" },
                    { new Guid("7ebaeef6-9f22-4476-8bbf-9e524b028cd8"), "UG", "Uganda" },
                    { new Guid("7ef3a7a3-eb77-4028-aeef-c677f4cf907b"), "TZ", "Tanzania" },
                    { new Guid("7efda655-9102-4dc5-94cf-5064e65c0632"), "UM", "Islas Ultramarinas Menores de Estados Unidos" },
                    { new Guid("7f56a383-04ea-4842-b30c-fecf146737d0"), "LY", "Libia" },
                    { new Guid("805667fd-1e67-44a0-a30f-dc9f72ae89c4"), "CO", "Colombia" },
                    { new Guid("8061cf72-f915-40b2-90a5-77162068e221"), "BB", "Barbados" },
                    { new Guid("80698799-cb5b-48b5-898a-a255c230c6bb"), "SD", "Sudán" },
                    { new Guid("83d0ccdc-df64-466e-ba6f-34d9cf2a5176"), "VN", "Vietnam" },
                    { new Guid("83f50e3a-5509-428b-8a08-a45eb15791dd"), "MK", "Macedonia del Norte" },
                    { new Guid("8530bafc-b878-4ea7-a2d5-4431814f3551"), "CR", "Costa Rica" },
                    { new Guid("8603a574-0692-4fdf-962b-04d1b44b760c"), "MP", "Islas Marianas del Norte" },
                    { new Guid("866909be-b10e-49a0-abca-c2c0a356e5d6"), "SH", "Santa Elena, Ascensión y Tristán de Acuña" },
                    { new Guid("869cce88-fd7f-4da0-a1b7-c32aef105a94"), "IL", "Israel" },
                    { new Guid("86b50876-f375-4de4-8580-96141263748d"), "TD", "Chad" },
                    { new Guid("86d53d1e-b663-4006-9d3d-b6876e9f120c"), "US", "Estados Unidos" },
                    { new Guid("8a925b86-57e2-4e3c-999e-8f3d905be075"), "CD", "Congo (Rep. Dem.)" },
                    { new Guid("8ab84da6-fc1f-4a3a-82fe-617b5ecdefb3"), "TM", "Turkmenistán" },
                    { new Guid("8ab9442a-1eea-42bb-9f1d-bac0a98c1af0"), "BO", "Bolivia" },
                    { new Guid("8b31e921-c25f-4752-b8c0-5ce2e4531892"), "BZ", "Belice" },
                    { new Guid("8b8c6267-4333-451b-9b7c-b2c96ffcb578"), "NO", "Noruega" },
                    { new Guid("8bad89d3-11cc-4fae-a5a2-45ebecdf5a7a"), "BQ", "Caribe Neerlandés" },
                    { new Guid("8c75f8ef-1082-40f2-96fc-c2cc23d55c53"), "BY", "Bielorrusia" },
                    { new Guid("8ce4aa67-66a3-4aa6-b184-649aabf76802"), "MS", "Montserrat" },
                    { new Guid("8d7811d6-2ec2-4461-9bdb-f08b7a692a11"), "BN", "Brunei" },
                    { new Guid("8dca6c1b-feb5-4d4c-a2d4-33e0636c63e1"), "OM", "Omán" },
                    { new Guid("8dd49756-22e3-4fac-9f5c-aabd596ea313"), "GI", "Gibraltar" },
                    { new Guid("8ff46c0f-55d1-47eb-aa46-f99a37b31dd8"), "GE", "Georgia" },
                    { new Guid("9162e7ad-23d5-4aea-a95a-4c87d31e765a"), "JO", "Jordania" },
                    { new Guid("92826d7c-418d-4345-b0c3-8237572c3054"), "MV", "Maldivas" },
                    { new Guid("9382f873-94ee-4573-b81e-809392855612"), "YT", "Mayotte" },
                    { new Guid("9594cedf-a710-490c-b914-ce172bfa6ac7"), "KH", "Camboya" },
                    { new Guid("95f35a8a-3bbf-4900-b85f-2fae4dbba5fc"), "PT", "Portugal" },
                    { new Guid("968186d7-2ca4-4a10-af20-5af09c4fc5ab"), "RS", "Serbia" },
                    { new Guid("99e68782-dcdb-400b-a0f7-da739bbd44fa"), "ID", "Indonesia" },
                    { new Guid("9a123551-f97c-4f34-b30f-65d3e0bb4d7b"), "BW", "Botswana" },
                    { new Guid("9a44fa72-4a93-4dce-a096-2453c0487f0f"), "GU", "Guam" },
                    { new Guid("9c5402cf-a319-4a1e-85e8-0eca4e15157a"), "ES", "España" },
                    { new Guid("9cf7d04c-5ec4-44fc-af47-5c409a1f315c"), "DJ", "Djibouti" },
                    { new Guid("9da551ce-3e57-4490-bc80-24889e9944a8"), "MQ", "Martinica" },
                    { new Guid("9ded1731-afa5-4433-9b4d-a1b9ed1bb322"), "KE", "Kenia" },
                    { new Guid("9e4919f6-b01d-4bbf-a0e0-69a6214f9833"), "TK", "Islas Tokelau" },
                    { new Guid("9f46cb94-7ae0-4bad-b52e-480068158a6c"), "GS", "Islas Georgias del Sur y Sandwich del Sur" },
                    { new Guid("9fc8f54f-dc3b-4fac-bbfc-efc42c2b7d3c"), "MR", "Mauritania" },
                    { new Guid("a0274691-a232-4fee-9ddd-95567ad5c4dc"), "AZ", "Azerbaiyán" },
                    { new Guid("a0901c3c-4678-4610-9eb3-9208bdc078ca"), "AM", "Armenia" },
                    { new Guid("a1234c79-4c10-4cdd-937f-7c4b6d49075a"), "NE", "Níger" },
                    { new Guid("a131ea74-ce81-4381-9de1-d5be68cceb23"), "JE", "Jersey" },
                    { new Guid("a15973ac-edf4-4119-9506-51b693efbbd9"), "FO", "Islas Faroe" },
                    { new Guid("a1968f9a-0ed3-45cf-8cfb-f6c780c6b2e5"), "LC", "Santa Lucía" },
                    { new Guid("a2090c26-741a-44dd-9390-eafd92dba7c8"), "WS", "Samoa" },
                    { new Guid("a2e8040f-5bd2-4b3f-83a1-235ade7c6ed4"), "MN", "Mongolia" },
                    { new Guid("a33fbad3-b691-4d0d-be44-f0ea261e71a4"), "TL", "Timor Oriental" },
                    { new Guid("a39d656b-e536-48ae-8f0a-d0c6b1945c87"), "CC", "Islas Cocos o Islas Keeling" },
                    { new Guid("a3eb8a72-a213-43f0-ad6b-5b0811c1e458"), "SA", "Arabia Saudí" },
                    { new Guid("a47c6a19-82f8-485b-9783-5fa70d5da743"), "TH", "Tailandia" },
                    { new Guid("a4c158fd-32c0-4a93-8f29-002634ed03f3"), "ZA", "Sudáfrica" },
                    { new Guid("a69bdef2-29a5-4c85-8e34-5d4cfa57e302"), "LA", "Laos" },
                    { new Guid("a6d8e374-6543-48bc-a605-4838813b503b"), "AT", "Austria" },
                    { new Guid("a7388a5c-c1bc-4e93-bb00-fcc719edcbf1"), "NZ", "Nueva Zelanda" },
                    { new Guid("a7c29582-6cd0-4558-a81a-ad5a84f59ee1"), "CA", "Canadá" },
                    { new Guid("a85b7b9e-01ec-4b91-9949-e7cda02a5113"), "LR", "Liberia" },
                    { new Guid("a948a4ab-d495-41ce-a8ed-d0285b580f3f"), "VE", "Venezuela" },
                    { new Guid("a967c691-b6f6-4eb3-b531-e8d3b931ed1c"), "ET", "Etiopía" },
                    { new Guid("a9a1d7dd-9b7b-418c-aba8-cbcc500fb9aa"), "EH", "Sahara Occidental" },
                    { new Guid("aab51c5c-569c-4489-b982-166b8eb6548b"), "NL", "Países Bajos" },
                    { new Guid("aae84a38-dd8b-49d4-b245-764890a915eb"), "PH", "Filipinas" },
                    { new Guid("ab6505f6-6638-40fd-ab77-469e22dad100"), "SG", "Singapur" },
                    { new Guid("b0b6e57e-77fe-494d-bac7-2abda64f6954"), "GB", "Reino Unido" },
                    { new Guid("b0f1ca4e-641c-4bab-9c82-d68f53ffa097"), "AD", "Andorra" },
                    { new Guid("b1144bf7-6e1a-4f70-b0f1-7a8cfb1a6f9f"), "EG", "Egipto" },
                    { new Guid("b47c9daa-06c9-4ae0-9ca4-0fe3c28abc45"), "SZ", "Suazilandia" },
                    { new Guid("b4b7a40f-e7b9-401c-af4a-5e69b2b1200d"), "SS", "Sudán del Sur" },
                    { new Guid("b84ae9d3-6907-42fe-8fbc-a02f1280f2d7"), "AL", "Albania" },
                    { new Guid("b8bdc1d3-bb00-442b-9f3f-5da09739dfc8"), "HN", "Honduras" },
                    { new Guid("bb671c91-fa45-41f7-af49-7f6d8a12bf11"), "DE", "Alemania" },
                    { new Guid("bd7a5a70-3c7a-43d2-9ded-b6929ae86ff3"), "CG", "Congo" },
                    { new Guid("be15b58a-34ca-4be2-8e96-d89cdbfb9550"), "VC", "San Vicente y Granadinas" },
                    { new Guid("bf1414f3-e19c-4e53-9f24-02a5e24c9de3"), "AO", "Angola" },
                    { new Guid("bf415dbb-782d-4626-adfe-ff42d8cfbd5a"), "MT", "Malta" },
                    { new Guid("c14e9e64-4ab3-48e7-ba7a-eaa2e41736ac"), "BT", "Bután" },
                    { new Guid("c1f35f07-9d37-401a-b0fa-316c6b2309a4"), "PE", "Perú" },
                    { new Guid("c25fcfb0-7464-461d-abb9-770c7de86ed1"), "PA", "Panamá" },
                    { new Guid("c3483946-8c63-4f00-8bd4-a02f40d306e6"), "SX", "Sint Maarten" },
                    { new Guid("c3f71149-5baa-4b7a-91ad-0d5bfa10802d"), "KP", "Corea del Norte" },
                    { new Guid("c60af867-8efe-48af-85c6-94c964d2d3da"), "FK", "Islas Malvinas" },
                    { new Guid("c95887d8-1c90-4798-8957-c7aff0dbc181"), "KR", "Corea del Sur" },
                    { new Guid("cabb83eb-855c-4338-aca5-1771d2f32084"), "FM", "Micronesia" },
                    { new Guid("cb01d263-9d41-4092-8764-47991586effc"), "JP", "Japón" },
                    { new Guid("cbcb028d-002a-4a5d-b390-cf36a91de7f4"), "AE", "Emiratos Árabes Unidos" },
                    { new Guid("ccabb518-5ed6-42ba-9895-bbe60014f102"), "BL", "San Bartolomé" },
                    { new Guid("cdbc92ba-1fb2-4390-ae54-f210ef306fc1"), "BS", "Bahamas" },
                    { new Guid("cded149c-9541-48bc-9c75-7674dc7d1c39"), "BI", "Burundi" },
                    { new Guid("cef334db-e528-4fc5-8b4d-c7a2ee1fc6f4"), "LU", "Luxemburgo" },
                    { new Guid("cfb3f1df-6fa9-440a-b418-0e2528d50488"), "IS", "Islandia" },
                    { new Guid("d25296da-bad1-4739-9884-db73140fdb82"), "KN", "San Cristóbal y Nieves" },
                    { new Guid("d4b2eb3a-5967-4257-99a4-8ae21c876cdd"), "CF", "República Centroafricana" },
                    { new Guid("d5338524-6d3b-407a-8926-f7f8f703df2a"), "MF", "Saint Martin" },
                    { new Guid("d55d90ab-63cc-4c1c-a007-7c623c2b2fa8"), "IT", "Italia" },
                    { new Guid("d7a06de2-bbb3-4f71-b277-7a01200e0963"), "SR", "Surinam" },
                    { new Guid("d7b7e468-a1d9-408f-b867-4af60dbb4b5f"), "GH", "Ghana" },
                    { new Guid("dd426855-6952-4463-933d-a8658ee69648"), "SK", "República Eslovaca" },
                    { new Guid("de57c088-0e3f-40ec-b222-797d0e09cb02"), "GA", "Gabón" },
                    { new Guid("df891446-797b-4efa-a2fa-a9ea4d0002f6"), "CV", "Cabo Verde" },
                    { new Guid("df91f327-6dfa-4dfa-bb68-88bf800236f6"), "TF", "Tierras Australes y Antárticas Francesas" },
                    { new Guid("dfaa491f-da0b-4ed7-847b-3704f422bf74"), "ML", "Mali" },
                    { new Guid("e055671f-497c-4f4a-91b8-5c69cd15e982"), "MY", "Malasia" },
                    { new Guid("e0f618d8-79c4-4522-b0a3-1819bb338082"), "BJ", "Benín" },
                    { new Guid("e3a3ee06-5230-46eb-897b-60865ec74351"), "NF", "Isla de Norfolk" },
                    { new Guid("e4e5b3ca-6d13-4d3e-8a6e-5699c4e335f4"), "AF", "Afganistán" },
                    { new Guid("e50b8079-a324-4607-a61e-d724391cc725"), "PF", "Polinesia Francesa" },
                    { new Guid("e577dd35-6925-4745-9e6f-11966cf6455c"), "LS", "Lesotho" },
                    { new Guid("e834051c-b1db-430a-8a31-ee4bdc9364ba"), "GF", "Guayana Francesa" },
                    { new Guid("e9f88cc3-c824-4dc8-86ba-62375aa0ad65"), "BG", "Bulgaria" },
                    { new Guid("eb82f569-26c5-45fd-92da-cec316b412c7"), "JM", "Jamaica" },
                    { new Guid("eb909cd8-9075-4bda-86d7-4402fbd9b104"), "CM", "Camerún" },
                    { new Guid("ebfc7080-707b-402d-b91e-5e76c02cd583"), "PG", "Papúa Nueva Guinea" },
                    { new Guid("ec21f8b0-bf96-4027-8b25-6b6c2822fce4"), "SJ", "Islas Svalbard y Jan Mayen" },
                    { new Guid("edbb8a29-0690-4240-abfa-c23eee4e1afa"), "ME", "Montenegro" },
                    { new Guid("eeb4b16b-6dbd-4a85-8f7b-c1559d174668"), "NU", "Niue" },
                    { new Guid("ef0ed30d-61f5-4b08-b152-d4095d3b5ba5"), "GY", "Guyana" },
                    { new Guid("f2c536ab-f0b0-42a8-8045-64d3ec960da7"), "AX", "Alandia" },
                    { new Guid("f5fa2d63-c83a-45bc-80a6-6d0a955ee604"), "GD", "Grenada" },
                    { new Guid("f687dd04-c29f-4d78-88af-319e87b6f64d"), "HR", "Croacia" },
                    { new Guid("f7b8952e-92aa-42a0-a9c8-9982e88905a2"), "CU", "Cuba" },
                    { new Guid("f83880c5-7fd8-460b-8642-b96579f05dfb"), "NA", "Namibia" },
                    { new Guid("f8a23d51-a851-40a4-80e7-d040c87aa17e"), "YE", "Yemen" },
                    { new Guid("f9443106-5947-44f9-a8e9-435e3ff19d29"), "PS", "Palestina" },
                    { new Guid("f96f8e2a-8711-4a5a-80e2-ec08a4d59a26"), "GL", "Groenlandia" },
                    { new Guid("fc517473-77bb-49b0-97e3-3544dbfed1a1"), "VU", "Vanuatu" },
                    { new Guid("fe48301c-19ea-4608-a54e-6af873a62880"), "LT", "Lituania" },
                    { new Guid("fe9865a3-159d-4f6c-8e25-23e463878965"), "CN", "China" },
                    { new Guid("ff36ac4d-a836-4153-ac1b-2523df6fd85a"), "FJ", "Fiyi" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("00a8409f-00b8-45b3-9608-d2fa873e19df"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("00c50a5c-a946-4c33-a676-37ca6ae3a150"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("0120084c-03ce-4c5f-933c-7a45f617162e"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("029bb73b-8ad1-42c2-9cf3-a4974ced857f"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("02b6a498-28e1-44f4-945d-caeb78e0a37b"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("02c4d95c-7830-4fb6-bdce-bae508943b43"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("04887b29-7bc2-4935-a268-e67388d58601"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("04f3b16d-5437-4f09-bf7a-8c9452cbb0f3"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("069abf71-8422-41d2-8f4e-3d2802d27718"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("07065449-c9e3-4446-b661-47ba6ecb519a"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("0cac11f0-8f91-44cd-8834-c0ea96c84e51"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("0d78fe0f-8d67-4251-af84-6a3ba46da075"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("0d7ddd52-ca3e-4834-9bf8-21dddc6a1420"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("0ff78adc-3558-4fca-9458-aa86c0ea6bf6"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("11253029-0ae2-4fd7-829d-b3cf260b4039"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("1192cc02-3920-4064-8f39-6bdf2f14d0df"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("14afd52c-dd47-4cc1-8161-9debfda7c2be"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("14f99c1a-0e1d-4ab6-b10f-ee10d797f670"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("153cb824-dc40-42af-8e45-fc7c46bb1d02"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("15829374-c08d-4eb8-b269-0c1ed852eab6"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("15e32b42-0163-4af4-9cd8-e960030331f2"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("16948ff4-180c-4b0e-ab76-60ecbcdac946"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("16f45316-7e79-4198-9a6a-4796efa5dfb0"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("1824dce2-8efd-404f-868e-7e11bc8d1f05"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("1891068c-b50b-4ca0-a566-7b96b00a973b"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("1b957d4f-3c7a-4678-bcab-ff3bb51ab273"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("1c0950cc-064a-4739-abbd-a459c0da2d7e"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("1dc6d671-c094-4847-8d50-8f6d66d2dc8d"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("1e8b932f-4e1c-479f-b5c5-2791e42a4271"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("20349fa7-5805-4235-a554-f183270decac"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("207af4eb-9c90-47b3-944b-9710962f0f59"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("20847316-f585-4844-b923-065e830a56b1"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("218f28d1-55f2-444d-8b75-cf28fbe8cb3d"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("2555f2c8-3435-4222-a344-eaffe17aa3e9"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("2642b83e-d9de-4b96-8d33-10efd24d1f86"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("269bf09e-d69b-4c92-a05b-6593e2b7f237"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("281ed329-46ef-48ca-88e6-86fa9d7c9241"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("28305b90-df96-4773-b37b-5f4694654e6d"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("29d8db58-2e81-4ceb-b101-95ebb674ac95"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("29e79e81-6f2e-427a-9e30-eb7731402146"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("2a6dac3c-03ff-40f7-8db4-fc8b9b5f8aed"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("2ad7003e-b983-4b11-965b-20c6513d199f"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("2c0f5675-485d-4a18-a193-9fa00d08fed5"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("2d00b3ef-7d38-46d8-9b0a-44fea8c387ee"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("2e7bbffb-d91c-4805-a083-86f68b8871a5"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("2eea36a2-3789-4829-afd5-c57171f5dfe0"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("2f0e9eee-8796-446d-a100-161e17b8b061"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("2fdf5051-8417-43d8-8377-d04f762ed602"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("2fe8bbe9-e109-4562-925e-ef7bbefff534"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("33cde7a3-18a8-40ed-ba37-a307bf2407ec"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("33def8f3-7561-4bc0-8098-d88c504dbf0f"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("3563a719-2d00-4f03-85a4-59aad03c8c6b"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("36735441-22b1-47f9-9dbe-f0dfe8a0d6a6"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("373d50fa-c345-4fe1-9939-add39624ceb0"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("374c01bd-db21-4b49-8905-6a9039cb7eeb"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("38446f2b-c4f4-4755-92c9-76c8ed85761c"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("39f2c768-5f1f-42da-b66b-7ff2a0414c5b"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("3a37cf79-7e20-493b-97e0-704c89442ad8"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("3af6d118-322b-477d-9ec1-1ca337df03d4"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("3c5d56dd-05cb-4c01-bac1-c9287131bb9c"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("3edd0bdf-ba32-425a-b7c6-4cce725df938"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("3f625a21-ed15-4579-bbf5-55e477c3d63d"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("422574d2-85b0-4642-b7c6-c269933f5688"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("42532ddc-5daf-4954-9135-09b1143a45b8"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("42d33ce1-3fd1-4c3c-819f-3f98b57df15c"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("434c1c8d-895a-4841-8203-c43fc93c46f9"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("43bcebd3-1285-4a91-bf39-4a2bf50cabfb"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("45b386f1-cd2f-4cf0-bb68-49a1ef970794"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("468c202b-b780-4688-bb91-e550de7c48f2"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("4a205056-87e2-445e-ae12-48f4b7ee57cb"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("4b038013-9709-4621-ad09-158b94b9dfcb"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("4d845dff-b0d6-4421-b168-53b7226b69df"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("4f091e9a-d45c-4b79-8ea2-5097558ff5cb"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("4f41d0f2-d586-488d-bd29-de20c40d9413"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("50db5220-56ea-428b-9c6b-0553c3fdb731"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("5118c961-45ad-4c68-88e3-7da271c14878"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("53321c78-fbde-447b-b693-59ade948943f"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("55366336-8325-4e95-8f87-d4e0d7d9a853"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("55afe1e8-b328-4128-bfde-e7dae803eb55"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("566607ca-be86-4601-b462-bc9b3acafd80"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("57797178-fb1b-45f0-907d-46069b57215f"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("5803c685-e5ab-4a11-bafa-3b42a1efb827"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("5b996f49-b707-4698-8aed-a3051c0d5ce3"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("5baf91f7-3b29-4725-b13d-76ba2a69717c"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("5d2857c3-6b6f-409a-869c-736644ce5eff"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("5d7ba3ed-9cd1-4883-b36e-875598ab10bc"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("5e0c8ed3-cdc0-498a-a2e1-6f24916f1412"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("5e6403b9-0935-46ee-914a-1ef24196e4a8"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("5e880adc-708c-47c5-a13b-96674b2033db"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("5ee35fe1-ebec-4365-af53-abe6f7b9d3d0"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("601b7882-f107-47e6-aa6e-d115fb30ab15"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("6197ab51-147f-4ca8-93b4-3ba072a8d5d1"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("6256f092-a05c-4b74-b469-7ec6cc24a736"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("630f5333-8279-437a-a0ed-a52a7a2f2f03"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("639a28d9-68e4-48d2-a250-81f08f9c0caa"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("63a8f010-efc4-4cef-a764-d06d67270a95"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("64229f03-02a5-4aa4-a0e2-218a731ca34d"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("66e213d8-b91d-42e4-a9b1-fefe3260670a"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("66e678e9-c74b-45da-a472-f9807140288a"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("69e1ba48-f092-4d22-9dcd-9a33618cbfc8"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("6a0f8edd-4a1f-4300-bb99-3510f5459040"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("6b5b9c68-e859-4f2d-bb4d-75b993f4bafe"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("6d590ec5-2453-45e6-9a9b-195e4e235ce8"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("6da02812-b230-4f0c-bb2e-7d21a831769a"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("6fed55e1-babe-4e8f-aaec-85d159cc1202"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("70292356-c3c7-4592-baae-edfa75446073"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("711686c1-2d56-4c04-9982-8ea277a67aea"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("73383825-49b2-4c25-8b6b-a63252092738"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("73636a54-ae1b-40b3-be87-4a7326f83d0e"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("73e8e174-335f-45eb-847d-d5adbc7b1175"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("74bd22b6-124a-44eb-8ccf-8ba1f6f4873d"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("75c928c8-0e28-4c88-95fe-d091fc0c16e9"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("7664810d-6d79-4b39-9e92-10085e25f6e8"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("774ff9b4-1e84-4945-a0bc-98e7345f0e64"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("78eff79a-9abe-4d30-aa26-a776e7a7338d"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("7943c322-79ec-4d98-b6d1-57d85fdf1419"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("7c37bc02-1b0a-4b0c-9c33-82c76310d175"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("7c8c95b1-f1d3-4c75-a256-316161219ff3"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("7ebaeef6-9f22-4476-8bbf-9e524b028cd8"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("7ef3a7a3-eb77-4028-aeef-c677f4cf907b"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("7efda655-9102-4dc5-94cf-5064e65c0632"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("7f56a383-04ea-4842-b30c-fecf146737d0"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("805667fd-1e67-44a0-a30f-dc9f72ae89c4"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("8061cf72-f915-40b2-90a5-77162068e221"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("80698799-cb5b-48b5-898a-a255c230c6bb"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("83d0ccdc-df64-466e-ba6f-34d9cf2a5176"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("83f50e3a-5509-428b-8a08-a45eb15791dd"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("8530bafc-b878-4ea7-a2d5-4431814f3551"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("8603a574-0692-4fdf-962b-04d1b44b760c"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("866909be-b10e-49a0-abca-c2c0a356e5d6"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("869cce88-fd7f-4da0-a1b7-c32aef105a94"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("86b50876-f375-4de4-8580-96141263748d"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("86d53d1e-b663-4006-9d3d-b6876e9f120c"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("8a925b86-57e2-4e3c-999e-8f3d905be075"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("8ab84da6-fc1f-4a3a-82fe-617b5ecdefb3"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("8ab9442a-1eea-42bb-9f1d-bac0a98c1af0"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("8b31e921-c25f-4752-b8c0-5ce2e4531892"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("8b8c6267-4333-451b-9b7c-b2c96ffcb578"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("8bad89d3-11cc-4fae-a5a2-45ebecdf5a7a"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("8c75f8ef-1082-40f2-96fc-c2cc23d55c53"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("8ce4aa67-66a3-4aa6-b184-649aabf76802"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("8d7811d6-2ec2-4461-9bdb-f08b7a692a11"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("8dca6c1b-feb5-4d4c-a2d4-33e0636c63e1"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("8dd49756-22e3-4fac-9f5c-aabd596ea313"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("8ff46c0f-55d1-47eb-aa46-f99a37b31dd8"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("9162e7ad-23d5-4aea-a95a-4c87d31e765a"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("92826d7c-418d-4345-b0c3-8237572c3054"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("9382f873-94ee-4573-b81e-809392855612"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("9594cedf-a710-490c-b914-ce172bfa6ac7"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("95f35a8a-3bbf-4900-b85f-2fae4dbba5fc"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("968186d7-2ca4-4a10-af20-5af09c4fc5ab"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("99e68782-dcdb-400b-a0f7-da739bbd44fa"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("9a123551-f97c-4f34-b30f-65d3e0bb4d7b"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("9a44fa72-4a93-4dce-a096-2453c0487f0f"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("9c5402cf-a319-4a1e-85e8-0eca4e15157a"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("9cf7d04c-5ec4-44fc-af47-5c409a1f315c"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("9da551ce-3e57-4490-bc80-24889e9944a8"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("9ded1731-afa5-4433-9b4d-a1b9ed1bb322"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("9e4919f6-b01d-4bbf-a0e0-69a6214f9833"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("9f46cb94-7ae0-4bad-b52e-480068158a6c"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("9fc8f54f-dc3b-4fac-bbfc-efc42c2b7d3c"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("a0274691-a232-4fee-9ddd-95567ad5c4dc"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("a0901c3c-4678-4610-9eb3-9208bdc078ca"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("a1234c79-4c10-4cdd-937f-7c4b6d49075a"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("a131ea74-ce81-4381-9de1-d5be68cceb23"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("a15973ac-edf4-4119-9506-51b693efbbd9"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("a1968f9a-0ed3-45cf-8cfb-f6c780c6b2e5"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("a2090c26-741a-44dd-9390-eafd92dba7c8"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("a2e8040f-5bd2-4b3f-83a1-235ade7c6ed4"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("a33fbad3-b691-4d0d-be44-f0ea261e71a4"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("a39d656b-e536-48ae-8f0a-d0c6b1945c87"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("a3eb8a72-a213-43f0-ad6b-5b0811c1e458"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("a47c6a19-82f8-485b-9783-5fa70d5da743"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("a4c158fd-32c0-4a93-8f29-002634ed03f3"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("a69bdef2-29a5-4c85-8e34-5d4cfa57e302"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("a6d8e374-6543-48bc-a605-4838813b503b"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("a7388a5c-c1bc-4e93-bb00-fcc719edcbf1"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("a7c29582-6cd0-4558-a81a-ad5a84f59ee1"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("a85b7b9e-01ec-4b91-9949-e7cda02a5113"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("a948a4ab-d495-41ce-a8ed-d0285b580f3f"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("a967c691-b6f6-4eb3-b531-e8d3b931ed1c"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("a9a1d7dd-9b7b-418c-aba8-cbcc500fb9aa"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("aab51c5c-569c-4489-b982-166b8eb6548b"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("aae84a38-dd8b-49d4-b245-764890a915eb"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("ab6505f6-6638-40fd-ab77-469e22dad100"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("b0b6e57e-77fe-494d-bac7-2abda64f6954"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("b0f1ca4e-641c-4bab-9c82-d68f53ffa097"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("b1144bf7-6e1a-4f70-b0f1-7a8cfb1a6f9f"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("b47c9daa-06c9-4ae0-9ca4-0fe3c28abc45"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("b4b7a40f-e7b9-401c-af4a-5e69b2b1200d"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("b84ae9d3-6907-42fe-8fbc-a02f1280f2d7"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("b8bdc1d3-bb00-442b-9f3f-5da09739dfc8"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("bb671c91-fa45-41f7-af49-7f6d8a12bf11"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("bd7a5a70-3c7a-43d2-9ded-b6929ae86ff3"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("be15b58a-34ca-4be2-8e96-d89cdbfb9550"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("bf1414f3-e19c-4e53-9f24-02a5e24c9de3"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("bf415dbb-782d-4626-adfe-ff42d8cfbd5a"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("c14e9e64-4ab3-48e7-ba7a-eaa2e41736ac"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("c1f35f07-9d37-401a-b0fa-316c6b2309a4"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("c25fcfb0-7464-461d-abb9-770c7de86ed1"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("c3483946-8c63-4f00-8bd4-a02f40d306e6"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("c3f71149-5baa-4b7a-91ad-0d5bfa10802d"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("c60af867-8efe-48af-85c6-94c964d2d3da"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("c95887d8-1c90-4798-8957-c7aff0dbc181"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("cabb83eb-855c-4338-aca5-1771d2f32084"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("cb01d263-9d41-4092-8764-47991586effc"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("cbcb028d-002a-4a5d-b390-cf36a91de7f4"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("ccabb518-5ed6-42ba-9895-bbe60014f102"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("cdbc92ba-1fb2-4390-ae54-f210ef306fc1"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("cded149c-9541-48bc-9c75-7674dc7d1c39"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("cef334db-e528-4fc5-8b4d-c7a2ee1fc6f4"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("cfb3f1df-6fa9-440a-b418-0e2528d50488"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("d25296da-bad1-4739-9884-db73140fdb82"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("d4b2eb3a-5967-4257-99a4-8ae21c876cdd"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("d5338524-6d3b-407a-8926-f7f8f703df2a"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("d55d90ab-63cc-4c1c-a007-7c623c2b2fa8"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("d7a06de2-bbb3-4f71-b277-7a01200e0963"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("d7b7e468-a1d9-408f-b867-4af60dbb4b5f"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("dd426855-6952-4463-933d-a8658ee69648"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("de57c088-0e3f-40ec-b222-797d0e09cb02"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("df891446-797b-4efa-a2fa-a9ea4d0002f6"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("df91f327-6dfa-4dfa-bb68-88bf800236f6"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("dfaa491f-da0b-4ed7-847b-3704f422bf74"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("e055671f-497c-4f4a-91b8-5c69cd15e982"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("e0f618d8-79c4-4522-b0a3-1819bb338082"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("e3a3ee06-5230-46eb-897b-60865ec74351"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("e4e5b3ca-6d13-4d3e-8a6e-5699c4e335f4"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("e50b8079-a324-4607-a61e-d724391cc725"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("e577dd35-6925-4745-9e6f-11966cf6455c"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("e834051c-b1db-430a-8a31-ee4bdc9364ba"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("e9f88cc3-c824-4dc8-86ba-62375aa0ad65"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("eb82f569-26c5-45fd-92da-cec316b412c7"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("eb909cd8-9075-4bda-86d7-4402fbd9b104"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("ebfc7080-707b-402d-b91e-5e76c02cd583"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("ec21f8b0-bf96-4027-8b25-6b6c2822fce4"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("edbb8a29-0690-4240-abfa-c23eee4e1afa"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("eeb4b16b-6dbd-4a85-8f7b-c1559d174668"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("ef0ed30d-61f5-4b08-b152-d4095d3b5ba5"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("f2c536ab-f0b0-42a8-8045-64d3ec960da7"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("f5fa2d63-c83a-45bc-80a6-6d0a955ee604"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("f687dd04-c29f-4d78-88af-319e87b6f64d"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("f7b8952e-92aa-42a0-a9c8-9982e88905a2"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("f83880c5-7fd8-460b-8642-b96579f05dfb"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("f8a23d51-a851-40a4-80e7-d040c87aa17e"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("f9443106-5947-44f9-a8e9-435e3ff19d29"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("f96f8e2a-8711-4a5a-80e2-ec08a4d59a26"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("fc517473-77bb-49b0-97e3-3544dbfed1a1"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("fe48301c-19ea-4608-a54e-6af873a62880"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("fe9865a3-159d-4f6c-8e25-23e463878965"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("ff36ac4d-a836-4153-ac1b-2523df6fd85a"));

            migrationBuilder.DropColumn(
                name: "EsActivo",
                table: "Proveedores");

            migrationBuilder.InsertData(
                table: "Paises",
                columns: new[] { "Id", "Codigo", "Nombre" },
                values: new object[,]
                {
                    { new Guid("00620db8-f9b7-440f-b455-0fe7b0a68217"), "MA", "Morocco" },
                    { new Guid("01d9f210-f02a-453d-a917-bf56491fc4f5"), "GQ", "Equatorial Guinea" },
                    { new Guid("01ec4c4f-c48e-4dca-bdfc-b24c8bcbd983"), "CU", "Cuba" },
                    { new Guid("04443509-2e34-4303-b26d-bf9ed611d4c3"), "VG", "British Virgin Islands, United Kingdom" },
                    { new Guid("0589819d-92eb-4621-ad06-e0501a005d8e"), "GB", "United Kingdom" },
                    { new Guid("07960697-5ce1-4e5d-9e20-11fd06a6ebb8"), "AO", "Angola" },
                    { new Guid("08f7e5d5-9379-45a6-bb4d-64baa36e9ad6"), "OM", "Oman" },
                    { new Guid("0a2a3596-7062-4c70-9ff8-d2e89dcd467e"), "NE", "Niger" },
                    { new Guid("0b99b7f2-b01a-4296-bc62-4ce98d8497fe"), "AZ", "Azerbaijan" },
                    { new Guid("0c2b259a-3587-4b39-84d3-231e0742ecce"), "TR", "Türkiye" },
                    { new Guid("0c580693-ef58-41ba-a012-1de1371e729e"), "BW", "Botswana" },
                    { new Guid("1042bae8-3ac0-40dd-a043-2fa0d7e1e45d"), "LK", "Sri Lanka" },
                    { new Guid("1055379b-9e39-4b0f-82e5-46520c6f058a"), "CO", "Colombia" },
                    { new Guid("109bcf17-d5a2-4df4-9215-a019010c73d6"), "NZ", "New Zealand" },
                    { new Guid("11418284-7934-4056-8be9-179650fed93d"), "SS", "South Sudan" },
                    { new Guid("11c44856-7a8c-4883-a621-1cc20024af08"), "PG", "Papua New Guinea" },
                    { new Guid("16265cd1-f1b1-4747-a217-f7ce279571f3"), "CL", "Chile" },
                    { new Guid("162f3a5c-b5b7-4e79-90c3-591d5a36fed1"), "IT", "Italy" },
                    { new Guid("16974e0d-cf4c-4a3d-8e43-29e72a9dd12d"), "LB", "Lebanon" },
                    { new Guid("17bc389d-9e34-49cd-b136-a96b0dcd13e6"), "AU", "Australia" },
                    { new Guid("190aa0c3-6274-494c-a2d2-b6bc18581d18"), "UZ", "Uzbekistan" },
                    { new Guid("191f316b-e767-43b2-b65f-d876f0563f99"), "GA", "Gabon" },
                    { new Guid("1935727a-a121-4550-8625-cbb12e5edc26"), "KE", "Kenya" },
                    { new Guid("19598843-6b3e-444a-964c-7d21020d97a2"), "HN", "Honduras" },
                    { new Guid("1e08fa95-27d0-4556-b6a6-70145adff27d"), "MO", "Macao, China" },
                    { new Guid("2011ba9d-279c-442e-afa1-c3557b2563f2"), "TL", "Timor-Leste" },
                    { new Guid("24ee5e70-cfe6-46c5-adde-789872807b42"), "BH", "Bahrain" },
                    { new Guid("296e6471-bfc0-4e29-b8cf-57f84e6ed8e0"), "GW", "Guinea Bissau" },
                    { new Guid("2b86f30b-eb8b-4d89-a92a-38fd76438b34"), "FI", "Finland" },
                    { new Guid("2e187b9c-2fb8-4a06-98c8-9d7799f992c0"), "UG", "Uganda" },
                    { new Guid("2e28347b-0c1a-41f1-8acf-7db104d559fe"), "KY", "Cayman Islands, United Kingdom" },
                    { new Guid("2ed8f913-0cf0-48b1-a5c0-77bd36942046"), "LS", "Lesotho" },
                    { new Guid("2edf66ca-526e-4549-ac79-e9de8424458c"), "ML", "Mali" },
                    { new Guid("2f76d88c-cf1f-4637-859d-6b4c2b19d55c"), "JO", "Jordan" },
                    { new Guid("326d1da6-5ab3-495f-887d-ea6d2ff3f8a0"), "SM", "San Marino" },
                    { new Guid("32c3c66e-1752-4765-a030-203f599b89ea"), "SG", "Singapore" },
                    { new Guid("3396adc4-901d-47fc-9d14-63625516cd9d"), "CR", "Costa Rica" },
                    { new Guid("33a1dcce-2354-4ef0-8b87-02160ec44b59"), "SV", "El Salvador" },
                    { new Guid("36a320c5-04de-49d9-a2ca-4553ccd65955"), "PR", "Puerto Rico, United States" },
                    { new Guid("38719d2f-0d6b-44e7-8380-5d999c0b17ab"), "NG", "Nigeria" },
                    { new Guid("3b28bdae-d908-478b-9a15-3ca8200ec7c3"), "PE", "Peru" },
                    { new Guid("3b424961-94d6-4c7d-a784-77d2ab5a6b41"), "GI", "Gibraltar, United Kingdom" },
                    { new Guid("3bf7a124-83e1-45a0-bee7-d421b895a430"), "VC", "Saint Vincent and the Grenadines" },
                    { new Guid("3c2f1cd7-ee8c-479a-90fa-ec7451ce61b1"), "KI", "Kiribati" },
                    { new Guid("3da12317-f88d-4127-a26d-68845e4c2888"), "TM", "Turkmenistan" },
                    { new Guid("3da5152e-dbfd-4b1f-8c11-b04ac3859bbc"), "NL", "Netherlands" },
                    { new Guid("3e3e624c-bff2-419e-959a-16449340ddb1"), "MH", "Marshall Islands" },
                    { new Guid("3e3ecd33-5d54-4aef-8fc8-067250f11152"), "LA", "Laos" },
                    { new Guid("3e3fdee8-5467-419e-97c1-2581e5e0d767"), "NA", "Namibia" },
                    { new Guid("3e7bd1ba-3563-417c-8054-10800148a55c"), "CW", "Curaçao" },
                    { new Guid("4098549f-d7ee-4b11-ac84-92e9aba9bf9f"), "MT", "Malta" },
                    { new Guid("424214c3-b50a-487e-95da-db9861669a01"), "GE", "Georgia" },
                    { new Guid("44765994-c197-4525-9bdc-7382f3effbfa"), "IN", "India" },
                    { new Guid("48997b6f-0d82-41b1-ab05-2fbc3302c96e"), "NR", "Nauru" },
                    { new Guid("4be7749e-bf2e-48de-9371-1f70518de8d5"), "MX", "Mexico" },
                    { new Guid("4f3cdf9b-9c16-4a40-8539-0c0d3c544a98"), "KZ", "Kazakhstan" },
                    { new Guid("5148128e-fb06-4c5a-bde6-b339e7188299"), "UA", "Ukraine" },
                    { new Guid("517ebbcb-a710-48a6-8496-b4c51e0c8b86"), "QA", "Qatar" },
                    { new Guid("532f0e0f-991a-4f6b-bf42-3e3dcc5ebdd9"), "PH", "Philippines" },
                    { new Guid("54e7a3c1-1317-46f2-b0bc-2da6c3237be1"), "KM", "Comoros" },
                    { new Guid("5525bc84-b82e-45dd-a568-4c607d58901c"), "EE", "Estonia" },
                    { new Guid("55261cab-225e-4a64-ac22-562df80a28d0"), "NP", "Nepal" },
                    { new Guid("56af8095-5280-4b04-a761-1c862eb5e317"), "BM", "Bermuda, United Kingdom" },
                    { new Guid("583eadaa-b856-46d2-86a5-7ebe91dd6c9b"), "KR", "Korea (Republic of)" },
                    { new Guid("59505dec-cdf0-42eb-8b0b-c0e6aacda56b"), "CA", "Canada" },
                    { new Guid("5b30f591-20cd-4bbf-8629-c35fa10b2a2b"), "JM", "Jamaica" },
                    { new Guid("5b842a69-9499-4dc4-9be6-1ae1f4667f20"), "AS", "American Samoa, United States" },
                    { new Guid("5d637d97-0c74-4a5b-bd40-b4a0ca154298"), "SD", "Sudan" },
                    { new Guid("5e88db2c-9453-4535-9a87-e90103ee1b3c"), "BG", "Bulgaria" },
                    { new Guid("5ff89786-52b5-4bb5-9544-00fbd045698a"), "CF", "Central African Republic" },
                    { new Guid("60f247b8-1410-48b4-a57a-44852bc8e4da"), "MM", "Myanmar" },
                    { new Guid("616b4643-e363-4ba1-99fa-513ec353e523"), "BB", "Barbados" },
                    { new Guid("616c2290-da9a-4981-b74b-675799c15202"), "GY", "Guyana" },
                    { new Guid("620f215f-a521-4ac2-8f4a-bb16e124d022"), "TZ", "Tanzania" },
                    { new Guid("625e7eb5-15c2-4e3d-9e22-e1e926db5260"), "922", "UN IRMCT (United Nations International Residual Mechanism for Criminal Tribunals) " },
                    { new Guid("64e752a8-bc85-4d44-85e9-ed079ecc7e04"), "DZ", "Algeria" },
                    { new Guid("65c4a624-e04c-4d13-894e-0046df0a20d7"), "BI", "Burundi" },
                    { new Guid("68bab6e7-d3ae-4b7f-aa2d-942ed9e6e07b"), "BS", "Bahamas" },
                    { new Guid("68e0e3f6-45f4-4ff0-8eb5-f2a2a1ae55dc"), "BN", "Brunei" },
                    { new Guid("694e0eb1-51d8-4af4-bde1-23ecbf36c63a"), "VN", "Viet Nam" },
                    { new Guid("69b6ad75-c9be-45ac-a580-177af4793741"), "AI", "Anguilla, United Kingdom" },
                    { new Guid("69d5bcb0-53aa-40fd-b070-dd2b04817a1a"), "IS", "Iceland" },
                    { new Guid("6a10ccd3-0da7-47cf-af45-c80168ee3552"), "TH", "Thailand" },
                    { new Guid("6b1d8329-07f3-4991-aaee-1194d0e929d7"), "AG", "Antigua and Barbuda" },
                    { new Guid("6c182dbd-96ed-4e72-b5f6-916c7c242c76"), "BR", "Brazil" },
                    { new Guid("6d48c7c2-a27c-40c1-b169-27cb3139e900"), "PW", "Palau" },
                    { new Guid("6defe922-f811-4afb-81e6-f66978e8d563"), "BD", "Bangladesh" },
                    { new Guid("6e71e6b2-68a2-4f18-ab84-1f99c4eac6ef"), "MN", "Mongolia" },
                    { new Guid("70b0b318-4d6d-45fd-8f13-0cc2a0d4d539"), "SO", "Somalia" },
                    { new Guid("71fd152f-3b29-4441-bc3b-9c7acad83150"), "MY", "Malaysia" },
                    { new Guid("72a3d1a4-f234-4bf1-9657-20c11f17108c"), "WS", "Samoa" },
                    { new Guid("736b1c18-bda9-447f-8330-1e6f7ec3d996"), "PL", "Poland" },
                    { new Guid("76578cb4-2f01-4799-973b-5fe27eaabe79"), "RO", "Romania" },
                    { new Guid("76931b72-e30e-4f4f-b067-923739afb8df"), "SR", "Suriname" },
                    { new Guid("7721285f-b341-4a7b-919a-fed7577f25c1"), "RS", "Serbia" },
                    { new Guid("789af701-0428-43fb-afe0-de24a82454b6"), "TC", "Turks and Caicos (Islands), United Kingdom" },
                    { new Guid("78f044f9-8f36-44a2-86be-c824991fc2ab"), "DM", "Dominica" },
                    { new Guid("7a034094-f00d-4f30-9b7b-910896f8b790"), "SN", "Senegal" },
                    { new Guid("7b64b7a3-5142-4e71-815f-f9b2f06ea485"), "ER", "Eritrea" },
                    { new Guid("7d1132c8-b43c-442c-aad4-d35b47e54bf1"), "NO", "Norway" },
                    { new Guid("7d61e451-54a2-4fb8-a432-652ecf6418a7"), "SC", "Seychelles" },
                    { new Guid("7f45c0c7-8f31-44e9-8adc-9496d38cfe63"), "CN", "China" },
                    { new Guid("7fc62237-4a79-4071-9ac8-fad25f56a4f5"), "BE", "Belgium" },
                    { new Guid("80252ed2-374d-4dc5-b643-404f09374057"), "MD", "Moldova" },
                    { new Guid("81f56c9f-d0d9-483a-9ed4-c0f81fc5df65"), "ET", "Ethiopia" },
                    { new Guid("82160f3f-3eb3-4830-8a0c-e85e9663d435"), "RW", "Rwanda" },
                    { new Guid("85eea948-ccb7-48ad-aa85-4598ee55d9a5"), "IQ", "Iraq" },
                    { new Guid("860d8823-e9ed-4c77-95f6-3683503dd322"), "ZW", "Zimbabwe" },
                    { new Guid("8699e2fa-43e0-4ff8-876a-d3cd10f01622"), "UY", "Uruguay" },
                    { new Guid("8779375e-96bd-4e0e-a2f6-be7ba92dced5"), "US", "United States" },
                    { new Guid("883e7ba4-fdda-4320-a516-ce36dc79c296"), "SL", "Sierra Leone" },
                    { new Guid("89310a2d-89fa-4d56-b153-2e5f0731018b"), "BA", "Bosnia and Herzegovina" },
                    { new Guid("8ad6460d-0d25-4c8a-aba8-867e01a22712"), "ST", "Sao Tome and Principe" },
                    { new Guid("8b223ec3-8f0d-4990-b27e-8ba704180fa2"), "CZ", "Czech Republic" },
                    { new Guid("8d3fd64c-e0e3-4af3-9bcc-1a933985770b"), "LY", "Libya" },
                    { new Guid("8d595af9-1b4d-43ca-b204-2d6519872c93"), "PY", "Paraguay" },
                    { new Guid("8d67ab04-7154-42e4-b0f7-91ef81c87cf9"), "UNK", "under UNMIK mandate (Kosovo)" },
                    { new Guid("8e890c16-34fa-4f2c-bcd5-8fbcc60097c4"), "TT", "Trinidad and Tobago" },
                    { new Guid("8efa8eb3-fbc6-4650-a56b-84df5c337e71"), "PA", "Panama" },
                    { new Guid("912f7edc-d547-465e-9c69-ae0be4735a27"), "MU", "Mauritius" },
                    { new Guid("913f7b51-cced-4b58-b039-dcd8b5fe7b70"), "GD", "Grenada" },
                    { new Guid("91942d29-a42e-48c9-9b1b-80e44da51d31"), "GH", "Ghana" },
                    { new Guid("91ec3c08-9581-461f-9b40-9455f529747b"), "SZ", "Eswatini" },
                    { new Guid("93bf1334-4cd9-49fc-9f2e-3b461adec31f"), "KN", "Saint Kitts and Nevis" },
                    { new Guid("94d8b720-3dca-4ee3-ab7a-3dc39696d689"), "CV", "Cabo Verde" },
                    { new Guid("952d64e4-bfee-405d-b199-52ee2c9248e8"), "GR", "Greece" },
                    { new Guid("97ac20f4-682f-4d55-85ea-585ef1ac6425"), "BQ", "Bonaire, Netherlands" },
                    { new Guid("98615b67-67a3-4b57-8c2c-307ef4c2d31c"), "HR", "Croatia" },
                    { new Guid("98b6c2a8-54f2-4902-bd82-6c7db6d11ad5"), "GN", "Guinea" },
                    { new Guid("998832d0-6d7f-4a83-a4c8-245168eac2c0"), "JP", "Japan" },
                    { new Guid("99ff1e02-0769-4974-8260-2b014e15bbaf"), "CY", "Cyprus" },
                    { new Guid("9a52ed05-5af8-4419-88ce-80195ab24da1"), "ID", "Indonesia" },
                    { new Guid("9a703909-91bf-4ac4-a6ec-3c7b3ad9088f"), "DJ", "Djibouti" },
                    { new Guid("9f106923-a7db-4b2d-bca4-50781d7dbec6"), "LV", "Latvia" },
                    { new Guid("9f6786e5-68cc-491d-bc2b-e8b4df11aa23"), "CM", "Cameroon" },
                    { new Guid("a4183410-86c1-49d3-99ee-0f998fff8a86"), "SB", "Solomon Islands" },
                    { new Guid("a588d859-626a-40f8-99de-8cecee68e372"), "KG", "Kyrgyzstan" },
                    { new Guid("a5b34e39-9159-4dc8-b815-2d1d3d5e0def"), "ZM", "Zambia" },
                    { new Guid("a743201b-006c-4146-b1cd-8519f8086edd"), "SK", "Slovakia" },
                    { new Guid("a7876684-bd92-4242-be7a-7e8c321b9f11"), "TN", "Tunisia" },
                    { new Guid("a850ebd4-0c01-435a-a9c8-1e79532ca4e2"), "SY", "Syria" },
                    { new Guid("a883229d-ccc0-4567-9226-d4026b37fced"), "ES", "Spain" },
                    { new Guid("a99c4232-e2ee-4aec-946f-197b13dd2b15"), "TV", "Tuvalu" },
                    { new Guid("a9ce8de6-d993-4847-861c-37b3afe19421"), "MW", "Malawi" },
                    { new Guid("aa83f025-30a2-410d-bbe2-5d7906399efd"), "VA", "Vatican City State" },
                    { new Guid("aca013ad-d8fb-4a95-9198-7680650c484e"), "MV", "Maldives" },
                    { new Guid("ad40eb29-9906-41b0-ab1a-633a0d3fe8c3"), "SX", "Sint Maarten" },
                    { new Guid("ad682fc9-38e8-4924-b71f-35099b8005eb"), "AL", "Albania" },
                    { new Guid("aebed0ca-6b35-41dd-86b2-1fe0c3e93ea3"), "AE", "United Arab Emirates" },
                    { new Guid("b1f47760-0828-4441-a18d-86ee965f9924"), "HU", "Hungary" },
                    { new Guid("b2530d40-3e3f-4799-abea-99b2ed5e0343"), "BY", "Belarus" },
                    { new Guid("b5257962-3670-4318-8f07-df3e6183ea3f"), "LI", "Liechtenstein" },
                    { new Guid("b69f48e9-0a8e-4191-bb62-9792d97d6aba"), "YE", "Yemen" },
                    { new Guid("b8201ed4-fcf7-4f22-8cb2-fb0874b2f9d9"), "TW", "Taiwan, China" },
                    { new Guid("ba97cca7-a3d1-4d6e-9b47-85a0516b8fde"), "KW", "Kuwait" },
                    { new Guid("baa0fe09-d11c-48bf-a22d-92f131496b4e"), "ME", "Montenegro" },
                    { new Guid("bb29003e-c422-41a5-8bb3-02c6f6f7feba"), "AF", "Afghanistan" },
                    { new Guid("bc0886a9-83e8-459b-98fd-5c880974b2fb"), "BT", "Bhutan" },
                    { new Guid("bd266a26-2edf-4e15-a5d9-293bcfcbe7b0"), "IR", "Iran" },
                    { new Guid("bde70f85-a357-499d-8e16-184998cd58fe"), "EG", "Egypt" },
                    { new Guid("be87fe8d-02b3-460a-b77d-f7dd7298b522"), "HT", "Haiti" },
                    { new Guid("be8e6c25-a3c4-4031-9ce2-58b0ff4c3a90"), "RU", "Russia" },
                    { new Guid("c04e0760-4057-402b-8d64-ba5474707e45"), "AD", "Andorra" },
                    { new Guid("c0df7e80-8371-4bc4-a3ca-0f29e9e31852"), "NI", "Nicaragua" },
                    { new Guid("c15e4b37-8f2e-44a9-ac30-e0e39e87c33f"), "VU", "Vanuatu" },
                    { new Guid("c3f5086a-afe9-4e40-9fbe-e3cab08e0e8e"), "TO", "Tonga" },
                    { new Guid("c6b53d16-c427-4574-a720-b061aa922534"), "BF", "Burkina Faso" },
                    { new Guid("c76be378-b488-41d4-a226-151cbbd10d0e"), "MR", "Mauritania" },
                    { new Guid("c865872d-b1d3-465e-981e-0107101a07c2"), "ZA", "South Africa" },
                    { new Guid("c9f99cf4-c7e5-4622-8cbf-a8b257289ca3"), "PT", "Portugal" },
                    { new Guid("cb276fe8-d58e-4801-8887-bd68e1e30f2b"), "LC", "Saint Lucia" },
                    { new Guid("cbc53fbf-fff7-4405-8c28-074beda5fcda"), "KP", "Korea (Democratic People's Republic of)" },
                    { new Guid("cc8dea8f-acb1-4035-982f-df6353d9fd06"), "AM", "Armenia" },
                    { new Guid("ccef45ec-8c32-4f08-86e2-5eb589401d1e"), "SA", "Saudi Arabia" },
                    { new Guid("cd39cc01-c9cf-425e-bd32-84f9ca71bb36"), "DO", "Dominican Republic" },
                    { new Guid("d13de921-2711-49e3-9873-9d7e53ab715a"), "DE", "Germany" },
                    { new Guid("d18cd18d-0644-41c5-b4c3-f5eb186f44ce"), "DK", "Denmark" },
                    { new Guid("d30043b7-9ced-41e3-9c36-6c07cd19ed7e"), "AR", "Argentina" },
                    { new Guid("d35e78ef-aea1-48f0-bbf3-43640aab0e84"), "MG", "Madagascar" },
                    { new Guid("d3bd7890-a9e2-42e9-b3ef-f1dead4483ff"), "FM", "Federated States of Micronesia" },
                    { new Guid("d4edc19c-542f-45ac-9fbd-20a9d96cb2e1"), "AW", "Aruba" },
                    { new Guid("d565c05d-d54f-4e5d-829c-e01bf9fcd291"), "BO", "Bolivia" },
                    { new Guid("d5ddb81f-735d-4546-b9d8-29358bf49706"), "CD", "Congo (Democratic Republic of)" },
                    { new Guid("d7684d8d-3181-4ce0-8976-bc377cb1525f"), "KH", "Cambodia" },
                    { new Guid("d791ddbe-167c-4239-bb89-6ac9604f4404"), "IL", "Israel" },
                    { new Guid("d7fe994e-524e-45ef-895a-6f5b336216eb"), "TG", "Togo" },
                    { new Guid("d95fb4c0-9470-45fc-b372-72c3487a5d06"), "TJ", "Tajikistan" },
                    { new Guid("d98ace5b-25be-489a-887b-3648ed4aee7b"), "IE", "Ireland" },
                    { new Guid("d9bb33a5-ffd9-4c90-9ab3-975262df3b0c"), "AT,BE,BG,CY,DE,DK,EE,ES,FI,FR,GR,HR,HU,IE,IT,LT,LU,LV,MT,NL", "European Union" },
                    { new Guid("da3849a2-53de-40e7-b503-992844b17826"), "PS", "Palestine, State of" },
                    { new Guid("daaba39f-8b75-45e1-a0c8-09e7a9f94fee"), "PK", "Pakistan" },
                    { new Guid("dc39b266-7bf8-4f97-86a0-0caf818d7011"), "AT", "Austria" },
                    { new Guid("dc6e84e9-760a-4e4c-a609-2fe1862de5be"), "SE", "Sweden" },
                    { new Guid("df8e6e02-877c-41b1-8592-ca670149f51a"), "LT", "Lithuania" },
                    { new Guid("e066f248-6d57-483d-a80c-809eaac3a49d"), "CG", "Congo" },
                    { new Guid("e0f0e607-135c-4b58-9ef4-22c6af85f9dc"), "LU", "Luxembourg" },
                    { new Guid("e10b3793-39b8-476c-92c8-4a011d7441c2"), "VE", "Venezuela" },
                    { new Guid("e208a94f-1732-4599-ac61-ddc46686f357"), "CI", "Côte d'Ivoire" },
                    { new Guid("e22402ce-a9f5-4ec7-b848-fbd8de296822"), "GT", "Guatemala" },
                    { new Guid("e5820efe-a599-4fdf-bf6b-10f94695a300"), "FJ", "Fiji" },
                    { new Guid("eae0d86d-093a-474d-8c89-b1aa4576bea4"), "TD", "Chad" },
                    { new Guid("eba1de11-faf4-4162-9052-041233f1044d"), "BJ", "Benin" },
                    { new Guid("ee85b80e-e2c8-41ec-b702-e819841a00e6"), "MS", "Montserrat, United Kingdom" },
                    { new Guid("f11da8b4-72b7-4a7a-8b19-e96417eb95e2"), "EC", "Ecuador" },
                    { new Guid("f2e33efa-6c4d-4b79-af76-ca11bc127216"), "SI", "Slovenia" },
                    { new Guid("f477f1b3-6e9c-4b37-aef1-391a84da01a0"), "CH", "Switzerland" },
                    { new Guid("f55ab587-7ed5-48b1-a546-a5bc632a83f1"), "914", "ICC (International Criminal Court)" },
                    { new Guid("f6e9ff0a-4902-4a01-90e4-fa66540f3364"), "GM", "Gambia" },
                    { new Guid("f6f4d0de-553c-4277-95fe-23b3e9f21dc6"), "MK", "North Macedonia" },
                    { new Guid("f74314ca-fda5-4f13-b387-dacd24746309"), "MZ", "Mozambique" },
                    { new Guid("f91e2f8e-7ced-4d1c-a7a9-ff0bd84288a4"), "HK", "Hong Kong, China" },
                    { new Guid("fa7a9f5e-a42a-40ea-b117-4743c03b3841"), "FR", "France" },
                    { new Guid("fadfd2ff-c307-41ff-9b47-bdd986af8060"), "BZ", "Belize" },
                    { new Guid("fafcb720-3e0d-4e64-8abc-6425b847183a"), "916", "STL (Special Tribunal for Lebanon)" },
                    { new Guid("ff24c00e-19f6-4b4c-9e34-4ca771af34fb"), "LR", "Liberia" },
                    { new Guid("ff2b29f5-f4dc-42b7-b70c-27f24b94fb58"), "MC", "Monaco" }
                });
        }
    }
}
