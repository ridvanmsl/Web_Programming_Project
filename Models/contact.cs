namespace WebAssignment.Models
{
    public class contact_info
    {
        public string? full_name { get; set; }
        public string? email { get; set; }
        public string? experience { get; set; }

    }

    public static class ContactInfoRepo
    {
        private static List<contact_info> _contact = new List<contact_info>();


        public static List<contact_info> contact
        {
            get
            {
                return _contact;
            }
        }
        public static void AddContact(contact_info info)
        {
            _contact.Add(info);
        }
    }
}
