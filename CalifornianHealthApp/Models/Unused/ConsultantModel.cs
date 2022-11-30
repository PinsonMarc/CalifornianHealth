﻿using CalifornianHealthApp.Models.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CalifornianHealthApp.Models.Unused
{
    public class ConsultantModel
    {
        public int id { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string speciality { get; set; }
    }

    public class ConsultantModelList
    {
        public List<ConsultantCalendar> consultantCalendars { get; set; }
        public List<Consultant> consultants { get; set; }
        public int selectedConsultantId { get; set; }
        public SelectList ConsultantsList { get; set; }
    }

}