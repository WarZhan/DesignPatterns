namespace MVCPattern
{
    /// <summary>
    /// Controller
    /// </summary>
    public class StudentController
    {
        private StudentModel _model = null;
        private StudentView _view = null;

        public StudentController(StudentModel model, StudentView view)
        {
            _model = model;
            _view = view;
        }

        public void Show()
        {
            _view.Show(_model.GetName());
        }
    }
}
