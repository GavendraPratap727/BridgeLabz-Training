using ContactsApp.Core;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<ContactService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// GET all contacts
app.MapGet("/contacts", (ContactService service) =>
    service.GetAllContacts());

// GET contact by id
app.MapGet("/contacts/{id}", (int id, ContactService service) =>
{
    var contact = service.GetContactById(id);
    return contact is not null ? Results.Ok(contact) : Results.NotFound($"Contact with id {id} not found.");
});

// GET search by name
app.MapGet("/contacts/search/{name}", (string name, ContactService service) =>
    service.SearchByName(name));

// POST add contact
app.MapPost("/contacts", (Contact contact, ContactService service) =>
{
    var added = service.AddContact(contact);
    return Results.Created($"/contacts/{added.Id}", added);
});

// PUT update contact
app.MapPut("/contacts/{id}", (int id, Contact contact, ContactService service) =>
{
    var updated = service.UpdateContact(id, contact);
    return updated ? Results.Ok("Contact updated successfully.") : Results.NotFound($"Contact with id {id} not found.");
});

// DELETE contact
app.MapDelete("/contacts/{id}", (int id, ContactService service) =>
{
    var deleted = service.DeleteContact(id);
    return deleted ? Results.Ok("Contact deleted successfully.") : Results.NotFound($"Contact with id {id} not found.");
});

app.Run();