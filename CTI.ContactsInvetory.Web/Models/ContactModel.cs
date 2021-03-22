using CTI.ContactsInvetory.Dto;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;


namespace CTI.ContactsInvetory.Web.Models
{
    public class ContactModel
    {
        private readonly string _baseAddress;
        private readonly Uri _baseURI;

        public ContactModel(IConfiguration configuration)
        {
            _baseAddress = configuration.GetValue<string>("apiBaseUrl");
            _baseURI = new Uri(_baseAddress);
        }

        public async Task<Contact> GetContact(int id)
        {
            Contact contact = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = _baseURI;
                //HTTP GET
                var result = await client.GetAsync($"{_baseAddress}/contact/" + id.ToString());

                if (result.IsSuccessStatusCode)
                {
                    contact = await result.Content.ReadAsAsync<Contact>();
                 }
            }

            return contact;
        }

        public async Task<IEnumerable<Contact>> GetContacts()
        {
            IList<Contact> contacts = new List<Contact>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = _baseURI;
                //HTTP GET
                var result = await client.GetAsync($"{_baseAddress}/contact");

                if (result.IsSuccessStatusCode)
                {
                    contacts = await result.Content.ReadAsAsync<IList<Contact>>();
                }
            }

            return contacts;
        }

        public async Task<Contact> AddContact(Contact contact)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = _baseURI;

                //HTTP POST
                var postTask = await client.PostAsJsonAsync<Contact>($"{_baseAddress}/contact", contact);
            }

            return contact;
        }

        public async Task<Contact> UpdateContact(int id, Contact contact)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = _baseURI;

                //HTTP POST
                var putTask = await client.PutAsJsonAsync<Contact>($"{_baseAddress}/contact/" + id.ToString(), contact);
            }

            return contact;
        }

        public async Task<bool> DeleteContact(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = _baseURI;

                //HTTP POST
                var deleteTask = await client.DeleteAsync($"{_baseAddress}/contact/" + id.ToString());
            }

            return true;
        }
    }
}
