using ElectiveApp.DataBase;

namespace ElectiveApp
{
    internal class Semester
    {
        private int _current_semester = 1;
        public Semester()
        {
            _current_semester = SemesterPerforms.GetCurrentSemester();
        }

        private const int _min_semester = 1;
        private const int _max_semester = 8;

        public int GetCurrentSemester => _current_semester;

        public int Increase()
        {
            _current_semester++;

            if(_current_semester > _max_semester)
            {
                _current_semester = _min_semester;
            }

            SemesterPerforms.ChangeCurrentSemester(_current_semester);
            return _current_semester;
        }
    }
}
