using System;
using System.Collections.Generic;

namespace projectsamozachet
{
    public class Facade
    {
        public Client_list client_List;
        public Visit_list visit_List;
        public Facade()
        {
            client_List = Client_list.get_instanse();
            visit_List = Visit_list.get_instanse();
        }
        public void create_client_list(Object[] obj)
        {
            client_List.add_el(new Client(Convert.ToInt32(obj[0]), obj[1].ToString(), obj[2].ToString(), obj[3].ToString(), obj[4].ToString(), Convert.ToInt32(obj[5])));
        }
        public void create_visit_list(Object[] obj)
        {
            visit_List.add_el(new Visit(Convert.ToInt32(obj[0]), Convert.ToInt32(obj[1]), Convert.ToInt32(obj[2]), obj[3].ToString(), obj[4].ToString(), obj[5].ToString()));
        }
        class Employee : Id
        {
            private int employeeId { get; set; }
            private string name { get; set; }

            private string surname { get; set; }

            private string lastName { get; set; }

            private int postId { get; set; }
            public Employee(int employeeId, string name, string surname, string lastName, int postId)
            {
                this.employeeId = employeeId;
                this.name = name;
                this.surname = surname;
                this.lastName = lastName;
                this.postId = postId;
            }
            public int id()
            {
                return this.employeeId;
            }
        }
        class Post : Id
        {
            private int postId { get; set; }
            private string postName { get; set; }

            public Post(int postId, string postName)
            {
                this.postId = postId;
                this.postName = postName;
            }
            public int id()
            {
                return this.postId;
            }

        }
        public class Visit : Id
        {
            public int visitId { get; set; }
            public int clientId { get; set; }
            public int employeeId { get; set; }
            public string service { get; set; }
            public string date { get; set; }
            public string dateEnd { get; set; }
            public Visit(int visitId, int clientId, int employeeId, string service, string date, string dateEnd)
            {
                this.visitId = visitId;
                this.clientId = clientId;
                this.employeeId = employeeId;
                this.service = service;
                this.date = date;
                this.dateEnd = dateEnd;
            }
            public int id()
            {
                return this.visitId;
            }
            public List<String> mass_s()
            {
                List<String> array = new List<String>();
                array.Add(clientId.ToString());
                array.Add(visitId.ToString());
                array.Add(employeeId.ToString());
                array.Add(service);
                array.Add(date);
                array.Add(dateEnd);

                return array;
            }
        }
        public class Client : Id
        {
            public int clientId { get; set; }
            public string name { get; set; }
            public string surname { get; set; }
            public string lastname { get; set; }
            public string automobil { get; set; }
            public int phone { get; set; }
            public Client(int clientId, string name, string surname, string lastname, string automobil, int phone)
            {
                this.clientId = clientId;
                this.name = name;
                this.surname = surname;
                this.lastname = lastname;
                this.automobil = automobil;
                this.phone = phone;
            }
            public int id()
            {
                return this.clientId;
            }
            public List<String> mass_s()
            {
                List<String> array = new List<String>();
                array.Add(clientId.ToString());
                array.Add(name);
                array.Add(surname);
                array.Add(lastname);
                array.Add(automobil);
                array.Add(phone.ToString());
                return array;
            }
        }
        interface Id
        {
            int id();
        }
        interface IList<T>
        {
            void add_el(T obj);
            void delete_el(int id);
            void update_el(T obj);
            Object select_el(T obj);
        }
        public class Client_list : IList<Client>
        {
            private List<Client> client_list;
            private static Client_list one;

            private Client_list()
            {
                client_list = new List<Client>();
            }
            public static Client_list get_instanse()
            {
                if (one == null)
                {
                    one = new Client_list();
                }
                return one;
            }
            public void add_el(Client client)
            {
                this.client_list.Add(client);
            }
            public void delete_el(int id)
            {
                this.client_list.RemoveAll(client => client.id() == id);
            }
            public void update_el(Client id)
            {
                Client old_client = this.client_list.Find(Client => Client.id() == id.id());
                old_client.clientId = id.clientId;
                old_client.name = id.name;
                old_client.surname = id.surname;
                old_client.lastname = id.lastname;
                old_client.automobil = id.automobil;
                old_client.phone = id.phone;
            }
            public Object select_el(Client obj)
            {
                return 1;
            }
            public List<List<string>> mass_klient()
            {
                List<List<string>> mass = new List<List<string>>();
                foreach (Client i in this.client_list)
                {
                    mass.Add(i.mass_s());
                }
                return mass;
            }
            public List<string> get_full_id()
            {
                List<string> ids = new List<string>();
                foreach (Client i in client_list)
                {
                    ids.Add(i.id().ToString());

                }
                return ids;
            }
        }
        public class Visit_list : IList<Visit>
        {
            private List<Visit> visit_list;
            private static Visit_list one;

            private Visit_list()
            {
                visit_list = new List<Visit>();
            }
            public static Visit_list get_instanse()
            {
                if (one == null)
                {
                    one = new Visit_list();
                }
                return one;
            }
            public void add_el(Visit visit)
            {
                this.visit_list.Add(visit);
            }
            public void delete_el(int id)
            {
                this.visit_list.RemoveAll(visit => visit.id() == id);
            }
            public void update_el(Visit id)
            {
                Visit old_order = this.visit_list.Find(Visit => Visit.id() == id.id());
                old_order.visitId = id.visitId;
                old_order.clientId = id.clientId;
                old_order.employeeId = id.employeeId;
                old_order.service = id.service;
                old_order.date = id.date;
                old_order.dateEnd = id.dateEnd;
            }
            public Object select_el(Visit obj)
            {
                return 1;
            }
            public List<List<string>> mass_visit()
            {
                List<List<string>> mass = new List<List<string>>();
                foreach (Visit i in this.visit_list)
                {
                    mass.Add(i.mass_s());
                }
                return mass;
            }
            public List<string> get_full_id()
            {
                List<string> ids = new List<string>();
                foreach (Visit i in visit_list)
                {
                    ids.Add(i.id().ToString());

                }
                return ids;
            }

        }
    }
}
