namespace ExamenFinalDWES.Models
{
        public class Login
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Password { get; set; }

            public bool IsValid()
            {
                return Nombre == "usuario" && Password == "contraseña";
            }
        }
    
}
