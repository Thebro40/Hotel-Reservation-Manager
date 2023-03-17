using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_Reservation_Manager.data.migrations
{
    public partial class AddedNaviPropsToReservation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Reservations_ReservationId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_ReservationId",
                table: "Rooms");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "01ad6a6a-0e57-4dad-a9dd-d6f9520a0f0f", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "04a8ec0f-249c-4013-b104-6dcd9906fcf0", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "0545f90a-70d8-4935-a049-95cf2d764afc", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "12c49bdf-8b79-46fa-93bd-9c806a42a146", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "171b17a3-bdf5-4e8b-a973-9695a905a338", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1be25721-5914-4520-8741-b46dcbddfaa6", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1c84c71d-a231-4b0a-92f0-97569eff3cc7", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2138aa1f-9037-41f4-955c-7f218c5b0c87", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2225cf23-2c7b-4035-94fe-4ef508c2da67", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "22b970d9-a138-441b-876e-906a2a80494a", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "23cf7c2f-acd3-45c1-9ea5-b59eb515db2e", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "24d6c12c-8d02-4e5a-8090-7e9c56e18095", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2e2e8e50-23a6-4e49-8188-8f074f7fb7a7", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "30204ffa-f756-411d-be05-b7efae209e0c", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "30d582e8-70e8-4e53-a189-ff87f6d4ff52", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "310a0bf1-44fa-45ef-9cc2-c80291d88f15", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "3141bfe2-4ea1-4703-9e76-9480aa913aeb", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "317f785b-6bf7-474e-8293-a8ee6d8a797f", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "32a5628d-7679-48d4-b81e-92ef61d50b81", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "36939b51-52e7-4b14-b3de-f5b2f1465bbb", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "3844a9df-77a3-4109-8ec9-eb8b50b77aaf", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "3b2b43e2-6a06-41fc-a23b-997ffe1d5a86", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "40055042-e587-4376-a14c-f42d858661a1", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "40dee55d-c036-4c00-8122-3fbe18a08291", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4264826e-90e0-421a-bddc-4a2c3e70433c", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "42835c46-e5ec-4229-aac3-08225ff7459e", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "441e75fc-9c7e-458d-b9b5-602d2ac24fff", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "49349abd-1cb6-4022-86fd-fbbbe7ec0c63", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4f8f4799-ffe4-47da-9e85-7df893f60687", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "515df932-7769-4581-b590-032eb391309d", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "53113d5a-7904-4b09-a41e-0a82452b5644", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5368e623-15e5-468f-9520-709495f69c6b", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5385dbad-b1b3-4b2d-8b32-cbe801d10aac", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "55759b4a-ea02-4314-8736-52c4a1ff9a17", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "56711d20-388a-4f66-86ad-18adccc6f80d", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "57c6dc2b-d42b-46e7-913c-c1ac44dc54bc", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5d7e0bc8-c6f8-4b3f-93e8-05b2d99e061e", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5dcea69b-a35a-4033-a4ca-515e41778834", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5f310e6e-f60f-49d8-aade-521799d45867", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "691c2734-906d-4244-bc38-34b8f1c422c4", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "699d13d3-6e14-44e9-959d-30e13c24e3b6", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6ec19c6b-7ae7-4df0-bb7a-1110d4b3671a", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6ef61d9e-67a3-410d-8e79-2f4ef2e73923", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6f02b90d-5286-48e0-afeb-4f4b9f51d471", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "72bae118-1a8e-4b6d-9a22-ff1c06f7a48d", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "744619b6-8c7f-4a8a-a1c9-767df6828f83", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7865dbbc-2034-45ef-924f-a19c6a7f5c8a", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7a1e3e1d-5eb6-4c94-8081-25620210fce3", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7f82a25e-b33f-4bb6-b038-819eccf813ae", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "81c2396b-664d-4725-aea3-111cb1668a14", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "82feddcd-2cfb-495a-a05e-fb55a4936ab9", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "83bd512b-329e-4f95-b7c1-9e7b45cc485b", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "87a7ecc6-d13f-4bad-b2b0-a026ae797c81", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8817f1a3-c1f8-458e-9174-89014698e0aa", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8880a31f-9062-49c8-97d3-5d0ff02e3b37", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "89bfc529-d0b8-480f-9194-5fb38d831e4d", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8e445864-a24d-4543-a6c6-9443d048cdb9", "6ecf672a-137e-4458-91b1-120bd23252c4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8f76f16c-b419-466c-a699-a381f5dbbb42", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "90bf7e12-ba0d-4529-ac3d-10408a10b48e", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "9349cb3d-2c32-4922-9ae8-f9c12e2f6574", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "973b3385-2c52-4e43-973e-742c5359bb10", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "999daf2b-0bf0-4f99-820e-009c1da8a85b", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "9ab9700e-aab5-4987-9bd9-20b19d0bac0a", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "9c250e9b-8343-4dfa-8d94-f650bda4e60d", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "9d4d1efa-6fac-454c-8dbd-492ab1e5f64f", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "9f1b6d0f-d448-4d04-998b-dfad94deb32a", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a382f457-031f-430c-a779-ad6066f00e59", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a7109c8e-6c15-48b2-bdf0-594301c41e95", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a8fd7085-15b7-4388-ad92-d0a7f8dfac02", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a976ff9e-2c2a-4ec2-bf1a-4e45dc48164e", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ac39ebb6-dd26-4157-88f3-2b3e617a4b77", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b0cd465c-70a4-41ed-84da-865165952cbf", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b26593e8-a8f4-4621-838e-3aa8e357a634", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b5e3b998-84e8-4fea-898f-4a02df84fb50", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b800df25-389b-464d-8a05-5ef5c5c43e96", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "bab17fa2-ff82-4dea-babc-527f16db3e78", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "be539df8-60ce-4dec-a1d0-e86bd541fe12", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "bfee186b-8f7f-47bf-ac1a-c96c31f43885", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c2f8a7a5-6a3f-469b-bcb4-3f85af10cc9b", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c601ea23-624b-450c-9579-0d1b7bba71be", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c806d3d2-b999-49f6-98a8-5e4beca42e4f", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c97b2b92-476b-4882-bace-338e944a07f8", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "caa54bf4-373c-48b3-a1c3-c5af356fe05d", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "cb235131-5172-4c2e-a910-423583f1979c", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d20dfd6b-8d25-4e9c-947c-6feb1333d483", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d5bbd992-b8a9-470a-948f-1806318c7807", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e46f9d0c-a7d3-405a-9493-94d75f6c52dd", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e5685cfe-3f9e-4366-aca6-0ddc300f4115", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e69ff9b9-7034-451a-a9af-f01929d6c682", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e967aedd-34ec-42d5-aabb-fe64a99a480b", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e96d0d8a-6a34-4d26-afd4-f7fa9c9af648", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ebfbfc66-bd23-4aaa-8a8a-6e6d4cc3bed0", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ece9887d-2925-4beb-95a1-8f6860452b07", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ed024312-f08c-42a3-9352-0a99fe6a67ab", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f05abb57-5fe4-4d1f-972c-516b5768598c", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f355fbfe-827d-4f58-84df-89fe35f5cde9", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f521e9c8-1992-461b-9056-c65bdf80f32a", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f5f75346-834c-465c-a299-72f791085292", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f706bf8c-ffba-4985-a1c4-5458b05cb7e9", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f7868b05-734f-4a3a-9844-fc4baef6c192", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ff2a668d-148a-42fa-82a6-58f5f7cbb15e", "863f63b8-943c-40a1-bae5-529fc38ce420" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ecf672a-137e-4458-91b1-120bd23252c4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "863f63b8-943c-40a1-bae5-529fc38ce420");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01ad6a6a-0e57-4dad-a9dd-d6f9520a0f0f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04a8ec0f-249c-4013-b104-6dcd9906fcf0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0545f90a-70d8-4935-a049-95cf2d764afc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12c49bdf-8b79-46fa-93bd-9c806a42a146");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "171b17a3-bdf5-4e8b-a973-9695a905a338");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1be25721-5914-4520-8741-b46dcbddfaa6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1c84c71d-a231-4b0a-92f0-97569eff3cc7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2138aa1f-9037-41f4-955c-7f218c5b0c87");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2225cf23-2c7b-4035-94fe-4ef508c2da67");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22b970d9-a138-441b-876e-906a2a80494a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23cf7c2f-acd3-45c1-9ea5-b59eb515db2e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24d6c12c-8d02-4e5a-8090-7e9c56e18095");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e2e8e50-23a6-4e49-8188-8f074f7fb7a7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30204ffa-f756-411d-be05-b7efae209e0c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30d582e8-70e8-4e53-a189-ff87f6d4ff52");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "310a0bf1-44fa-45ef-9cc2-c80291d88f15");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3141bfe2-4ea1-4703-9e76-9480aa913aeb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "317f785b-6bf7-474e-8293-a8ee6d8a797f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32a5628d-7679-48d4-b81e-92ef61d50b81");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36939b51-52e7-4b14-b3de-f5b2f1465bbb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3844a9df-77a3-4109-8ec9-eb8b50b77aaf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b2b43e2-6a06-41fc-a23b-997ffe1d5a86");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40055042-e587-4376-a14c-f42d858661a1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40dee55d-c036-4c00-8122-3fbe18a08291");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4264826e-90e0-421a-bddc-4a2c3e70433c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42835c46-e5ec-4229-aac3-08225ff7459e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "441e75fc-9c7e-458d-b9b5-602d2ac24fff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49349abd-1cb6-4022-86fd-fbbbe7ec0c63");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f8f4799-ffe4-47da-9e85-7df893f60687");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "515df932-7769-4581-b590-032eb391309d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53113d5a-7904-4b09-a41e-0a82452b5644");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5368e623-15e5-468f-9520-709495f69c6b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5385dbad-b1b3-4b2d-8b32-cbe801d10aac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55759b4a-ea02-4314-8736-52c4a1ff9a17");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56711d20-388a-4f66-86ad-18adccc6f80d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57c6dc2b-d42b-46e7-913c-c1ac44dc54bc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5d7e0bc8-c6f8-4b3f-93e8-05b2d99e061e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5dcea69b-a35a-4033-a4ca-515e41778834");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5f310e6e-f60f-49d8-aade-521799d45867");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "691c2734-906d-4244-bc38-34b8f1c422c4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "699d13d3-6e14-44e9-959d-30e13c24e3b6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6ec19c6b-7ae7-4df0-bb7a-1110d4b3671a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6ef61d9e-67a3-410d-8e79-2f4ef2e73923");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f02b90d-5286-48e0-afeb-4f4b9f51d471");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72bae118-1a8e-4b6d-9a22-ff1c06f7a48d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "744619b6-8c7f-4a8a-a1c9-767df6828f83");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7865dbbc-2034-45ef-924f-a19c6a7f5c8a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a1e3e1d-5eb6-4c94-8081-25620210fce3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7f82a25e-b33f-4bb6-b038-819eccf813ae");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "81c2396b-664d-4725-aea3-111cb1668a14");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82feddcd-2cfb-495a-a05e-fb55a4936ab9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83bd512b-329e-4f95-b7c1-9e7b45cc485b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87a7ecc6-d13f-4bad-b2b0-a026ae797c81");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8817f1a3-c1f8-458e-9174-89014698e0aa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8880a31f-9062-49c8-97d3-5d0ff02e3b37");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "89bfc529-d0b8-480f-9194-5fb38d831e4d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f76f16c-b419-466c-a699-a381f5dbbb42");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90bf7e12-ba0d-4529-ac3d-10408a10b48e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9349cb3d-2c32-4922-9ae8-f9c12e2f6574");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "973b3385-2c52-4e43-973e-742c5359bb10");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "999daf2b-0bf0-4f99-820e-009c1da8a85b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ab9700e-aab5-4987-9bd9-20b19d0bac0a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c250e9b-8343-4dfa-8d94-f650bda4e60d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9d4d1efa-6fac-454c-8dbd-492ab1e5f64f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f1b6d0f-d448-4d04-998b-dfad94deb32a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a382f457-031f-430c-a779-ad6066f00e59");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7109c8e-6c15-48b2-bdf0-594301c41e95");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8fd7085-15b7-4388-ad92-d0a7f8dfac02");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a976ff9e-2c2a-4ec2-bf1a-4e45dc48164e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ac39ebb6-dd26-4157-88f3-2b3e617a4b77");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0cd465c-70a4-41ed-84da-865165952cbf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b26593e8-a8f4-4621-838e-3aa8e357a634");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b5e3b998-84e8-4fea-898f-4a02df84fb50");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b800df25-389b-464d-8a05-5ef5c5c43e96");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bab17fa2-ff82-4dea-babc-527f16db3e78");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be539df8-60ce-4dec-a1d0-e86bd541fe12");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bfee186b-8f7f-47bf-ac1a-c96c31f43885");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2f8a7a5-6a3f-469b-bcb4-3f85af10cc9b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c601ea23-624b-450c-9579-0d1b7bba71be");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c806d3d2-b999-49f6-98a8-5e4beca42e4f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c97b2b92-476b-4882-bace-338e944a07f8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "caa54bf4-373c-48b3-a1c3-c5af356fe05d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb235131-5172-4c2e-a910-423583f1979c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d20dfd6b-8d25-4e9c-947c-6feb1333d483");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5bbd992-b8a9-470a-948f-1806318c7807");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e46f9d0c-a7d3-405a-9493-94d75f6c52dd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5685cfe-3f9e-4366-aca6-0ddc300f4115");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e69ff9b9-7034-451a-a9af-f01929d6c682");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e967aedd-34ec-42d5-aabb-fe64a99a480b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e96d0d8a-6a34-4d26-afd4-f7fa9c9af648");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ebfbfc66-bd23-4aaa-8a8a-6e6d4cc3bed0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ece9887d-2925-4beb-95a1-8f6860452b07");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed024312-f08c-42a3-9352-0a99fe6a67ab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f05abb57-5fe4-4d1f-972c-516b5768598c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f355fbfe-827d-4f58-84df-89fe35f5cde9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f521e9c8-1992-461b-9056-c65bdf80f32a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f5f75346-834c-465c-a299-72f791085292");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f706bf8c-ffba-4985-a1c4-5458b05cb7e9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7868b05-734f-4a3a-9844-fc4baef6c192");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff2a668d-148a-42fa-82a6-58f5f7cbb15e");

            migrationBuilder.AlterColumn<string>(
                name: "ReservationId",
                table: "Rooms",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerId",
                table: "Reservations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RoomId",
                table: "Reservations",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a7476f94-9c6c-4d0b-a491-ccbd22708d63", "e7dfd218-84db-48d3-ae51-d4681510b515", "User", "USER" },
                    { "9a6f1070-687d-4e46-bf4d-cee6ff8371a5", "9101721b-fbf6-49b4-a742-d62429e4fe2e", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445864-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "HireDate", "PasswordHash" },
                values: new object[] { "55d23f89-57e3-4474-96b1-2bc7829ac799", new DateTime(2023, 3, 17, 9, 47, 44, 43, DateTimeKind.Local).AddTicks(1252), "AQAAAAEAACcQAAAAENd/iJjcba0++o9TmTOFpsAI5SPmauQZkuUOXp/H6byi7Xhdb7enESC8tC7JQDblxg==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "EGN", "Email", "EmailConfirmed", "FireDate", "FirstName", "HireDate", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "d32bf7d5-018b-4223-8665-eef67f66e406", 0, "cd6b95ca-a99d-4da8-8606-91558a39f6dd", "009892", "user98@abv.bg", true, null, "Jack", new DateTime(2023, 3, 17, 9, 47, 44, 868, DateTimeKind.Local).AddTicks(4064), true, "Alexandrov", false, null, "Jack", "user98@abv.bg", "user98@abv.bg", "AQAAAAEAACcQAAAAEKwNGI38XrM9WkDKEsG1VyDUmucJL+sSbzhIANmRGaeXv1Yyy6miPaiAs04lmGmORQ==", "007083", true, "", false, "user98@abv.bg" },
                    { "a497ada4-a3db-47fb-bbcf-ea766a3e3024", 0, "7780b276-b409-460f-b751-9b093ee4c655", "009907", "user72@abv.bg", true, null, "Alex", new DateTime(2023, 3, 17, 9, 47, 44, 659, DateTimeKind.Local).AddTicks(8354), true, "Johnson", false, null, "Alex", "user72@abv.bg", "user72@abv.bg", "AQAAAAEAACcQAAAAEAeMt0OJDclc34bYwgFbc5TWqw8+HI3P7HBB16r4PCtOTej6y1udxYOVV6TxlH4X5Q==", "004790", true, "", false, "user72@abv.bg" },
                    { "926186a8-f496-4025-82c6-1fc2878bdffc", 0, "c0296bbc-97a0-4827-9551-2e9967bb468e", "004211", "user71@abv.bg", true, null, "Jane", new DateTime(2023, 3, 17, 9, 47, 44, 652, DateTimeKind.Local).AddTicks(448), true, "Alexandrov", false, null, "Alex", "user71@abv.bg", "user71@abv.bg", "AQAAAAEAACcQAAAAEFii/vVNEOaY3OU6Al6FjTk1DhkuOFrwhlgFQi/IYmhnX5eTexKt5jmFofwYFfj1oA==", "000682", true, "", false, "user71@abv.bg" },
                    { "fce64203-c0a0-455c-bc9e-d244928a00ee", 0, "778a3b0f-9a43-46da-a0f1-b8b9e14bc3c0", "000132", "user70@abv.bg", true, null, "Jane", new DateTime(2023, 3, 17, 9, 47, 44, 644, DateTimeKind.Local).AddTicks(4340), true, "Johnson", false, null, "Jane", "user70@abv.bg", "user70@abv.bg", "AQAAAAEAACcQAAAAEBG19gtc0wRakeBMvUcNTnHZwj2f8QVUNuS2RMchGOfJvx2t3fDMkvXz9MZFI9LBpA==", "007709", true, "", false, "user70@abv.bg" },
                    { "ea57e053-4eba-4dd6-9674-1b239bf340e8", 0, "23f012a2-6c7d-404a-b389-1f208f6db2a2", "003720", "user69@abv.bg", true, null, "John", new DateTime(2023, 3, 17, 9, 47, 44, 636, DateTimeKind.Local).AddTicks(5078), true, "Alexandrov", false, null, "Jane", "user69@abv.bg", "user69@abv.bg", "AQAAAAEAACcQAAAAECdAQ98JfYo9Zr4r3JpWXThjOJha7EvEMrzAHXd9rwCujs0hdz7FQKqslHiyJOTOKg==", "005531", true, "", false, "user69@abv.bg" },
                    { "b35682ad-ec89-4d99-b50d-8aa50f64a543", 0, "3485636c-4d54-4076-97f5-9c069c327067", "000804", "user68@abv.bg", true, null, "Jane", new DateTime(2023, 3, 17, 9, 47, 44, 628, DateTimeKind.Local).AddTicks(730), true, "Alexandrov", false, null, "Jack", "user68@abv.bg", "user68@abv.bg", "AQAAAAEAACcQAAAAEGuGoA2DABaonHm9ise+vsIxuzhJGi22TiqSg70u5yduzJcxAOPn8PmIMsRofAG4lw==", "005721", true, "", false, "user68@abv.bg" },
                    { "d556448d-e65d-48fd-87f4-d654f544ac7d", 0, "5b046f23-3bd2-49d5-9333-3da1caf2018d", "000260", "user67@abv.bg", true, null, "Jack", new DateTime(2023, 3, 17, 9, 47, 44, 618, DateTimeKind.Local).AddTicks(8207), true, "Alexandrov", false, null, "Jane", "user67@abv.bg", "user67@abv.bg", "AQAAAAEAACcQAAAAEABUNxG5MuWmPFzQLEHjdFNSlJlFgp7NlEYsHbMp6TmAFC+ZbAimosA2FogaBX41Ow==", "002208", true, "", false, "user67@abv.bg" },
                    { "43baaf25-0eb1-4b08-abf6-47b0c27047b3", 0, "bc723c43-fe92-4ac0-bdf1-9eb9e8fe3b19", "001463", "user66@abv.bg", true, null, "Alex", new DateTime(2023, 3, 17, 9, 47, 44, 610, DateTimeKind.Local).AddTicks(4991), true, "Alexandrov", false, null, "Jane", "user66@abv.bg", "user66@abv.bg", "AQAAAAEAACcQAAAAEKs1BrO+OHy/L6hrdFlk8pwTIh5Xyj6ktuScHD/pxlQ10GR3Lj9X1bGfJ8dpQL2ImQ==", "009152", true, "", false, "user66@abv.bg" },
                    { "694c5c68-6350-454a-988b-a5c41abbb9cd", 0, "a52c8214-0f2a-4d12-b5c8-7b890d176062", "006366", "user65@abv.bg", true, null, "Alex", new DateTime(2023, 3, 17, 9, 47, 44, 601, DateTimeKind.Local).AddTicks(268), true, "Johnson", false, null, "Jane", "user65@abv.bg", "user65@abv.bg", "AQAAAAEAACcQAAAAELKlC7jyfmYgL1ofa6A++p0vibW1z90vSBrty6xjVtvffGzWzQzfsy5fu2sdQk2hRg==", "001528", true, "", false, "user65@abv.bg" },
                    { "9ad9e070-8ba6-49ee-b399-aae6bfe04cbc", 0, "7e3ffd90-305b-4452-879e-1a806b92ce4f", "003867", "user64@abv.bg", true, null, "Alex", new DateTime(2023, 3, 17, 9, 47, 44, 592, DateTimeKind.Local).AddTicks(7299), true, "Johnson", false, null, "Jack", "user64@abv.bg", "user64@abv.bg", "AQAAAAEAACcQAAAAEOtlO8Olt46gfM9j7qYruN/sfuFQK1Lw0RNGa14IN7lDtO84Qw3sixWknHcI3umXrg==", "008130", true, "", false, "user64@abv.bg" },
                    { "385e32d0-0ed3-489c-aac3-0757274f1e85", 0, "a9fead8c-8fae-4ac9-967c-4cb9f9b6e75a", "002453", "user73@abv.bg", true, null, "Jane", new DateTime(2023, 3, 17, 9, 47, 44, 668, DateTimeKind.Local).AddTicks(5262), true, "Johnson", false, null, "Alex", "user73@abv.bg", "user73@abv.bg", "AQAAAAEAACcQAAAAEJ2HSyLtBGkQGHlJM9EMaLCKqlubg9uHMQCB0fZRgdBWrlNShPDK3fVRD0AEYGG3Kg==", "009106", true, "", false, "user73@abv.bg" },
                    { "758a4456-20fe-4ae5-889f-245aca37dabb", 0, "525c9f42-37c2-4b63-978c-cb7425537f23", "007687", "user63@abv.bg", true, null, "Jane", new DateTime(2023, 3, 17, 9, 47, 44, 584, DateTimeKind.Local).AddTicks(5899), true, "Alexandrov", false, null, "John", "user63@abv.bg", "user63@abv.bg", "AQAAAAEAACcQAAAAEH0qMBmmVE6SSOazjq17tqzMiqTWQXD9ywasaGhTu4+CbQCLLIVKFKz8/PP6X/+Niw==", "007595", true, "", false, "user63@abv.bg" },
                    { "b4fdcaea-950c-4ad5-8235-763a5c6b42d7", 0, "6864c152-f8b4-45c6-a2f9-662bbd9a1a0d", "005214", "user61@abv.bg", true, null, "Jane", new DateTime(2023, 3, 17, 9, 47, 44, 564, DateTimeKind.Local).AddTicks(7189), true, "Johnson", false, null, "John", "user61@abv.bg", "user61@abv.bg", "AQAAAAEAACcQAAAAEKksIysIebYbbDseisiemdZiyERh9UzmkcrE717K+QsFhALeJLpKRcY49I+4OK4NUQ==", "006929", true, "", false, "user61@abv.bg" },
                    { "db070855-fc49-4303-8919-95ad8d716add", 0, "1a51cb95-62ac-4ed6-9d44-1a46aa2d4541", "009510", "user60@abv.bg", true, null, "Jane", new DateTime(2023, 3, 17, 9, 47, 44, 554, DateTimeKind.Local).AddTicks(6141), true, "Johnson", false, null, "Jane", "user60@abv.bg", "user60@abv.bg", "AQAAAAEAACcQAAAAENJeLG3v5C/q5whlvLFWSq1JmacYA1Yhl4o5nD0FXibkT0UuAaPtPewgW/aWdP2j3g==", "000877", true, "", false, "user60@abv.bg" },
                    { "ef5e8cf8-2270-4dbb-9a85-9cf1174dca18", 0, "7acce894-acc8-4990-8611-b391777c21ba", "006400", "user59@abv.bg", true, null, "Alex", new DateTime(2023, 3, 17, 9, 47, 44, 544, DateTimeKind.Local).AddTicks(961), true, "Alexandrov", false, null, "Jane", "user59@abv.bg", "user59@abv.bg", "AQAAAAEAACcQAAAAELuAU8Ej5y/zJey0eOwLeMB9h+X9pI2JFabeTGx9CWBqIG+mmWhG35HpkuqCfmjgow==", "003645", true, "", false, "user59@abv.bg" },
                    { "832b538c-d1d6-4252-bc31-486e0dc0c6ac", 0, "c9b063fa-359d-4676-9b35-8fef05e85483", "009942", "user58@abv.bg", true, null, "Jack", new DateTime(2023, 3, 17, 9, 47, 44, 531, DateTimeKind.Local).AddTicks(9711), true, "Johnson", false, null, "Jane", "user58@abv.bg", "user58@abv.bg", "AQAAAAEAACcQAAAAEKnOJWu1Ag2OwxK8eVNx6vqxn9SEejxideTHhfAyGxbXCj6gRvdUefCeilp+jCqUFw==", "008946", true, "", false, "user58@abv.bg" },
                    { "4c3c00bc-172b-4363-8c04-1535a5e9d664", 0, "2d36ddaf-fc01-4b84-8722-eb673c6fd52f", "001466", "user57@abv.bg", true, null, "John", new DateTime(2023, 3, 17, 9, 47, 44, 520, DateTimeKind.Local).AddTicks(6405), true, "Johnson", false, null, "Alex", "user57@abv.bg", "user57@abv.bg", "AQAAAAEAACcQAAAAEAhSJuiiBeIH/ZMxnj9NttA9nFqboMftUpBATd2EMChVUlr8hGYpB5bNXRWvos1e6g==", "001942", true, "", false, "user57@abv.bg" },
                    { "7d5ff411-3bcb-4707-ae87-6d9338584d9b", 0, "6bb3af42-c6e0-4f62-be2b-0197f2b5e672", "006833", "user56@abv.bg", true, null, "Alex", new DateTime(2023, 3, 17, 9, 47, 44, 509, DateTimeKind.Local).AddTicks(5054), true, "Alexandrov", false, null, "Jane", "user56@abv.bg", "user56@abv.bg", "AQAAAAEAACcQAAAAECZqs5JhITdDXhvqot6NkmJCjoR0wxdPPU28qDuZ/dpT43/c2oY/6ZRMItdKy9JYow==", "009965", true, "", false, "user56@abv.bg" },
                    { "70ba5e2f-cc7b-474f-8e66-9d30aee80108", 0, "87ba3cb1-8f6e-4b84-a3e7-0ef18bfcd323", "006399", "user55@abv.bg", true, null, "Jane", new DateTime(2023, 3, 17, 9, 47, 44, 497, DateTimeKind.Local).AddTicks(2664), true, "Johnson", false, null, "Jane", "user55@abv.bg", "user55@abv.bg", "AQAAAAEAACcQAAAAEGuQziiBe7eUCdXoQRvYfiGRWBlaf20yfen+4TQyQLu9lnS3hvtp4ryuwkcgjJT6rg==", "004873", true, "", false, "user55@abv.bg" },
                    { "b46a4033-75e1-4b67-9823-02bdf43988df", 0, "010dae4e-6d1d-4b25-958a-c495dd0e07bf", "004737", "user54@abv.bg", true, null, "John", new DateTime(2023, 3, 17, 9, 47, 44, 487, DateTimeKind.Local).AddTicks(6228), true, "Alexandrov", false, null, "John", "user54@abv.bg", "user54@abv.bg", "AQAAAAEAACcQAAAAELAwV5EOskG5p7Zxv0sdoVr5X0imPpg9Pvx3/52bZPkTpb8gsRbWJA0uknrwROIgMw==", "009775", true, "", false, "user54@abv.bg" },
                    { "accffeb1-d844-4b82-aa80-b33257a8d5e3", 0, "f77664cc-a94a-4609-828c-d981712e4443", "001680", "user53@abv.bg", true, null, "Jane", new DateTime(2023, 3, 17, 9, 47, 44, 476, DateTimeKind.Local).AddTicks(9769), true, "Alexandrov", false, null, "Jane", "user53@abv.bg", "user53@abv.bg", "AQAAAAEAACcQAAAAECjn+ihKmIWibsP4AQz/tWS+B+Xgui7pxqPUjuF8kx8vBSPDVSfkfR6XmMm8fZc64w==", "002074", true, "", false, "user53@abv.bg" },
                    { "05984939-e431-4a74-8628-5daed308320f", 0, "ecec03fd-f223-4894-be9b-d755f6480be3", "003169", "user62@abv.bg", true, null, "Jack", new DateTime(2023, 3, 17, 9, 47, 44, 574, DateTimeKind.Local).AddTicks(7364), true, "Johnson", false, null, "Jane", "user62@abv.bg", "user62@abv.bg", "AQAAAAEAACcQAAAAEL2CFMSbTbKfnhLO/cBX6JdTE42hbfb57MSzwHAScFA78X8pdZwAhV2MSseivXDWTQ==", "007196", true, "", false, "user62@abv.bg" },
                    { "bd00c6fc-6a35-48bf-a53e-571766158cc2", 0, "38220be3-7b17-4cf7-b9d4-2936ac43ceee", "008018", "user74@abv.bg", true, null, "Jack", new DateTime(2023, 3, 17, 9, 47, 44, 676, DateTimeKind.Local).AddTicks(4500), true, "Alexandrov", false, null, "Alex", "user74@abv.bg", "user74@abv.bg", "AQAAAAEAACcQAAAAENrRzjCYFq/xZeuhhZ46UzIru2W0PrSyDj0AfQdduZKV7r1QbU9imdpOWOLgvrjWqw==", "005560", true, "", false, "user74@abv.bg" },
                    { "5aad2227-e9da-4dec-b827-ed6a4ee39cb6", 0, "4404d780-094b-4618-ac72-52f2386f0b9c", "004756", "user75@abv.bg", true, null, "Jack", new DateTime(2023, 3, 17, 9, 47, 44, 684, DateTimeKind.Local).AddTicks(4846), true, "Alexandrov", false, null, "John", "user75@abv.bg", "user75@abv.bg", "AQAAAAEAACcQAAAAEL38HzxBQ6bZ6ZQXH3vX/mMM50q8snO/uD1u12FGJZxJGZERvq/wMKqaNPsUK5arxA==", "008687", true, "", false, "user75@abv.bg" },
                    { "f0b4ce71-22cb-45bb-8346-d3a8952c8bbf", 0, "c81a6923-aaff-48a1-87ff-9d5bee0f890b", "002114", "user52@abv.bg", true, null, "John", new DateTime(2023, 3, 17, 9, 47, 44, 466, DateTimeKind.Local).AddTicks(7212), true, "Johnson", false, null, "Alex", "user52@abv.bg", "user52@abv.bg", "AQAAAAEAACcQAAAAEL4qR8ivrDA+rak3mrC0qQx8uzGXvlIVC4r7C3R7QQA3by7+uUlSiXwVT4PoR00sAg==", "008848", true, "", false, "user52@abv.bg" },
                    { "35427986-7481-401a-b629-1b626439d138", 0, "ecdb7334-e6ca-4e18-b4dd-1427127d74f3", "004037", "user97@abv.bg", true, null, "Jack", new DateTime(2023, 3, 17, 9, 47, 44, 860, DateTimeKind.Local).AddTicks(1616), true, "Alexandrov", false, null, "John", "user97@abv.bg", "user97@abv.bg", "AQAAAAEAACcQAAAAEBiyq0K8ZiK9PwQwE+XZPp6RzPxoYECXJzPIwgonC04QBLp32bctFGlrc6PEQiZbqA==", "001028", true, "", false, "user97@abv.bg" },
                    { "3c1591e4-ebdf-4276-b7d8-48218c11e195", 0, "95d00cf4-c4b0-44b0-82ec-9ce4529a77f9", "004616", "user96@abv.bg", true, null, "Jack", new DateTime(2023, 3, 17, 9, 47, 44, 852, DateTimeKind.Local).AddTicks(4100), true, "Johnson", false, null, "Jane", "user96@abv.bg", "user96@abv.bg", "AQAAAAEAACcQAAAAEK7Q6whzcdaaYTNmSG4I5nj+cXsYMHcKzP30LS+w/JFywiqI8Z/R0K/yzWCcUkY8xw==", "009473", true, "", false, "user96@abv.bg" },
                    { "efb8e81e-33f8-47b3-8bfd-d519b27b2dcb", 0, "bce60c79-69c0-43f1-8c1e-7d23e14dfc72", "001732", "user95@abv.bg", true, null, "Jack", new DateTime(2023, 3, 17, 9, 47, 44, 844, DateTimeKind.Local).AddTicks(8979), true, "Alexandrov", false, null, "John", "user95@abv.bg", "user95@abv.bg", "AQAAAAEAACcQAAAAECSRjfisKvc0bpn4gRDfwzVWNzfAf5h6tMthwqhsYfUVRRA100CyHll9TIuR/wAvMg==", "003258", true, "", false, "user95@abv.bg" },
                    { "3105418e-0caf-420e-8414-d0252ab1d0de", 0, "4a8cd62d-4bcb-4f43-9c22-651074b1010f", "005625", "user94@abv.bg", true, null, "Alex", new DateTime(2023, 3, 17, 9, 47, 44, 836, DateTimeKind.Local).AddTicks(5383), true, "Alexandrov", false, null, "Alex", "user94@abv.bg", "user94@abv.bg", "AQAAAAEAACcQAAAAEAvuY1iyHT5DgQ9ojX1ZMbUdNERb+rYlNRrohgZyJWO2uRLcE9MTKE4AkbWq66GVdg==", "004917", true, "", false, "user94@abv.bg" },
                    { "70b6e0b9-0819-43a8-94c4-1f3bd5a28f6c", 0, "f3bb96b4-cf78-4a74-8df5-351aad0b9a26", "009719", "user93@abv.bg", true, null, "Jane", new DateTime(2023, 3, 17, 9, 47, 44, 828, DateTimeKind.Local).AddTicks(9824), true, "Alexandrov", false, null, "John", "user93@abv.bg", "user93@abv.bg", "AQAAAAEAACcQAAAAEN2YPLKwGp/i5uWzYhK/CrP7NzJwzDifp/qBdQN7bVIabWdPKKlqwDl+CdtP+xh5wA==", "008618", true, "", false, "user93@abv.bg" },
                    { "07d3fd80-8712-4289-9a25-3959b1592b73", 0, "212291f9-c473-4c5e-875e-c5fa92c5dfab", "009703", "user92@abv.bg", true, null, "Jack", new DateTime(2023, 3, 17, 9, 47, 44, 819, DateTimeKind.Local).AddTicks(5492), true, "Alexandrov", false, null, "Jane", "user92@abv.bg", "user92@abv.bg", "AQAAAAEAACcQAAAAEEU0seOJRVyClHC759oFZbcw3h63RhXUVDXTWbQ5IYHUdJM/cHWguwvNtBplI9GtNg==", "009392", true, "", false, "user92@abv.bg" },
                    { "1c4044bf-f016-4769-a635-1be8568727c4", 0, "bbf6d608-b82b-4518-93fc-9cae76d5da3d", "004884", "user91@abv.bg", true, null, "Jack", new DateTime(2023, 3, 17, 9, 47, 44, 811, DateTimeKind.Local).AddTicks(9458), true, "Alexandrov", false, null, "Alex", "user91@abv.bg", "user91@abv.bg", "AQAAAAEAACcQAAAAEAo/OYcUOnz+i/+waLSifyLwaDHDAeQPASE8cj4u2TN2rSOXfA9G+2SjLurP15o+dw==", "008023", true, "", false, "user91@abv.bg" },
                    { "da320495-b65a-4d99-af12-64d738f0e5b3", 0, "768b8adb-36e8-408f-8e8b-75250aec2dc2", "009598", "user90@abv.bg", true, null, "Jack", new DateTime(2023, 3, 17, 9, 47, 44, 802, DateTimeKind.Local).AddTicks(7503), true, "Johnson", false, null, "Jane", "user90@abv.bg", "user90@abv.bg", "AQAAAAEAACcQAAAAEFxC7+DAcjFj7691PpDswd3XNPZ0reyY4I2yctOFT0Z6V0QcxOZI/2RDv3jv2PkS1w==", "002649", true, "", false, "user90@abv.bg" },
                    { "6e1591e6-dc09-4e82-a519-90595e4673be", 0, "d6d2284c-6ade-4818-8cbe-139f3531a33f", "008686", "user89@abv.bg", true, null, "Alex", new DateTime(2023, 3, 17, 9, 47, 44, 795, DateTimeKind.Local).AddTicks(380), true, "Johnson", false, null, "Alex", "user89@abv.bg", "user89@abv.bg", "AQAAAAEAACcQAAAAEE0teGX4msBdOkdWHlnCEDQmf4On+3LK/FaKohl46SoDKmfWPQ+4MpUoRoW4bqrADw==", "001884", true, "", false, "user89@abv.bg" },
                    { "8d3d0c2e-a984-48fe-b54d-7eb8988fcc8e", 0, "19b9de43-1bef-4398-9ffd-28c8d967dfe5", "008259", "user88@abv.bg", true, null, "Jane", new DateTime(2023, 3, 17, 9, 47, 44, 787, DateTimeKind.Local).AddTicks(1129), true, "Alexandrov", false, null, "Jack", "user88@abv.bg", "user88@abv.bg", "AQAAAAEAACcQAAAAEPAYm6aTGiJT8LdCyqpao//xlfvJZ3YWtxBIL0yKapBpuyesTjABIpg69fVMjRnwCg==", "009982", true, "", false, "user88@abv.bg" },
                    { "480fc1fc-1f3e-4cd2-a7ed-424d1b5a34a5", 0, "213454b1-9677-4ed1-9db3-cf48ce5a1c4d", "006945", "user87@abv.bg", true, null, "Jane", new DateTime(2023, 3, 17, 9, 47, 44, 779, DateTimeKind.Local).AddTicks(216), true, "Alexandrov", false, null, "Jack", "user87@abv.bg", "user87@abv.bg", "AQAAAAEAACcQAAAAEOvx35k1Pv8suzMtqxtjCAjCh1R+P6HPdRRvHv1W4k8GMChpJUAXwDFelYIIVeXUEA==", "003917", true, "", false, "user87@abv.bg" },
                    { "c4f5bdb2-0e0d-43ed-8e10-3b8469ef8171", 0, "b0a662d8-b605-42c7-937c-70cb70515ada", "001510", "user86@abv.bg", true, null, "Jack", new DateTime(2023, 3, 17, 9, 47, 44, 770, DateTimeKind.Local).AddTicks(5877), true, "Alexandrov", false, null, "Jack", "user86@abv.bg", "user86@abv.bg", "AQAAAAEAACcQAAAAEMVQOptTJ5SOHOqD3DWMd8axTYNgqkqR7HS/+bRd1bLK3AlvCMMDMuWcPnTUlWH1KA==", "008062", true, "", false, "user86@abv.bg" },
                    { "b5cdeb10-d9fa-4ad5-b353-d3634055f0da", 0, "2c839fd4-ddc6-4f8c-be94-7787336adbe4", "008094", "user85@abv.bg", true, null, "Jack", new DateTime(2023, 3, 17, 9, 47, 44, 762, DateTimeKind.Local).AddTicks(7095), true, "Johnson", false, null, "Jane", "user85@abv.bg", "user85@abv.bg", "AQAAAAEAACcQAAAAECsMsioBFLFK5SivTC0Lwd1M2RVk4S0RoPg2zCg6iY9NWX4vbFrr5iUGdUWuG1ORfQ==", "004453", true, "", false, "user85@abv.bg" },
                    { "76b92cda-04aa-4aed-8332-8331ab693a5d", 0, "ed62bc39-c38a-4d7b-b11c-42df79b84f9a", "006708", "user84@abv.bg", true, null, "John", new DateTime(2023, 3, 17, 9, 47, 44, 754, DateTimeKind.Local).AddTicks(7943), true, "Johnson", false, null, "Jane", "user84@abv.bg", "user84@abv.bg", "AQAAAAEAACcQAAAAEMHPX43KAeBWXITLCS8m9hIEylggZ5KBSNoOBjimGw2f/6zySVNPB26MNpBrxYUB0w==", "009871", true, "", false, "user84@abv.bg" },
                    { "f7647dc5-9059-4587-b2ad-7761f03bd7c9", 0, "2d67e30f-e5fb-4a29-8b3a-47fa8f8d943c", "007870", "user83@abv.bg", true, null, "John", new DateTime(2023, 3, 17, 9, 47, 44, 747, DateTimeKind.Local).AddTicks(1669), true, "Johnson", false, null, "Jack", "user83@abv.bg", "user83@abv.bg", "AQAAAAEAACcQAAAAEAKI2wt4WHETOdg1/L/3NQvrnXFdASGUCB/HYHuhKp5i+llTJ5CaJC102/ek6gQTMQ==", "006745", true, "", false, "user83@abv.bg" },
                    { "040eb26d-6599-456c-8fca-f5945e08025c", 0, "99d40e12-b566-4f13-bf5b-f87302427718", "000246", "user82@abv.bg", true, null, "Jack", new DateTime(2023, 3, 17, 9, 47, 44, 739, DateTimeKind.Local).AddTicks(1963), true, "Johnson", false, null, "Alex", "user82@abv.bg", "user82@abv.bg", "AQAAAAEAACcQAAAAECxRywgtpQzQXxtcjOzaLJrX83dr2RxOxXG5fH9CA/4xoHnWfM+gFhQzCWHLn8h/rA==", "003533", true, "", false, "user82@abv.bg" },
                    { "dab18a25-a001-48ff-b873-ba59a18586bf", 0, "866f1ccd-415f-4c85-92a8-0b855ed7c6ec", "000974", "user81@abv.bg", true, null, "Alex", new DateTime(2023, 3, 17, 9, 47, 44, 731, DateTimeKind.Local).AddTicks(3273), true, "Johnson", false, null, "Alex", "user81@abv.bg", "user81@abv.bg", "AQAAAAEAACcQAAAAEDtCHnWifr1LHT58wdHn7Ux2C4hY/NZkz6oUW2+gSs9hRbbAjWTWXgpG7/o3Kfo3PQ==", "000333", true, "", false, "user81@abv.bg" },
                    { "785cb93c-8368-4611-88fe-5ae02a139570", 0, "1263c225-564f-4a5d-88c8-50c584aa42cc", "000410", "user80@abv.bg", true, null, "Jane", new DateTime(2023, 3, 17, 9, 47, 44, 723, DateTimeKind.Local).AddTicks(3517), true, "Alexandrov", false, null, "Alex", "user80@abv.bg", "user80@abv.bg", "AQAAAAEAACcQAAAAEHXecx5n1Gi9Zisdlj09lhmTpPPfTRP3+SsNkR5BbhXIfmAYrYBaRfkmdlcxlvLlJA==", "008348", true, "", false, "user80@abv.bg" },
                    { "c082c204-f8ff-48a8-a516-008187c55154", 0, "f9687a5c-c1d2-460d-8dc3-5fc24304839f", "000724", "user79@abv.bg", true, null, "John", new DateTime(2023, 3, 17, 9, 47, 44, 715, DateTimeKind.Local).AddTicks(9065), true, "Alexandrov", false, null, "Jack", "user79@abv.bg", "user79@abv.bg", "AQAAAAEAACcQAAAAEJ8u9CyS3fzeQk08YTMRL5+0UWj58CXWPWi8p9wKuVe3+4Uw2OaiRo2RL/rDCwY3LA==", "000908", true, "", false, "user79@abv.bg" },
                    { "d580f112-d007-47be-a363-66cf3c716a47", 0, "aa42078b-4feb-41dd-b3b8-a4343b99470c", "006934", "user78@abv.bg", true, null, "Jane", new DateTime(2023, 3, 17, 9, 47, 44, 707, DateTimeKind.Local).AddTicks(9493), true, "Johnson", false, null, "Jack", "user78@abv.bg", "user78@abv.bg", "AQAAAAEAACcQAAAAEBdrQYBKceMrbPbzxQ13lOc7EFtyBZ7KoaRien8mDOWhqqu8fxMM5lA+DwBiTwp1Zw==", "005604", true, "", false, "user78@abv.bg" },
                    { "dd87e554-da00-4585-9bf6-71a539048753", 0, "e20852fe-03a2-4a82-aa72-2a657b8cece4", "009336", "user77@abv.bg", true, null, "Jane", new DateTime(2023, 3, 17, 9, 47, 44, 700, DateTimeKind.Local).AddTicks(498), true, "Alexandrov", false, null, "Alex", "user77@abv.bg", "user77@abv.bg", "AQAAAAEAACcQAAAAEDe0o6V4terlgvfv1/fV3dV/wdyC3SdRd1PWRBPIcsV1eGutH4fZyPSoY/K3uujxJw==", "008627", true, "", false, "user77@abv.bg" },
                    { "bc9d1e30-5923-40fe-aec2-c733c5918914", 0, "142baf61-1d4d-4f61-aa21-402fae84a0de", "007535", "user99@abv.bg", true, null, "Jack", new DateTime(2023, 3, 17, 9, 47, 44, 876, DateTimeKind.Local).AddTicks(1773), true, "Johnson", false, null, "Jack", "user99@abv.bg", "user99@abv.bg", "AQAAAAEAACcQAAAAEPBu5ywrJ61Qch2Tb3ZAQH+6Xyyv/VvqLH5G6uFfhM+StdYfHBuegWWZ5dWZyblnFg==", "001272", true, "", false, "user99@abv.bg" },
                    { "d5e64f4f-7a8b-46f0-b889-d455e9812586", 0, "5382d822-c874-43e2-8b06-f55aac54162e", "009384", "user76@abv.bg", true, null, "Jack", new DateTime(2023, 3, 17, 9, 47, 44, 692, DateTimeKind.Local).AddTicks(678), true, "Alexandrov", false, null, "John", "user76@abv.bg", "user76@abv.bg", "AQAAAAEAACcQAAAAEEAph68y9ycY2sU/UX/4dsfKnWHgPG1/PHxdTfgJr7oDENBJONkNtveGResq2+mJZg==", "009949", true, "", false, "user76@abv.bg" },
                    { "19766a36-9a89-495c-92da-e39a7da363ff", 0, "5f41eb74-b51c-42f8-bee9-d6a22386b46d", "004297", "user51@abv.bg", true, null, "Alex", new DateTime(2023, 3, 17, 9, 47, 44, 457, DateTimeKind.Local).AddTicks(4767), true, "Alexandrov", false, null, "Jack", "user51@abv.bg", "user51@abv.bg", "AQAAAAEAACcQAAAAELmiTvCImJIazuroQ0usVnaIYiWgotgFb0PycHTLCZqxtaSE1wDD+7bQ7DFPJzAw4A==", "000854", true, "", false, "user51@abv.bg" },
                    { "15bd6335-ac99-4456-ac03-1d3d346b5db1", 0, "c7cf2367-2ee8-422f-8753-f254294b0bfe", "006803", "user49@abv.bg", true, null, "John", new DateTime(2023, 3, 17, 9, 47, 44, 441, DateTimeKind.Local).AddTicks(4567), true, "Johnson", false, null, "Jane", "user49@abv.bg", "user49@abv.bg", "AQAAAAEAACcQAAAAEBbTUy2Z5e3BqKb5qYrcl/zBcI+U1VLaZ9nKSqcWKStWOGSa+yysZJA+oGquWtR3Hg==", "002117", true, "", false, "user49@abv.bg" },
                    { "4d4fd55e-f189-4a6a-9ede-c8a89f9fb06a", 0, "337f14a4-3d6d-4be9-a7d6-552a6f20a0b4", "008975", "user22@abv.bg", true, null, "Jane", new DateTime(2023, 3, 17, 9, 47, 44, 225, DateTimeKind.Local).AddTicks(8548), true, "Johnson", false, null, "Alex", "user22@abv.bg", "user22@abv.bg", "AQAAAAEAACcQAAAAENhVluv8+R7DkbPcMqDVL3UXbe4ghGwgoGm2LXpHR6eTYylqX7zeGnq5LaAW09E8HA==", "002678", true, "", false, "user22@abv.bg" },
                    { "c0c59c5a-d5cd-4e2c-9947-2860dc1706a2", 0, "a3bde354-68ec-4d7b-a4bd-3304b3338f91", "006988", "user21@abv.bg", true, null, "Jack", new DateTime(2023, 3, 17, 9, 47, 44, 217, DateTimeKind.Local).AddTicks(6004), true, "Johnson", false, null, "Jack", "user21@abv.bg", "user21@abv.bg", "AQAAAAEAACcQAAAAEDb1fgtHtTXKzVchlPvjL7RBAw/jqIu6vB70pfx8jCDFAedshDh7+Jbg8pMjM0Briw==", "007410", true, "", false, "user21@abv.bg" },
                    { "5b636504-6010-45a4-ad8a-d89e343ebd69", 0, "cb001fd2-b285-46d4-a4e5-861e74c3375e", "008421", "user20@abv.bg", true, null, "Jack", new DateTime(2023, 3, 17, 9, 47, 44, 209, DateTimeKind.Local).AddTicks(8325), true, "Alexandrov", false, null, "Jane", "user20@abv.bg", "user20@abv.bg", "AQAAAAEAACcQAAAAEI68zECTemon4dLtRV/SgxkGm71u7ysA5iM9YMC/XDr8Vi8HXlSUaOiANjuWs28gCg==", "004194", true, "", false, "user20@abv.bg" },
                    { "ac121170-72af-440c-99e9-65616173ce76", 0, "4379e5f0-0999-4344-85bb-74df95427b6f", "000844", "user19@abv.bg", true, null, "Jack", new DateTime(2023, 3, 17, 9, 47, 44, 202, DateTimeKind.Local).AddTicks(592), true, "Johnson", false, null, "John", "user19@abv.bg", "user19@abv.bg", "AQAAAAEAACcQAAAAEJGbUW3l2534KVx0lIXZY04N0LfWFSzJP+WttIgBiuQ3Ib8n6OYHIJFLEKJX6KyQgw==", "004585", true, "", false, "user19@abv.bg" },
                    { "5d3607b8-0005-4df3-8654-5c1d83c66153", 0, "2a7afb72-1782-48da-941c-b8be8589112b", "003468", "user18@abv.bg", true, null, "Alex", new DateTime(2023, 3, 17, 9, 47, 44, 194, DateTimeKind.Local).AddTicks(5283), true, "Alexandrov", false, null, "Jane", "user18@abv.bg", "user18@abv.bg", "AQAAAAEAACcQAAAAEAzJcpIPcPhUvJ+UydzPvopx4sbQjQsgA6j2KbW/B6WtHgI/uu356bJ6N8Gu5T66fw==", "003737", true, "", false, "user18@abv.bg" },
                    { "9ff2d0d0-0ed3-438a-a7ab-9db7b2db2a21", 0, "7271ca9d-6770-4098-ad5c-ad076620db12", "001906", "user17@abv.bg", true, null, "Jack", new DateTime(2023, 3, 17, 9, 47, 44, 186, DateTimeKind.Local).AddTicks(5243), true, "Johnson", false, null, "Jane", "user17@abv.bg", "user17@abv.bg", "AQAAAAEAACcQAAAAEGmKD4Nmt4ziLRjcAKVMx0tJlvVx/0KKeD0hT31iawV9LmDnRfEb4DGHUXD7Rs6Caw==", "005890", true, "", false, "user17@abv.bg" },
                    { "cb7f3ed4-3c02-4c81-a053-79dd014a36e2", 0, "b54113db-2155-455a-8323-5d2a3f4dd75d", "009736", "user16@abv.bg", true, null, "Jack", new DateTime(2023, 3, 17, 9, 47, 44, 178, DateTimeKind.Local).AddTicks(6995), true, "Johnson", false, null, "John", "user16@abv.bg", "user16@abv.bg", "AQAAAAEAACcQAAAAEPQnxn1Kuhr3XovPeF4wG/EKny9+aEL/UiAtEdCqFpAzjKc5e15RxwNiGV4fbeUesA==", "007858", true, "", false, "user16@abv.bg" },
                    { "4c439338-8638-4a12-b5ca-c0ac6d9872a2", 0, "c2c11d66-f99a-43af-92b3-dd0e3612a1ba", "002362", "user15@abv.bg", true, null, "John", new DateTime(2023, 3, 17, 9, 47, 44, 170, DateTimeKind.Local).AddTicks(2407), true, "Johnson", false, null, "Alex", "user15@abv.bg", "user15@abv.bg", "AQAAAAEAACcQAAAAENLItBbmzBQrpsg41kAr718fV0cvrnT0/NQBpQ7gPvKGoLL4jqJL7lrGaY4bu3u1Hg==", "006512", true, "", false, "user15@abv.bg" },
                    { "ce5634dd-1d58-4c71-9632-040db53040e0", 0, "e1ee7b52-b19d-4b0f-b922-0745891ea2ed", "006032", "user14@abv.bg", true, null, "John", new DateTime(2023, 3, 17, 9, 47, 44, 161, DateTimeKind.Local).AddTicks(1087), true, "Alexandrov", false, null, "Alex", "user14@abv.bg", "user14@abv.bg", "AQAAAAEAACcQAAAAEB43gBFGFVeI2kzXlmiBc5hbEtvK9tZfVi7N1PbtnEUkMgOXJLeTxTWPjolacjmoZw==", "006982", true, "", false, "user14@abv.bg" },
                    { "8f3e149e-651d-40d5-b9a7-58bb87d17769", 0, "4a9109d7-400e-451c-a703-2c5c73ca9f03", "001770", "user13@abv.bg", true, null, "John", new DateTime(2023, 3, 17, 9, 47, 44, 153, DateTimeKind.Local).AddTicks(8330), true, "Alexandrov", false, null, "Alex", "user13@abv.bg", "user13@abv.bg", "AQAAAAEAACcQAAAAEI9lEpuxCDkmdkn7Uo54rbPuV+aLP7fIOEAV1fj6cphoKMagfCBi+IgnePe28V/zAQ==", "001316", true, "", false, "user13@abv.bg" },
                    { "9f467850-264a-4ec1-a405-a6891137a5a7", 0, "ffe43f8f-23ae-43c9-a2df-5330026db5ec", "006715", "user23@abv.bg", true, null, "Alex", new DateTime(2023, 3, 17, 9, 47, 44, 234, DateTimeKind.Local).AddTicks(4628), true, "Alexandrov", false, null, "Jack", "user23@abv.bg", "user23@abv.bg", "AQAAAAEAACcQAAAAEA+rlYhEyAr7z9zA7PAi15vZKt9CEZjNWdZ9RJtEpyQwosqV/rgUwe7buOOSZiu0gw==", "007242", true, "", false, "user23@abv.bg" },
                    { "ff8dc7eb-475a-458c-bd0f-c9c0c8e217d6", 0, "db6358e2-bc94-43e3-b44f-c2f3798de005", "009136", "user12@abv.bg", true, null, "John", new DateTime(2023, 3, 17, 9, 47, 44, 145, DateTimeKind.Local).AddTicks(6765), true, "Alexandrov", false, null, "Jack", "user12@abv.bg", "user12@abv.bg", "AQAAAAEAACcQAAAAELaf9XhMhnBdwRGHu/kh9mBXMunHH26XiFHqmDjDCCXvHIYruVhDrD0BUnihjZ292A==", "000803", true, "", false, "user12@abv.bg" },
                    { "945ba4cb-2057-4980-ba92-ebad3c330bfd", 0, "b0b63aa4-8e66-4b1e-ad3d-86f630afd281", "005871", "user10@abv.bg", true, null, "Jane", new DateTime(2023, 3, 17, 9, 47, 44, 130, DateTimeKind.Local).AddTicks(1316), true, "Johnson", false, null, "Alex", "user10@abv.bg", "user10@abv.bg", "AQAAAAEAACcQAAAAEPBbieme9SwiEcAbirFBRxPn7nfNmLxa7q0QOaQqbF6s0lPB2ZfQqEzy+/JzVxTL6g==", "007276", true, "", false, "user10@abv.bg" },
                    { "80e75155-d4f2-4623-9d7a-440d49f0f2d4", 0, "bd18e052-b88a-4faa-870d-e682a65b4997", "002139", "user9@abv.bg", true, null, "John", new DateTime(2023, 3, 17, 9, 47, 44, 122, DateTimeKind.Local).AddTicks(7398), true, "Alexandrov", false, null, "Jack", "user9@abv.bg", "user9@abv.bg", "AQAAAAEAACcQAAAAENA02PpURk4VcBYv6VdyJ9op5pU3NdzUsQIClanLa/39qz5jq2qG55IH+A43tl50QQ==", "002275", true, "", false, "user9@abv.bg" },
                    { "c2466986-069b-4d72-a5cc-0f2df53742a4", 0, "6e4619d9-00a0-43e3-8ebf-ca520d597a8f", "004719", "user8@abv.bg", true, null, "John", new DateTime(2023, 3, 17, 9, 47, 44, 114, DateTimeKind.Local).AddTicks(9931), true, "Alexandrov", false, null, "Jane", "user8@abv.bg", "user8@abv.bg", "AQAAAAEAACcQAAAAEPz0+dstA55Znlds/evcBN7H+972fvluJTs60BrjpiiaQS0iMWfwRVLtVuszrlp+lg==", "005920", true, "", false, "user8@abv.bg" },
                    { "ed814e61-d904-41f4-98d0-9bb867f050b7", 0, "c36d599f-8751-48d2-b630-2ce40d71c882", "003723", "user7@abv.bg", true, null, "Jane", new DateTime(2023, 3, 17, 9, 47, 44, 107, DateTimeKind.Local).AddTicks(4855), true, "Alexandrov", false, null, "Jane", "user7@abv.bg", "user7@abv.bg", "AQAAAAEAACcQAAAAEPw4P1VRbucv7vwCPuKPh+Bw1AxyK7yACsnrv/whgNoAB7c8ZK9svJwvPalPLSMX0g==", "004896", true, "", false, "user7@abv.bg" },
                    { "acd1b5b8-b15b-4770-b8c2-f007f92c8b1b", 0, "9127c0ec-aeaa-4113-b66e-8aff9a11373c", "001103", "user6@abv.bg", true, null, "Jack", new DateTime(2023, 3, 17, 9, 47, 44, 99, DateTimeKind.Local).AddTicks(3620), true, "Johnson", false, null, "John", "user6@abv.bg", "user6@abv.bg", "AQAAAAEAACcQAAAAEKhu+VvHankZMGJVR+Mb6AESfpSgxqRL04lEcugfhsK1Pu0g+4oIIJA8SUWWsld3bw==", "001487", true, "", false, "user6@abv.bg" },
                    { "0496cd27-a73c-4cde-8678-4db227f2912d", 0, "fb0ec0b2-94a5-41a2-8758-d4264bee6b1f", "008767", "user5@abv.bg", true, null, "Jack", new DateTime(2023, 3, 17, 9, 47, 44, 89, DateTimeKind.Local).AddTicks(8458), true, "Johnson", false, null, "Jack", "user5@abv.bg", "user5@abv.bg", "AQAAAAEAACcQAAAAEGtMdFGv2VLL5e0dhvGysL/QaAueB3QEACoYeYlQTpEMOipPf98AdPsO1oICc/gDCQ==", "009631", true, "", false, "user5@abv.bg" },
                    { "e9c7d9a7-b50f-4cbe-ab3e-fd9a540c3172", 0, "6baa0e66-2ac4-4142-8714-d8a3731d3383", "006552", "user4@abv.bg", true, null, "John", new DateTime(2023, 3, 17, 9, 47, 44, 80, DateTimeKind.Local).AddTicks(6745), true, "Johnson", false, null, "Jack", "user4@abv.bg", "user4@abv.bg", "AQAAAAEAACcQAAAAEPV3ySr5lBn3fVj+Ix8C04M1R8yC3kMkRtRZw7yWvRz0m2qHb7+wsyfLJbVAasSmDQ==", "005157", true, "", false, "user4@abv.bg" },
                    { "28397a52-0725-4507-adac-af1da1f36c15", 0, "12fbf48e-fb55-42e2-b7c8-7c0e8fc83a5f", "002251", "user3@abv.bg", true, null, "John", new DateTime(2023, 3, 17, 9, 47, 44, 72, DateTimeKind.Local).AddTicks(9689), true, "Johnson", false, null, "Jane", "user3@abv.bg", "user3@abv.bg", "AQAAAAEAACcQAAAAELkwDBgWAs74agpi12ZQRT8uzp6/4oi+ZdoIB4r9d5aMIE2LfAVt8RCVuzGVwm2unw==", "003519", true, "", false, "user3@abv.bg" },
                    { "8bad8d17-9cf2-4fe5-9ef8-b0f4f44df361", 0, "6efd83db-6613-4f5f-a07b-cd5ec389dc9a", "006121", "user2@abv.bg", true, null, "Jack", new DateTime(2023, 3, 17, 9, 47, 44, 64, DateTimeKind.Local).AddTicks(7506), true, "Alexandrov", false, null, "Alex", "user2@abv.bg", "user2@abv.bg", "AQAAAAEAACcQAAAAEADp7sgOubiHPRltrpUGIfU4le4SAuHy6hjykMNJb1q77dg/JMy5aklCfE6JLFRAcw==", "003604", true, "", false, "user2@abv.bg" },
                    { "944d790a-4529-4000-b6af-dc5f9e7dc331", 0, "47948ff6-54f0-41b0-9c32-692ff8f67970", "003748", "user1@abv.bg", true, null, "John", new DateTime(2023, 3, 17, 9, 47, 44, 56, DateTimeKind.Local).AddTicks(7532), true, "Alexandrov", false, null, "Alex", "user1@abv.bg", "user1@abv.bg", "AQAAAAEAACcQAAAAEKcG0P1drPZS8i4TDVzFRyy5AcBq6d2xO+HTGR24eJJyy5ceIqOnsS/ezjFXgdYy2w==", "007062", true, "", false, "user1@abv.bg" },
                    { "d82ecd13-f5c6-4aac-8b12-76f54a1639b6", 0, "24555da3-19e9-4d91-a983-9e4c2689cf49", "005969", "user11@abv.bg", true, null, "John", new DateTime(2023, 3, 17, 9, 47, 44, 138, DateTimeKind.Local).AddTicks(1057), true, "Alexandrov", false, null, "Alex", "user11@abv.bg", "user11@abv.bg", "AQAAAAEAACcQAAAAENPY9MCmQfAyDpKRgvT6KkvAg06ACr/4T9uYAAbDTVPxYK92Z8EWyBs7pnRI6w8ayg==", "003981", true, "", false, "user11@abv.bg" },
                    { "8f0a9cfd-aa84-4440-a576-9125e92d8f29", 0, "c7cf04b5-9540-46c8-a4dd-d2bcbdab45d9", "004443", "user50@abv.bg", true, null, "Jack", new DateTime(2023, 3, 17, 9, 47, 44, 449, DateTimeKind.Local).AddTicks(4341), true, "Johnson", false, null, "Alex", "user50@abv.bg", "user50@abv.bg", "AQAAAAEAACcQAAAAENjkt3IriR+j8+1J6YMVKDzXRki/rk0MUYuGdmaiNLln1jHt9fYuSY/iAo6OROFMeA==", "009617", true, "", false, "user50@abv.bg" },
                    { "7ad4e235-0f4e-4ad6-a40e-1144a639cf7d", 0, "d00753e1-a9fe-4b60-a874-cf255cd1aa2c", "004368", "user24@abv.bg", true, null, "Jack", new DateTime(2023, 3, 17, 9, 47, 44, 243, DateTimeKind.Local).AddTicks(564), true, "Alexandrov", false, null, "Jane", "user24@abv.bg", "user24@abv.bg", "AQAAAAEAACcQAAAAEOpC1DBal7H1YDGYurHOGdYTYt43HD6LTKGP2bJGnG70U6xOKlIuXi1wJMXQpY99Og==", "000153", true, "", false, "user24@abv.bg" },
                    { "15980b4c-c6f9-43ca-9840-2f1b21d01a96", 0, "4b410995-773c-4575-b08e-fe73230a3a61", "001316", "user26@abv.bg", true, null, "Jack", new DateTime(2023, 3, 17, 9, 47, 44, 260, DateTimeKind.Local).AddTicks(479), true, "Alexandrov", false, null, "John", "user26@abv.bg", "user26@abv.bg", "AQAAAAEAACcQAAAAEAXdYZfmURBJe23N7P+XAR4Af2/cVG7Ha2A3U2dgc4AyltEFOtozzYzLe35Jfs7PEA==", "004336", true, "", false, "user26@abv.bg" },
                    { "95979a0a-e8a8-450a-8896-ab22bcf017f2", 0, "1c876d21-2e59-413c-8c95-650c54300e5b", "009763", "user48@abv.bg", true, null, "Jane", new DateTime(2023, 3, 17, 9, 47, 44, 433, DateTimeKind.Local).AddTicks(7211), true, "Johnson", false, null, "John", "user48@abv.bg", "user48@abv.bg", "AQAAAAEAACcQAAAAELGvGGZipZG42loFu7FjF6OQzieHLXLhMz3fFRXp/xlsEi/HsD5i5qDXfIS2z2+e2w==", "002187", true, "", false, "user48@abv.bg" },
                    { "8a21090c-40da-4616-990d-fa0c2a8d7956", 0, "76832f85-07bb-4486-8e75-33f10f0cbdfe", "002402", "user47@abv.bg", true, null, "Alex", new DateTime(2023, 3, 17, 9, 47, 44, 425, DateTimeKind.Local).AddTicks(7912), true, "Johnson", false, null, "Jane", "user47@abv.bg", "user47@abv.bg", "AQAAAAEAACcQAAAAEMonV7TJJ9sBj/oi4FHZdHeYfrDIKljRrMbv7wfb0dx/RWIvxQdWItj7j4WWjO0uJg==", "009584", true, "", false, "user47@abv.bg" },
                    { "0a1a9081-43e9-4058-872c-38c21b015b54", 0, "5aa436cb-6663-4242-8bf0-3796a77b3122", "003861", "user46@abv.bg", true, null, "Jack", new DateTime(2023, 3, 17, 9, 47, 44, 418, DateTimeKind.Local).AddTicks(1444), true, "Johnson", false, null, "Alex", "user46@abv.bg", "user46@abv.bg", "AQAAAAEAACcQAAAAECcLV8JMmRHSo7NAJjtNpGh6CuoX4m3fb18QcxQPUftRkhXJmeqAdpsMStvgHLzclw==", "004327", true, "", false, "user46@abv.bg" },
                    { "f9948714-b687-4b0c-97d1-4750b6c175c7", 0, "e2b62c91-b734-4b75-ac64-75e25cdfd51e", "005704", "user45@abv.bg", true, null, "Jane", new DateTime(2023, 3, 17, 9, 47, 44, 410, DateTimeKind.Local).AddTicks(4747), true, "Alexandrov", false, null, "Jane", "user45@abv.bg", "user45@abv.bg", "AQAAAAEAACcQAAAAEGFgb52U0SoaYZizvvB9B58PGVbsKpdw1VVKuTd8Dvla+iilOMnHiWXWlnl5grp/rA==", "004827", true, "", false, "user45@abv.bg" },
                    { "68efef42-0e4f-4fa5-acee-767d14230bb5", 0, "25476082-0cf9-47fd-9bc9-ebe0983054a1", "001841", "user44@abv.bg", true, null, "Jane", new DateTime(2023, 3, 17, 9, 47, 44, 403, DateTimeKind.Local).AddTicks(410), true, "Johnson", false, null, "Jack", "user44@abv.bg", "user44@abv.bg", "AQAAAAEAACcQAAAAEMluDYuQPab9BY45s0xQnpjnDIRWbA0+ijzxWwYa667iQc8IbP2uLlmCN8nH53vOTg==", "007219", true, "", false, "user44@abv.bg" },
                    { "091be594-7616-450a-b218-43d66ffa2add", 0, "5b603338-0c6f-4a93-bda4-23157579e128", "001699", "user43@abv.bg", true, null, "Jane", new DateTime(2023, 3, 17, 9, 47, 44, 395, DateTimeKind.Local).AddTicks(5285), true, "Alexandrov", false, null, "Jack", "user43@abv.bg", "user43@abv.bg", "AQAAAAEAACcQAAAAED4vdyFISHHC4UhT/s3FHwrioSADMPNdEn5msjj5ihCLkHr4RQDxd7H5Rw1XjlexAw==", "009632", true, "", false, "user43@abv.bg" },
                    { "82dcfe64-ec42-461e-a2ce-2238380cc950", 0, "9a26aab6-f541-4a78-a7a3-74b49cb4f832", "009664", "user42@abv.bg", true, null, "Jack", new DateTime(2023, 3, 17, 9, 47, 44, 388, DateTimeKind.Local).AddTicks(174), true, "Johnson", false, null, "Alex", "user42@abv.bg", "user42@abv.bg", "AQAAAAEAACcQAAAAEGs7kwKkaW4zcwL7QWwTcLR9Fq30Zq3guVxi0vNPFprkBd2JxTZzvTyDKLjlOygYVQ==", "003042", true, "", false, "user42@abv.bg" },
                    { "5d2d7b06-fff2-44cb-8e4e-4caa260f7ba7", 0, "e5b13b56-043c-4f68-b35a-ffa92c0e94fe", "005725", "user41@abv.bg", true, null, "Jack", new DateTime(2023, 3, 17, 9, 47, 44, 379, DateTimeKind.Local).AddTicks(9859), true, "Alexandrov", false, null, "Alex", "user41@abv.bg", "user41@abv.bg", "AQAAAAEAACcQAAAAEC2ixX2TBbiUuBX4PqIa1kADX22H/bu9FcZj5BziXIjI3yPUSGoUyhOO0o7Q4HI8yg==", "001088", true, "", false, "user41@abv.bg" },
                    { "568c4e70-f4f3-43ee-a426-4c1cf2dd01b0", 0, "bad6bb00-5193-43b9-8e62-2869e9f402ed", "004886", "user40@abv.bg", true, null, "Jane", new DateTime(2023, 3, 17, 9, 47, 44, 372, DateTimeKind.Local).AddTicks(232), true, "Johnson", false, null, "Jane", "user40@abv.bg", "user40@abv.bg", "AQAAAAEAACcQAAAAEJ5aEKXHEZ5o7x0Jzo+Wabsq919fpqKsEX7PCGm8EfFNOt5OZqIynGf1eYsJg2xX+g==", "004606", true, "", false, "user40@abv.bg" },
                    { "b32353a5-1f51-45f4-8468-40f2089c50df", 0, "48068100-eb20-469e-aac5-864826d824d6", "003075", "user39@abv.bg", true, null, "Alex", new DateTime(2023, 3, 17, 9, 47, 44, 363, DateTimeKind.Local).AddTicks(5760), true, "Johnson", false, null, "Jack", "user39@abv.bg", "user39@abv.bg", "AQAAAAEAACcQAAAAEENsIXkGyh/ToXtFC1gZkKm6RQd5y7l36YvY4vPUr5zZRtKJ2sv1XD7Y+JHSRuoimw==", "000212", true, "", false, "user39@abv.bg" },
                    { "4fd5f3b3-afaf-47fb-9d53-67a1be458eea", 0, "8a6e51b9-26c6-4f9b-a557-3ba1a642b758", "002212", "user25@abv.bg", true, null, "Jane", new DateTime(2023, 3, 17, 9, 47, 44, 251, DateTimeKind.Local).AddTicks(5007), true, "Johnson", false, null, "John", "user25@abv.bg", "user25@abv.bg", "AQAAAAEAACcQAAAAEJz3SifeP9wZHm4AsuMNLSxsCUiQfa7xbO1Jxe9zjYlqMMyJ+potUuOr/0FmOZri6A==", "007094", true, "", false, "user25@abv.bg" },
                    { "a2f0391f-9075-498b-9c48-e6c08dfffd86", 0, "44362e8d-1ca2-4b5d-944b-b6bb9361b898", "004059", "user38@abv.bg", true, null, "Alex", new DateTime(2023, 3, 17, 9, 47, 44, 356, DateTimeKind.Local).AddTicks(2130), true, "Alexandrov", false, null, "Jack", "user38@abv.bg", "user38@abv.bg", "AQAAAAEAACcQAAAAEBqqSVRIWvMYSMGhQfuD7+BDGUpKmA7gAEUvVK8JtbUWtbSSA5FbuOA5NyxkpRs/yA==", "006682", true, "", false, "user38@abv.bg" },
                    { "3f52ba94-369f-435c-a1bf-f82bc3acd70b", 0, "c722eff0-f787-4090-8b1f-ab1b7b063986", "004289", "user36@abv.bg", true, null, "John", new DateTime(2023, 3, 17, 9, 47, 44, 340, DateTimeKind.Local).AddTicks(3751), true, "Alexandrov", false, null, "Jack", "user36@abv.bg", "user36@abv.bg", "AQAAAAEAACcQAAAAED1VO6P7Jet4SNU9G0bQ4fHnUb6CQlI3Cb5aPDqXMJhB3Pmin2GrDR6W9DRP/brsag==", "004384", true, "", false, "user36@abv.bg" },
                    { "f7acd957-9ced-4283-b8d7-3dbe177e3cb7", 0, "dfe277ae-dbbd-4b3d-a9a5-d2438d104805", "004371", "user35@abv.bg", true, null, "Jane", new DateTime(2023, 3, 17, 9, 47, 44, 332, DateTimeKind.Local).AddTicks(2097), true, "Alexandrov", false, null, "Jane", "user35@abv.bg", "user35@abv.bg", "AQAAAAEAACcQAAAAEJZFyKbo4HZSlYvwXgfN3HRPCjeUMYq+6p+pcE9ZzZ7XsnPSS5Fio70o+oG8S0cjqQ==", "007032", true, "", false, "user35@abv.bg" },
                    { "d226e7b3-e962-4ada-817b-d7e62b4aa049", 0, "89e8b1ea-c055-400b-8f2f-cf0f8c92709e", "003025", "user34@abv.bg", true, null, "John", new DateTime(2023, 3, 17, 9, 47, 44, 324, DateTimeKind.Local).AddTicks(9382), true, "Alexandrov", false, null, "John", "user34@abv.bg", "user34@abv.bg", "AQAAAAEAACcQAAAAEEOo4nqeoGr593HkWqAnVR+4b/EpypzLfD8hA7/vGzTLg9cwk2lalJeLTkRWqbMIrg==", "001176", true, "", false, "user34@abv.bg" },
                    { "fad2e075-998a-4d97-8478-690f42e76891", 0, "5c85de27-344e-4630-a75a-d95557a389fe", "000936", "user33@abv.bg", true, null, "John", new DateTime(2023, 3, 17, 9, 47, 44, 317, DateTimeKind.Local).AddTicks(1487), true, "Alexandrov", false, null, "Jack", "user33@abv.bg", "user33@abv.bg", "AQAAAAEAACcQAAAAEDwQDx6jjYuvgvuuwDlqLfutpLXu6P0WQbVxl3cqcRvIjkFKH1iqIicmo9CMz/jTow==", "004176", true, "", false, "user33@abv.bg" },
                    { "56a597ac-1e76-4b75-9d18-a6eba2fcc01f", 0, "03068680-eca2-40a6-9873-44fa81f52f89", "006565", "user32@abv.bg", true, null, "Jane", new DateTime(2023, 3, 17, 9, 47, 44, 308, DateTimeKind.Local).AddTicks(4409), true, "Johnson", false, null, "Jane", "user32@abv.bg", "user32@abv.bg", "AQAAAAEAACcQAAAAEL5xc8UtP1zFrj/7IVbzQ8oV8x2LN+old/ENPgBo7zoXyfpjdf3nU49VEODwliVVIQ==", "000410", true, "", false, "user32@abv.bg" },
                    { "9b0cf926-4e8a-4166-98e2-b6757dde400b", 0, "19ead6a1-eeaf-46c9-8b60-f216ddc8ec29", "001565", "user31@abv.bg", true, null, "John", new DateTime(2023, 3, 17, 9, 47, 44, 299, DateTimeKind.Local).AddTicks(8939), true, "Alexandrov", false, null, "Alex", "user31@abv.bg", "user31@abv.bg", "AQAAAAEAACcQAAAAEIePEcV8spj5Z2AApfYY+GtgHRJGbuyxmKC7IH4vJLKvFBKsA6W2F2Su4A3xwqQvkg==", "001329", true, "", false, "user31@abv.bg" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "EGN", "Email", "EmailConfirmed", "FireDate", "FirstName", "HireDate", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7a39cbb7-ee86-41ea-9c2d-1cdacdf08077", 0, "f3628fb0-b80a-41b9-aa8f-dcb3eff583b0", "000331", "user30@abv.bg", true, null, "Jane", new DateTime(2023, 3, 17, 9, 47, 44, 291, DateTimeKind.Local).AddTicks(9511), true, "Johnson", false, null, "Jack", "user30@abv.bg", "user30@abv.bg", "AQAAAAEAACcQAAAAEEN59uJEqGKfQXHKLQ7RhubLpJSumxyDJffz3gNHqI7u9nKa9QdCB3sgmh3TksYmKQ==", "009725", true, "", false, "user30@abv.bg" },
                    { "a438cf56-0fe0-40ff-8346-e3f462808f78", 0, "71eff376-a83f-4666-9841-e8f5c66535d2", "009092", "user29@abv.bg", true, null, "John", new DateTime(2023, 3, 17, 9, 47, 44, 284, DateTimeKind.Local).AddTicks(742), true, "Alexandrov", false, null, "Alex", "user29@abv.bg", "user29@abv.bg", "AQAAAAEAACcQAAAAEJscVUU+tFo01Sfe0S/m1xRTDvnQyJ0XdkbQgX1xalVf3O4ysLBsouVUxvAzpA8xfg==", "003906", true, "", false, "user29@abv.bg" },
                    { "cb68412e-9669-4325-a5e1-a5767acc3f69", 0, "6e913e47-8d82-4790-8f96-67567f67d4ad", "002613", "user28@abv.bg", true, null, "Jane", new DateTime(2023, 3, 17, 9, 47, 44, 276, DateTimeKind.Local).AddTicks(8254), true, "Alexandrov", false, null, "Jane", "user28@abv.bg", "user28@abv.bg", "AQAAAAEAACcQAAAAEGnr3RxclxPeD1b6aOX2uSry/p2VY1i/fak1gXbzcUr4CN6RHap4x+n5797gWcQ3Mg==", "003280", true, "", false, "user28@abv.bg" },
                    { "81e04944-02b0-4ccc-8799-0b50469102ab", 0, "b5f39e5b-770b-4283-8fa0-6b2df6b2a71e", "007949", "user27@abv.bg", true, null, "Jack", new DateTime(2023, 3, 17, 9, 47, 44, 268, DateTimeKind.Local).AddTicks(172), true, "Alexandrov", false, null, "Jack", "user27@abv.bg", "user27@abv.bg", "AQAAAAEAACcQAAAAEIfIL8i39mkvHZA84aGZjiAT/D/5LSBP7E+zb2qs2ZZ//D3V8jYv1PN2smQ+MUUe8Q==", "000139", true, "", false, "user27@abv.bg" },
                    { "31e7b704-d4f1-40f5-95a7-4693a8971886", 0, "e1561461-3e05-456e-a8df-7ab899a9f1db", "007585", "user37@abv.bg", true, null, "Jack", new DateTime(2023, 3, 17, 9, 47, 44, 347, DateTimeKind.Local).AddTicks(9563), true, "Johnson", false, null, "Jane", "user37@abv.bg", "user37@abv.bg", "AQAAAAEAACcQAAAAEFh+RKLmlQZdoE3RL4+HpqzCUtuXEiAYzrP3inJQKK8ScMUlCUNp9o9SOsl8X0ouTQ==", "002757", true, "", false, "user37@abv.bg" },
                    { "a78f098f-81a9-447f-a657-d7a87eed3a94", 0, "c5304149-b4af-4994-9db0-600a715131f6", "001327", "user0@abv.bg", true, null, "Jane", new DateTime(2023, 3, 17, 9, 47, 44, 48, DateTimeKind.Local).AddTicks(7721), true, "Alexandrov", false, null, "Jane", "user0@abv.bg", "user0@abv.bg", "AQAAAAEAACcQAAAAEPqAiR8DxVEQwTRTt2vaNMguD74AgUMrA2/HjOAerFvN0xmRI6tCl8cxojg3xiiy6Q==", "006702", true, "", false, "user0@abv.bg" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "8e445864-a24d-4543-a6c6-9443d048cdb9", "9a6f1070-687d-4e46-bf4d-cee6ff8371a5" },
                    { "926186a8-f496-4025-82c6-1fc2878bdffc", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "fce64203-c0a0-455c-bc9e-d244928a00ee", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "ea57e053-4eba-4dd6-9674-1b239bf340e8", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "b35682ad-ec89-4d99-b50d-8aa50f64a543", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "d556448d-e65d-48fd-87f4-d654f544ac7d", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "43baaf25-0eb1-4b08-abf6-47b0c27047b3", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "694c5c68-6350-454a-988b-a5c41abbb9cd", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "9ad9e070-8ba6-49ee-b399-aae6bfe04cbc", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "758a4456-20fe-4ae5-889f-245aca37dabb", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "05984939-e431-4a74-8628-5daed308320f", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "b4fdcaea-950c-4ad5-8235-763a5c6b42d7", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "db070855-fc49-4303-8919-95ad8d716add", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "ef5e8cf8-2270-4dbb-9a85-9cf1174dca18", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "832b538c-d1d6-4252-bc31-486e0dc0c6ac", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "4c3c00bc-172b-4363-8c04-1535a5e9d664", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "7d5ff411-3bcb-4707-ae87-6d9338584d9b", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "70ba5e2f-cc7b-474f-8e66-9d30aee80108", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "b46a4033-75e1-4b67-9823-02bdf43988df", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "accffeb1-d844-4b82-aa80-b33257a8d5e3", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "f0b4ce71-22cb-45bb-8346-d3a8952c8bbf", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "19766a36-9a89-495c-92da-e39a7da363ff", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "a497ada4-a3db-47fb-bbcf-ea766a3e3024", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "385e32d0-0ed3-489c-aac3-0757274f1e85", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "bd00c6fc-6a35-48bf-a53e-571766158cc2", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "5aad2227-e9da-4dec-b827-ed6a4ee39cb6", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "35427986-7481-401a-b629-1b626439d138", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "3c1591e4-ebdf-4276-b7d8-48218c11e195", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "efb8e81e-33f8-47b3-8bfd-d519b27b2dcb", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "3105418e-0caf-420e-8414-d0252ab1d0de", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "70b6e0b9-0819-43a8-94c4-1f3bd5a28f6c", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "07d3fd80-8712-4289-9a25-3959b1592b73", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "1c4044bf-f016-4769-a635-1be8568727c4", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "da320495-b65a-4d99-af12-64d738f0e5b3", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "6e1591e6-dc09-4e82-a519-90595e4673be", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "8d3d0c2e-a984-48fe-b54d-7eb8988fcc8e", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "8f0a9cfd-aa84-4440-a576-9125e92d8f29", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "480fc1fc-1f3e-4cd2-a7ed-424d1b5a34a5", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "b5cdeb10-d9fa-4ad5-b353-d3634055f0da", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "76b92cda-04aa-4aed-8332-8331ab693a5d", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "f7647dc5-9059-4587-b2ad-7761f03bd7c9", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "040eb26d-6599-456c-8fca-f5945e08025c", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "dab18a25-a001-48ff-b873-ba59a18586bf", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "785cb93c-8368-4611-88fe-5ae02a139570", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "c082c204-f8ff-48a8-a516-008187c55154", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "d580f112-d007-47be-a363-66cf3c716a47", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "dd87e554-da00-4585-9bf6-71a539048753", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "d5e64f4f-7a8b-46f0-b889-d455e9812586", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "c4f5bdb2-0e0d-43ed-8e10-3b8469ef8171", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "d32bf7d5-018b-4223-8665-eef67f66e406", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "15bd6335-ac99-4456-ac03-1d3d346b5db1", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "8a21090c-40da-4616-990d-fa0c2a8d7956", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "5b636504-6010-45a4-ad8a-d89e343ebd69", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "ac121170-72af-440c-99e9-65616173ce76", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "5d3607b8-0005-4df3-8654-5c1d83c66153", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "9ff2d0d0-0ed3-438a-a7ab-9db7b2db2a21", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "cb7f3ed4-3c02-4c81-a053-79dd014a36e2", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "4c439338-8638-4a12-b5ca-c0ac6d9872a2", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "ce5634dd-1d58-4c71-9632-040db53040e0", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "8f3e149e-651d-40d5-b9a7-58bb87d17769", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "ff8dc7eb-475a-458c-bd0f-c9c0c8e217d6", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "d82ecd13-f5c6-4aac-8b12-76f54a1639b6", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "945ba4cb-2057-4980-ba92-ebad3c330bfd", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "80e75155-d4f2-4623-9d7a-440d49f0f2d4", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "c2466986-069b-4d72-a5cc-0f2df53742a4", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "ed814e61-d904-41f4-98d0-9bb867f050b7", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "acd1b5b8-b15b-4770-b8c2-f007f92c8b1b", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "0496cd27-a73c-4cde-8678-4db227f2912d", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "e9c7d9a7-b50f-4cbe-ab3e-fd9a540c3172", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "28397a52-0725-4507-adac-af1da1f36c15", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "8bad8d17-9cf2-4fe5-9ef8-b0f4f44df361", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "944d790a-4529-4000-b6af-dc5f9e7dc331", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "a78f098f-81a9-447f-a657-d7a87eed3a94", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "c0c59c5a-d5cd-4e2c-9947-2860dc1706a2", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "4d4fd55e-f189-4a6a-9ede-c8a89f9fb06a", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "9f467850-264a-4ec1-a405-a6891137a5a7", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "7ad4e235-0f4e-4ad6-a40e-1144a639cf7d", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "0a1a9081-43e9-4058-872c-38c21b015b54", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "f9948714-b687-4b0c-97d1-4750b6c175c7", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "68efef42-0e4f-4fa5-acee-767d14230bb5", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "091be594-7616-450a-b218-43d66ffa2add", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "82dcfe64-ec42-461e-a2ce-2238380cc950", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "5d2d7b06-fff2-44cb-8e4e-4caa260f7ba7", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "568c4e70-f4f3-43ee-a426-4c1cf2dd01b0", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "b32353a5-1f51-45f4-8468-40f2089c50df", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "a2f0391f-9075-498b-9c48-e6c08dfffd86", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "31e7b704-d4f1-40f5-95a7-4693a8971886", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "95979a0a-e8a8-450a-8896-ab22bcf017f2", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "3f52ba94-369f-435c-a1bf-f82bc3acd70b", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "d226e7b3-e962-4ada-817b-d7e62b4aa049", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "fad2e075-998a-4d97-8478-690f42e76891", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "56a597ac-1e76-4b75-9d18-a6eba2fcc01f", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "9b0cf926-4e8a-4166-98e2-b6757dde400b", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "7a39cbb7-ee86-41ea-9c2d-1cdacdf08077", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "a438cf56-0fe0-40ff-8346-e3f462808f78", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "cb68412e-9669-4325-a5e1-a5767acc3f69", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "81e04944-02b0-4ccc-8799-0b50469102ab", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "15980b4c-c6f9-43ca-9840-2f1b21d01a96", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "4fd5f3b3-afaf-47fb-9d53-67a1be458eea", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "f7acd957-9ced-4283-b8d7-3dbe177e3cb7", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" },
                    { "bc9d1e30-5923-40fe-aec2-c733c5918914", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_RoomId",
                table: "Reservations",
                column: "RoomId",
                unique: true,
                filter: "[RoomId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Rooms_RoomId",
                table: "Reservations",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Rooms_RoomId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_RoomId",
                table: "Reservations");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "040eb26d-6599-456c-8fca-f5945e08025c", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "0496cd27-a73c-4cde-8678-4db227f2912d", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "05984939-e431-4a74-8628-5daed308320f", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "07d3fd80-8712-4289-9a25-3959b1592b73", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "091be594-7616-450a-b218-43d66ffa2add", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "0a1a9081-43e9-4058-872c-38c21b015b54", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "15980b4c-c6f9-43ca-9840-2f1b21d01a96", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "15bd6335-ac99-4456-ac03-1d3d346b5db1", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "19766a36-9a89-495c-92da-e39a7da363ff", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1c4044bf-f016-4769-a635-1be8568727c4", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "28397a52-0725-4507-adac-af1da1f36c15", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "3105418e-0caf-420e-8414-d0252ab1d0de", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "31e7b704-d4f1-40f5-95a7-4693a8971886", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "35427986-7481-401a-b629-1b626439d138", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "385e32d0-0ed3-489c-aac3-0757274f1e85", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "3c1591e4-ebdf-4276-b7d8-48218c11e195", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "3f52ba94-369f-435c-a1bf-f82bc3acd70b", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "43baaf25-0eb1-4b08-abf6-47b0c27047b3", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "480fc1fc-1f3e-4cd2-a7ed-424d1b5a34a5", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4c3c00bc-172b-4363-8c04-1535a5e9d664", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4c439338-8638-4a12-b5ca-c0ac6d9872a2", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4d4fd55e-f189-4a6a-9ede-c8a89f9fb06a", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4fd5f3b3-afaf-47fb-9d53-67a1be458eea", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "568c4e70-f4f3-43ee-a426-4c1cf2dd01b0", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "56a597ac-1e76-4b75-9d18-a6eba2fcc01f", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5aad2227-e9da-4dec-b827-ed6a4ee39cb6", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5b636504-6010-45a4-ad8a-d89e343ebd69", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5d2d7b06-fff2-44cb-8e4e-4caa260f7ba7", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5d3607b8-0005-4df3-8654-5c1d83c66153", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "68efef42-0e4f-4fa5-acee-767d14230bb5", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "694c5c68-6350-454a-988b-a5c41abbb9cd", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6e1591e6-dc09-4e82-a519-90595e4673be", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "70b6e0b9-0819-43a8-94c4-1f3bd5a28f6c", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "70ba5e2f-cc7b-474f-8e66-9d30aee80108", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "758a4456-20fe-4ae5-889f-245aca37dabb", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "76b92cda-04aa-4aed-8332-8331ab693a5d", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "785cb93c-8368-4611-88fe-5ae02a139570", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7a39cbb7-ee86-41ea-9c2d-1cdacdf08077", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7ad4e235-0f4e-4ad6-a40e-1144a639cf7d", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7d5ff411-3bcb-4707-ae87-6d9338584d9b", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "80e75155-d4f2-4623-9d7a-440d49f0f2d4", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "81e04944-02b0-4ccc-8799-0b50469102ab", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "82dcfe64-ec42-461e-a2ce-2238380cc950", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "832b538c-d1d6-4252-bc31-486e0dc0c6ac", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8a21090c-40da-4616-990d-fa0c2a8d7956", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8bad8d17-9cf2-4fe5-9ef8-b0f4f44df361", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8d3d0c2e-a984-48fe-b54d-7eb8988fcc8e", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8e445864-a24d-4543-a6c6-9443d048cdb9", "9a6f1070-687d-4e46-bf4d-cee6ff8371a5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8f0a9cfd-aa84-4440-a576-9125e92d8f29", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8f3e149e-651d-40d5-b9a7-58bb87d17769", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "926186a8-f496-4025-82c6-1fc2878bdffc", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "944d790a-4529-4000-b6af-dc5f9e7dc331", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "945ba4cb-2057-4980-ba92-ebad3c330bfd", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "95979a0a-e8a8-450a-8896-ab22bcf017f2", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "9ad9e070-8ba6-49ee-b399-aae6bfe04cbc", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "9b0cf926-4e8a-4166-98e2-b6757dde400b", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "9f467850-264a-4ec1-a405-a6891137a5a7", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "9ff2d0d0-0ed3-438a-a7ab-9db7b2db2a21", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a2f0391f-9075-498b-9c48-e6c08dfffd86", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a438cf56-0fe0-40ff-8346-e3f462808f78", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a497ada4-a3db-47fb-bbcf-ea766a3e3024", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a78f098f-81a9-447f-a657-d7a87eed3a94", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ac121170-72af-440c-99e9-65616173ce76", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "accffeb1-d844-4b82-aa80-b33257a8d5e3", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "acd1b5b8-b15b-4770-b8c2-f007f92c8b1b", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b32353a5-1f51-45f4-8468-40f2089c50df", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b35682ad-ec89-4d99-b50d-8aa50f64a543", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b46a4033-75e1-4b67-9823-02bdf43988df", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b4fdcaea-950c-4ad5-8235-763a5c6b42d7", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b5cdeb10-d9fa-4ad5-b353-d3634055f0da", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "bc9d1e30-5923-40fe-aec2-c733c5918914", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "bd00c6fc-6a35-48bf-a53e-571766158cc2", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c082c204-f8ff-48a8-a516-008187c55154", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c0c59c5a-d5cd-4e2c-9947-2860dc1706a2", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c2466986-069b-4d72-a5cc-0f2df53742a4", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c4f5bdb2-0e0d-43ed-8e10-3b8469ef8171", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "cb68412e-9669-4325-a5e1-a5767acc3f69", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "cb7f3ed4-3c02-4c81-a053-79dd014a36e2", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ce5634dd-1d58-4c71-9632-040db53040e0", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d226e7b3-e962-4ada-817b-d7e62b4aa049", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d32bf7d5-018b-4223-8665-eef67f66e406", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d556448d-e65d-48fd-87f4-d654f544ac7d", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d580f112-d007-47be-a363-66cf3c716a47", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d5e64f4f-7a8b-46f0-b889-d455e9812586", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d82ecd13-f5c6-4aac-8b12-76f54a1639b6", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "da320495-b65a-4d99-af12-64d738f0e5b3", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "dab18a25-a001-48ff-b873-ba59a18586bf", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "db070855-fc49-4303-8919-95ad8d716add", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "dd87e554-da00-4585-9bf6-71a539048753", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e9c7d9a7-b50f-4cbe-ab3e-fd9a540c3172", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ea57e053-4eba-4dd6-9674-1b239bf340e8", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ed814e61-d904-41f4-98d0-9bb867f050b7", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ef5e8cf8-2270-4dbb-9a85-9cf1174dca18", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "efb8e81e-33f8-47b3-8bfd-d519b27b2dcb", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f0b4ce71-22cb-45bb-8346-d3a8952c8bbf", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f7647dc5-9059-4587-b2ad-7761f03bd7c9", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f7acd957-9ced-4283-b8d7-3dbe177e3cb7", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f9948714-b687-4b0c-97d1-4750b6c175c7", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "fad2e075-998a-4d97-8478-690f42e76891", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "fce64203-c0a0-455c-bc9e-d244928a00ee", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ff8dc7eb-475a-458c-bd0f-c9c0c8e217d6", "a7476f94-9c6c-4d0b-a491-ccbd22708d63" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a6f1070-687d-4e46-bf4d-cee6ff8371a5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7476f94-9c6c-4d0b-a491-ccbd22708d63");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "040eb26d-6599-456c-8fca-f5945e08025c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0496cd27-a73c-4cde-8678-4db227f2912d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05984939-e431-4a74-8628-5daed308320f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07d3fd80-8712-4289-9a25-3959b1592b73");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "091be594-7616-450a-b218-43d66ffa2add");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a1a9081-43e9-4058-872c-38c21b015b54");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15980b4c-c6f9-43ca-9840-2f1b21d01a96");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15bd6335-ac99-4456-ac03-1d3d346b5db1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19766a36-9a89-495c-92da-e39a7da363ff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1c4044bf-f016-4769-a635-1be8568727c4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28397a52-0725-4507-adac-af1da1f36c15");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3105418e-0caf-420e-8414-d0252ab1d0de");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31e7b704-d4f1-40f5-95a7-4693a8971886");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35427986-7481-401a-b629-1b626439d138");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "385e32d0-0ed3-489c-aac3-0757274f1e85");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c1591e4-ebdf-4276-b7d8-48218c11e195");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f52ba94-369f-435c-a1bf-f82bc3acd70b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43baaf25-0eb1-4b08-abf6-47b0c27047b3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "480fc1fc-1f3e-4cd2-a7ed-424d1b5a34a5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c3c00bc-172b-4363-8c04-1535a5e9d664");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c439338-8638-4a12-b5ca-c0ac6d9872a2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d4fd55e-f189-4a6a-9ede-c8a89f9fb06a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fd5f3b3-afaf-47fb-9d53-67a1be458eea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "568c4e70-f4f3-43ee-a426-4c1cf2dd01b0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56a597ac-1e76-4b75-9d18-a6eba2fcc01f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5aad2227-e9da-4dec-b827-ed6a4ee39cb6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b636504-6010-45a4-ad8a-d89e343ebd69");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5d2d7b06-fff2-44cb-8e4e-4caa260f7ba7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5d3607b8-0005-4df3-8654-5c1d83c66153");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68efef42-0e4f-4fa5-acee-767d14230bb5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "694c5c68-6350-454a-988b-a5c41abbb9cd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6e1591e6-dc09-4e82-a519-90595e4673be");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "70b6e0b9-0819-43a8-94c4-1f3bd5a28f6c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "70ba5e2f-cc7b-474f-8e66-9d30aee80108");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "758a4456-20fe-4ae5-889f-245aca37dabb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76b92cda-04aa-4aed-8332-8331ab693a5d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "785cb93c-8368-4611-88fe-5ae02a139570");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a39cbb7-ee86-41ea-9c2d-1cdacdf08077");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ad4e235-0f4e-4ad6-a40e-1144a639cf7d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7d5ff411-3bcb-4707-ae87-6d9338584d9b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "80e75155-d4f2-4623-9d7a-440d49f0f2d4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "81e04944-02b0-4ccc-8799-0b50469102ab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82dcfe64-ec42-461e-a2ce-2238380cc950");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "832b538c-d1d6-4252-bc31-486e0dc0c6ac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a21090c-40da-4616-990d-fa0c2a8d7956");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8bad8d17-9cf2-4fe5-9ef8-b0f4f44df361");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d3d0c2e-a984-48fe-b54d-7eb8988fcc8e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f0a9cfd-aa84-4440-a576-9125e92d8f29");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f3e149e-651d-40d5-b9a7-58bb87d17769");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "926186a8-f496-4025-82c6-1fc2878bdffc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "944d790a-4529-4000-b6af-dc5f9e7dc331");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "945ba4cb-2057-4980-ba92-ebad3c330bfd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95979a0a-e8a8-450a-8896-ab22bcf017f2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ad9e070-8ba6-49ee-b399-aae6bfe04cbc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b0cf926-4e8a-4166-98e2-b6757dde400b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f467850-264a-4ec1-a405-a6891137a5a7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ff2d0d0-0ed3-438a-a7ab-9db7b2db2a21");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2f0391f-9075-498b-9c48-e6c08dfffd86");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a438cf56-0fe0-40ff-8346-e3f462808f78");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a497ada4-a3db-47fb-bbcf-ea766a3e3024");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a78f098f-81a9-447f-a657-d7a87eed3a94");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ac121170-72af-440c-99e9-65616173ce76");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "accffeb1-d844-4b82-aa80-b33257a8d5e3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "acd1b5b8-b15b-4770-b8c2-f007f92c8b1b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b32353a5-1f51-45f4-8468-40f2089c50df");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b35682ad-ec89-4d99-b50d-8aa50f64a543");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b46a4033-75e1-4b67-9823-02bdf43988df");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4fdcaea-950c-4ad5-8235-763a5c6b42d7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b5cdeb10-d9fa-4ad5-b353-d3634055f0da");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bc9d1e30-5923-40fe-aec2-c733c5918914");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd00c6fc-6a35-48bf-a53e-571766158cc2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c082c204-f8ff-48a8-a516-008187c55154");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c0c59c5a-d5cd-4e2c-9947-2860dc1706a2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2466986-069b-4d72-a5cc-0f2df53742a4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c4f5bdb2-0e0d-43ed-8e10-3b8469ef8171");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb68412e-9669-4325-a5e1-a5767acc3f69");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb7f3ed4-3c02-4c81-a053-79dd014a36e2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce5634dd-1d58-4c71-9632-040db53040e0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d226e7b3-e962-4ada-817b-d7e62b4aa049");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d32bf7d5-018b-4223-8665-eef67f66e406");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d556448d-e65d-48fd-87f4-d654f544ac7d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d580f112-d007-47be-a363-66cf3c716a47");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5e64f4f-7a8b-46f0-b889-d455e9812586");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d82ecd13-f5c6-4aac-8b12-76f54a1639b6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da320495-b65a-4d99-af12-64d738f0e5b3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dab18a25-a001-48ff-b873-ba59a18586bf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db070855-fc49-4303-8919-95ad8d716add");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd87e554-da00-4585-9bf6-71a539048753");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9c7d9a7-b50f-4cbe-ab3e-fd9a540c3172");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea57e053-4eba-4dd6-9674-1b239bf340e8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed814e61-d904-41f4-98d0-9bb867f050b7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef5e8cf8-2270-4dbb-9a85-9cf1174dca18");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "efb8e81e-33f8-47b3-8bfd-d519b27b2dcb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0b4ce71-22cb-45bb-8346-d3a8952c8bbf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7647dc5-9059-4587-b2ad-7761f03bd7c9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7acd957-9ced-4283-b8d7-3dbe177e3cb7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9948714-b687-4b0c-97d1-4750b6c175c7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fad2e075-998a-4d97-8478-690f42e76891");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fce64203-c0a0-455c-bc9e-d244928a00ee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff8dc7eb-475a-458c-bd0f-c9c0c8e217d6");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Reservations");

            migrationBuilder.AlterColumn<string>(
                name: "ReservationId",
                table: "Rooms",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "863f63b8-943c-40a1-bae5-529fc38ce420", "0939480b-aa97-4966-83f2-5fe931068b83", "User", "USER" },
                    { "6ecf672a-137e-4458-91b1-120bd23252c4", "515aa90f-60c7-4b34-9445-f8a05799c543", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445864-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "HireDate", "PasswordHash" },
                values: new object[] { "a214fa04-8c13-41d6-a6e1-bdeb997b7131", new DateTime(2023, 3, 16, 18, 45, 30, 486, DateTimeKind.Local).AddTicks(9087), "AQAAAAEAACcQAAAAEKUsJm1RN2z+fB944D2r9X15VfA8kE10MJD+hOQrOQNoyK2ajQ3UG3KLFeAYe8Pcww==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "EGN", "Email", "EmailConfirmed", "FireDate", "FirstName", "HireDate", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "310a0bf1-44fa-45ef-9cc2-c80291d88f15", 0, "33f27e9e-9b57-436f-bc37-a957a360d621", "004886", "user98@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 31, 333, DateTimeKind.Local).AddTicks(1368), true, "Alexandrov", false, null, "Jane", "user98@abv.bg", "user98@abv.bg", "AQAAAAEAACcQAAAAEESoCLB/gktYS43iOJjMvnRQcNkNA7v3N5TpJS2CiPA75wkc7dnxZVLsxDXoymPN8g==", "008783", true, "", false, "user98@abv.bg" },
                    { "40055042-e587-4376-a14c-f42d858661a1", 0, "df9fa0da-c700-466f-b334-91ffb14625b3", "001516", "user72@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 31, 110, DateTimeKind.Local).AddTicks(3549), true, "Alexandrov", false, null, "John", "user72@abv.bg", "user72@abv.bg", "AQAAAAEAACcQAAAAEBPzubqt71ZOkL5W2A3S2zikG8mroVa9YXJOdE3zc68Ppf93PtS6N0I6DKfvxZCqXw==", "009866", true, "", false, "user72@abv.bg" },
                    { "22b970d9-a138-441b-876e-906a2a80494a", 0, "ef29281c-a61d-49e0-8169-e85caf3432be", "009276", "user71@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 31, 101, DateTimeKind.Local).AddTicks(9657), true, "Johnson", false, null, "Jane", "user71@abv.bg", "user71@abv.bg", "AQAAAAEAACcQAAAAEGvqgPMX99jK24phBti4k3GgtLls4+uqo1kTL5wmHUxvjBAuFiEVoFoJsPDU81WGzA==", "005682", true, "", false, "user71@abv.bg" },
                    { "6f02b90d-5286-48e0-afeb-4f4b9f51d471", 0, "1ee3ca9a-5949-43c9-b79f-b0bcedb64a56", "001540", "user70@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 31, 92, DateTimeKind.Local).AddTicks(146), true, "Johnson", false, null, "Jack", "user70@abv.bg", "user70@abv.bg", "AQAAAAEAACcQAAAAEIofA9G+eghp29hm6FFvzju+n8ZXsWEm/Afr3ERA2vSdxhLetKH6pdw08fpyA5ssog==", "003179", true, "", false, "user70@abv.bg" },
                    { "691c2734-906d-4244-bc38-34b8f1c422c4", 0, "71a155a0-4be0-4e6b-b012-901ba4ec653e", "002844", "user69@abv.bg", true, null, "Jack", new DateTime(2023, 3, 16, 18, 45, 31, 83, DateTimeKind.Local).AddTicks(5808), true, "Alexandrov", false, null, "Alex", "user69@abv.bg", "user69@abv.bg", "AQAAAAEAACcQAAAAEELQ/gjLZw4iLeN7fB4/aqRIa+GBjCPswpZaoHtcbA1rbgj1thood5fyBRyO8k5UpA==", "003834", true, "", false, "user69@abv.bg" },
                    { "973b3385-2c52-4e43-973e-742c5359bb10", 0, "6ade9eeb-1e82-411b-88c2-111532f7a005", "008897", "user68@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 31, 74, DateTimeKind.Local).AddTicks(9644), true, "Alexandrov", false, null, "Jane", "user68@abv.bg", "user68@abv.bg", "AQAAAAEAACcQAAAAEEhuaPp8fMfL8vxwMAIO1tvR9Vcfl+mgLRFm+J9s7ZUbv6H5mj77YLRIPEKL5w0hIA==", "007390", true, "", false, "user68@abv.bg" },
                    { "6ec19c6b-7ae7-4df0-bb7a-1110d4b3671a", 0, "3d1d8714-cafe-4573-bbdc-0762cc7b02f8", "002147", "user67@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 31, 66, DateTimeKind.Local).AddTicks(2440), true, "Alexandrov", false, null, "Jane", "user67@abv.bg", "user67@abv.bg", "AQAAAAEAACcQAAAAECJb2X6d3uvjHGXWeMBAudO2T6RpklWkFCB46AetHd377GOblUDdicpXJjUi+dnFtg==", "008185", true, "", false, "user67@abv.bg" },
                    { "bfee186b-8f7f-47bf-ac1a-c96c31f43885", 0, "e594c3c2-46c3-4807-b41a-5386ce836c68", "003748", "user66@abv.bg", true, null, "Jack", new DateTime(2023, 3, 16, 18, 45, 31, 58, DateTimeKind.Local).AddTicks(424), true, "Johnson", false, null, "Alex", "user66@abv.bg", "user66@abv.bg", "AQAAAAEAACcQAAAAEAdDVo9ZSexDaxW4uWwZ7jTHS2gS7ufG8ZjAR5O/uBKvwxdjQEbV+1w22LPK8n5PXA==", "002097", true, "", false, "user66@abv.bg" },
                    { "2e2e8e50-23a6-4e49-8188-8f074f7fb7a7", 0, "b15aa6ef-66b1-4cc7-8461-11c59bd5ccb1", "003209", "user65@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 31, 49, DateTimeKind.Local).AddTicks(9429), true, "Johnson", false, null, "John", "user65@abv.bg", "user65@abv.bg", "AQAAAAEAACcQAAAAECH5am/cOuaQmwAMMJbw4Ql0ANp8cz1zBaGAxbaK5mVtBtT9R0gNRDM3fePaCmiYrQ==", "003534", true, "", false, "user65@abv.bg" },
                    { "56711d20-388a-4f66-86ad-18adccc6f80d", 0, "64bfc2b8-8396-4af7-8f74-28ba0049b44f", "000776", "user64@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 31, 42, DateTimeKind.Local).AddTicks(668), true, "Alexandrov", false, null, "Jack", "user64@abv.bg", "user64@abv.bg", "AQAAAAEAACcQAAAAEOkBesB4Maj2/lvzTysT5S2f9/5++65tQaLAUSsFNgS135Ns5V8Y+LIx1yWpBtUNUg==", "007157", true, "", false, "user64@abv.bg" },
                    { "9f1b6d0f-d448-4d04-998b-dfad94deb32a", 0, "d574d571-6fbe-4050-8511-b275d084909b", "000432", "user73@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 31, 118, DateTimeKind.Local).AddTicks(4688), true, "Alexandrov", false, null, "Alex", "user73@abv.bg", "user73@abv.bg", "AQAAAAEAACcQAAAAELE3A7B6jDpLO0EBtbOktNhEM4K0/fO1uTigaZc0AAVmcVSePWZbYBmUtbtGFd8bHQ==", "009073", true, "", false, "user73@abv.bg" },
                    { "ed024312-f08c-42a3-9352-0a99fe6a67ab", 0, "e456bb5b-6063-4563-8c56-d5acee8351fe", "009836", "user63@abv.bg", true, null, "Jack", new DateTime(2023, 3, 16, 18, 45, 31, 34, DateTimeKind.Local).AddTicks(2186), true, "Alexandrov", false, null, "Jack", "user63@abv.bg", "user63@abv.bg", "AQAAAAEAACcQAAAAEB0bfeeWRcnF84nnkWoeFOn8nw9kwCnEfFuY2P/gv0TjzjSrxZ9sZ0dx2Q82xTlhDQ==", "007885", true, "", false, "user63@abv.bg" },
                    { "5368e623-15e5-468f-9520-709495f69c6b", 0, "d3d0e135-d615-46df-aa98-13efcf6fb360", "006436", "user61@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 31, 18, DateTimeKind.Local).AddTicks(8377), true, "Johnson", false, null, "Jane", "user61@abv.bg", "user61@abv.bg", "AQAAAAEAACcQAAAAECVwO3NUIT8N28xMQEcqfJ9x45/g68HfnnuKuRnkwo7f4GjR25ntoFiSk212dtUDCQ==", "009610", true, "", false, "user61@abv.bg" },
                    { "24d6c12c-8d02-4e5a-8090-7e9c56e18095", 0, "40ad7137-97db-45f9-bd27-01eb37b27775", "007843", "user60@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 31, 11, DateTimeKind.Local).AddTicks(3173), true, "Johnson", false, null, "Jack", "user60@abv.bg", "user60@abv.bg", "AQAAAAEAACcQAAAAEKRufzwzHVGbP21i9VqEUY22JbEogrkGTvuDMktTrxqh5rOMHa80watD/8S+8qfYjw==", "001942", true, "", false, "user60@abv.bg" },
                    { "5385dbad-b1b3-4b2d-8b32-cbe801d10aac", 0, "c9355627-13a6-47b6-afb2-311b5a866ad8", "009437", "user59@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 31, 3, DateTimeKind.Local).AddTicks(5839), true, "Alexandrov", false, null, "Alex", "user59@abv.bg", "user59@abv.bg", "AQAAAAEAACcQAAAAEJPYcX75+MSsiCOhJTsROdTFodQs+uXjQOjFIR0QcEqB8ZaEOF7bUAFBX/J4PMXFxw==", "005056", true, "", false, "user59@abv.bg" },
                    { "d5bbd992-b8a9-470a-948f-1806318c7807", 0, "c4a5d3ff-49e0-48e2-b17d-0e1aa5b58d6a", "009931", "user58@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 30, 995, DateTimeKind.Local).AddTicks(350), true, "Alexandrov", false, null, "Jack", "user58@abv.bg", "user58@abv.bg", "AQAAAAEAACcQAAAAEH+YFkFH0/ZYPWbQTWrgRpnCZeWjOc/w3jdN34E5ysASRUlNec0eWExIn10SBygQcg==", "004959", true, "", false, "user58@abv.bg" },
                    { "9ab9700e-aab5-4987-9bd9-20b19d0bac0a", 0, "8686f01c-c134-4602-ba4b-e396fdae9e15", "003454", "user57@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 30, 986, DateTimeKind.Local).AddTicks(9730), true, "Johnson", false, null, "Jack", "user57@abv.bg", "user57@abv.bg", "AQAAAAEAACcQAAAAEOYLOuOzJMIU3XujOkirzNXuF5jlCTv1655iJJiXx+MBp1cOMUO0Xv0tiK6R5BwkQA==", "002320", true, "", false, "user57@abv.bg" },
                    { "171b17a3-bdf5-4e8b-a973-9695a905a338", 0, "9746fe39-2d4e-4274-81ae-09089ba2cd4e", "008226", "user56@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 30, 978, DateTimeKind.Local).AddTicks(7576), true, "Alexandrov", false, null, "Jack", "user56@abv.bg", "user56@abv.bg", "AQAAAAEAACcQAAAAEB6vSwGlET3sUen99OZ0LaN1N+A1jR119f0QpYHId4//uVaFsVP2PCLy3sGZ0+1nWg==", "005424", true, "", false, "user56@abv.bg" },
                    { "7865dbbc-2034-45ef-924f-a19c6a7f5c8a", 0, "988725d7-68fd-41cf-bdce-d874815603c1", "000464", "user55@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 30, 970, DateTimeKind.Local).AddTicks(6644), true, "Johnson", false, null, "Jane", "user55@abv.bg", "user55@abv.bg", "AQAAAAEAACcQAAAAEIHqJcAq/RMylu186xaf9n+Uby8YSMMS8Ei0mKfK95C1+cQPwz4uMYAIpf61PvUd1g==", "009959", true, "", false, "user55@abv.bg" },
                    { "83bd512b-329e-4f95-b7c1-9e7b45cc485b", 0, "4f9ef728-f0e6-4c6a-8d5a-0e7cfddafdbf", "005791", "user54@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 30, 962, DateTimeKind.Local).AddTicks(5752), true, "Alexandrov", false, null, "John", "user54@abv.bg", "user54@abv.bg", "AQAAAAEAACcQAAAAEFactMre2xlSpa7PWV8zzz4/5dY7ST0uW2FzHQIOpMg3IyY4Q07/uqHQi4U/cSTOsA==", "008415", true, "", false, "user54@abv.bg" },
                    { "ff2a668d-148a-42fa-82a6-58f5f7cbb15e", 0, "30ec3596-35dc-4ab5-ba2a-5bf1dbe27367", "004213", "user53@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 30, 954, DateTimeKind.Local).AddTicks(6494), true, "Alexandrov", false, null, "John", "user53@abv.bg", "user53@abv.bg", "AQAAAAEAACcQAAAAEDwQA/TUpdBgJz5+o7/9f/LzSZrkDxffqbWndsLe1gP8aX6p1ogsooe6gRA1lCPdmA==", "006754", true, "", false, "user53@abv.bg" },
                    { "f355fbfe-827d-4f58-84df-89fe35f5cde9", 0, "fe26a57d-e704-41d7-8076-a4e2007aa96c", "006980", "user62@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 31, 26, DateTimeKind.Local).AddTicks(2722), true, "Johnson", false, null, "John", "user62@abv.bg", "user62@abv.bg", "AQAAAAEAACcQAAAAEG/AWxi6eo6idaY2HHk67Ht34BJl1Ufn0kas+92YaVq0BqQSM7/SNGhtF6FT+owxzw==", "002457", true, "", false, "user62@abv.bg" },
                    { "3844a9df-77a3-4109-8ec9-eb8b50b77aaf", 0, "7ce084d1-6dcf-4c96-b65a-487aa775da61", "007924", "user74@abv.bg", true, null, "Jack", new DateTime(2023, 3, 16, 18, 45, 31, 127, DateTimeKind.Local).AddTicks(5990), true, "Alexandrov", false, null, "Alex", "user74@abv.bg", "user74@abv.bg", "AQAAAAEAACcQAAAAEB4/RzbEcGZX2k0AbB12Zbo+XfwmUfLYk/rHeXhZpE3skWbWMUHgrZh50OsHyNJ1xQ==", "000572", true, "", false, "user74@abv.bg" },
                    { "f5f75346-834c-465c-a299-72f791085292", 0, "d330a766-ff2c-4872-bdc4-81ebd3ba0676", "004335", "user75@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 31, 136, DateTimeKind.Local).AddTicks(6438), true, "Alexandrov", false, null, "Jack", "user75@abv.bg", "user75@abv.bg", "AQAAAAEAACcQAAAAEMV2EcwsWhtk4r3gp9XJtlnJpKrZ8EKOd0s12HAyDRx6FYlYCtD14fsWAka89bbOWw==", "003818", true, "", false, "user75@abv.bg" },
                    { "0545f90a-70d8-4935-a049-95cf2d764afc", 0, "d6bbef62-d84b-40dc-9220-49fd435f89c9", "002122", "user52@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 30, 946, DateTimeKind.Local).AddTicks(6112), true, "Johnson", false, null, "Jack", "user52@abv.bg", "user52@abv.bg", "AQAAAAEAACcQAAAAEBaKHqaJV4BuNTrYOueGKZWtPGeOl9SMTJ9R9hVBXcbYD/PpoRbHedG6xe3qXbdMZg==", "002890", true, "", false, "user52@abv.bg" },
                    { "2138aa1f-9037-41f4-955c-7f218c5b0c87", 0, "dbc147b0-4375-4ebe-a1cf-d419a3671390", "004697", "user97@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 31, 325, DateTimeKind.Local).AddTicks(5348), true, "Alexandrov", false, null, "Jane", "user97@abv.bg", "user97@abv.bg", "AQAAAAEAACcQAAAAEJ8FL0Mu1BQD8JUajj91SfETbzdpF0KVzj/DdT4rnyvdLpAdhkM+LyAdk60hf1lyTQ==", "004507", true, "", false, "user97@abv.bg" },
                    { "c806d3d2-b999-49f6-98a8-5e4beca42e4f", 0, "87fe72a5-69e8-47c0-ad83-16fda09cba80", "002258", "user96@abv.bg", true, null, "Jack", new DateTime(2023, 3, 16, 18, 45, 31, 317, DateTimeKind.Local).AddTicks(3107), true, "Alexandrov", false, null, "Jane", "user96@abv.bg", "user96@abv.bg", "AQAAAAEAACcQAAAAEK+4M5j2XwK1Hows106CRkRFmjpjaMRzc7VzCK29dbtlzBEgtQwpWcZJj5QPrc+f0A==", "004953", true, "", false, "user96@abv.bg" },
                    { "ebfbfc66-bd23-4aaa-8a8a-6e6d4cc3bed0", 0, "e2ec44ad-4da5-4baf-bc30-2f18b98854f4", "005356", "user95@abv.bg", true, null, "Jack", new DateTime(2023, 3, 16, 18, 45, 31, 309, DateTimeKind.Local).AddTicks(3558), true, "Alexandrov", false, null, "Jack", "user95@abv.bg", "user95@abv.bg", "AQAAAAEAACcQAAAAEJqCRqPsYX8IxXPkvCr6SiYuyMx/JCosC2My/iGwWdfFf+9Sw5eK2Iib6KwgIiLReQ==", "005137", true, "", false, "user95@abv.bg" },
                    { "bab17fa2-ff82-4dea-babc-527f16db3e78", 0, "720ea2ef-faff-4b9d-a1b6-f7f88340ec27", "007500", "user94@abv.bg", true, null, "Jack", new DateTime(2023, 3, 16, 18, 45, 31, 300, DateTimeKind.Local).AddTicks(9708), true, "Johnson", false, null, "Alex", "user94@abv.bg", "user94@abv.bg", "AQAAAAEAACcQAAAAEK3bTGObM4yU6PdC+A8+Fts1lS9Y7jlaYmopnoR9P7t50aEV+2bO+ZIhu4vWKL2dAw==", "008182", true, "", false, "user94@abv.bg" },
                    { "81c2396b-664d-4725-aea3-111cb1668a14", 0, "faeede65-75d8-46fa-b454-e76e6a59969f", "005403", "user93@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 31, 292, DateTimeKind.Local).AddTicks(760), true, "Johnson", false, null, "Jack", "user93@abv.bg", "user93@abv.bg", "AQAAAAEAACcQAAAAEFOSonNpJsV44djhEQBN3DbOCgSJQ92O+CkzejDI3ZClA3taq7KGEK7Ke5F982SKXQ==", "003398", true, "", false, "user93@abv.bg" },
                    { "5d7e0bc8-c6f8-4b3f-93e8-05b2d99e061e", 0, "59e05b24-8729-4d8b-9bc8-06d325db22b8", "001582", "user92@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 31, 283, DateTimeKind.Local).AddTicks(7761), true, "Alexandrov", false, null, "Jack", "user92@abv.bg", "user92@abv.bg", "AQAAAAEAACcQAAAAEKw+stq4fP0dhDWDRJUTp+aCrOn71VJoOF3nDHCOTNkKZcbyqlYY1UdaXzZfsuDcKQ==", "009947", true, "", false, "user92@abv.bg" },
                    { "1c84c71d-a231-4b0a-92f0-97569eff3cc7", 0, "5c4a921f-cc11-4728-aa1e-0ff140eb107a", "002837", "user91@abv.bg", true, null, "Jack", new DateTime(2023, 3, 16, 18, 45, 31, 275, DateTimeKind.Local).AddTicks(5949), true, "Alexandrov", false, null, "Jack", "user91@abv.bg", "user91@abv.bg", "AQAAAAEAACcQAAAAEIcY1n8RJDnkox017IWXAK+WjtM0QfAUp4+vNXE5eLw18XAZ3PEM21ro/fpB9JWi2Q==", "009914", true, "", false, "user91@abv.bg" },
                    { "be539df8-60ce-4dec-a1d0-e86bd541fe12", 0, "b6a53d0b-a0ae-4894-92b6-6eaaf6db1ea4", "006191", "user90@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 31, 267, DateTimeKind.Local).AddTicks(3005), true, "Johnson", false, null, "Jack", "user90@abv.bg", "user90@abv.bg", "AQAAAAEAACcQAAAAEB8ZsEInskQTeQDnCJ7oJa0sENuzkCwrA/nSBjNghBHeyWzR3qD7+GE13xKKs9D+PQ==", "007950", true, "", false, "user90@abv.bg" },
                    { "7f82a25e-b33f-4bb6-b038-819eccf813ae", 0, "768c4534-8496-4bd2-af7c-e8f229061bdb", "000958", "user89@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 31, 258, DateTimeKind.Local).AddTicks(7477), true, "Johnson", false, null, "Jane", "user89@abv.bg", "user89@abv.bg", "AQAAAAEAACcQAAAAEBS6qmH8qI4KnfRP81JgAz0rxEtwpDE7g+ToZdGhM3sj8FUkegpLvP0aSMLITnV8Cg==", "004520", true, "", false, "user89@abv.bg" },
                    { "4f8f4799-ffe4-47da-9e85-7df893f60687", 0, "cec65fed-ce4a-47d6-bdf8-33a8b265dad0", "003698", "user88@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 31, 249, DateTimeKind.Local).AddTicks(5381), true, "Alexandrov", false, null, "John", "user88@abv.bg", "user88@abv.bg", "AQAAAAEAACcQAAAAELQ4peK1m40htmcXFKBXrEux0wjEXkF8b+uqfre0AUiFMTXgpg0ip65cNmQofdcaUw==", "004890", true, "", false, "user88@abv.bg" },
                    { "12c49bdf-8b79-46fa-93bd-9c806a42a146", 0, "662f4655-e30e-4ca3-bc1f-8d91456e63d4", "004397", "user87@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 31, 241, DateTimeKind.Local).AddTicks(1936), true, "Johnson", false, null, "Jack", "user87@abv.bg", "user87@abv.bg", "AQAAAAEAACcQAAAAEN39Iav0Zi3vuZJHxRxfX0fROtjvmjFhEvwd5HJr400liOX0O5AiXMhEfIHrU+Gcgg==", "004355", true, "", false, "user87@abv.bg" },
                    { "b5e3b998-84e8-4fea-898f-4a02df84fb50", 0, "58fe2a3e-a166-45b7-8b5e-22c290a6202e", "008234", "user86@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 31, 232, DateTimeKind.Local).AddTicks(6363), true, "Alexandrov", false, null, "Alex", "user86@abv.bg", "user86@abv.bg", "AQAAAAEAACcQAAAAEHINZ0mCgswxwK7UbPWRJDq7moju1HO3A8mtN+EajXNtRGEIu7/LaRcpvyrSSgeL2w==", "002803", true, "", false, "user86@abv.bg" },
                    { "30d582e8-70e8-4e53-a189-ff87f6d4ff52", 0, "b263c82d-3d60-4c5b-883a-097b29f48226", "004825", "user85@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 31, 223, DateTimeKind.Local).AddTicks(8345), true, "Alexandrov", false, null, "Jack", "user85@abv.bg", "user85@abv.bg", "AQAAAAEAACcQAAAAEAnt0Uw7Lp8Y4IQ4qNKeI3kUTNqlG5JiwE+C99hCjMpcjzZmj51yOHgunMQL5Oq30A==", "004893", true, "", false, "user85@abv.bg" },
                    { "b0cd465c-70a4-41ed-84da-865165952cbf", 0, "c8771cbc-22bc-4451-b0bb-f1fe860141c6", "009846", "user84@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 31, 215, DateTimeKind.Local).AddTicks(408), true, "Johnson", false, null, "Jane", "user84@abv.bg", "user84@abv.bg", "AQAAAAEAACcQAAAAEKMeFZ2lgmpRjH/NQLqnewRMZb+dHbLqDXW5PSXGjfeIptCNnZceOWk6k+CTGSDDGg==", "007001", true, "", false, "user84@abv.bg" },
                    { "42835c46-e5ec-4229-aac3-08225ff7459e", 0, "15da1801-3ea2-4e07-b5f9-db32636bbbfe", "009713", "user83@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 31, 206, DateTimeKind.Local).AddTicks(5310), true, "Johnson", false, null, "Alex", "user83@abv.bg", "user83@abv.bg", "AQAAAAEAACcQAAAAEMrO5tk3xymywsmFCPzENPVNWzOXPwmzx+OQkBtRMQfJpRa04VxH+0yYq6X6+1Lq+w==", "000322", true, "", false, "user83@abv.bg" },
                    { "317f785b-6bf7-474e-8293-a8ee6d8a797f", 0, "7895e9de-fe4e-47b7-be4f-25831ddb9f1d", "004486", "user82@abv.bg", true, null, "Jack", new DateTime(2023, 3, 16, 18, 45, 31, 198, DateTimeKind.Local).AddTicks(181), true, "Alexandrov", false, null, "Jack", "user82@abv.bg", "user82@abv.bg", "AQAAAAEAACcQAAAAEApwytza/MX3fpkZJdN0kQUiz9LVIm//JjFOBTPtZpDeEvrlhxrecBu7h5j1Tyj9ew==", "008452", true, "", false, "user82@abv.bg" },
                    { "cb235131-5172-4c2e-a910-423583f1979c", 0, "099ed8f1-b80f-4656-a6b3-b87f8bdd6607", "002074", "user81@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 31, 189, DateTimeKind.Local).AddTicks(5933), true, "Alexandrov", false, null, "Alex", "user81@abv.bg", "user81@abv.bg", "AQAAAAEAACcQAAAAELCNtVDlhvY2VeSR+HTrnSj3gD/7XJyyzOFqM0OSJ0HZIjDpvHn9RbGX7grkmrw03g==", "007251", true, "", false, "user81@abv.bg" },
                    { "3141bfe2-4ea1-4703-9e76-9480aa913aeb", 0, "3ab0e858-35bd-4679-888e-96f2dce8a1e5", "006187", "user80@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 31, 181, DateTimeKind.Local).AddTicks(1075), true, "Johnson", false, null, "Jack", "user80@abv.bg", "user80@abv.bg", "AQAAAAEAACcQAAAAEINyGKcQJK0IcuRxhPXMbckrvjr77Y8KLF4I6kvGjE8WIueIkgoFh4Z/YN1Y6KUibQ==", "009164", true, "", false, "user80@abv.bg" },
                    { "e69ff9b9-7034-451a-a9af-f01929d6c682", 0, "abc76b45-3329-4777-b896-187de715c5b0", "002400", "user79@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 31, 172, DateTimeKind.Local).AddTicks(2802), true, "Johnson", false, null, "Alex", "user79@abv.bg", "user79@abv.bg", "AQAAAAEAACcQAAAAEKBwY4Rtuw83Dkbs0fg8NDuv7vU8VtNhGs8jk95jN4tengccZP471RyFw4GbMBl9Vw==", "001875", true, "", false, "user79@abv.bg" },
                    { "5f310e6e-f60f-49d8-aade-521799d45867", 0, "73890619-59cd-4366-be8f-bb641e703c9e", "001028", "user78@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 31, 162, DateTimeKind.Local).AddTicks(6815), true, "Alexandrov", false, null, "Alex", "user78@abv.bg", "user78@abv.bg", "AQAAAAEAACcQAAAAELCVqmS5TOlannASuDNhHZfibi+021yQPjJuWN8OPFkjvoNVezcbLgscYkJ/sOzi4w==", "007454", true, "", false, "user78@abv.bg" },
                    { "f7868b05-734f-4a3a-9844-fc4baef6c192", 0, "acca3802-3505-4834-90c2-f0230bef5adc", "002600", "user77@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 31, 153, DateTimeKind.Local).AddTicks(8330), true, "Johnson", false, null, "Jack", "user77@abv.bg", "user77@abv.bg", "AQAAAAEAACcQAAAAEGFUd/zFxqR7uydTTKlxsdGDO+2QoZJeYacvKzCWOvq5/tb6ODKH3I3546EvaaKupw==", "006028", true, "", false, "user77@abv.bg" },
                    { "36939b51-52e7-4b14-b3de-f5b2f1465bbb", 0, "109aa763-bc3f-4ee1-b5ff-b0e859aa570a", "009477", "user99@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 31, 340, DateTimeKind.Local).AddTicks(9161), true, "Alexandrov", false, null, "Jack", "user99@abv.bg", "user99@abv.bg", "AQAAAAEAACcQAAAAEE9QR6gqeYJRzIFW5SJp+SOERMdFhOjYPEedqt5mOQMM33DjXbQEvcFv98CzvlbjIA==", "003978", true, "", false, "user99@abv.bg" },
                    { "ece9887d-2925-4beb-95a1-8f6860452b07", 0, "31c25e36-9a81-48e6-989f-b774edc44043", "003312", "user76@abv.bg", true, null, "Jack", new DateTime(2023, 3, 16, 18, 45, 31, 144, DateTimeKind.Local).AddTicks(7714), true, "Alexandrov", false, null, "Jane", "user76@abv.bg", "user76@abv.bg", "AQAAAAEAACcQAAAAEHfS/Pe7NQ9y8hmyf7XKbTVWrVGuGvO3njRDTFNUImXSWV0IIxXusu5npC2n01j93Q==", "009299", true, "", false, "user76@abv.bg" },
                    { "8817f1a3-c1f8-458e-9174-89014698e0aa", 0, "2bed117c-e4d1-486f-9d78-dc7f5fde4fd4", "009085", "user51@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 30, 938, DateTimeKind.Local).AddTicks(7841), true, "Alexandrov", false, null, "Jack", "user51@abv.bg", "user51@abv.bg", "AQAAAAEAACcQAAAAEOtw8GoTcsHToriEfnn0iVMflY9Saf02MX0t6SIJWLEB5JdYy2YeMGlNMtVIomKGgw==", "005170", true, "", false, "user51@abv.bg" },
                    { "515df932-7769-4581-b590-032eb391309d", 0, "0b5bd052-9836-4aae-a0e6-0f592f4aca48", "006658", "user49@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 30, 921, DateTimeKind.Local).AddTicks(1574), true, "Johnson", false, null, "Alex", "user49@abv.bg", "user49@abv.bg", "AQAAAAEAACcQAAAAEOyrW65TCGiSR9/FHlSg/tRDRYeuF+Rjv+ZJcIxMAAma4n3sehShscKkQ5RBhNl0aw==", "005667", true, "", false, "user49@abv.bg" },
                    { "ac39ebb6-dd26-4157-88f3-2b3e617a4b77", 0, "06d6f043-9903-46ea-a204-e4d1299b9099", "004142", "user22@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 30, 687, DateTimeKind.Local).AddTicks(173), true, "Alexandrov", false, null, "Alex", "user22@abv.bg", "user22@abv.bg", "AQAAAAEAACcQAAAAEPFWkwxUE8SAV1HlIWPISmSei9t0pvidJHhWQu34Ok0i/Jwe0o9fJgfRdgZLb87/+A==", "000806", true, "", false, "user22@abv.bg" },
                    { "e5685cfe-3f9e-4366-aca6-0ddc300f4115", 0, "4ee7cefd-7511-486c-9a94-ec72dfe6bf57", "003726", "user21@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 30, 678, DateTimeKind.Local).AddTicks(2403), true, "Alexandrov", false, null, "Jane", "user21@abv.bg", "user21@abv.bg", "AQAAAAEAACcQAAAAECcxpMDyAHDDkwSn7QiNEgq+Jc0B9x9lFU2ql7Xz1tFg7BWU75NH2serfEJHiryFSQ==", "000529", true, "", false, "user21@abv.bg" },
                    { "a7109c8e-6c15-48b2-bdf0-594301c41e95", 0, "8e98620c-12c0-45d3-8b25-59b38daf582b", "009454", "user20@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 30, 670, DateTimeKind.Local).AddTicks(3907), true, "Johnson", false, null, "John", "user20@abv.bg", "user20@abv.bg", "AQAAAAEAACcQAAAAEGP0CldP/czJBAxZ56c1m8ijPt5O38RN4YzvbcPknD0mmmcCU2HkWRQUJeuMedg+ww==", "000066", true, "", false, "user20@abv.bg" },
                    { "30204ffa-f756-411d-be05-b7efae209e0c", 0, "a4439447-410c-4ed1-a36d-3a7a279f7b45", "005597", "user19@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 30, 662, DateTimeKind.Local).AddTicks(2639), true, "Johnson", false, null, "John", "user19@abv.bg", "user19@abv.bg", "AQAAAAEAACcQAAAAEPk6z4JtS8uFndjm9/vYqeYcs0aFUEOZmSALeOTukAu8SEbjyUmz3aI9kOTsBtWQvg==", "004156", true, "", false, "user19@abv.bg" },
                    { "04a8ec0f-249c-4013-b104-6dcd9906fcf0", 0, "308a8c3c-d865-4f9a-8c34-4f2dc45f5d9d", "001656", "user18@abv.bg", true, null, "Jack", new DateTime(2023, 3, 16, 18, 45, 30, 654, DateTimeKind.Local).AddTicks(6299), true, "Alexandrov", false, null, "Jack", "user18@abv.bg", "user18@abv.bg", "AQAAAAEAACcQAAAAEMquZTHOKujk1S1006eK6dxlRoY+XvykwQCTXGY6jvORlI+P5wcDcILHtiX+CgEOuA==", "008035", true, "", false, "user18@abv.bg" },
                    { "49349abd-1cb6-4022-86fd-fbbbe7ec0c63", 0, "fd5d3528-558d-41bc-8d66-b561a36bf1eb", "002236", "user17@abv.bg", true, null, "Jack", new DateTime(2023, 3, 16, 18, 45, 30, 646, DateTimeKind.Local).AddTicks(7204), true, "Johnson", false, null, "Jack", "user17@abv.bg", "user17@abv.bg", "AQAAAAEAACcQAAAAEJ38qLb+CuEJRcSPwuiHobz2qs8/DVcj/APvnDERxpJqAl7snw6z7VAY7u2+Z2fzqA==", "007158", true, "", false, "user17@abv.bg" },
                    { "c97b2b92-476b-4882-bace-338e944a07f8", 0, "83d1f1a3-d6d7-438f-8aea-750a766a9139", "006670", "user16@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 30, 638, DateTimeKind.Local).AddTicks(7733), true, "Johnson", false, null, "Jack", "user16@abv.bg", "user16@abv.bg", "AQAAAAEAACcQAAAAEOJn22NLKgpygoRL00O8Wvy5CyJE32OT2s6kNqgS/CzGIJLL/b7cqPGR5J/Z79eCeg==", "009426", true, "", false, "user16@abv.bg" },
                    { "1be25721-5914-4520-8741-b46dcbddfaa6", 0, "4af10038-7507-4e31-b4a6-423723c762ed", "003710", "user15@abv.bg", true, null, "Jack", new DateTime(2023, 3, 16, 18, 45, 30, 630, DateTimeKind.Local).AddTicks(5864), true, "Alexandrov", false, null, "John", "user15@abv.bg", "user15@abv.bg", "AQAAAAEAACcQAAAAEEj2gv0CwitN3ey0e5K9O3/AiHE83aD4thJ01I0x44KjjQ6wWy22sn0ha4QEO8jQWQ==", "004251", true, "", false, "user15@abv.bg" },
                    { "55759b4a-ea02-4314-8736-52c4a1ff9a17", 0, "5561c86d-ce1a-429e-82a9-e763802b93b9", "003141", "user14@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 30, 621, DateTimeKind.Local).AddTicks(8895), true, "Alexandrov", false, null, "Jane", "user14@abv.bg", "user14@abv.bg", "AQAAAAEAACcQAAAAEMYhfd4kv2wPOraLV2si9mxkVgnPRppn/gw9RXS+1mXnzKOz20oapsFaLCevpcotVw==", "006045", true, "", false, "user14@abv.bg" },
                    { "9c250e9b-8343-4dfa-8d94-f650bda4e60d", 0, "56d70cad-5acf-4022-9149-8414b4eca9ac", "006198", "user13@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 30, 613, DateTimeKind.Local).AddTicks(5236), true, "Alexandrov", false, null, "Alex", "user13@abv.bg", "user13@abv.bg", "AQAAAAEAACcQAAAAEBCjDIGI9SbF2WuADOPhrBR/q7jfMXBgz4D2exErdSPnXtUL3qYjyFbEHNi2LajFHw==", "000707", true, "", false, "user13@abv.bg" },
                    { "40dee55d-c036-4c00-8122-3fbe18a08291", 0, "56af1c44-c7ed-49c9-a5ee-62dbcb399b54", "009594", "user23@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 30, 695, DateTimeKind.Local).AddTicks(83), true, "Johnson", false, null, "Jack", "user23@abv.bg", "user23@abv.bg", "AQAAAAEAACcQAAAAEFRkEOcRWKf7K/hhHe5aEwF18txfJ8Lsb5DzLkCrW15LDKdEC7Oi9ZJypgjr6tN1Tw==", "003804", true, "", false, "user23@abv.bg" },
                    { "7a1e3e1d-5eb6-4c94-8081-25620210fce3", 0, "b0f4ea18-46c9-4577-a548-291691b759bb", "007517", "user12@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 30, 602, DateTimeKind.Local).AddTicks(7739), true, "Alexandrov", false, null, "Alex", "user12@abv.bg", "user12@abv.bg", "AQAAAAEAACcQAAAAEBtifmF/BzChF/aQ4pbOoYXnZj8vNzdZmI24Koh7BwvYEn4QTZ8iS0dHbqdoRlHRUg==", "000327", true, "", false, "user12@abv.bg" },
                    { "8880a31f-9062-49c8-97d3-5d0ff02e3b37", 0, "8d3f3963-2875-4e76-9791-e29a0e744416", "009444", "user10@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 30, 582, DateTimeKind.Local).AddTicks(6450), true, "Alexandrov", false, null, "Jack", "user10@abv.bg", "user10@abv.bg", "AQAAAAEAACcQAAAAEKDp0ZxsZuAYRv+b++eJ1quZV0s6+WhZwnphIEqIQ2eMP+zui0i96A7KcDWNMT64jQ==", "008065", true, "", false, "user10@abv.bg" },
                    { "d20dfd6b-8d25-4e9c-947c-6feb1333d483", 0, "c518a6ea-a168-49ec-8815-0e56b605690c", "000567", "user9@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 30, 572, DateTimeKind.Local).AddTicks(2727), true, "Alexandrov", false, null, "Jack", "user9@abv.bg", "user9@abv.bg", "AQAAAAEAACcQAAAAEFyaYFr9E213a2m6WmjibsfrblAP7MXgw1Uy0YVMob7JmfaAtTegdfjg2JdwYZhdGQ==", "006058", true, "", false, "user9@abv.bg" },
                    { "3b2b43e2-6a06-41fc-a23b-997ffe1d5a86", 0, "a3cf17c0-30b5-46d5-9b5f-aa90078f3eeb", "009960", "user8@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 30, 561, DateTimeKind.Local).AddTicks(7609), true, "Johnson", false, null, "Jane", "user8@abv.bg", "user8@abv.bg", "AQAAAAEAACcQAAAAEERUUzK78Jq6Ey/YS4yRVo0u+XUFVRH+gA+e2KsiAMiNc1Je5xHT7gIh/1qmYyzkKg==", "007092", true, "", false, "user8@abv.bg" },
                    { "72bae118-1a8e-4b6d-9a22-ff1c06f7a48d", 0, "a8bfd21d-8fa7-478b-a345-256aaa81c87d", "009232", "user7@abv.bg", true, null, "Jack", new DateTime(2023, 3, 16, 18, 45, 30, 553, DateTimeKind.Local).AddTicks(3477), true, "Johnson", false, null, "Alex", "user7@abv.bg", "user7@abv.bg", "AQAAAAEAACcQAAAAEDxJ3eIKMO22DY7fJSnO6GDXN30PX6S5YeS4T488AC22rXcP/jZ8GKPxyRDGX11yyw==", "007284", true, "", false, "user7@abv.bg" },
                    { "b800df25-389b-464d-8a05-5ef5c5c43e96", 0, "aa3846be-8a35-45d7-baef-fe203210be7b", "001947", "user6@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 30, 543, DateTimeKind.Local).AddTicks(3811), true, "Johnson", false, null, "Alex", "user6@abv.bg", "user6@abv.bg", "AQAAAAEAACcQAAAAEHnBta1q6HGGTPk9g+M5GtUL5yUV2cd/wNZza5CJ5jXIC/7lCCOvFIFQVcQT0pkyow==", "001326", true, "", false, "user6@abv.bg" },
                    { "5dcea69b-a35a-4033-a4ca-515e41778834", 0, "129d20d5-f226-417b-a489-7fdab1936748", "003305", "user5@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 30, 535, DateTimeKind.Local).AddTicks(3302), true, "Johnson", false, null, "Jane", "user5@abv.bg", "user5@abv.bg", "AQAAAAEAACcQAAAAEOGMPujvqmSflC96Xc39V03Yh1Oq2daLpG+VEp/KTPz9YnAUlOolMmrT0N+kgHmFKg==", "001076", true, "", false, "user5@abv.bg" },
                    { "4264826e-90e0-421a-bddc-4a2c3e70433c", 0, "6b91e84d-1c20-446e-bee4-42bfc693b607", "008466", "user4@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 30, 526, DateTimeKind.Local).AddTicks(1873), true, "Alexandrov", false, null, "Jane", "user4@abv.bg", "user4@abv.bg", "AQAAAAEAACcQAAAAEHq2vO2P34Hz7alubgBG/4yZ2UovntRHLoBHmRgFWe9fDLZMAM+a5Oif8s6LZj0xGw==", "003889", true, "", false, "user4@abv.bg" },
                    { "9349cb3d-2c32-4922-9ae8-f9c12e2f6574", 0, "4f040ae3-61fd-452f-8e03-7d6abe861c83", "008054", "user3@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 30, 518, DateTimeKind.Local).AddTicks(2347), true, "Johnson", false, null, "Jane", "user3@abv.bg", "user3@abv.bg", "AQAAAAEAACcQAAAAEFeNtidnGuaUz2b0VMNfTBbRHjNHsUHny6ljJmQfMPyQhKK3KybBgZO7Ia4BijVOOg==", "008385", true, "", false, "user3@abv.bg" },
                    { "e967aedd-34ec-42d5-aabb-fe64a99a480b", 0, "40da15c5-0546-4ebb-ad0e-938303fd95f6", "000988", "user2@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 30, 509, DateTimeKind.Local).AddTicks(3552), true, "Alexandrov", false, null, "John", "user2@abv.bg", "user2@abv.bg", "AQAAAAEAACcQAAAAEI2PCDc1ti12ekNpSUzFOhcJkrUEQGXDb8xdMb7RrgPr+PrD74FFn/xLjc+SmzKPtA==", "000543", true, "", false, "user2@abv.bg" },
                    { "e46f9d0c-a7d3-405a-9493-94d75f6c52dd", 0, "06c6b29d-8290-4baa-b16b-429a113a19ed", "000309", "user1@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 30, 501, DateTimeKind.Local).AddTicks(469), true, "Alexandrov", false, null, "Jane", "user1@abv.bg", "user1@abv.bg", "AQAAAAEAACcQAAAAEBH29clWc3f1wU1PQejbxkTHYJpycGv2JpXFCGNSbSTu5mWnEaGsh99yZ5QV5825/g==", "000649", true, "", false, "user1@abv.bg" },
                    { "9d4d1efa-6fac-454c-8dbd-492ab1e5f64f", 0, "09375a80-2ea2-499f-877b-e89610a4330c", "008238", "user11@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 30, 593, DateTimeKind.Local).AddTicks(6862), true, "Johnson", false, null, "Jack", "user11@abv.bg", "user11@abv.bg", "AQAAAAEAACcQAAAAEPACVHWUzeJ+VSZvxRN8XQsy7AXmgthxEZY03ch8kx2WKBUh5f3RscwxnOWGofsesg==", "002045", true, "", false, "user11@abv.bg" },
                    { "e96d0d8a-6a34-4d26-afd4-f7fa9c9af648", 0, "8499d104-83da-4b84-b680-ee118e4ffd98", "004397", "user50@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 30, 930, DateTimeKind.Local).AddTicks(5260), true, "Johnson", false, null, "Jane", "user50@abv.bg", "user50@abv.bg", "AQAAAAEAACcQAAAAEK78VsIBu4D+eKRGCNYKsYBpGK66D5/7tZL5yMP6zaON/9fHA3KtBADGUTh0fQXYbQ==", "003368", true, "", false, "user50@abv.bg" },
                    { "999daf2b-0bf0-4f99-820e-009c1da8a85b", 0, "175fabf6-99fc-47d0-b878-cf851c8ab6f3", "000183", "user24@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 30, 703, DateTimeKind.Local).AddTicks(5301), true, "Johnson", false, null, "Jane", "user24@abv.bg", "user24@abv.bg", "AQAAAAEAACcQAAAAEO3vTvpN4Q8AlCrFLGLXB4Dy+UMJhfhb7OBJLSegMAxmd3Jgg2ahEqkH4j/3X6LM4A==", "009007", true, "", false, "user24@abv.bg" },
                    { "f05abb57-5fe4-4d1f-972c-516b5768598c", 0, "2431f985-4ad3-483e-b6c8-da02c296e4bf", "007522", "user26@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 30, 720, DateTimeKind.Local).AddTicks(724), true, "Alexandrov", false, null, "Alex", "user26@abv.bg", "user26@abv.bg", "AQAAAAEAACcQAAAAEF3RkSQj84EuqI6NSIjZ0z4s+UDhLfiCQaUdC/z2i52E339jcynMfDA/cqDKwAFiQA==", "004715", true, "", false, "user26@abv.bg" },
                    { "699d13d3-6e14-44e9-959d-30e13c24e3b6", 0, "1edbfb49-a764-453e-834b-8d1344112ac8", "005145", "user48@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 30, 911, DateTimeKind.Local).AddTicks(8782), true, "Alexandrov", false, null, "Alex", "user48@abv.bg", "user48@abv.bg", "AQAAAAEAACcQAAAAEOpEbmjZko29hS2zuIBlyp5+3glyGBB+vPO0gCNTyGihloCCnL3XwC3+BLaeAv0y1w==", "004426", true, "", false, "user48@abv.bg" },
                    { "6ef61d9e-67a3-410d-8e79-2f4ef2e73923", 0, "20649858-6c2f-4e12-b8d2-b8a57bc3a14f", "007508", "user47@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 30, 902, DateTimeKind.Local).AddTicks(8315), true, "Alexandrov", false, null, "Jack", "user47@abv.bg", "user47@abv.bg", "AQAAAAEAACcQAAAAEGDiPsaXdaYdCGUIzhJrj5RfQ3SVwpNvPvebPWPym26J5NlCF3s5Ytbqs0ZVGA7qFw==", "003045", true, "", false, "user47@abv.bg" },
                    { "01ad6a6a-0e57-4dad-a9dd-d6f9520a0f0f", 0, "3930c605-518c-41f9-ace3-906cfcc17732", "006962", "user46@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 30, 894, DateTimeKind.Local).AddTicks(3084), true, "Alexandrov", false, null, "Jack", "user46@abv.bg", "user46@abv.bg", "AQAAAAEAACcQAAAAEORuEk3yZonOBYyFKbvyu9lzLmdmvAPRfs36qkizTPVDY7fw4TBByGBW4BpadnV0Hw==", "000831", true, "", false, "user46@abv.bg" },
                    { "c601ea23-624b-450c-9579-0d1b7bba71be", 0, "84523d8e-6992-4316-80f6-5a573fdf9653", "009843", "user45@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 30, 885, DateTimeKind.Local).AddTicks(5637), true, "Alexandrov", false, null, "John", "user45@abv.bg", "user45@abv.bg", "AQAAAAEAACcQAAAAEE3yemfifb0dpeBAmKxqS9iumNoR8zc6Iskl746PN0ZG7bHHz/OUTU+4diMfrbCejg==", "002713", true, "", false, "user45@abv.bg" },
                    { "82feddcd-2cfb-495a-a05e-fb55a4936ab9", 0, "c4163dd0-226d-4782-b7fc-2aa2b9711494", "000626", "user44@abv.bg", true, null, "Jack", new DateTime(2023, 3, 16, 18, 45, 30, 877, DateTimeKind.Local).AddTicks(617), true, "Johnson", false, null, "Alex", "user44@abv.bg", "user44@abv.bg", "AQAAAAEAACcQAAAAEMwd4vnHh8NsuXJmfYUatDdX7Os2lnuyxBJ/kuwOTtYRYJ6g0Q8E9q74np15KVN1ug==", "001931", true, "", false, "user44@abv.bg" },
                    { "2225cf23-2c7b-4035-94fe-4ef508c2da67", 0, "f2ac6a86-8d7a-48ee-8231-f378984dc314", "003602", "user43@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 30, 868, DateTimeKind.Local).AddTicks(101), true, "Johnson", false, null, "Alex", "user43@abv.bg", "user43@abv.bg", "AQAAAAEAACcQAAAAEJCl35rgfHNEoA6qyCgluRpaI2rwpLHEova8wTyytfqTsVRyJoBKDW3P4DI/uMDbIA==", "000359", true, "", false, "user43@abv.bg" },
                    { "32a5628d-7679-48d4-b81e-92ef61d50b81", 0, "ef386015-59dc-4857-b483-0c9c80f8e5dc", "002473", "user42@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 30, 859, DateTimeKind.Local).AddTicks(7408), true, "Alexandrov", false, null, "Jane", "user42@abv.bg", "user42@abv.bg", "AQAAAAEAACcQAAAAEO1BBCZmESAXIZWC/YvPm2ahUopX9Hv60gmj28UaW8E9zzt8P1jFOlOQTLFeZvZm2Q==", "006811", true, "", false, "user42@abv.bg" },
                    { "f706bf8c-ffba-4985-a1c4-5458b05cb7e9", 0, "d0e05202-fdbe-4e77-86c4-39bf35cf0174", "007178", "user41@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 30, 850, DateTimeKind.Local).AddTicks(8542), true, "Johnson", false, null, "Jack", "user41@abv.bg", "user41@abv.bg", "AQAAAAEAACcQAAAAEIa9vUdZShOaAyTGEisgZQSCfSPEKprUMhMLevWQzhcqFYlGhFo4DZZ2blfC/hfZFQ==", "001829", true, "", false, "user41@abv.bg" },
                    { "744619b6-8c7f-4a8a-a1c9-767df6828f83", 0, "b8a68569-bff4-4f34-9610-93b4ef41df0e", "009733", "user40@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 30, 841, DateTimeKind.Local).AddTicks(3464), true, "Johnson", false, null, "Jane", "user40@abv.bg", "user40@abv.bg", "AQAAAAEAACcQAAAAEJ8fGTasLx51VjxMdJRUYJliJVIJqXtM0oF1uVxXeExGsA8GMS0oR7vfo8UhUHqdng==", "009166", true, "", false, "user40@abv.bg" },
                    { "90bf7e12-ba0d-4529-ac3d-10408a10b48e", 0, "9e376df0-a432-4c52-bd30-57962d3c4fbc", "003284", "user39@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 30, 831, DateTimeKind.Local).AddTicks(7694), true, "Johnson", false, null, "Alex", "user39@abv.bg", "user39@abv.bg", "AQAAAAEAACcQAAAAEK8XP42X7U69ZWOa0JficsjNixs72R1kW9d2fDP0JOpAih98I/g9whtd7zr+OR5OEQ==", "004542", true, "", false, "user39@abv.bg" },
                    { "441e75fc-9c7e-458d-b9b5-602d2ac24fff", 0, "06ef83c7-f0bc-4879-8802-4f9030ecbaa4", "001089", "user25@abv.bg", true, null, "Jack", new DateTime(2023, 3, 16, 18, 45, 30, 711, DateTimeKind.Local).AddTicks(6372), true, "Johnson", false, null, "John", "user25@abv.bg", "user25@abv.bg", "AQAAAAEAACcQAAAAENaVDw5gDUHxW1KfxGnxAE4LOjOxeDfsIEyFrYjq2bO0ZTJC9tkpV+duTQtdToMoUA==", "004414", true, "", false, "user25@abv.bg" },
                    { "89bfc529-d0b8-480f-9194-5fb38d831e4d", 0, "c8723a77-f3c3-4b2d-9579-7ebf80bc5ef5", "002780", "user38@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 30, 821, DateTimeKind.Local).AddTicks(194), true, "Johnson", false, null, "Alex", "user38@abv.bg", "user38@abv.bg", "AQAAAAEAACcQAAAAENkBxJrJ4yd5myGoYUHER8pDJYhGjw4yMv5OChLg9tYR0VGQsMkabAmhBrFk+giW1A==", "002873", true, "", false, "user38@abv.bg" },
                    { "b26593e8-a8f4-4621-838e-3aa8e357a634", 0, "e0100a31-9a69-42c4-b915-9c7103bd44cf", "004230", "user36@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 30, 804, DateTimeKind.Local).AddTicks(6918), true, "Johnson", false, null, "John", "user36@abv.bg", "user36@abv.bg", "AQAAAAEAACcQAAAAEJdFSh0uZmVIqwkCgBCaj9bIs3U/Wg1G2b8bI1ys/L7pV4BRVuuKxOsq2JNcX54Weg==", "006653", true, "", false, "user36@abv.bg" },
                    { "87a7ecc6-d13f-4bad-b2b0-a026ae797c81", 0, "2c217f9e-cf34-4992-b1d4-45295a3cf2e2", "002358", "user35@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 30, 796, DateTimeKind.Local).AddTicks(294), true, "Alexandrov", false, null, "John", "user35@abv.bg", "user35@abv.bg", "AQAAAAEAACcQAAAAEDiN0hmSjZKAvTZ5gFz7G9TmfD0PrVCQ2GAYmUlnzdrFYO3l6AtKgwqnt4NfcQf57w==", "007793", true, "", false, "user35@abv.bg" },
                    { "23cf7c2f-acd3-45c1-9ea5-b59eb515db2e", 0, "54e633e0-072d-42b2-9494-3327e451838c", "009361", "user34@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 30, 787, DateTimeKind.Local).AddTicks(8682), true, "Alexandrov", false, null, "Jane", "user34@abv.bg", "user34@abv.bg", "AQAAAAEAACcQAAAAEIUeyNqFyACGssdJbQPS4Ce3edD7mvZv521CIRFpF8fvWhJRLPPA1yrSZ79UwhIiZA==", "008898", true, "", false, "user34@abv.bg" },
                    { "a8fd7085-15b7-4388-ad92-d0a7f8dfac02", 0, "6b96aa97-c353-4e04-bd7c-4a5840b185d2", "007429", "user33@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 30, 778, DateTimeKind.Local).AddTicks(6358), true, "Alexandrov", false, null, "Alex", "user33@abv.bg", "user33@abv.bg", "AQAAAAEAACcQAAAAEBLppbBhY6W9zlgjeqzZAdB56uNgYdxblgYgBYo7ZbfZpnRAKKGVFwVUzrIgxSM7iQ==", "007724", true, "", false, "user33@abv.bg" },
                    { "57c6dc2b-d42b-46e7-913c-c1ac44dc54bc", 0, "b0c8080c-e400-4348-a06f-f103e23a48a9", "006550", "user32@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 30, 770, DateTimeKind.Local).AddTicks(2552), true, "Alexandrov", false, null, "Alex", "user32@abv.bg", "user32@abv.bg", "AQAAAAEAACcQAAAAENRNV3vA0vYNgFEFy4cfrSXw4yX6ElrL3Q2j/pt0TOwd1J4k+hRBFvVSaMWDRPOLdQ==", "005529", true, "", false, "user32@abv.bg" },
                    { "a382f457-031f-430c-a779-ad6066f00e59", 0, "783a178c-9d02-4369-80e4-b4943f990503", "008295", "user31@abv.bg", true, null, "Jack", new DateTime(2023, 3, 16, 18, 45, 30, 761, DateTimeKind.Local).AddTicks(3683), true, "Johnson", false, null, "Alex", "user31@abv.bg", "user31@abv.bg", "AQAAAAEAACcQAAAAEIl0QYXzPl2zP2oJ+blUrjthPVtsRCMx9TuVlGoQdW0nmyxw2M5gbdqK4TR1vQYwgw==", "000111", true, "", false, "user31@abv.bg" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "EGN", "Email", "EmailConfirmed", "FireDate", "FirstName", "HireDate", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "caa54bf4-373c-48b3-a1c3-c5af356fe05d", 0, "84489793-ebac-4092-b1cf-763b488ee575", "001851", "user30@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 30, 753, DateTimeKind.Local).AddTicks(2429), true, "Alexandrov", false, null, "John", "user30@abv.bg", "user30@abv.bg", "AQAAAAEAACcQAAAAEBvtxUNoMYbYyIp9Z3aOoX3nVucbjmU/OBGZ0ymiJaZjPSanE1YXVzTipFlvsTiCkQ==", "004482", true, "", false, "user30@abv.bg" },
                    { "c2f8a7a5-6a3f-469b-bcb4-3f85af10cc9b", 0, "93e73ab0-5ba5-4aa7-83e3-feb3a4a5988f", "002183", "user29@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 30, 745, DateTimeKind.Local).AddTicks(795), true, "Alexandrov", false, null, "Jane", "user29@abv.bg", "user29@abv.bg", "AQAAAAEAACcQAAAAEPRJ7skZWsZtwpjOucR/ygaTbeXshDQfEP4AmWQ/hCO090dsFHtdu+Bih9ibDg+Jwg==", "004788", true, "", false, "user29@abv.bg" },
                    { "f521e9c8-1992-461b-9056-c65bdf80f32a", 0, "ce7af5d9-a19a-44ad-a4f4-c330565d06f4", "004312", "user28@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 30, 736, DateTimeKind.Local).AddTicks(9531), true, "Alexandrov", false, null, "Jack", "user28@abv.bg", "user28@abv.bg", "AQAAAAEAACcQAAAAEC2SGJuIposaoDtWmLJHJDar+KYeYAi57YxRCbase/qHjVl9QLHjYuLl1/d3tIawvQ==", "000408", true, "", false, "user28@abv.bg" },
                    { "53113d5a-7904-4b09-a41e-0a82452b5644", 0, "803be067-609b-4fad-ba40-042dbe2baeea", "007571", "user27@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 30, 728, DateTimeKind.Local).AddTicks(2263), true, "Alexandrov", false, null, "Jane", "user27@abv.bg", "user27@abv.bg", "AQAAAAEAACcQAAAAEAOPpcHdOx9PzKv5g8giBJEeD+ZR4OxvFJ1hyKiZ9k0HXmdxCg20G/f2NhaNBZkMnw==", "007297", true, "", false, "user27@abv.bg" },
                    { "8f76f16c-b419-466c-a699-a381f5dbbb42", 0, "e72eb565-cf1e-444d-8d40-3022ecacba2c", "009453", "user37@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 30, 812, DateTimeKind.Local).AddTicks(9308), true, "Alexandrov", false, null, "Jack", "user37@abv.bg", "user37@abv.bg", "AQAAAAEAACcQAAAAEJSV1/CzHF7S2vAhBEI4Q/tBmWQz/R07Ocb0X3QeashRIIBvgy0Fb5maSUWKriLBVQ==", "009325", true, "", false, "user37@abv.bg" },
                    { "a976ff9e-2c2a-4ec2-bf1a-4e45dc48164e", 0, "7990e678-5a6c-49f8-9a1f-3d9db1edfab0", "002130", "user0@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 30, 492, DateTimeKind.Local).AddTicks(6189), true, "Johnson", false, null, "Alex", "user0@abv.bg", "user0@abv.bg", "AQAAAAEAACcQAAAAEDaRl0vvmW0jrNwOtO4YchtlEbSdfX+YdAd9c0y4SAiFU23wKyzyuHCamd/hnojAdw==", "004907", true, "", false, "user0@abv.bg" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "8e445864-a24d-4543-a6c6-9443d048cdb9", "6ecf672a-137e-4458-91b1-120bd23252c4" },
                    { "22b970d9-a138-441b-876e-906a2a80494a", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "6f02b90d-5286-48e0-afeb-4f4b9f51d471", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "691c2734-906d-4244-bc38-34b8f1c422c4", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "973b3385-2c52-4e43-973e-742c5359bb10", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "6ec19c6b-7ae7-4df0-bb7a-1110d4b3671a", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "bfee186b-8f7f-47bf-ac1a-c96c31f43885", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "2e2e8e50-23a6-4e49-8188-8f074f7fb7a7", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "56711d20-388a-4f66-86ad-18adccc6f80d", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "ed024312-f08c-42a3-9352-0a99fe6a67ab", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "f355fbfe-827d-4f58-84df-89fe35f5cde9", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "5368e623-15e5-468f-9520-709495f69c6b", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "24d6c12c-8d02-4e5a-8090-7e9c56e18095", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "5385dbad-b1b3-4b2d-8b32-cbe801d10aac", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "d5bbd992-b8a9-470a-948f-1806318c7807", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "9ab9700e-aab5-4987-9bd9-20b19d0bac0a", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "171b17a3-bdf5-4e8b-a973-9695a905a338", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "7865dbbc-2034-45ef-924f-a19c6a7f5c8a", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "83bd512b-329e-4f95-b7c1-9e7b45cc485b", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "ff2a668d-148a-42fa-82a6-58f5f7cbb15e", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "0545f90a-70d8-4935-a049-95cf2d764afc", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "8817f1a3-c1f8-458e-9174-89014698e0aa", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "40055042-e587-4376-a14c-f42d858661a1", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "9f1b6d0f-d448-4d04-998b-dfad94deb32a", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "3844a9df-77a3-4109-8ec9-eb8b50b77aaf", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "f5f75346-834c-465c-a299-72f791085292", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "2138aa1f-9037-41f4-955c-7f218c5b0c87", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "c806d3d2-b999-49f6-98a8-5e4beca42e4f", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "ebfbfc66-bd23-4aaa-8a8a-6e6d4cc3bed0", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "bab17fa2-ff82-4dea-babc-527f16db3e78", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "81c2396b-664d-4725-aea3-111cb1668a14", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "5d7e0bc8-c6f8-4b3f-93e8-05b2d99e061e", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "1c84c71d-a231-4b0a-92f0-97569eff3cc7", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "be539df8-60ce-4dec-a1d0-e86bd541fe12", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "7f82a25e-b33f-4bb6-b038-819eccf813ae", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "4f8f4799-ffe4-47da-9e85-7df893f60687", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "e96d0d8a-6a34-4d26-afd4-f7fa9c9af648", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "12c49bdf-8b79-46fa-93bd-9c806a42a146", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "30d582e8-70e8-4e53-a189-ff87f6d4ff52", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "b0cd465c-70a4-41ed-84da-865165952cbf", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "42835c46-e5ec-4229-aac3-08225ff7459e", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "317f785b-6bf7-474e-8293-a8ee6d8a797f", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "cb235131-5172-4c2e-a910-423583f1979c", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "3141bfe2-4ea1-4703-9e76-9480aa913aeb", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "e69ff9b9-7034-451a-a9af-f01929d6c682", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "5f310e6e-f60f-49d8-aade-521799d45867", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "f7868b05-734f-4a3a-9844-fc4baef6c192", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "ece9887d-2925-4beb-95a1-8f6860452b07", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "b5e3b998-84e8-4fea-898f-4a02df84fb50", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "310a0bf1-44fa-45ef-9cc2-c80291d88f15", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "515df932-7769-4581-b590-032eb391309d", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "6ef61d9e-67a3-410d-8e79-2f4ef2e73923", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "a7109c8e-6c15-48b2-bdf0-594301c41e95", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "30204ffa-f756-411d-be05-b7efae209e0c", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "04a8ec0f-249c-4013-b104-6dcd9906fcf0", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "49349abd-1cb6-4022-86fd-fbbbe7ec0c63", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "c97b2b92-476b-4882-bace-338e944a07f8", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "1be25721-5914-4520-8741-b46dcbddfaa6", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "55759b4a-ea02-4314-8736-52c4a1ff9a17", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "9c250e9b-8343-4dfa-8d94-f650bda4e60d", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "7a1e3e1d-5eb6-4c94-8081-25620210fce3", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "9d4d1efa-6fac-454c-8dbd-492ab1e5f64f", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "8880a31f-9062-49c8-97d3-5d0ff02e3b37", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "d20dfd6b-8d25-4e9c-947c-6feb1333d483", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "3b2b43e2-6a06-41fc-a23b-997ffe1d5a86", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "72bae118-1a8e-4b6d-9a22-ff1c06f7a48d", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "b800df25-389b-464d-8a05-5ef5c5c43e96", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "5dcea69b-a35a-4033-a4ca-515e41778834", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "4264826e-90e0-421a-bddc-4a2c3e70433c", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "9349cb3d-2c32-4922-9ae8-f9c12e2f6574", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "e967aedd-34ec-42d5-aabb-fe64a99a480b", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "e46f9d0c-a7d3-405a-9493-94d75f6c52dd", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "a976ff9e-2c2a-4ec2-bf1a-4e45dc48164e", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "e5685cfe-3f9e-4366-aca6-0ddc300f4115", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "ac39ebb6-dd26-4157-88f3-2b3e617a4b77", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "40dee55d-c036-4c00-8122-3fbe18a08291", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "999daf2b-0bf0-4f99-820e-009c1da8a85b", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "01ad6a6a-0e57-4dad-a9dd-d6f9520a0f0f", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "c601ea23-624b-450c-9579-0d1b7bba71be", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "82feddcd-2cfb-495a-a05e-fb55a4936ab9", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "2225cf23-2c7b-4035-94fe-4ef508c2da67", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "32a5628d-7679-48d4-b81e-92ef61d50b81", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "f706bf8c-ffba-4985-a1c4-5458b05cb7e9", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "744619b6-8c7f-4a8a-a1c9-767df6828f83", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "90bf7e12-ba0d-4529-ac3d-10408a10b48e", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "89bfc529-d0b8-480f-9194-5fb38d831e4d", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "8f76f16c-b419-466c-a699-a381f5dbbb42", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "699d13d3-6e14-44e9-959d-30e13c24e3b6", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "b26593e8-a8f4-4621-838e-3aa8e357a634", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "23cf7c2f-acd3-45c1-9ea5-b59eb515db2e", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "a8fd7085-15b7-4388-ad92-d0a7f8dfac02", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "57c6dc2b-d42b-46e7-913c-c1ac44dc54bc", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "a382f457-031f-430c-a779-ad6066f00e59", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "caa54bf4-373c-48b3-a1c3-c5af356fe05d", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "c2f8a7a5-6a3f-469b-bcb4-3f85af10cc9b", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "f521e9c8-1992-461b-9056-c65bdf80f32a", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "53113d5a-7904-4b09-a41e-0a82452b5644", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "f05abb57-5fe4-4d1f-972c-516b5768598c", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "441e75fc-9c7e-458d-b9b5-602d2ac24fff", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "87a7ecc6-d13f-4bad-b2b0-a026ae797c81", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "36939b51-52e7-4b14-b3de-f5b2f1465bbb", "863f63b8-943c-40a1-bae5-529fc38ce420" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_ReservationId",
                table: "Rooms",
                column: "ReservationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Reservations_ReservationId",
                table: "Rooms",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
