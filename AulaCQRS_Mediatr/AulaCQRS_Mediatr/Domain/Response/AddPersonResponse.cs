namespace AulaCQRS_Mediatr.Domain.Response
{
    public class AddPersonResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string TaxId { get; set; }
    }
}
