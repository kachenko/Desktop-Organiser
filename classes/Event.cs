using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_Organiser.classes
{
    static class Event
    {
        private static int id;
        private static int userId;
        private static DateTime remindedDate;
        private static int rank;
        private static string title;
        private static string description;
        private static DateTime creationDate;
        private static char isActive;

        //public static Event(int id, int userId, DateTime remindedDate, int rank, string title, string description, DateTime creationDate, bool isActive)
        //{
        //    EventId = id;
        //    UserId = userId;
        //    RemindedDate = remindedDate;
        //    Rank = rank;
        //    Title = title;
        //    Description = description;
        //    CreationDate = creationDate;
        //    IsEventActive = isActive;
        //}

        public static int EventId
        {
            get { return id; }
            set { id = value; }
        }
        public static int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        public static DateTime RemindedDate
        {
            get { return remindedDate; }
            set { remindedDate = value; }
        }
        public static int Rank
        {
            get { return rank; }
            set { rank = value; }
        }
        public static string Title
        {
            get { return title; }
            set { title = value; }
        }
        public static string Description
        {
            get { return description; }
            set { description = value; }
        }
        public static DateTime CreationDate
        {
            get { return creationDate; }
            set { creationDate = value; }
        }
        public static char IsEventActive
        {
            get { return isActive; }
            set { isActive = value; }
        }
    }
}
