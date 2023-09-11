using Ej01.App.Domain.Entities;

namespace Ej01.App.ViewModels
{
    internal class PersonViewModel
    {
        private Person _person { get; }

        public PersonViewModel()
        {
            _person = new Person();
        }

        public void SetDocumentNumber(string documentNumberStr)
        {
            _person.DocumentNumber = int.TryParse(documentNumberStr, out var docNumber) ? docNumber : default;
        }

        public void SetBirthDate(DateTime birthDateTime)
        {
            _person.BirthDate = DateOnly.FromDateTime(birthDateTime);
        }

        public void SetFirstName(string firstName)
        {
            _person.FirstName = firstName;
        }

        public void SetLastName(string lastName)
        {
            _person.LastName = lastName;
        }

        public void Validate()
        {
            var (isValid, msg) = _person.Validate();

            if (isValid)
            {
                MessageBox.Show("La persona es valida!", "Validación exitosa", MessageBoxButtons.OK);
                return;
            }

            MessageBox.Show(msg, "Validación fallida", MessageBoxButtons.OK);
        }
    }
}
