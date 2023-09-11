namespace Ej01.App.Domain.Entities
{
    internal class Person
    {
        public int DocumentNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly BirthDate { get; set; }

        public (bool, string) Validate()
        {
            var flag = true;
            var msg = "";

            if (string.IsNullOrEmpty(FirstName) || FirstName.Length == 0)
            {
                flag = false;
                msg += "El nombre no puede estar vacío. \r\n";
            }

            if (string.IsNullOrEmpty(LastName) || LastName.Length == 0)
            {
                flag = false;
                msg += "El apellido no puede estar vacío. \r\n";
            }

            if (FirstName.Length > 50)
            {
                flag = false;
                msg += "El nombre debe ser menor a 50 caracteres. \r\n";
            }

            if (LastName.Length > 50)
            {
                flag = false;
                msg += "El apellido debe ser menor a 50 caracteres. \r\n";
            }

            if (DocumentNumber.ToString().Length is > 8 or < 6)
            {
                flag = false;
                msg += "El nro documento debe tener entre 7 y 8 caracteres. \r\n";
            }

            if (BirthDate > DateOnly.FromDateTime(DateTime.Today))
            {
                flag = false;
                msg += "La fecha de nacimiento debe ser menor a la fecha de hoy. \r\n";
            }

            return (flag, msg);
        }
    }
}
