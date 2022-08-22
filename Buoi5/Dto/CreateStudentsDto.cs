namespace Buoi5.Dto
{
    public class CreateStudentsDto
    {
        private string _name;
        private string _msv;
        private DateTime _dateofbirth;

        public string Name
        {
            get { return _name; }
            set { _name = value?.Trim(); }
        }
        public string Msv
        {
            get { return _msv; }
            set
            {
                _msv = value?.Trim();
            }
        }
        public DateTime DateofBirth
        {
            get { return _dateofbirth; }            
            set { _dateofbirth = value; }
        }
    }
}
