using StaffAPI.Models;

namespace StaffAPI.Repository
{
    public class StaffRepository : IStaffRepository
    {
        List<Staff> staffs = new List<Staff>();
        public void AddStaff(Staff staff)
        {
            staffs.Add(staff);
        }

        public void DeleteStaff(string staffId)
        {
            Staff staff = staffs.SingleOrDefault(s => s.StaffId == staffId);
            staffs.Remove(staff);
        }

        public List<Staff> GetAll()
        {
            return staffs;
        }

        public Staff GetStaff(string staffId)
        {
            return staffs.SingleOrDefault(s => s.StaffId == staffId);
        }

        public List<Staff> GetStaffByStd(string std)
        {
            List<Staff> staffswithStd = new List<Staff>();
            foreach(var staff in staffs)
            {
                foreach(var s in staff.stds)
                {
                    if(s==std)
                    {
                        staffswithStd.Add(staff);
                    }
                }
            }
            return staffswithStd;
            //List<Staff> staffswithStd=(from s in staffs
                                        //where s.Stds.Contains(std)
                                        //select s).ToList();
        }

        public List<Staff> GetStaffBySubjects(string subject)
        {
            List<Staff> staffswithSubject = new List<Staff>();
            foreach (var staff in staffs)
            {
                foreach (var s in staff.Subjects)
                {
                    if (s == subject)
                    {
                        staffswithSubject.Add(staff);
                    }
                }
            }
            return staffswithSubject;
        }

        public void UpdateStaff(Staff staff)
        {
          foreach(var s in staffs)
            {
                if(s.StaffId==staff.StaffId)
                {
                    s.Name = staff.Name;
                    s.Subjects = staff.Subjects;
                }
            }
        }
    }
}
