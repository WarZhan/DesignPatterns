namespace MVCPattern
{
    /// <summary>
    /// Model
    /// </summary>
    public class StudentModel
    {
        private string _name = "";

        public void SetName(string name) 
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }
    }
}
