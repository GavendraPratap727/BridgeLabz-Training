using ContactsApp.Core;
using ContactsApp.Core.Repository;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("ContactsDb");
builder.Services.AddSingleton(new ContactRepository(connectionString!));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/contacts", (ContactRepository repo) => repo.GetAllContacts());

app.MapGet("/contacts/{id}", (int id, ContactRepository repo) =>
{
    var contact = repo.GetContactById(id);
    return contact is not null ? Results.Ok(contact) : Results.NotFound($"Contact with id {id} not found.");
});

app.MapGet("/contacts/search/{name}", (string name, ContactRepository repo) =>
    repo.SearchByName(name));

app.MapPost("/contacts", (Contact contact, ContactRepository repo) =>
{
    var added = repo.AddContact(contact);
    return Results.Created($"/contacts/{added.Id}", added);
});

app.MapPut("/contacts/{id}", (int id, Contact contact, ContactRepository repo) =>
{
    var updated = repo.UpdateContact(id, contact);
    return updated ? Results.Ok("Contact updated successfully.") : Results.NotFound($"Contact with id {id} not found.");
});

app.MapDelete("/contacts/{id}", (int id, ContactRepository repo) =>
{
    var deleted = repo.DeleteContact(id);
    return deleted ? Results.Ok("Contact deleted successfully.") : Results.NotFound($"Contact with id {id} not found.");
});

app.Run();