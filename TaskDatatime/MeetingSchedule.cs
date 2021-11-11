using System;
using System.Collections.Generic;
using System.Text;

namespace TaskDatatime
{
    class MeetingSchedule
    {
        private List<Meeting> meetings = new List<Meeting>();

        public void SetMeeting(DateTime from, DateTime to, string fullname)
        {
            if (from < DateTime.Now)
            {
                Console.WriteLine("Kecmishe aid meetting yarada bilmezsen");
            }
            else if (meetings.Count == 0)
            {
                meetings.Add(new Meeting(from,to,fullname));
            }
            else
            {
                foreach (Meeting item in meetings)
                {
                    if (!((from > item.ToDate && from > item.FromDate) || (to < item.FromDate && to < item.ToDate)))
                    {
                        throw new InvalidMeetingException("Duzgun vaxt deyil");
                    }
                }

                meetings.Add(new Meeting(from, to, fullname));
            }
        }

        public int FindMeetingsCount(DateTime from)
        {
            int count = 0;
            foreach (Meeting meet in meetings)
            {
                if (meet.FromDate > from)
                {
                    count++;
                }
            }
            return count;
        }

        public List<Meeting> FindMeetings(Predicate<Meeting> predicate)
        {
            List<Meeting> newMeetings = new List<Meeting>();

            foreach (var item in meetings)
            {
                if (predicate(item))
                {
                    newMeetings.Add(item);
                }
            }

            return newMeetings;
        }

        public bool ExistMeetingsByName(string str)
        {
            foreach (var item in meetings)
            {
                if (item.FullName.Contains(str))
                {
                    return true;
                }
            }
            return false;
        }

        public bool ExistMeetings(Predicate<Meeting> predicate)
        {
            foreach (var item in meetings)
            {
                if (predicate(item))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
