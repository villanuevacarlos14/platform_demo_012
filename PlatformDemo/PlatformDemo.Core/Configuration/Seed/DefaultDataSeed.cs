using Microsoft.EntityFrameworkCore;
using PlatformDemo.Core.Model;

namespace PlatformDemo.Core.Configuration.Seed;

public static class DefaultDataSeed
{
    public static void Seed(ModelBuilder builder)
    {
        builder.Entity<Customer>().HasData(
            new Customer { Id = new Guid("8fd65b94-2805-41d5-94e1-6403174b20ce"), Name = "John Smith", PhoneNumber = "123-456-7890" },
            new Customer { Id = new Guid("41b1e9a6-d20b-489d-974a-7d005bf7f4a8"), Name = "Emily Johnson", PhoneNumber = "123-456-7891" },
            new Customer { Id = new Guid("386bc9f2-f6f6-484c-8c3b-2ed671b99ef4"), Name = "Michael Brown", PhoneNumber = "123-456-7892" },
            new Customer { Id = new Guid("b399e175-0b33-438e-9c08-b4fa4a2e5c59"), Name = "Sophia Williams", PhoneNumber = "123-456-7893" },
            new Customer { Id = new Guid("976aad69-027e-4112-974b-5d37385e458d"), Name = "Matthew Jones", PhoneNumber = "123-456-7894" },
            new Customer { Id = new Guid("3a6e36b4-70eb-4c78-99e6-2bb54fffe191"), Name = "Olivia Davis", PhoneNumber = "123-456-7895" },
            new Customer { Id = new Guid("3c591b9d-ddfa-471d-b653-e4dfeedd51d7"), Name = "Liam Garcia", PhoneNumber = "123-456-7896" },
            new Customer { Id = new Guid("0440a7c3-d4d4-4e61-a429-d77f88e1baaf"), Name = "Isabella Rodriguez", PhoneNumber = "123-456-7897" },
            new Customer { Id = new Guid("a114403b-629f-4b69-b1dd-cab3308875bc"), Name = "Lucas Martinez", PhoneNumber = "123-456-7898" },
            new Customer { Id = new Guid("2c5fe80d-e82d-4f00-9c9d-34fa5d02a5ec"), Name = "Ava Hernandez", PhoneNumber = "123-456-7899" },
            new Customer { Id = new Guid("95075645-37c2-401f-a879-c5e223a0447b"), Name = "Sebastian Kim", PhoneNumber = "123-456-7800" },
            new Customer { Id = new Guid("0a0fe0b9-4ab0-461b-a742-802f1ef4aec6"), Name = "Emma Lee", PhoneNumber = "123-456-7801" },
            new Customer { Id = new Guid("bbdb6ba4-9e3b-43c6-829f-bb3a2723db92"), Name = "William Clark", PhoneNumber = "123-456-7802" },
            new Customer { Id = new Guid("57e69e95-0e9f-4727-845f-37e5c0233574"), Name = "Mia Lewis", PhoneNumber = "123-456-7803" },
            new Customer { Id = new Guid("e760ee67-3140-47c2-8634-946fdf44a873"), Name = "Henry Young", PhoneNumber = "123-456-7804" }
        );
        
        builder.Entity<Order>().HasData(
            new Order { Id = new Guid("b705da3e-bc99-4230-84ea-7d5e4b1bae6e"), OrderNumber = 1, Amount = 100.50M, CustomerId = new Guid("8fd65b94-2805-41d5-94e1-6403174b20ce") },
            new Order { Id = new Guid("bd24708a-8dd3-4e58-92f0-24e5112f8cd4"), OrderNumber = 2, Amount = 200.50M, CustomerId = new Guid("8fd65b94-2805-41d5-94e1-6403174b20ce") },
            new Order { Id = new Guid("43066a60-68e4-4ac9-b8f3-7a55e48549c1"), OrderNumber = 3, Amount = 100.50M, CustomerId = new Guid("41b1e9a6-d20b-489d-974a-7d005bf7f4a8") },
            new Order { Id = new Guid("c9aec803-36c3-465a-bbf4-5b3c098dcff8"), OrderNumber = 4, Amount = 200.50M, CustomerId = new Guid("41b1e9a6-d20b-489d-974a-7d005bf7f4a8") },
            new Order { Id = new Guid("ae2aa7de-47f3-4fac-ac78-2d2252bc9e3f"), OrderNumber = 5, Amount = 100.50M, CustomerId = new Guid("41b1e9a6-d20b-489d-974a-7d005bf7f4a8") },
            new Order { Id = new Guid("e08fad3b-a9af-40dd-ad0a-4045f1b85e70"), OrderNumber = 6, Amount = 200.50M, CustomerId = new Guid("41b1e9a6-d20b-489d-974a-7d005bf7f4a8") },
            new Order { Id = new Guid("993fe5bd-cd1e-4794-ba9f-8f28e23056cc"), OrderNumber = 7, Amount = 200.50M, CustomerId = new Guid("386bc9f2-f6f6-484c-8c3b-2ed671b99ef4") },
            new Order { Id = new Guid("7d278dad-b049-48b8-87e5-c5e604130b2d"), OrderNumber = 8, Amount = 100.50M, CustomerId = new Guid("386bc9f2-f6f6-484c-8c3b-2ed671b99ef4") },
            new Order { Id = new Guid("04de6182-c351-460c-9760-43e077a7f31d"), OrderNumber = 9, Amount = 200.50M, CustomerId = new Guid("386bc9f2-f6f6-484c-8c3b-2ed671b99ef4") },
            new Order { Id = new Guid("7f66b17e-a23d-4848-ba90-9d174261368a"), OrderNumber = 10, Amount = 100.50M, CustomerId = new Guid("976aad69-027e-4112-974b-5d37385e458d") },
            new Order { Id = new Guid("5ce02d9c-0309-423a-ba1d-4a4afb7c6543"), OrderNumber = 11, Amount = 200.50M, CustomerId = new Guid("976aad69-027e-4112-974b-5d37385e458d") },
            new Order { Id = new Guid("f0e053cf-b43b-4cc1-93e9-5edfa834ffb2"), OrderNumber = 12, Amount = 200.50M, CustomerId = new Guid("3a6e36b4-70eb-4c78-99e6-2bb54fffe191") },
            new Order { Id = new Guid("9b91223d-0b9a-4ecf-acf6-f6959a43bfa1"), OrderNumber = 13, Amount = 200.50M, CustomerId = new Guid("3c591b9d-ddfa-471d-b653-e4dfeedd51d7") },
            new Order { Id = new Guid("514bca15-7964-4bf6-85be-57f43796be31"), OrderNumber = 14, Amount = 100.50M, CustomerId = new Guid("3c591b9d-ddfa-471d-b653-e4dfeedd51d7") },
            new Order { Id = new Guid("40db7b6d-7bd1-43c6-9e6e-e8d168bfff8f"), OrderNumber = 15, Amount = 200.50M, CustomerId = new Guid("3c591b9d-ddfa-471d-b653-e4dfeedd51d7") },
            new Order { Id = new Guid("33543d58-9e6f-40bb-a85e-74aa7c8eb9cb"), OrderNumber = 16, Amount = 200.50M, CustomerId = new Guid("0440a7c3-d4d4-4e61-a429-d77f88e1baaf") },
            new Order { Id = new Guid("0ccb12cc-e43c-4c3b-b334-ed3360bf74e8"), OrderNumber = 17, Amount = 100.50M, CustomerId = new Guid("0440a7c3-d4d4-4e61-a429-d77f88e1baaf") },
            new Order { Id = new Guid("b40f6572-1915-4ac6-81b4-2e2983f6b6b0"), OrderNumber = 18, Amount = 200.50M, CustomerId = new Guid("0440a7c3-d4d4-4e61-a429-d77f88e1baaf") },
            new Order { Id = new Guid("01f08be3-d92f-4dcc-8b8a-b376a9486573"), OrderNumber = 19, Amount = 100.50M, CustomerId = new Guid("a114403b-629f-4b69-b1dd-cab3308875bc") },
            new Order { Id = new Guid("cb5add99-075f-4d82-b684-0e15232ddc2f"), OrderNumber = 20, Amount = 200.50M, CustomerId = new Guid("a114403b-629f-4b69-b1dd-cab3308875bc") },
            new Order { Id = new Guid("343154f4-26fc-4a1a-b647-cb7677c7e974"), OrderNumber = 21, Amount = 100.50M, CustomerId = new Guid("a114403b-629f-4b69-b1dd-cab3308875bc") },
            new Order { Id = new Guid("d651559f-adc6-4097-aaf6-652fa2b47f5e"), OrderNumber = 22, Amount = 200.50M, CustomerId = new Guid("a114403b-629f-4b69-b1dd-cab3308875bc") },
            new Order { Id = new Guid("8c8f3c28-ba21-46e8-af60-dbbf0faaa8ca"), OrderNumber = 23, Amount = 200.50M, CustomerId = new Guid("a114403b-629f-4b69-b1dd-cab3308875bc") },
            new Order { Id = new Guid("c35deeb7-dbc1-4adc-8eb9-57e11015d13f"), OrderNumber = 25, Amount = 200.50M, CustomerId = new Guid("2c5fe80d-e82d-4f00-9c9d-34fa5d02a5ec") },
            new Order { Id = new Guid("e62af2e6-f3e6-42a5-a020-7fdf1fdb0bc8"), OrderNumber = 26, Amount = 200.50M, CustomerId = new Guid("95075645-37c2-401f-a879-c5e223a0447b") },
            new Order { Id = new Guid("3afc0387-1d03-43a1-b9c8-eb757011c68d"), OrderNumber = 27, Amount = 200.50M, CustomerId = new Guid("0a0fe0b9-4ab0-461b-a742-802f1ef4aec6") },
            new Order { Id = new Guid("45637736-2e95-4859-9a24-d0e77adc26f5"), OrderNumber = 28, Amount = 200.50M, CustomerId = new Guid("0a0fe0b9-4ab0-461b-a742-802f1ef4aec6") },
            new Order { Id = new Guid("9ed6bcac-a364-4724-838b-14c99017b64e"), OrderNumber = 29, Amount = 200.50M, CustomerId = new Guid("bbdb6ba4-9e3b-43c6-829f-bb3a2723db92") },
            new Order { Id = new Guid("20b8a648-ccf4-4726-8579-47b2deac0aaa"), OrderNumber = 30, Amount = 200.50M, CustomerId = new Guid("bbdb6ba4-9e3b-43c6-829f-bb3a2723db92") },
            new Order { Id = new Guid("49c29393-1b1b-41f2-8735-e3039322c93f"), OrderNumber = 31, Amount = 200.50M, CustomerId = new Guid("57e69e95-0e9f-4727-845f-37e5c0233574") },
            new Order { Id = new Guid("1dfbf4ff-c3d4-44f4-a21d-d85d754ecea0"), OrderNumber = 32, Amount = 100.50M, CustomerId = new Guid("57e69e95-0e9f-4727-845f-37e5c0233574") },
            new Order { Id = new Guid("b71694f2-5dae-4af1-ae50-96702f5dce99"), OrderNumber = 33, Amount = 200.50M, CustomerId = new Guid("57e69e95-0e9f-4727-845f-37e5c0233574") }
        );
    }
}