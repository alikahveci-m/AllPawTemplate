namespace AllPawTemplate.Dtos
{
    public class UserSignUpModelDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool AcceptPetShopTerms { get; set; }
    }
}
