using Microsoft.Data.SqlClient;

namespace ContactsApp.Core.Repository;

public class ContactRepository
{
    private readonly string _connectionString;

    public ContactRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public Contact AddContact(Contact contact)
    {
        using var conn = new SqlConnection(_connectionString);
        conn.Open();

        var query = @"INSERT INTO Contacts (Name, PhoneNumber, Email, Address)
                      OUTPUT INSERTED.Id
                      VALUES (@Name, @Phone, @Email, @Address)";

        using var cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@Name", contact.Name);
        cmd.Parameters.AddWithValue("@Phone", contact.PhoneNumber);
        cmd.Parameters.AddWithValue("@Email", contact.Email);
        cmd.Parameters.AddWithValue("@Address", contact.Address);

        contact.Id = (int)cmd.ExecuteScalar();
        return contact;
    }

    public List<Contact> GetAllContacts()
    {
        var contacts = new List<Contact>();
        using var conn = new SqlConnection(_connectionString);
        conn.Open();

        var query = "SELECT Id, Name, PhoneNumber, Email, Address FROM Contacts";
        using var cmd = new SqlCommand(query, conn);
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            contacts.Add(MapReaderToContact(reader));
        }
        return contacts;
    }

    public Contact? GetContactById(int id)
    {
        using var conn = new SqlConnection(_connectionString);
        conn.Open();

        var query = "SELECT Id, Name, PhoneNumber, Email, Address FROM Contacts WHERE Id = @Id";
        using var cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@Id", id);

        using var reader = cmd.ExecuteReader();
        return reader.Read() ? MapReaderToContact(reader) : null;
    }

    public List<Contact> SearchByName(string name)
    {
        var contacts = new List<Contact>();
        using var conn = new SqlConnection(_connectionString);
        conn.Open();

        var query = "SELECT Id, Name, PhoneNumber, Email, Address FROM Contacts WHERE Name LIKE @Name";
        using var cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@Name", $"%{name}%");

        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            contacts.Add(MapReaderToContact(reader));
        }
        return contacts;
    }

    public bool UpdateContact(int id, Contact contact)
    {
        using var conn = new SqlConnection(_connectionString);
        conn.Open();

        var query = @"UPDATE Contacts
                      SET Name = @Name, PhoneNumber = @Phone, Email = @Email, Address = @Address
                      WHERE Id = @Id";

        using var cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@Name", contact.Name);
        cmd.Parameters.AddWithValue("@Phone", contact.PhoneNumber);
        cmd.Parameters.AddWithValue("@Email", contact.Email);
        cmd.Parameters.AddWithValue("@Address", contact.Address);
        cmd.Parameters.AddWithValue("@Id", id);

        return cmd.ExecuteNonQuery() > 0;
    }

    public bool DeleteContact(int id)
    {
        using var conn = new SqlConnection(_connectionString);
        conn.Open();

        var query = "DELETE FROM Contacts WHERE Id = @Id";
        using var cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@Id", id);

        return cmd.ExecuteNonQuery() > 0;
    }

    private static Contact MapReaderToContact(SqlDataReader reader)
    {
        return new Contact
        {
            Id = reader.GetInt32(0),
            Name = reader.GetString(1),
            PhoneNumber = reader.IsDBNull(2) ? "" : reader.GetString(2),
            Email = reader.IsDBNull(3) ? "" : reader.GetString(3),
            Address = reader.IsDBNull(4) ? "" : reader.GetString(4)
        };
    }
}