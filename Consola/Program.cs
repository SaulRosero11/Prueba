using System;
using ModelosDB;
using Modelo;
using System.Collections.Generic;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Address direccion1 = new Address
            {
                address = "Shyris y el Telegrafo",
                address2 = "Calle Carapungo y Linares",
                distric = "Quito",
                city_id = 2,
                postal_code = "170102",
                phone = "0936451236",
                last_update = DateTime.Now           
            };

            Address direccion2 = new Address
            {
                address = "12 de Octubre",
                address2 = "6 de Diciembre y Naciones Unidas",
                distric = "Quito",
                city_id = 3,
                postal_code = "170103",
                phone = "0965984712",
                last_update = DateTime.Now
            };

            Address direccion3 = new Address
            {
                address = "Calderon",
                address2 = "10 de agosto y Azuay",
                distric = "Cuenca",
                city_id = 1,
                postal_code = "010101",
                phone = "0936231542",
                last_update = DateTime.Now
            };

            Address direccion4 = new Address
            {
                address = "Azuay y San Bartolo",
                address2 = "Parque Calderon",
                distric = "Cuenca",
                city_id = 1,
                postal_code = "010102",
                phone = "0923151002",
                last_update = DateTime.Now
            };

            Address direccion5 = new Address
            {
                address = "Shyris y el Telegrafo",
                address2 = "Calle Carapungo y Linares",
                distric = "Quito",
                city_id = 3,
                postal_code = "170104",
                phone = "0936451236",
                last_update = DateTime.Now
            };

            staff empleado1 = new staff
            {
                first_name =  "Anthony",
                last_name = "Rosero",
                email = "antohny@hotmail.com",
                addressId =1,
                store_id = 1,
                active = true,
                username = "Tony01",
                password = "12345",
                last_update = DateTime.Now,
                picture = "data:image/jpeg;base64,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"
            };

            staff empleado2 = new staff
            {
                first_name = "Alexis",
                last_name = "Enriques",
                email = "alexis@hotmail.com",
                addressId = 1,
                store_id = 3,
                active = true,
                username = "Alexis23",
                password = "172564",
                last_update = DateTime.Now,
                picture = "data:image/jpeg;base64,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"
            };

            staff empleado3 = new staff
            {
                first_name = "Issac",
                last_name = "Minda",
                email = "issac@hotmail.com",
                addressId = 1,
                store_id = 1,
                active = true,
                username = "Issac11",
                password = "1234587",
                last_update = DateTime.Now,
                picture = "data:image/jpeg;base64,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"
            };

            staff empleado4 = new staff
            {
                first_name = "Freddy",
                last_name = "Alaba",
                email = "alaba@hotmail.com",
                addressId = 1,
                store_id = 4,
                active = true,
                username = "Freddy09",
                password = "457987",
                last_update = DateTime.Now,
                picture = "data:image/jpeg;base64,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"
            };

            staff empleado5 = new staff
            {
                first_name = "Mario",
                last_name = "Astudillo",
                email = "mario@hotmail.com",
                addressId = 1,
                store_id = 2,
                active = true,
                username = "Mario08",
                password = "15462121",
                last_update = DateTime.Now,
                picture = "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBw8HBhAQBxISEhUVEBEXFhATDhIPDxoXFhUYFxUSHhYYHSggJBonGxUVITEhJSkrLi4uFx8zODMsNygtLi0BCgoKDg0OGhAQFi0dIB8rLSstLS0tLS0tLS0tKy0rLS0tKy0tLS0tKystKy0tLS0rKy4tLS0rLS0rKysrKy03K//AABEIALIBGwMBIgACEQEDEQH/xAAbAAEAAgMBAQAAAAAAAAAAAAAABQYCAwQBB//EADIQAQABAwEFBAkEAwAAAAAAAAABAgMEEQUhMVGxEkFhcRMzUnKBkcHR4SI0ofAjMlP/xAAYAQEBAQEBAAAAAAAAAAAAAAAAAgMBBP/EABwRAQEBAQEAAwEAAAAAAAAAAAABAhExAyFREv/aAAwDAQACEQMRAD8A+iAPSyAAAAAAAAAAAAAAB7RRNyrSiJmeURq67Wy7tfGIp85+zlsjvHGJe3sX/rX8Ij6yZODYxbWt2avCNY1n+E/3Hf5qICeO4WkAAAAAAAAAAAAAAAAAAAAAAAAAABlbom5XFNG+ZncBbtzdriLcTM8oS+LsiKY1yZ1n2Y3R83XhYlOLb0jfPfVz/DpY63+LmWNu3Tbp0txERyiNGQIUObOw4y6I1nSY10nz8HSEvBV8nHqxrml2PKe6Wpab9mm/bmm7Gsfz5q7m4s4t3Srh3Tzj7ts66izjQAtIAAAAAAAAAAAAAAAAAAAAAAAAk9hWoqu1VT3RER8eKMTGwfV1+cdE78dz6lQGDQAAAAcu0rEX8SrXjEax5w6mF6NbNXuz0IKqPIevSyAAAAAAAAAAAAAAAAAAAAAAAAEzsH1FfvfRDJrYX7er3/pCN+Kz6kwGKwAAABjd9VV5T0ZMbvqqvKegKnHB68jg9elkAAAAAAAAAAAAAAAAAAAAAAAA8WDZOPVj2Ji7GmtWvHXuhX54LZantW4nnEdGfyX6VlkAyWAAAAMbka2505SyAVS5bqtV9m5Gk8mLr2tOufV8OkOR6J4zoA64AAAAAAAAAAAAAAAAAAAAAALJs656TComPZ0+W5W0lsS9NN6aJndMaxHjH46I3OxWU2AxWAAAAA5NqX5sYkzRumZiInz/ABqSdEHmV+ky65j2p+zS8evQyAHQAAAAAAAAAAAAAAAAAAAAAAb8G56HLoqnn13fVoHKLaODZWZ6e32a/wDaI+cc3ews41AHAAAQu3but2miO6NZ+PD++KWv3YsWZqq4RCs3rk3rs1V8Zn+wvE++p1WADZAAAAAAAAAAAAAAAAAAAAAAAAAACS2FTrkVTyp6z+E2i9i2KrcVzciY17Omsac0ow360ngAl0ABybV/YV/DrCurHtKibmFVFEazu3Rx4wrkxpOktfj8RoAaJAAAAAAAAAAAAAAAAAAAAAAAAHTs236TNoieevy3tFq1Vdq0tRMz4Qm9lYU42tV7TWe7XXSE6vI7IkAGDQAAAAV/bFvsZszziJ+k9FgcW1MScq1Ho9NYnv3bu+Ois3lcs+lfGd6xXYnS7TMdPmwbswAAAAAAAAAAAAAAAAAAHgPR1Yuz7mRviNI9qfslsbZluxvqjtTznh8k3UjsiGx8O5kerjd7U7oSmPsiijffntTy4UpIZ3dq5ljRRFunSiIiOURpDIEOgAAAAAAAPKqYqjSrf4Tvhw5Gyrd3fb/RPhvj5O8dlsFdyNnXLHd2o507/wCHItrnyMK3kesjf7UbpXPk/U3KtCQydk1299n9UcuFSPqiaZ0q3TyndLSWVPAB1wAAAAAAAAAAAiNZ0gGzHsVZFzs2o16R4pvE2bRYiJr/AFVc54fCG7CxoxbMRTx755y6GOtdXIAIUAAAAAAAAAAAAAAAANORi0ZNP+WPjwn5twCu5+BVizrG+nn3x4S5Frroi5RMVxrExvhWcuxOPkVUz3cJ8O5tjXUWNQC0gAAAAAAADbi/uqPfp6g5fHVoAedoAAAAAAAAAAAAAAAAAAAAIPbv7qn3PrILx65rxHANmYAAAD//2Q=="
            };

            staff empleado6 = new staff
            {
                first_name = "Bryan",
                last_name = "Zumba",
                email = "bryan@hotmail.com",
                addressId = 1,
                store_id = 3,
                active = true,
                username = "Bryan05",
                password = "213454",
                last_update = DateTime.Now,
                picture = "data:image/jpeg;base64,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"
            };

            payment payment1 = new payment
            {
                customer_Id = 1,
                staffId = 1,
                rental_Id = 1,
                amount = 100,
                payment_date= DateTime.Now
            };

            payment payment2 = new payment
            {
                customer_Id = 2,
                staffId = 2,
                rental_Id = 2,
                amount = 300,
                payment_date = DateTime.Now
            };

            payment payment3 = new payment
            {
                customer_Id = 3,
                staffId = 3,
                rental_Id = 1,
                amount = 4000,
                payment_date = DateTime.Now
            };

            payment payment4 = new payment
            {
                customer_Id = 1,
                staffId = 4,
                rental_Id = 5,
                amount = 800,
                payment_date = DateTime.Now
            };

            payment payment5 = new payment
            {
                customer_Id = 7,
                staffId = 5,
                rental_Id = 5,
                amount = 500,
                payment_date = DateTime.Now
            };

            payment payment6 = new payment
            {
                customer_Id = 6,
                staffId = 6,
                rental_Id = 3,
                amount = 400,
                payment_date = DateTime.Now
            };

            payment payment7 = new payment
            {
                customer_Id = 2,
                staffId = 2,
                rental_Id = 3,
                amount = 100,
                payment_date = DateTime.Now
            };

            payment payment8 = new payment
            {
                customer_Id = 5,
                staffId = 5,
                rental_Id = 4,
                amount = 300,
                payment_date = DateTime.Now
            };

            payment payment9 = new payment
            {
                customer_Id = 6,
                staffId = 5,
                rental_Id = 1,
                amount = 900,
                payment_date = DateTime.Now
            };

            payment payment10 = new payment
            {
                customer_Id =8,
                staffId = 3,
                rental_Id = 2,
                amount = 1000,
                payment_date = DateTime.Now
            };

            List<Address> direccion= new List<Address>() { direccion1, direccion2, direccion3, direccion4, direccion5};

            List<staff> empleados = new List<staff>() { empleado1, empleado2, empleado3, empleado4, empleado5, empleado6 };

            List<payment> Payments = new List<payment>() { payment1, payment2, payment3, payment4, payment5, payment6, payment7, payment8, payment9, payment10 };

            using (DBconexion repos = new DBconexion())
            {
                repos.Addresses.AddRange(direccion);
                repos.Staffs.AddRange(empleados);
                repos.Payments.AddRange(Payments);
                repos.SaveChanges();
            }
        }
    }
}
