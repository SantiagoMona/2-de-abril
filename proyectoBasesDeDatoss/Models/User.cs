namespace proyectoBasesDeDatoss.Moldels
{
    public class User
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set;}
        public string Names { get; set; } 
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}