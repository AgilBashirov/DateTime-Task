using System;
using System.Collections.Generic;

namespace TaskDatatime
{
    class Program
    {
        static void Main(string[] args)
        {
            MeetingSchedule meetingSchedule = new MeetingSchedule();
            meetingSchedule.SetMeeting(Convert.ToDateTime("14/11/2021"), Convert.ToDateTime("15/11/2021"),"Meet1");
            meetingSchedule.SetMeeting(Convert.ToDateTime("16/11/2021"), Convert.ToDateTime("17/11/2021"), "Meet2");
            meetingSchedule.SetMeeting(Convert.ToDateTime("18/11/2021"), Convert.ToDateTime("19/11/2021"), "Meet3");

            meetingSchedule.SetMeeting(Convert.ToDateTime("20/11/2021"), Convert.ToDateTime("21/11/2021"), "Meet4");

            //** If u want see fullnames make meetings public **//
            //foreach (var item in meetingSchedule.meetings)
            //{
            //    Console.WriteLine(item.FullName);
            //}

            //** FindMeetingsCount **//
            //int count = meetingSchedule.FindMeetingsCount(Convert.ToDateTime("15/11/2021"));
            //Console.WriteLine(count);

            //** FindMeetings **//
            //List<Meeting> specialMeetings = meetingSchedule.FindMeetings(x => x.FullName == "Meet1");
            //foreach (var item in specialMeetings)
            //{
            //    Console.WriteLine(item.FullName);
            //}

            //** ExistMeetingsByName **//
            //bool isExist = meetingSchedule.ExistMeetingsByName("Meet5");
            //Console.WriteLine(isExist);

            bool isExist = meetingSchedule.ExistMeetings(x=>x.FromDate == Convert.ToDateTime("14/11/2021") && x.ToDate == Convert.ToDateTime("15/11/2021"));
            Console.WriteLine(isExist);
        }
    }
}
