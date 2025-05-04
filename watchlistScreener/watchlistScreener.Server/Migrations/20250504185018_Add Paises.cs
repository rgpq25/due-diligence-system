using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace watchlistScreener.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddPaises : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pais",
                table: "Proveedores");

            migrationBuilder.AddColumn<Guid>(
                name: "PaisId",
                table: "Proveedores",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.Id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Proveedores_PaisId",
                table: "Proveedores",
                column: "PaisId");

            migrationBuilder.AddForeignKey(
                name: "FK_Proveedores_Paises_PaisId",
                table: "Proveedores",
                column: "PaisId",
                principalTable: "Paises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proveedores_Paises_PaisId",
                table: "Proveedores");

            migrationBuilder.DropTable(
                name: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Proveedores_PaisId",
                table: "Proveedores");

            migrationBuilder.DropColumn(
                name: "PaisId",
                table: "Proveedores");

            migrationBuilder.AddColumn<string>(
                name: "Pais",
                table: "Proveedores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
