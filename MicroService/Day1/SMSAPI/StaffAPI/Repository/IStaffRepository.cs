using StaffAPI.Models;

namespace StaffAPI.Repository
{
    public interface IStaffRepository
    {
        void AddStaff(Staff staff);
        void UpdateStaff(Staff staff);
        void DeleteStaff(string staffId);
        List<Staff> GetAll();
        List<Staff> GetStaffByStd(string std);
        List<Staff> GetStaffBySubjects(string subject);
        Staff GetStaff(string staffId);
    }
}
